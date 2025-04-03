
namespace ReservaAPP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEntrar1 = new System.Windows.Forms.Button();
            this.btnCriarempresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrar1
            // 
            this.btnEntrar1.AutoSize = true;
            this.btnEntrar1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar1.Location = new System.Drawing.Point(176, 295);
            this.btnEntrar1.Name = "btnEntrar1";
            this.btnEntrar1.Size = new System.Drawing.Size(100, 30);
            this.btnEntrar1.TabIndex = 0;
            this.btnEntrar1.Text = "Cadastrar";
            this.btnEntrar1.UseVisualStyleBackColor = true;
            this.btnEntrar1.Click += new System.EventHandler(this.btnEntrar1_Click);
            // 
            // btnCriarempresa
            // 
            this.btnCriarempresa.BackColor = System.Drawing.Color.White;
            this.btnCriarempresa.Location = new System.Drawing.Point(518, 295);
            this.btnCriarempresa.Name = "btnCriarempresa";
            this.btnCriarempresa.Size = new System.Drawing.Size(99, 30);
            this.btnCriarempresa.TabIndex = 1;
            this.btnCriarempresa.Text = "Criar";
            this.btnCriarempresa.UseVisualStyleBackColor = false;
            this.btnCriarempresa.Click += new System.EventHandler(this.btnCriarempresa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCriarempresa);
            this.Controls.Add(this.btnEntrar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar1;
        private System.Windows.Forms.Button btnCriarempresa;
    }
}

