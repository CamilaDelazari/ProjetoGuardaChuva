namespace ProjetoGuardaChuva
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            pictureBox1 = new PictureBox();
            btnCadastro = new Button();
            btnAssociacao = new Button();
            btnAbout = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 93);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(112, 107);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(233, 58);
            btnCadastro.TabIndex = 1;
            btnCadastro.Text = "Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnAssociacao
            // 
            btnAssociacao.Location = new Point(112, 209);
            btnAssociacao.Name = "btnAssociacao";
            btnAssociacao.Size = new Size(233, 58);
            btnAssociacao.TabIndex = 2;
            btnAssociacao.Text = "Associação";
            btnAssociacao.UseVisualStyleBackColor = true;
            btnAssociacao.Click += btnAssociacao_Click;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(365, 285);
            btnAbout.Name = "btnAbout";
            btnAbout.RightToLeft = RightToLeft.No;
            btnAbout.Size = new Size(77, 28);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(112, 34);
            label1.Name = "label1";
            label1.Size = new Size(330, 23);
            label1.TabIndex = 4;
            label1.Text = "Seja bem vindo ao projeto Guarda Chuva!";
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(452, 325);
            Controls.Add(label1);
            Controls.Add(btnAbout);
            Controls.Add(btnAssociacao);
            Controls.Add(btnCadastro);
            Controls.Add(pictureBox1);
            Name = "formMain";
            Text = "formMain";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnCadastro;
        private Button btnAssociacao;
        private Button btnAbout;
        private Label label1;
    }
}