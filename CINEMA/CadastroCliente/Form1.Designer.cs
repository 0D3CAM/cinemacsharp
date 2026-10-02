namespace CadastroCliente
{
    partial class TelaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCliente));
            this.TituloPagina = new System.Windows.Forms.Label();
            this.Opcao = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TituloPagina
            // 
            this.TituloPagina.AutoSize = true;
            this.TituloPagina.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TituloPagina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TituloPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloPagina.Location = new System.Drawing.Point(217, 46);
            this.TituloPagina.Name = "TituloPagina";
            this.TituloPagina.Padding = new System.Windows.Forms.Padding(300, 0, 300, 0);
            this.TituloPagina.Size = new System.Drawing.Size(814, 44);
            this.TituloPagina.TabIndex = 0;
            this.TituloPagina.Text = "Bem-Vindo!";
            this.TituloPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TituloPagina.Click += new System.EventHandler(this.label1_Click);
            // 
            // Opcao
            // 
            this.Opcao.AutoSize = true;
            this.Opcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcao.Location = new System.Drawing.Point(414, 156);
            this.Opcao.Name = "Opcao";
            this.Opcao.Size = new System.Drawing.Size(410, 31);
            this.Opcao.TabIndex = 1;
            this.Opcao.Text = "Escolha uma das opções abaixo:";
            this.Opcao.Click += new System.EventHandler(this.Opcao_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Cadastrar.Location = new System.Drawing.Point(476, 256);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(286, 76);
            this.Cadastrar.TabIndex = 2;
            this.Cadastrar.Text = "Cadastrar Cliente";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Consultar
            // 
            this.Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Consultar.Location = new System.Drawing.Point(476, 347);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(286, 76);
            this.Consultar.TabIndex = 3;
            this.Consultar.Text = "Consultar Cliente";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Atualizar.Location = new System.Drawing.Point(476, 438);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(286, 76);
            this.Atualizar.TabIndex = 4;
            this.Atualizar.Text = "Atualizar Cliente";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Excluir
            // 
            this.Excluir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Excluir.Location = new System.Drawing.Point(476, 529);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(286, 76);
            this.Excluir.TabIndex = 5;
            this.Excluir.Text = "Excluir Cliente";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.Gemini_Generated_Image_m9i5t1m9i5t1m9i5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 670);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Opcao);
            this.Controls.Add(this.TituloPagina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1254, 709);
            this.MinimumSize = new System.Drawing.Size(1254, 709);
            this.Name = "TelaCliente";
            this.Text = "TelaCliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloPagina;
        private System.Windows.Forms.Label Opcao;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Excluir;
    }
}

