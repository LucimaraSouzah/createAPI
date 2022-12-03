using CreateAPI.Models;

namespace CreateAPI.DAL
{
    public class TipoPessoaDAL
    {
        private static Dictionary<long, GêneroPessoa> bancoGêneroPessoa = new Dictionary<long, GêneroPessoa>();
        private static int contadorBanco = 2;

        static TipoPessoaDAL()
        {
            GêneroPessoa Feminino = new GêneroPessoa();
            Feminino.Tag = 1;
            Feminino.Gênero = "Feminino";

            Pessoa Mauro = new Pessoa();
            Mauro.Id = 1;
            Mauro.Nome = "Mauro";
            Mauro.Idade = 18;
            Mauro.Trabalho = "Desenvolvedor";
            Mauro.Endereço = "MG";

            GêneroPessoa Masculino = new GêneroPessoa();
            Masculino.Tag = 2;
            Masculino.Gênero = "Masculino";

            Masculino.Adiciona(Mauro);

            bancoGêneroPessoa.Add(1, Feminino);
            bancoGêneroPessoa.Add(2, Masculino);
        }

        public void Inserir(GêneroPessoa gêneroPessoa)
        {
            contadorBanco++;
            gêneroPessoa.Tag = contadorBanco;
            bancoGêneroPessoa.Add(contadorBanco, gêneroPessoa);
        }

        public GêneroPessoa Consultar(int Tag)
        {
            return bancoGêneroPessoa[Tag];
        }
        
        public IList<GêneroPessoa> Listar()
        {
            return new List<GêneroPessoa>(bancoGêneroPessoa.Values);
        }

        public void Excluir(int Tag)
        {
            bancoGêneroPessoa.Remove(Tag);
        }

        public void Alterar(GêneroPessoa gêneroPessoa)
        {
            bancoGêneroPessoa[gêneroPessoa.Tag] = gêneroPessoa;
        }
    }
}
