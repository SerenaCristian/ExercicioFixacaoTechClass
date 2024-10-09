using ExercicioFixacao.Core.Entidades;
using System.Collections.Generic;

namespace ExercicioFixacao.Infra
{
    internal class Repositorio
    {
        private static List<Cliente> clientes = new List<Cliente>();
        public void Add(Cliente cliente)
        {
            clientes.Add(cliente);
        }


    }
}
