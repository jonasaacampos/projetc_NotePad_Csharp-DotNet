using System;
using System.IO;
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


        private void menuArquivoSalvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Gerenciador.FilePath))
            {
                SalvarArquivo(Gerenciador.FilePath);
            }
            else
            {
                SaveFileDialog mensagemBoxSalvarArquivo = new SaveFileDialog();

                mensagemBoxSalvarArquivo.Title = "Salvar";
                mensagemBoxSalvarArquivo.Filter = "markDown file | *.md | text file | *.txt| todos | *.*";
                mensagemBoxSalvarArquivo.CheckFileExists = false;

                var mensagemBoxSalvar = mensagemBoxSalvarArquivo.ShowDialog();

                if (mensagemBoxSalvar != DialogResult.Cancel && mensagemBoxSalvar != DialogResult.Abort)
                {
                    SalvarArquivo(mensagemBoxSalvarArquivo.FileName);
                }

            }

        }
        private void menuArquivoAbrir_Click(object sender, EventArgs e)
        {
            
        }

        private void menuArquivoSalvarComo_Click(object sender, EventArgs e)
        {

        }

        private void SalvarArquivo( string path)
        {
            //objeto para escrita do arquivo

            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(path, false); // se o arquivo já existir, ele será sobrescrito | caso esteja como true, o conteúdo é atualizado
                writer.Write(txtContent.Text);

                FileInfo file = new FileInfo(path);
                Gerenciador.FolderPath = file.DirectoryName + "\\";
                Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                Gerenciador.FileExtension = file.Extension;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o arquivo: \n" + ex.Message);
            }
            finally
            {
                writer.Close();
            }


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
