namespace ExercicioFixacao.Core.Entidades
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }

        public bool Ativo { get; set; }

        public Cliente()
        {
            Ativo = true;
        }
    }
}
