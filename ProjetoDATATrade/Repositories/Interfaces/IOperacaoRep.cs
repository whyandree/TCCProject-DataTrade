﻿using ProjetoDATATrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories.Interfaces
{
    public interface IOperacaoRep
    {
        void InserirOperacoes(Operacao operacao);
        void AlterarOperacoes(Operacao operacao);
        void ExcluirOperacoes(int id);
        Operacao ObterOperacoes(int id);
        IEnumerable<Operacao>ObterTodasOperacoes();
        void GerarRelatorio(Operacao operacao);
    }
}
