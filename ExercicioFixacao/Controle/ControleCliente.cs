using ExercicioFixacao.Core.Entidades;
using ExercicioFixacao.Servico;

namespace ExercicioFixacao.Controle
{
    internal class ControleCliente
    {
        private readonly ServicoCliente _servicoCliente;
      public void Add(string nome, string sobrenome, int idade)
        {
            Cliente cliente = new Cliente()
            {
                Nome = nome,
                Sobrenome = sobrenome,
                Idade = idade
            };

            _servicoCliente.Add(cliente);
        }
    }
}
