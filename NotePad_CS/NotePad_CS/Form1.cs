using System;
using System.Threading;
using System.Windows.Forms;

namespace NotePad_CS
{
    public partial class NotePadCS : Form
    {
        public NotePadCS()
        {
            InitializeComponent();
        }


        #region Menu Arquivo


        private void menuArquivoNovo_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
        }

        private void menuArquivoNovaJanela_Click(object sender, EventArgs e)
        {
            // Forma 1 - criar novo objeto para a janela

            //NotePadCS janela = new NotePadCS();
            //janela.Show();

            //Forma 2 - Criar uma Thread para que cada nova instância não possua vínculo com o objeto original

            Thread thread = new Thread(() => Application.Run(new NotePadCS()));
            thread.SetApartmentState(ApartmentState.STA); // definir se será uma thread única ou múltipla (processamento em fila ou em pararelo)
            thread.Start();

        }

        private void menuArquivoAbrir_Click(object sender, EventArgs e)
        {

        }

        private void menuArquivoSalvar_Click(object sender, EventArgs e)
        {

        }

        private void menuArquivoSalvarComo_Click(object sender, EventArgs e)
        {

        }

        private void menuArquivoSair_Click(object sender, EventArgs e)
        {

            var messageBoxSairPrograma = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (messageBoxSairPrograma == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        #endregion





        #region toolStripStatusLabel1_Click
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }


        #endregion


    }
}
