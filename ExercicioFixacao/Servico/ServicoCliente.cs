using ExercicioFixacao.Core.Entidades;
using ExercicioFixacao.Infra;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioFixacao.Servico
{
    internal class ServicoCliente
    {
        private readonly RepositorioCliente _repositorioCliente;

        public ServicoCliente()
        {
            _repositorioCliente = new RepositorioCliente();
        }

        public void AdicionarCliente(Cliente cliente)
        {
            var clienteExistente = _repositorioCliente.GetClientes().FirstOrDefault(c =>
                c.Nome == cliente.Nome &&
                c.Sobrenome == cliente.Sobrenome &&
                c.Idade == cliente.Idade);

            if (clienteExistente != null)
            {
                Console.WriteLine("Cliente já cadastrado.");
                return;
            }

            _repositorioCliente.AdicionarCliente(cliente);
            Console.WriteLine("Cliente cadastrado com sucesso!");
        }

        public List<Cliente> GetClientes()
        {
            return _repositorioCliente.GetClientes();
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _repositorioCliente.AtualizarCliente(cliente);
        }

        public void DeleteFisico(Cliente cliente)
        {
            _repositorioCliente.DeleteFisico(cliente);
        }

        public void DeleteLogico(int id)
        {
            _repositorioCliente.DeleteLogico(id);
        }
    }
}
