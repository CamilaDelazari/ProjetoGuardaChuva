﻿namespace ProjetoGuardaChuva
{
    partial class formCadastroGeral
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
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            txtNomeArea = new TextBox();
            cmbIDArea = new ComboBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            btnInserir = new Button();
            tabPage2 = new TabPage();
            label19 = new Label();
            txtInclinacao = new TextBox();
            label18 = new Label();
            comboBox2 = new ComboBox();
            label14 = new Label();
            lblResultadoCalculo = new Label();
            txtBaseTelhado = new TextBox();
            txtAreaTelhado = new TextBox();
            label13 = new Label();
            label12 = new Label();
            btnCalcular = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            tabPage3 = new TabPage();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            textBox10 = new TextBox();
            comboBox4 = new ComboBox();
            label17 = new Label();
            label15 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, -4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 383);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 39);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(540, 344);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightGray;
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtNomeArea);
            tabPage1.Controls.Add(cmbIDArea);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(btnInserir);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(532, 316);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro de Setor";
            tabPage1.Click += tabPage1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 15);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "ID do Setor:";
            // 
            // txtNomeArea
            // 
            txtNomeArea.Location = new Point(109, 42);
            txtNomeArea.Name = "txtNomeArea";
            txtNomeArea.Size = new Size(289, 23);
            txtNomeArea.TabIndex = 5;
            // 
            // cmbIDArea
            // 
            cmbIDArea.Enabled = false;
            cmbIDArea.FormattingEnabled = true;
            cmbIDArea.Location = new Point(109, 12);
            cmbIDArea.Name = "cmbIDArea";
            cmbIDArea.Size = new Size(72, 23);
            cmbIDArea.TabIndex = 4;
            cmbIDArea.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 45);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome do Setor:";
            // 
            // button2
            // 
            button2.Location = new Point(187, 94);
            button2.Name = "button2";
            button2.Size = new Size(79, 25);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(102, 94);
            button1.Name = "button1";
            button1.Size = new Size(79, 25);
            button1.TabIndex = 1;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(17, 94);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(79, 25);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightGray;
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(txtInclinacao);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(lblResultadoCalculo);
            tabPage2.Controls.Add(txtBaseTelhado);
            tabPage2.Controls.Add(txtAreaTelhado);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(btnCalcular);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(532, 316);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastro de Domicílio";
            tabPage2.Click += tabPage2_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(457, 186);
            label19.Name = "label19";
            label19.Size = new Size(72, 15);
            label19.TabIndex = 29;
            label19.Text = "em graus (°)";
            // 
            // txtInclinacao
            // 
            txtInclinacao.Location = new Point(404, 181);
            txtInclinacao.Name = "txtInclinacao";
            txtInclinacao.Size = new Size(48, 23);
            txtInclinacao.TabIndex = 28;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(297, 186);
            label18.Name = "label18";
            label18.Size = new Size(108, 15);
            label18.TabIndex = 27;
            label18.Text = "Inclinação Telhado:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(105, 38);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(324, 23);
            comboBox2.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 41);
            label14.Name = "label14";
            label14.Size = new Size(37, 15);
            label14.TabIndex = 25;
            label14.Text = "Setor:";
            // 
            // lblResultadoCalculo
            // 
            lblResultadoCalculo.AutoSize = true;
            lblResultadoCalculo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoCalculo.ForeColor = SystemColors.Highlight;
            lblResultadoCalculo.Location = new Point(6, 244);
            lblResultadoCalculo.Name = "lblResultadoCalculo";
            lblResultadoCalculo.Size = new Size(141, 20);
            lblResultadoCalculo.TabIndex = 24;
            lblResultadoCalculo.Text = "lblResultadoCalculo";
            // 
            // txtBaseTelhado
            // 
            txtBaseTelhado.Location = new Point(105, 209);
            txtBaseTelhado.Name = "txtBaseTelhado";
            txtBaseTelhado.Size = new Size(186, 23);
            txtBaseTelhado.TabIndex = 23;
            txtBaseTelhado.TextChanged += textBox9_TextChanged;
            // 
            // txtAreaTelhado
            // 
            txtAreaTelhado.Location = new Point(105, 181);
            txtAreaTelhado.Name = "txtAreaTelhado";
            txtAreaTelhado.Size = new Size(186, 23);
            txtAreaTelhado.TabIndex = 22;
            txtAreaTelhado.TextChanged += textBox8_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 212);
            label13.Name = "label13";
            label13.Size = new Size(78, 15);
            label13.TabIndex = 21;
            label13.Text = "Base Telhado:";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 186);
            label12.Name = "label12";
            label12.Size = new Size(86, 15);
            label12.TabIndex = 20;
            label12.Text = "Altura Telhado:";
            label12.Click += label12_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(310, 209);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(82, 22);
            btnCalcular.TabIndex = 19;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // button5
            // 
            button5.Location = new Point(185, 277);
            button5.Name = "button5";
            button5.Size = new Size(82, 22);
            button5.TabIndex = 18;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(97, 277);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 17;
            button4.Text = "Gravar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(8, 277);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 16;
            button3.Text = "Inserir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(291, 11);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(138, 23);
            textBox7.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(169, 14);
            label11.Name = "label11";
            label11.Size = new Size(116, 15);
            label11.TabIndex = 14;
            label11.Text = "Número de Contato:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(458, 152);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(68, 23);
            textBox6.TabIndex = 13;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(398, 155);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 12;
            label10.Text = "Número:";
            label10.Click += label10_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(105, 152);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(287, 23);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 155);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 10;
            label9.Text = "Rua:";
            label9.Click += label9_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(224, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(302, 23);
            textBox4.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(171, 97);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 8;
            label8.Text = "Cidade:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(54, 23);
            textBox3.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 97);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 6;
            label7.Text = "Estado:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(421, 23);
            textBox2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 126);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 4;
            label6.Text = "Bairro:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 23);
            textBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 69);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 2;
            label5.Text = "CEP:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(105, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(54, 23);
            comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 14);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 0;
            label4.Text = "ID do Domicílio:";
            label4.Click += label4_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightGray;
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(textBox10);
            tabPage3.Controls.Add(comboBox4);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label15);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(532, 316);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cadastro de Estoque";
            // 
            // button9
            // 
            button9.Location = new Point(179, 79);
            button9.Name = "button9";
            button9.Size = new Size(80, 24);
            button9.TabIndex = 8;
            button9.Text = "Cancelar";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(93, 79);
            button8.Name = "button8";
            button8.Size = new Size(80, 24);
            button8.TabIndex = 7;
            button8.Text = "Gravar";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(7, 79);
            button7.Name = "button7";
            button7.Size = new Size(80, 24);
            button7.TabIndex = 6;
            button7.Text = "Inserir";
            button7.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(217, 41);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(87, 23);
            textBox10.TabIndex = 5;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(92, 9);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(90, 23);
            comboBox4.TabIndex = 4;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(7, 44);
            label17.Name = "label17";
            label17.Size = new Size(204, 15);
            label17.TabIndex = 2;
            label17.Text = "Capacidade do Recipiente (em litros):";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(7, 13);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 0;
            label15.Text = "ID Recipiente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(173, 13);
            label1.Name = "label1";
            label1.Size = new Size(207, 21);
            label1.TabIndex = 0;
            label1.Text = "Escolha um tipo de cadsatro:";
            // 
            // formCadastroGeral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(540, 382);
            Controls.Add(groupBox1);
            Name = "formCadastroGeral";
            Text = "Cadastro Geral";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cmbIDArea;
        private Label label2;
        private Button button2;
        private Button button1;
        private Button btnInserir;
        private TabPage tabPage3;
        private Label label3;
        private TextBox txtNomeArea;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox4;
        private Label label8;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox textBox7;
        private Label label11;
        private Button btnCalcular;
        private TextBox txtBaseTelhado;
        private TextBox txtAreaTelhado;
        private Label label13;
        private Label label12;
        private Label lblResultadoCalculo;
        private ComboBox comboBox2;
        private Label label14;
        private ComboBox comboBox4;
        private Label label17;
        private Label label15;
        private TextBox textBox10;
        private Button button9;
        private Button button8;
        private Button button7;
        private TextBox txtInclinacao;
        private Label label18;
        private Label label19;
    }
}