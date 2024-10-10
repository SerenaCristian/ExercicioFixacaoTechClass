using System;
using ExercicioFixacao.Core.Entidades;
using ExercicioFixacao.Infra;


namespace ExercicioFixacao.Servico
{
    internal class ServicoCliente
    {
        private readonly RepositorioCliente _repositorioCliente;

        public ServicoCliente()
        {
            _repositorioCliente = new RepositorioCliente();
        }

        public void Add(Cliente cliente)
        {
            if (cliente.Nome == cliente.Nome && cliente.Sobrenome == cliente.Sobrenome && cliente.Idade == cliente.Idade)
            {
                Console.WriteLine("Cliente já cadastrado");
                return;
            }
            else if (cliente.Nome != cliente.Nome && cliente.Sobrenome != cliente.Sobrenome && cliente.Idade != cliente.Idade)

            {
                Console.WriteLine("Continuar cadastro");
                return;
            }
            _repositorioCliente.Add(cliente);
        }


    }
}
