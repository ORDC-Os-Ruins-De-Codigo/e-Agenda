﻿using e_Agenda.Dominio.ModuloCompromissos;
using e_Agenda.Infraestrutura.Arquivos.Compartilhado;

namespace e_Agenda.Infraestrutura.Arquivos.ModuloCompromisso;
public class RepositorioCompromisso : RepositorioBase<Compromisso>, IRepositorioCompromisso
{
    public RepositorioCompromisso(ContextoDados contexto) : base(contexto) { }
    protected override List<Compromisso> ObterRegistros() {
        return contexto.Compromissos;
    }
}
