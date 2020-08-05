namespace W2___Strdef_Editor
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.Buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.replace = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.Substituir = new System.Windows.Forms.Button();
            this.Pesquisar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StrList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirStrDefbinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarStrDefbinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarStrDefcsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.strDefText = new System.Windows.Forms.TextBox();
            this.Alterar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Enabled = false;
            this.Buscar.Location = new System.Drawing.Point(6, 19);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.replace);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.Substituir);
            this.groupBox1.Controls.Add(this.Pesquisar);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "por";
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(616, 37);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(153, 20);
            this.replace.TabIndex = 4;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(616, 11);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(153, 20);
            this.search.TabIndex = 3;
            // 
            // Substituir
            // 
            this.Substituir.Location = new System.Drawing.Point(535, 11);
            this.Substituir.Name = "Substituir";
            this.Substituir.Size = new System.Drawing.Size(75, 23);
            this.Substituir.TabIndex = 2;
            this.Substituir.Text = "Substituir";
            this.Substituir.UseVisualStyleBackColor = true;
            this.Substituir.Click += new System.EventHandler(this.Substituir_Click);
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(88, 20);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(441, 20);
            this.Pesquisar.TabIndex = 1;
            this.Pesquisar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Alterar);
            this.groupBox2.Controls.Add(this.strDefText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.StrList);
            this.groupBox2.Location = new System.Drawing.Point(13, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 439);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Linguagens do servidor / Cliente";
            // 
            // StrList
            // 
            this.StrList.FormattingEnabled = true;
            this.StrList.Location = new System.Drawing.Point(7, 59);
            this.StrList.Name = "StrList";
            this.StrList.Size = new System.Drawing.Size(762, 368);
            this.StrList.TabIndex = 0;
            this.StrList.SelectedIndexChanged += new System.EventHandler(this.StrList_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(68, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirStrDefbinToolStripMenuItem,
            this.salvarStrDefbinToolStripMenuItem,
            this.salvarStrDefcsvToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirStrDefbinToolStripMenuItem
            // 
            this.abrirStrDefbinToolStripMenuItem.Name = "abrirStrDefbinToolStripMenuItem";
            this.abrirStrDefbinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirStrDefbinToolStripMenuItem.Text = "Abrir StrDef.bin";
            this.abrirStrDefbinToolStripMenuItem.Click += new System.EventHandler(this.abrirStrDefbinToolStripMenuItem_Click);
            // 
            // salvarStrDefbinToolStripMenuItem
            // 
            this.salvarStrDefbinToolStripMenuItem.Enabled = false;
            this.salvarStrDefbinToolStripMenuItem.Name = "salvarStrDefbinToolStripMenuItem";
            this.salvarStrDefbinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarStrDefbinToolStripMenuItem.Text = "Salvar StrDef.bin";
            this.salvarStrDefbinToolStripMenuItem.Click += new System.EventHandler(this.salvarStrDefbinToolStripMenuItem_Click);
            // 
            // salvarStrDefcsvToolStripMenuItem
            // 
            this.salvarStrDefcsvToolStripMenuItem.Enabled = false;
            this.salvarStrDefcsvToolStripMenuItem.Name = "salvarStrDefcsvToolStripMenuItem";
            this.salvarStrDefcsvToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarStrDefcsvToolStripMenuItem.Text = "Salvar StrDef.csv";
            this.salvarStrDefcsvToolStripMenuItem.Click += new System.EventHandler(this.salvarStrDefcsvToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(373, 552);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Texto atual:";
            // 
            // strDefText
            // 
            this.strDefText.Location = new System.Drawing.Point(87, 29);
            this.strDefText.Name = "strDefText";
            this.strDefText.Size = new System.Drawing.Size(531, 20);
            this.strDefText.TabIndex = 6;
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(624, 27);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(144, 23);
            this.Alterar.TabIndex = 6;
            this.Alterar.Text = "Salvar edição";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Window";
            this.Text = "StrEditor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox replace;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button Substituir;
        private System.Windows.Forms.TextBox Pesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListBox StrList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirStrDefbinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarStrDefbinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarStrDefcsvToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox strDefText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Alterar;
    }
}