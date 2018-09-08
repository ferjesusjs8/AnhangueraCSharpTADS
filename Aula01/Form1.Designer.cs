namespace Aula01
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
            this.btnCadastro = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listaUsuarios = new System.Windows.Forms.DataGridView();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(71, 135);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(100, 23);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            this.btnCadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCadastro_KeyDown);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(15, 25);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(135, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(56, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(135, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(56, 95);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(135, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // listaUsuarios
            // 
            this.listaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuarios.Location = new System.Drawing.Point(265, 25);
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.Size = new System.Drawing.Size(240, 150);
            this.listaUsuarios.TabIndex = 7;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(56, 186);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 8;
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Location = new System.Drawing.Point(329, 186);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(97, 24);
            this.btnAtualizarDados.TabIndex = 9;
            this.btnAtualizarDados.Text = "Atualizar";
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtualizarDados);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.listaUsuarios);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.btnCadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView listaUsuarios;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnAtualizarDados;
    }
}

