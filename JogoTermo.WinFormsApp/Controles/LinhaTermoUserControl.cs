using JogoTermo.WinFormsApp.Dominio;
using System.Linq;

namespace JogoTermo.WinFormsApp.Controles
{
    public partial class LinhaTermoUserControl : UserControl
    {
        private int indiceAtual = 0;

        public bool EstaPreenchida
        {
            get { return indiceAtual == 5; }
        }

        public LinhaTermoUserControl()
        {
            InitializeComponent();
        }

        public void Digitar(string letra)
        {
            if (EstaPreenchida)
                return;

            List<Label> controles = gridColunas.Controls.Cast<Label>().Reverse().ToList();

            controles[indiceAtual].Text = letra;

            indiceAtual++;
        }

        public override string ToString()
        {
            string palavraCompleta = "";

            foreach (Label label in gridColunas.Controls.Cast<Label>().Reverse())
                palavraCompleta += label.Text;

            return palavraCompleta;
        }

        public void ColorirLabels(AvaliacaoLetra[] avaliacoes)
        {
            List<Label> controles = gridColunas.Controls.Cast<Label>().Reverse().ToList();

            for (int i = 0; i < avaliacoes.Length; i++)
            {
                Label labelSelecionado = controles[i];

                switch (avaliacoes[i])
                {
                    case AvaliacaoLetra.Correta:
                        labelSelecionado.BackColor = Color.LawnGreen;
                        break;

                    case AvaliacaoLetra.PosicaoIncorreta:
                        labelSelecionado.BackColor = Color.Goldenrod;
                        break;

                    case AvaliacaoLetra.NaoExistente:
                        labelSelecionado.BackColor = SystemColors.WindowFrame;
                        break;
                }
            }
        }

        public void Apagar()
        {
            if (indiceAtual <= 0)
                return;

            indiceAtual--;

            Label labelSelecionada = gridColunas.Controls.Cast<Label>().Reverse().ToList()[indiceAtual];

            labelSelecionada.Text = "";
        }

        internal void Limpar()
        {
            indiceAtual = 0;

            foreach (Label label in gridColunas.Controls)
            {
                label.Text = "";
                label.BackColor = SystemColors.GrayText;
            }
        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void lbl5_Click(object sender, EventArgs e)
        {
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
        }
    }
}