namespace Frete_PI_Desktop.Views
{
    partial class frmCadastroParam
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtIdVeiculoParametro = new TextBox();
            label1 = new Label();
            txtDataVeiculoParametro = new MaskedTextBox();
            label2 = new Label();
            txtConsumoCombustivel = new MaskedTextBox();
            label3 = new Label();
            txtValorCapital = new MaskedTextBox();
            txtTaxaRemuneracao = new MaskedTextBox();
            txtMesesUso = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtLicenciamento = new MaskedTextBox();
            label8 = new Label();
            txtValorEquipamento = new MaskedTextBox();
            label9 = new Label();
            txtVidaEquipamento = new MaskedTextBox();
            lstvParametros = new ListView();
            btnCadastrarParametro = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            btnBuscarParametro = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fundo_branco;
            pictureBox1.Location = new Point(25, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 458);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.fundo_branco;
            pictureBox2.Location = new Point(478, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(436, 458);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // txtIdVeiculoParametro
            // 
            txtIdVeiculoParametro.Location = new Point(39, 198);
            txtIdVeiculoParametro.Name = "txtIdVeiculoParametro";
            txtIdVeiculoParametro.Size = new Size(100, 23);
            txtIdVeiculoParametro.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 180);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 28;
            label1.Text = "id do veiculo:";
            // 
            // txtDataVeiculoParametro
            // 
            txtDataVeiculoParametro.Location = new Point(158, 198);
            txtDataVeiculoParametro.Mask = "00/00/0000";
            txtDataVeiculoParametro.Name = "txtDataVeiculoParametro";
            txtDataVeiculoParametro.Size = new Size(100, 23);
            txtDataVeiculoParametro.TabIndex = 29;
            txtDataVeiculoParametro.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 180);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 30;
            label2.Text = "Data atual:";
            // 
            // txtConsumoCombustivel
            // 
            txtConsumoCombustivel.Location = new Point(286, 198);
            txtConsumoCombustivel.Name = "txtConsumoCombustivel";
            txtConsumoCombustivel.Size = new Size(100, 23);
            txtConsumoCombustivel.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 180);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 32;
            label3.Text = "Consumo de Combustível:";
            // 
            // txtValorCapital
            // 
            txtValorCapital.Location = new Point(39, 253);
            txtValorCapital.Name = "txtValorCapital";
            txtValorCapital.Size = new Size(151, 23);
            txtValorCapital.TabIndex = 33;
            // 
            // txtTaxaRemuneracao
            // 
            txtTaxaRemuneracao.Location = new Point(208, 253);
            txtTaxaRemuneracao.Name = "txtTaxaRemuneracao";
            txtTaxaRemuneracao.Size = new Size(151, 23);
            txtTaxaRemuneracao.TabIndex = 34;
            // 
            // txtMesesUso
            // 
            txtMesesUso.Location = new Point(39, 311);
            txtMesesUso.Name = "txtMesesUso";
            txtMesesUso.Size = new Size(166, 23);
            txtMesesUso.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 235);
            label4.Name = "label4";
            label4.Size = new Size(151, 15);
            label4.TabIndex = 36;
            label4.Text = " Valor Capital Investido(rcc)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 235);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 37;
            label5.Text = "Taxa de remuneração atual:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 293);
            label6.Name = "label6";
            label6.Size = new Size(166, 15);
            label6.TabIndex = 38;
            label6.Text = "Quantidade em meses de uso:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(220, 293);
            label7.Name = "label7";
            label7.Size = new Size(216, 15);
            label7.TabIndex = 40;
            label7.Text = "Valor anual do linanciamento do chassi:";
            // 
            // txtLicenciamento
            // 
            txtLicenciamento.Location = new Point(220, 311);
            txtLicenciamento.Name = "txtLicenciamento";
            txtLicenciamento.Size = new Size(214, 23);
            txtLicenciamento.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 350);
            label8.Name = "label8";
            label8.Size = new Size(158, 15);
            label8.TabIndex = 42;
            label8.Text = "Valor inicial do equipamento";
            // 
            // txtValorEquipamento
            // 
            txtValorEquipamento.Location = new Point(39, 368);
            txtValorEquipamento.Name = "txtValorEquipamento";
            txtValorEquipamento.Size = new Size(158, 23);
            txtValorEquipamento.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(220, 350);
            label9.Name = "label9";
            label9.Size = new Size(144, 15);
            label9.TabIndex = 44;
            label9.Text = "Vida útil do equipamento:";
            // 
            // txtVidaEquipamento
            // 
            txtVidaEquipamento.Location = new Point(220, 368);
            txtVidaEquipamento.Name = "txtVidaEquipamento";
            txtVidaEquipamento.Size = new Size(158, 23);
            txtVidaEquipamento.TabIndex = 43;
            // 
            // lstvParametros
            // 
            lstvParametros.Location = new Point(506, 198);
            lstvParametros.Name = "lstvParametros";
            lstvParametros.Size = new Size(380, 302);
            lstvParametros.TabIndex = 45;
            lstvParametros.UseCompatibleStateImageBehavior = false;
            // 
            // btnCadastrarParametro
            // 
            btnCadastrarParametro.Location = new Point(52, 459);
            btnCadastrarParametro.Name = "btnCadastrarParametro";
            btnCadastrarParametro.Size = new Size(179, 23);
            btnCadastrarParametro.TabIndex = 46;
            btnCadastrarParametro.Text = "(Re)Cadastrar Parametro";
            btnCadastrarParametro.UseVisualStyleBackColor = true;
            btnCadastrarParametro.Click += btnCadastrarParametro_Click;
            // 
            // button2
            // 
            button2.Location = new Point(237, 459);
            button2.Name = "button2";
            button2.Size = new Size(179, 23);
            button2.TabIndex = 47;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(52, 488);
            button3.Name = "button3";
            button3.Size = new Size(179, 23);
            button3.TabIndex = 48;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(545, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 49;
            // 
            // btnBuscarParametro
            // 
            btnBuscarParametro.Location = new Point(788, 140);
            btnBuscarParametro.Name = "btnBuscarParametro";
            btnBuscarParametro.Size = new Size(75, 23);
            btnBuscarParametro.TabIndex = 50;
            btnBuscarParametro.Text = "button1";
            btnBuscarParametro.UseVisualStyleBackColor = true;
            btnBuscarParametro.Click += btnBuscarParametro_Click;
            // 
            // button4
            // 
            button4.Location = new Point(788, 169);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 51;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // frmCadastroParam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 628);
            Controls.Add(button4);
            Controls.Add(btnBuscarParametro);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCadastrarParametro);
            Controls.Add(lstvParametros);
            Controls.Add(label9);
            Controls.Add(txtVidaEquipamento);
            Controls.Add(label8);
            Controls.Add(txtValorEquipamento);
            Controls.Add(label7);
            Controls.Add(txtLicenciamento);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMesesUso);
            Controls.Add(txtTaxaRemuneracao);
            Controls.Add(txtValorCapital);
            Controls.Add(label3);
            Controls.Add(txtConsumoCombustivel);
            Controls.Add(label2);
            Controls.Add(txtDataVeiculoParametro);
            Controls.Add(label1);
            Controls.Add(txtIdVeiculoParametro);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmCadastroParam";
            Text = "frmCadastroParam";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtIdVeiculoParametro;
        private Label label1;
        private MaskedTextBox txtDataVeiculoParametro;
        private Label label2;
        private MaskedTextBox txtConsumoCombustivel;
        private Label label3;
        private MaskedTextBox txtValorCapital;
        private MaskedTextBox txtTaxaRemuneracao;
        private MaskedTextBox txtMesesUso;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaskedTextBox txtLicenciamento;
        private Label label8;
        private MaskedTextBox txtValorEquipamento;
        private Label label9;
        private MaskedTextBox txtVidaEquipamento;
        private ListView lstvParametros;
        private Button btnCadastrarParametro;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button btnBuscarParametro;
        private Button button4;
    }
}