
namespace ReservaAPP
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.btnRestaurante = new System.Windows.Forms.Button();
            this.btnSalao = new System.Windows.Forms.Button();
            this.btnHotel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestaurante
            // 
            this.btnRestaurante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurante.BackgroundImage")));
            this.btnRestaurante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestaurante.Location = new System.Drawing.Point(114, 338);
            this.btnRestaurante.Name = "btnRestaurante";
            this.btnRestaurante.Size = new System.Drawing.Size(52, 33);
            this.btnRestaurante.TabIndex = 0;
            this.btnRestaurante.UseVisualStyleBackColor = true;
            this.btnRestaurante.Click += new System.EventHandler(this.btnRestaurante_Click);
            // 
            // btnSalao
            // 
            this.btnSalao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalao.BackgroundImage")));
            this.btnSalao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalao.Location = new System.Drawing.Point(629, 338);
            this.btnSalao.Name = "btnSalao";
            this.btnSalao.Size = new System.Drawing.Size(52, 33);
            this.btnSalao.TabIndex = 1;
            this.btnSalao.UseVisualStyleBackColor = true;
            this.btnSalao.Click += new System.EventHandler(this.btnSalao_Click);
            // 
            // btnHotel
            // 
            this.btnHotel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotel.BackgroundImage")));
            this.btnHotel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHotel.Location = new System.Drawing.Point(374, 307);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(52, 33);
            this.btnHotel.TabIndex = 2;
            this.btnHotel.UseVisualStyleBackColor = true;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHotel);
            this.Controls.Add(this.btnSalao);
            this.Controls.Add(this.btnRestaurante);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestaurante;
        private System.Windows.Forms.Button btnSalao;
        private System.Windows.Forms.Button btnHotel;
    }
}