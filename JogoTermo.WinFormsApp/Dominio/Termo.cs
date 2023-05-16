namespace JogoTermo.WinFormsApp.Dominio
{
    public class Termo
    {
        private string palavraSecreta = "";
        public int tentativas = 0;

        public Termo()
        {
            palavraSecreta = "AMIGO";
        }

        public AvaliacaoLetra[] Avaliar(string palavra)
        {
            tentativas++;

            AvaliacaoLetra[] avaliacoes = new AvaliacaoLetra[palavra.Length];

            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == palavraSecreta[i])
                    avaliacoes[i] = AvaliacaoLetra.Correta;

                else if (palavraSecreta.Contains(palavra[i]))
                    avaliacoes[i] = AvaliacaoLetra.PosicaoIncorreta;
                else
                    avaliacoes[i] = AvaliacaoLetra.NaoExistente;
            }

            return avaliacoes;
        }

        public bool JogadorAcertou(string palavra)
        {
            return palavra == palavraSecreta;
        }

        public bool JogadorPerdeu()
        {
            return tentativas == 5;
        }

        private string ObterPalavraAleatoria()
        {
            string[] palavras = {

                "AMIGO",

            };

            int indiceAletorio = new Random().Next(palavras.Length);

            return palavras[indiceAletorio];
        }
    }
}
