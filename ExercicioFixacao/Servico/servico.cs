using ExercicioFixacao.Core.Entidades;
using ExercicioFixacao.Infra;
using System;

namespace ExercicioFixacao.Servico
{
    internal class servico
    {
        private Repositorio _Repositorio;

        public void Add(Cliente cliente)
        {
            _Repositorio = new Repositorio();
            _Repositorio.Add(cliente);
           
        }

    }
}
