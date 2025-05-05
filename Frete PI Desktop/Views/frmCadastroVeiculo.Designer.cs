namespace Frete_PI_Desktop
{
    partial class frmCadastroVeiculo
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
            txtPlaca = new MaskedTextBox();
            label1 = new Label();
            txtRenavam = new MaskedTextBox();
            txtModelo = new TextBox();
            txtAnoVeiculo = new TextBox();
            txtCorVeiculo = new TextBox();
            cmbTipoVeiculo = new ComboBox();
            txtCapacidadeVeiculo = new TextBox();
            txtObservacaoVeiculo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmbStatusVeiculo = new ComboBox();
            btnCadastrarVeiculo = new Button();
            txtBuscar = new TextBox();
            label10 = new Label();
            btnBuscar = new Button();
            lstvVeiculos = new ListView();
            columnId = new ColumnHeader();
            columnPlaca = new ColumnHeader();
            columnRenavam = new ColumnHeader();
            columnModelo = new ColumnHeader();
            columnAnoFabricacao = new ColumnHeader();
            columnCor = new ColumnHeader();
            columnTipo = new ColumnHeader();
            columnCapacidade = new ColumnHeader();
            columnOBS = new ColumnHeader();
            columnStatus = new ColumnHeader();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            btnNovoVeiculo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(53, 154);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(154, 23);
            txtPlaca.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(53, 136);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Placa do Veículo:";
            // 
            // txtRenavam
            // 
            txtRenavam.Location = new Point(237, 155);
            txtRenavam.Name = "txtRenavam";
            txtRenavam.Size = new Size(180, 23);
            txtRenavam.TabIndex = 2;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(53, 211);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(154, 23);
            txtModelo.TabIndex = 3;
            // 
            // txtAnoVeiculo
            // 
            txtAnoVeiculo.Location = new Point(240, 211);
            txtAnoVeiculo.Name = "txtAnoVeiculo";
            txtAnoVeiculo.Size = new Size(180, 23);
            txtAnoVeiculo.TabIndex = 4;
            // 
            // txtCorVeiculo
            // 
            txtCorVeiculo.Location = new Point(53, 272);
            txtCorVeiculo.Name = "txtCorVeiculo";
            txtCorVeiculo.Size = new Size(154, 23);
            txtCorVeiculo.TabIndex = 5;
            // 
            // cmbTipoVeiculo
            // 
            cmbTipoVeiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVeiculo.FormattingEnabled = true;
            cmbTipoVeiculo.Location = new Point(237, 272);
            cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            cmbTipoVeiculo.Size = new Size(183, 23);
            cmbTipoVeiculo.TabIndex = 6;
            // 
            // txtCapacidadeVeiculo
            // 
            txtCapacidadeVeiculo.Location = new Point(53, 331);
            txtCapacidadeVeiculo.Name = "txtCapacidadeVeiculo";
            txtCapacidadeVeiculo.Size = new Size(154, 23);
            txtCapacidadeVeiculo.TabIndex = 7;
            // 
            // txtObservacaoVeiculo
            // 
            txtObservacaoVeiculo.Location = new Point(53, 384);
            txtObservacaoVeiculo.Multiline = true;
            txtObservacaoVeiculo.Name = "txtObservacaoVeiculo";
            txtObservacaoVeiculo.Size = new Size(367, 63);
            txtObservacaoVeiculo.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(237, 137);
            label2.Name = "label2";
            label2.Size = new Size(180, 15);
            label2.TabIndex = 10;
            label2.Text = "Número da Renavam do Veículo:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 193);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 11;
            label3.Text = "Modelo do Veículo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(237, 193);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 12;
            label4.Text = "Ano do Veículo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(53, 254);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 13;
            label5.Text = "Cor do Veículo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(237, 254);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 14;
            label6.Text = "Tipo do Veículo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(53, 313);
            label7.Name = "label7";
            label7.Size = new Size(130, 15);
            label7.TabIndex = 15;
            label7.Text = "Capacidade do Veículo:\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(53, 366);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 16;
            label8.Text = "Observação:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(237, 313);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 17;
            label9.Text = "Status do Veículo:";
            // 
            // cmbStatusVeiculo
            // 
            cmbStatusVeiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusVeiculo.FormattingEnabled = true;
            cmbStatusVeiculo.Location = new Point(237, 331);
            cmbStatusVeiculo.Name = "cmbStatusVeiculo";
            cmbStatusVeiculo.Size = new Size(183, 23);
            cmbStatusVeiculo.TabIndex = 18;
            // 
            // btnCadastrarVeiculo
            // 
            btnCadastrarVeiculo.BackColor = SystemColors.ButtonHighlight;
            btnCadastrarVeiculo.FlatAppearance.BorderColor = SystemColors.HotTrack;
            btnCadastrarVeiculo.ForeColor = SystemColors.Desktop;
            btnCadastrarVeiculo.Location = new Point(53, 464);
            btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            btnCadastrarVeiculo.Size = new Size(177, 23);
            btnCadastrarVeiculo.TabIndex = 19;
            btnCadastrarVeiculo.Text = "(Re)Cadastrar Veículo";
            btnCadastrarVeiculo.UseVisualStyleBackColor = false;
            btnCadastrarVeiculo.Click += btnCadastrarVeiculo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(531, 154);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(214, 23);
            txtBuscar.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(531, 136);
            label10.Name = "label10";
            label10.Size = new Size(136, 15);
            label10.TabIndex = 21;
            label10.Text = "Insira a Placa do Veículo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(767, 137);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lstvVeiculos
            // 
            lstvVeiculos.AllowColumnReorder = true;
            lstvVeiculos.BackColor = SystemColors.Window;
            lstvVeiculos.Columns.AddRange(new ColumnHeader[] { columnId, columnPlaca, columnRenavam, columnModelo, columnAnoFabricacao, columnCor, columnTipo, columnCapacidade, columnOBS, columnStatus });
            lstvVeiculos.GridLines = true;
            lstvVeiculos.Location = new Point(500, 193);
            lstvVeiculos.MultiSelect = false;
            lstvVeiculos.Name = "lstvVeiculos";
            lstvVeiculos.Size = new Size(361, 294);
            lstvVeiculos.TabIndex = 23;
            lstvVeiculos.UseCompatibleStateImageBehavior = false;
            lstvVeiculos.ItemSelectionChanged += lstvVeiculos_ItemSelectionChanged;
            // 
            // columnId
            // 
            columnId.Text = "ID";
            // 
            // columnPlaca
            // 
            columnPlaca.Text = "Placa";
            // 
            // columnRenavam
            // 
            columnRenavam.Text = "Renavam";
            // 
            // columnModelo
            // 
            columnModelo.Text = "Modelo";
            // 
            // columnAnoFabricacao
            // 
            columnAnoFabricacao.Text = "Ano Fabricação";
            // 
            // columnCor
            // 
            columnCor.Text = "Cor";
            // 
            // columnTipo
            // 
            columnTipo.Text = "Tipo";
            // 
            // columnCapacidade
            // 
            columnCapacidade.Text = "Capacidade";
            // 
            // columnOBS
            // 
            columnOBS.Text = "Observação";
            // 
            // columnStatus
            // 
            columnStatus.Text = "Status";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fundo_branco;
            pictureBox1.Location = new Point(23, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 473);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.fundo_branco;
            pictureBox2.Location = new Point(477, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(399, 458);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonHighlight;
            label11.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(119, 78);
            label11.Name = "label11";
            label11.Size = new Size(227, 31);
            label11.TabIndex = 26;
            label11.Text = "Cadastro de Veículo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ButtonHighlight;
            label12.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(605, 78);
            label12.Name = "label12";
            label12.Size = new Size(162, 31);
            label12.TabIndex = 27;
            label12.Text = "Lista Veículos";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(243, 464);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(177, 23);
            btnAtualizar.TabIndex = 28;
            btnAtualizar.Text = "Atualizar Veículo";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(767, 166);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 29;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnNovoVeiculo
            // 
            btnNovoVeiculo.BackColor = SystemColors.ButtonHighlight;
            btnNovoVeiculo.FlatAppearance.BorderColor = SystemColors.HotTrack;
            btnNovoVeiculo.ForeColor = SystemColors.Desktop;
            btnNovoVeiculo.Location = new Point(53, 496);
            btnNovoVeiculo.Name = "btnNovoVeiculo";
            btnNovoVeiculo.Size = new Size(177, 23);
            btnNovoVeiculo.TabIndex = 30;
            btnNovoVeiculo.Text = "Cadastrar novo veículo";
            btnNovoVeiculo.UseVisualStyleBackColor = false;
            btnNovoVeiculo.Click += btnNovoVeiculo_Click;
            // 
            // frmCadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 637);
            Controls.Add(btnNovoVeiculo);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(lstvVeiculos);
            Controls.Add(btnBuscar);
            Controls.Add(label10);
            Controls.Add(txtBuscar);
            Controls.Add(btnCadastrarVeiculo);
            Controls.Add(cmbStatusVeiculo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtObservacaoVeiculo);
            Controls.Add(txtCapacidadeVeiculo);
            Controls.Add(cmbTipoVeiculo);
            Controls.Add(txtCorVeiculo);
            Controls.Add(txtAnoVeiculo);
            Controls.Add(txtModelo);
            Controls.Add(txtRenavam);
            Controls.Add(label1);
            Controls.Add(txtPlaca);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            MaximizeBox = false;
            Name = "frmCadastroVeiculo";
            Text = "frmCadastroVeiculo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtPlaca;
        private Label label1;
        private MaskedTextBox txtRenavam;
        private TextBox txtModelo;
        private TextBox txtAnoVeiculo;
        private TextBox txtCorVeiculo;
        private ComboBox cmbTipoVeiculo;
        private TextBox txtCapacidadeVeiculo;
        private TextBox txtObservacaoVeiculo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cmbStatusVeiculo;
        private Button btnCadastrarVeiculo;
        private TextBox txtBuscar;
        private Label label10;
        private Button btnBuscar;
        private ListView lstvVeiculos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label11;
        private Label label12;
        private ColumnHeader columnPlaca;
        private ColumnHeader columnRenavam;
        private ColumnHeader columnModelo;
        private ColumnHeader columnAnoFabricacao;
        private ColumnHeader columnCor;
        private ColumnHeader columnTipo;
        private ColumnHeader columnCapacidade;
        private ColumnHeader columnStatus;
        private ColumnHeader columnId;
        private ColumnHeader columnOBS;
        private Button btnAtualizar;
        private Button btnDeletar;
        private Button btnNovoVeiculo;
    }
}