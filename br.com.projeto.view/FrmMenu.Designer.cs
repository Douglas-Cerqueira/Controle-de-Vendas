namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroDeCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaDeClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroDeFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaDeFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroDeFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaDeFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroDeProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultaDeProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroDeVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaDeVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrocaDeUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSairDoSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuFuncionario,
            this.menuFornecedores,
            this.menuProdutos,
            this.menuVendas,
            this.menuConfig});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroDeCliente,
            this.menuConsultaDeClientes});
            this.menuCliente.Image = global::Projeto_Controle_Vendas.Properties.Resources.customers;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(107, 29);
            this.menuCliente.Text = "Clientes";
            // 
            // menuCadastroDeCliente
            // 
            this.menuCadastroDeCliente.Name = "menuCadastroDeCliente";
            this.menuCadastroDeCliente.Size = new System.Drawing.Size(257, 30);
            this.menuCadastroDeCliente.Text = "Cadastro de Clientes";
            this.menuCadastroDeCliente.Click += new System.EventHandler(this.menuCadastroDeCliente_Click);
            // 
            // menuConsultaDeClientes
            // 
            this.menuConsultaDeClientes.Name = "menuConsultaDeClientes";
            this.menuConsultaDeClientes.Size = new System.Drawing.Size(257, 30);
            this.menuConsultaDeClientes.Text = "Consulta de Clientes";
            this.menuConsultaDeClientes.Click += new System.EventHandler(this.menuConsultaDeClientes_Click);
            // 
            // menuFuncionario
            // 
            this.menuFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroDeFuncionario,
            this.menuConsultaDeFuncionario});
            this.menuFuncionario.Image = global::Projeto_Controle_Vendas.Properties.Resources.employees;
            this.menuFuncionario.Name = "menuFuncionario";
            this.menuFuncionario.Size = new System.Drawing.Size(148, 29);
            this.menuFuncionario.Text = "Funcionários";
            // 
            // menuCadastroDeFuncionario
            // 
            this.menuCadastroDeFuncionario.Name = "menuCadastroDeFuncionario";
            this.menuCadastroDeFuncionario.Size = new System.Drawing.Size(298, 30);
            this.menuCadastroDeFuncionario.Text = "Cadastro de Funcionários";
            this.menuCadastroDeFuncionario.Click += new System.EventHandler(this.menuCadastroDeFuncionario_Click);
            // 
            // menuConsultaDeFuncionario
            // 
            this.menuConsultaDeFuncionario.Name = "menuConsultaDeFuncionario";
            this.menuConsultaDeFuncionario.Size = new System.Drawing.Size(298, 30);
            this.menuConsultaDeFuncionario.Text = "Consulta de Funcionários";
            this.menuConsultaDeFuncionario.Click += new System.EventHandler(this.menuConsultaDeFuncionario_Click);
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroDeFornecedores,
            this.menuConsultaDeFornecedores});
            this.menuFornecedores.Image = global::Projeto_Controle_Vendas.Properties.Resources.supplier;
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(154, 29);
            this.menuFornecedores.Text = "Fornecedores";
            // 
            // menuCadastroDeFornecedores
            // 
            this.menuCadastroDeFornecedores.Name = "menuCadastroDeFornecedores";
            this.menuCadastroDeFornecedores.Size = new System.Drawing.Size(304, 30);
            this.menuCadastroDeFornecedores.Text = "Cadastro de Fornecedores";
            this.menuCadastroDeFornecedores.Click += new System.EventHandler(this.menuCadastroDeFornecedores_Click);
            // 
            // menuConsultaDeFornecedores
            // 
            this.menuConsultaDeFornecedores.Name = "menuConsultaDeFornecedores";
            this.menuConsultaDeFornecedores.Size = new System.Drawing.Size(304, 30);
            this.menuConsultaDeFornecedores.Text = "Consulta de Fornecedores";
            this.menuConsultaDeFornecedores.Click += new System.EventHandler(this.menuConsultaDeFornecedores_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroDeProdutos,
            this.MenuConsultaDeProdutos});
            this.menuProdutos.Image = global::Projeto_Controle_Vendas.Properties.Resources.box;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(116, 29);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuCadastroDeProdutos
            // 
            this.menuCadastroDeProdutos.Name = "menuCadastroDeProdutos";
            this.menuCadastroDeProdutos.Size = new System.Drawing.Size(266, 30);
            this.menuCadastroDeProdutos.Text = "Cadastro de Produtos";
            this.menuCadastroDeProdutos.Click += new System.EventHandler(this.menuCadastroDeProdutos_Click);
            // 
            // MenuConsultaDeProdutos
            // 
            this.MenuConsultaDeProdutos.Name = "MenuConsultaDeProdutos";
            this.MenuConsultaDeProdutos.Size = new System.Drawing.Size(266, 30);
            this.MenuConsultaDeProdutos.Text = "Consulta de Produtos";
            this.MenuConsultaDeProdutos.Click += new System.EventHandler(this.MenuConsultaDeProdutos_Click);
            // 
            // menuVendas
            // 
            this.menuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroDeVendas,
            this.menuConsultaDeVendas});
            this.menuVendas.Image = global::Projeto_Controle_Vendas.Properties.Resources.sales;
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(101, 29);
            this.menuVendas.Text = "Vendas";
            // 
            // menuCadastroDeVendas
            // 
            this.menuCadastroDeVendas.Name = "menuCadastroDeVendas";
            this.menuCadastroDeVendas.Size = new System.Drawing.Size(251, 30);
            this.menuCadastroDeVendas.Text = "Nova Venda";
            this.menuCadastroDeVendas.Click += new System.EventHandler(this.menuCadastroDeVendas_Click);
            // 
            // menuConsultaDeVendas
            // 
            this.menuConsultaDeVendas.Name = "menuConsultaDeVendas";
            this.menuConsultaDeVendas.Size = new System.Drawing.Size(251, 30);
            this.menuConsultaDeVendas.Text = "Histórico de Vendas";
            this.menuConsultaDeVendas.Click += new System.EventHandler(this.menuConsultaDeVendas_Click);
            // 
            // menuConfig
            // 
            this.menuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrocaDeUsuario,
            this.menuSairDoSistema});
            this.menuConfig.Image = global::Projeto_Controle_Vendas.Properties.Resources.settings;
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(162, 29);
            this.menuConfig.Text = "Configurações";
            // 
            // menuTrocaDeUsuario
            // 
            this.menuTrocaDeUsuario.Name = "menuTrocaDeUsuario";
            this.menuTrocaDeUsuario.Size = new System.Drawing.Size(232, 30);
            this.menuTrocaDeUsuario.Text = "Trocar de Usuário";
            this.menuTrocaDeUsuario.Click += new System.EventHandler(this.menuTrocaDeUsuario_Click);
            // 
            // menuSairDoSistema
            // 
            this.menuSairDoSistema.Name = "menuSairDoSistema";
            this.menuSairDoSistema.Size = new System.Drawing.Size(232, 30);
            this.menuSairDoSistema.Text = "Sair do Sistema";
            this.menuSairDoSistema.Click += new System.EventHandler(this.menuSairDoSistema_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtData,
            this.toolStripStatusLabel3,
            this.txtHora,
            this.toolStripStatusLabel5,
            this.txtUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Data Atual:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(73, 17);
            this.txtData.Text = "27/08/2025";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel3.Text = "Hora Atual:";
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(38, 17);
            this.txtHora.Text = "06:52";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel5.Text = "Usuário Logado:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(108, 17);
            this.txtUsuario.Text = "Douglas Cerqueira";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Controle_Vendas.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu Principal - Controle de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaDeClientes;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaDeFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaDeFornecedores;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultaDeProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaDeVendas;
        private System.Windows.Forms.ToolStripMenuItem menuTrocaDeUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuSairDoSistema;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripMenuItem menuCliente;
        public System.Windows.Forms.ToolStripMenuItem menuFuncionario;
        public System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        public System.Windows.Forms.ToolStripMenuItem menuProdutos;
        public System.Windows.Forms.ToolStripMenuItem menuVendas;
        public System.Windows.Forms.ToolStripMenuItem menuConfig;
        public System.Windows.Forms.ToolStripMenuItem menuCadastroDeCliente;
        public System.Windows.Forms.ToolStripMenuItem menuCadastroDeFuncionario;
        public System.Windows.Forms.ToolStripMenuItem menuCadastroDeFornecedores;
        public System.Windows.Forms.ToolStripMenuItem menuCadastroDeProdutos;
        public System.Windows.Forms.ToolStripMenuItem menuCadastroDeVendas;
        public System.Windows.Forms.ToolStripStatusLabel txtData;
        public System.Windows.Forms.ToolStripStatusLabel txtHora;
        public System.Windows.Forms.ToolStripStatusLabel txtUsuario;
        private System.Windows.Forms.Timer timer1;
    }
}