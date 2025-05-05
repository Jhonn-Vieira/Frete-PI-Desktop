namespace Frete_PI_Desktop
{
    partial class frmDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadatrarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarVeiculoToolStripMenuItem = new ToolStripMenuItem();
            parâmetrosToolStripMenuItem = new ToolStripMenuItem();
            custosFixosToolStripMenuItem = new ToolStripMenuItem();
            custosVariáveisToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadatrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadatrarToolStripMenuItem
            // 
            cadatrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarVeiculoToolStripMenuItem, cadastrarFuncionárioToolStripMenuItem });
            cadatrarToolStripMenuItem.Name = "cadatrarToolStripMenuItem";
            cadatrarToolStripMenuItem.Size = new Size(69, 20);
            cadatrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // cadastrarVeiculoToolStripMenuItem
            // 
            cadastrarVeiculoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { parâmetrosToolStripMenuItem, custosFixosToolStripMenuItem, custosVariáveisToolStripMenuItem });
            cadastrarVeiculoToolStripMenuItem.Name = "cadastrarVeiculoToolStripMenuItem";
            cadastrarVeiculoToolStripMenuItem.Size = new Size(190, 22);
            cadastrarVeiculoToolStripMenuItem.Text = "Cadastrar Veiculo";
            cadastrarVeiculoToolStripMenuItem.Click += cadastrarVeiculoToolStripMenuItem_Click;
            // 
            // parâmetrosToolStripMenuItem
            // 
            parâmetrosToolStripMenuItem.Name = "parâmetrosToolStripMenuItem";
            parâmetrosToolStripMenuItem.Size = new Size(180, 22);
            parâmetrosToolStripMenuItem.Text = "Parâmetros";
            parâmetrosToolStripMenuItem.Click += parâmetrosToolStripMenuItem_Click;
            // 
            // custosFixosToolStripMenuItem
            // 
            custosFixosToolStripMenuItem.Name = "custosFixosToolStripMenuItem";
            custosFixosToolStripMenuItem.Size = new Size(180, 22);
            custosFixosToolStripMenuItem.Text = "Custos fixos";
            // 
            // custosVariáveisToolStripMenuItem
            // 
            custosVariáveisToolStripMenuItem.Name = "custosVariáveisToolStripMenuItem";
            custosVariáveisToolStripMenuItem.Size = new Size(180, 22);
            custosVariáveisToolStripMenuItem.Text = "Custos Variáveis";
            // 
            // cadastrarFuncionárioToolStripMenuItem
            // 
            cadastrarFuncionárioToolStripMenuItem.Name = "cadastrarFuncionárioToolStripMenuItem";
            cadastrarFuncionárioToolStripMenuItem.Size = new Size(190, 22);
            cadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar Funcionário";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmDashboard";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadatrarToolStripMenuItem;
        private ToolStripMenuItem cadastrarVeiculoToolStripMenuItem;
        private ToolStripMenuItem parâmetrosToolStripMenuItem;
        private ToolStripMenuItem custosFixosToolStripMenuItem;
        private ToolStripMenuItem custosVariáveisToolStripMenuItem;
        private ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
    }
}
