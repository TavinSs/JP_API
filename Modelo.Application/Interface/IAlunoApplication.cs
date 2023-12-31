﻿using Modelo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Application.Interface
{
    public interface IAlunoApplication
    {
        Aluno BuscarAluno(int id);
        Retorno InserirAluno(Aluno aluno);
        void EditarAluno(AlunoDto alunoDto);
        void DeletarAluno(AlunoDto alunoDto);
    }
}
