namespace NotePad_CS
{
    partial class FormSobre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowserSobre = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserSobre
            // 
            this.webBrowserSobre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserSobre.Location = new System.Drawing.Point(0, 0);
            this.webBrowserSobre.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserSobre.Name = "webBrowserSobre";
            this.webBrowserSobre.Size = new System.Drawing.Size(800, 450);
            this.webBrowserSobre.TabIndex = 0;
            this.webBrowserSobre.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserSobre_DocumentCompleted);
            // 
            // FormSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserSobre);
            this.Name = "FormSobre";
            this.Text = "Sobre o NotePad_CS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserSobre;
    }
}