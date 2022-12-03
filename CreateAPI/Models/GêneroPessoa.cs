namespace CreateAPI.Models
{
    public class GêneroPessoa
    {
        public int Tag { get; set; }
        public string Gênero { get; set; }

        public List<Pessoa> Pessoas { get; set; }

        public GêneroPessoa()
        {
            this.Pessoas = new List<Pessoa>();
        }

        public void Adiciona(Pessoa pessoa)
        {
            this.Pessoas.Add(pessoa);
        }

        public void Remove(long id)
        {
            Pessoa pessoa = Pessoas.FirstOrDefault(x => x.Id == id);

            Pessoas.Remove(pessoa);
        }

        public void Altera(Pessoa pessoa)
        {
            Remove(pessoa.Id);
            Adiciona(pessoa);
        }
    }
}
