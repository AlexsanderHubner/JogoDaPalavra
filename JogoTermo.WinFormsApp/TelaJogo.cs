using JogoTermo.WinFormsApp.Controles;
using JogoTermo.WinFormsApp.Dominio;

namespace JogoTermo.WinFormsApp
{
    public partial class TelaJogo : Form
    {
        private Termo jogo;

        public LinhaTermoUserControl LinhaAtual
        {
            get
            {
                return (LinhaTermoUserControl)gridPrincipal.Controls[jogo.tentativas];
            }
        }

        public TelaJogo()
        {
            InitializeComponent();

            RegistrarEventos();

            jogo = new Termo();
        }

        public void RegistrarEventos()
        {
            foreach (Button botao in pnlTeclado.Controls)
            {
                if (botao.Name == "btnEnter" ||
                    botao.Name == "btnReiniciar" ||
                    botao.Name == "btnApagar")
                    continue;

                botao.Click += DigitarLetra;
            }

            btnEnter.Click += AvaliarPalavra;

            btnApagar.Click += ApagarLetra;

            btnReiniciar.Click += ReiniciarJogo;
        }

        private void ReiniciarJogo(object? sender, EventArgs e)
        {
            jogo = new Termo();

            pnlTeclado.Enabled = true;

            btnReiniciar.Visible = false;

            foreach (LinhaTermoUserControl linha in gridPrincipal.Controls)
                linha.Limpar();
        }

        private void ApagarLetra(object? sender, EventArgs e)
        {
            LinhaAtual.Apagar();
        }

        private void AvaliarPalavra(object? sender, EventArgs e)
        {
            LinhaTermoUserControl linha = LinhaAtual;

            string palavraCompleta = linha.ToString();

            AvaliacaoLetra[] avaliacoes = jogo.Avaliar(palavraCompleta);

            linha.ColorirLabels(avaliacoes);

            if (jogo.JogadorAcertou(palavraCompleta) || jogo.JogadorPerdeu())
            {
                pnlTeclado.Enabled = false;
                btnReiniciar.Visible = true;
            }
        }

        private void DigitarLetra(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender!;

            LinhaAtual.Digitar(botaoClicado.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TelaTermo_Load(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }
    }


}