using ExercicioFixacao.Core.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioFixacao.Infra
{
    internal class RepositorioCliente
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private static int _id = 0; 

        public void AdicionarCliente(Cliente cliente)
        {
            cliente.Id = ++_id; 
            clientes.Add(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            var clienteExistente = clientes.FirstOrDefault(x => x.Id == cliente.Id);
            if (clienteExistente != null)
            {
                clienteExistente.Nome = cliente.Nome;
                clienteExistente.Sobrenome = cliente.Sobrenome;
                clienteExistente.Idade = cliente.Idade;
            }
        }

        public void DeleteFisico(Cliente cliente)
        {
            clientes.Remove(cliente);
        }

        public void DeleteLogico(int id)
        {
            var cliente = clientes.FirstOrDefault(x => x.Id == id);
            if (cliente != null)
            {
                cliente.Ativo = false; 
            }
        }

        public List<Cliente> GetClientes()
        {
            return clientes;
        }

        public List<Cliente> ListarClientesAtivos()
        {
            return clientes.Where(x => x.Ativo).ToList();
        }
    }
}
