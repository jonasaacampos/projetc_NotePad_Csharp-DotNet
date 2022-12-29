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

        #region Métodos comuns ao menu

        private void SalvarArquivo(string path)
        {
            //objeto para escrita do arquivo

            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(path, false); // se o arquivo já existir, ele será sobrescrito | caso esteja como true, o conteúdo é atualizado
                writer.Write(txtContent.Text);

                FileInfo file = new FileInfo(path);
                CaminhoArquivoUsuarioDefinir(file);
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

        public void CaixaDialogoSalvar(string tituloCaixaDialogo)
        {
            SaveFileDialog mensagemBoxSalvarArquivo = new SaveFileDialog();

            mensagemBoxSalvarArquivo.Title = tituloCaixaDialogo;
            mensagemBoxSalvarArquivo.Filter = "markDown file | *.md | text file | *.txt| todos | *.*";
            mensagemBoxSalvarArquivo.CheckFileExists = false;
  
            var mensagemBoxSalvar = mensagemBoxSalvarArquivo.ShowDialog();

            FileInfo file = new FileInfo(mensagemBoxSalvarArquivo.FileName);

            if (mensagemBoxSalvar != DialogResult.Cancel && mensagemBoxSalvar != DialogResult.Abort)
            {
                SalvarArquivo(mensagemBoxSalvarArquivo.FileName);
                Text = Application.ProductName + " | " + file.Name;
            }
        }

        public void CaixaDialogoAbrir()
        {
            OpenFileDialog caixaDialogoAbrirArquivo = new OpenFileDialog();
            caixaDialogoAbrirArquivo.Filter = "todos | *.*";

            DialogResult caixaAbrirArquivo = caixaDialogoAbrirArquivo.ShowDialog();

            if (caixaAbrirArquivo != DialogResult.Cancel && caixaAbrirArquivo != DialogResult.Abort)
            {
                if (File.Exists(caixaDialogoAbrirArquivo.FileName))
                {
                    FileInfo file = new FileInfo(caixaDialogoAbrirArquivo.FileName);
                    Text = Application.ProductName + " | " + file.Name;
                    CaminhoArquivoUsuarioDefinir(file);

                    StreamReader reader = null;

                    try
                    {
                        reader = new StreamReader(file.FullName, true);
                        txtContent.Text = reader.ReadToEnd();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao abrir o arquivo. \n" + ex.Message);
                    }
                    finally
                    {
                        reader.Close();
                        menuArquivoSalvar.Enabled = true;
                    }

                }
            }

        }

        public static void CaminhoArquivoUsuarioDefinir(FileInfo file)
        {
            Gerenciador.FolderPath = file.DirectoryName + "\\";
            Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
            Gerenciador.FileExtension = file.Extension;
        }

        #endregion

        private void menuArquivoNovo_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
            menuArquivoSalvar.Enabled = true;
            Text = Application.ProductName;
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
            Text = Application.ProductName;

        }
 
        private void menuArquivoSalvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Gerenciador.FilePath))
            {
                SalvarArquivo(Gerenciador.FilePath);
            }
            else
            {
                CaixaDialogoSalvar("Salvar... ");
                menuArquivoSalvar.Enabled = false;
            }

        }

        private void menuArquivoSalvarComo_Click(object sender, EventArgs e)
        {
            CaixaDialogoSalvar("Salvar Como...");

        }
      
        private void menuArquivoAbrir_Click(object sender, EventArgs e)
        {
            CaixaDialogoAbrir();

        }

        private void menuArquivoSair_Click(object sender, EventArgs e)
        {

            var messageBoxSairPrograma = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (messageBoxSairPrograma == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            menuArquivoSalvar.Enabled = true;
        }

        #endregion

        #region Menu Editar

        private void menuEditarDesfazer_Click(object sender, EventArgs e)
        {
            txtContent.Undo();
        }

        private void menuEditarRefazer_Click(object sender, EventArgs e)
        {
            txtContent.Redo();
        }

        private void menuEditarRecortar_Click(object sender, EventArgs e)
        {
            txtContent.Cut();
        }

        private void menuEditarCopiar_Click(object sender, EventArgs e)
        {
            txtContent.Copy();
        }

        private void menuEditarColar_Click(object sender, EventArgs e)
        {
            txtContent.Paste();
        }

        private void menuEditarExcluir_Click(object sender, EventArgs e)
        {
            //txtContent.Text retorna uma string, da qual podemos utilizar os métodos de strings
            // removemos o texto selecionado e retornamos uma nota string, que substitui o texto original
            txtContent.Text = txtContent.Text.Remove(txtContent.SelectionStart, txtContent.SelectedText.Length);
        }

        private void menuEditarDataHora_Click(object sender, EventArgs e)
        {
            int index = txtContent.SelectionStart;
            string dataHora = DateTime.Now.ToString();

            //se o cursos estiver no início da linha, inserir a data e hora, e mudar o cursor para a posição posterior 
            //aos dados inseridos
            if (txtContent.SelectionStart == txtContent.Text.Length)
            {
                txtContent.Text = txtContent.Text + dataHora;
                txtContent.SelectionStart = index + dataHora.Length;
                return;

                //se o return foi executado, o programa ignora o restante do método
            }

            string temp = "";

            for (int i = 0; i < txtContent.Text.Length ; i++)
            {
                if (i == txtContent.SelectionStart)
                {
                    temp += dataHora;
                    temp += txtContent.Text[i];
                }
                else
                {
                    temp += txtContent.Text[i];
                }
            }

            txtContent.Text = temp;
            txtContent.SelectionStart = index + dataHora.Length;

        }

        #endregion

        #region Menu Formatar

        private void menuFormatarQuebraDeLinhaAutomatica_Click(object sender, EventArgs e)
        {
            txtContent.WordWrap = menuFormatarQuebraDeLinhaAutomatica.Checked;

        }

        private void menuFormatarFonte_Click(object sender, EventArgs e)
        {
            FontDialog fonte = new FontDialog();
            fonte.ShowColor = true;
            fonte.ShowEffects = true;

            fonte.Font = txtContent.Font;
            fonte.Color = txtContent.ForeColor;

            DialogResult caixaDialogoFonte = fonte.ShowDialog();

            if (caixaDialogoFonte == DialogResult.OK)
            {
                txtContent.Font = fonte.Font;
                txtContent.ForeColor = fonte.Color;
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
