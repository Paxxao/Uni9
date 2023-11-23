namespace ProjetoUrnaEletronica
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
            this.lblCandidato = new System.Windows.Forms.Label();
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnFinalizarVotacao = new System.Windows.Forms.Button();
            this.btnConfirmarVoto = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCandidato
            // 
            this.lblCandidato.AutoSize = true;
            this.lblCandidato.Location = new System.Drawing.Point(70, 38);
            this.lblCandidato.Name = "lblCandidato";
            this.lblCandidato.Size = new System.Drawing.Size(58, 13);
            this.lblCandidato.TabIndex = 0;
            this.lblCandidato.Text = "Candidato:";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(360, 38);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(43, 13);
            this.lblPartido.TabIndex = 1;
            this.lblPartido.Text = "Partido:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(360, 191);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(70, 88);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(40, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Status:";
            // 
            // btnFinalizarVotacao
            // 
            this.btnFinalizarVotacao.Location = new System.Drawing.Point(363, 165);
            this.btnFinalizarVotacao.Name = "btnFinalizarVotacao";
            this.btnFinalizarVotacao.Size = new System.Drawing.Size(107, 23);
            this.btnFinalizarVotacao.TabIndex = 5;
            this.btnFinalizarVotacao.Text = "Finalizar Votação";
            this.btnFinalizarVotacao.UseVisualStyleBackColor = true;
            this.btnFinalizarVotacao.Click += new System.EventHandler(this.btnFinalizarVotacao_Click_1);
            // 
            // btnConfirmarVoto
            // 
            this.btnConfirmarVoto.Location = new System.Drawing.Point(73, 169);
            this.btnConfirmarVoto.Name = "btnConfirmarVoto";
            this.btnConfirmarVoto.Size = new System.Drawing.Size(96, 23);
            this.btnConfirmarVoto.TabIndex = 6;
            this.btnConfirmarVoto.Text = "Confirmar Voto";
            this.btnConfirmarVoto.UseVisualStyleBackColor = true;
            this.btnConfirmarVoto.Click += new System.EventHandler(this.btnConfirmarVoto_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(73, 143);
            this.txtCodigo.Mask = "000";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCodigo_MaskInputRejected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(363, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 312);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnConfirmarVoto);
            this.Controls.Add(this.btnFinalizarVotacao);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.lblCandidato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCandidato;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnFinalizarVotacao;
        private System.Windows.Forms.Button btnConfirmarVoto;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

