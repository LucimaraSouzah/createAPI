namespace CreateAPI.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereço { get; set;}
        public string Trabalho { get; set;}
        public int Idade { get; set;}

        public Pessoa() { }

        public Pessoa(int Id, string Nome, string Endereço, int Idade, string Trabalho)
        {
            this. Id = Id;
            this.Nome = Nome;
            this.Endereço = Endereço;
            this.Idade = Idade;
            this.Trabalho = Trabalho;
        }
    }
}
