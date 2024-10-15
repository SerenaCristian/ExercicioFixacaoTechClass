using ExercicioFixacao.Core.Entidades;
using ExercicioFixacao.Servico;
using System.Collections.Generic;

namespace ExercicioFixacao.Controle
{
    internal class ClienteControle
    {
        private readonly ServicoCliente _servicoCliente;

        public ClienteControle()
        {
            _servicoCliente = new ServicoCliente();
        }

        public void AdicionarCliente(string nome, string sobrenome, int idade)
        {
            Cliente cliente = new Cliente
            {
                Nome = nome,
                Sobrenome = sobrenome,
                Idade = idade
            };

            _servicoCliente.AdicionarCliente(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return _servicoCliente.GetClientes();
        }

        public void EditarCliente(int clienteId, string novoNome, string novoSobrenome, int novaIdade)
        {
            var cliente = new Cliente
            {
                Id = clienteId,
                Nome = novoNome,
                Sobrenome = novoSobrenome,
                Idade = novaIdade
            };

            _servicoCliente.AtualizarCliente(cliente);
        }

        public void DeleteClienteFisico(int clienteId)
        {
            var cliente = new Cliente { Id = clienteId }; 
            _servicoCliente.DeleteFisico(cliente);
        }

        public void DeleteClienteLogico(int clienteId)
        {
            _servicoCliente.DeleteLogico(clienteId);
        }
    }
}
