namespace WindowsFormsApplication1
{
    partial class frmCadEntrevistado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadEntrevistado));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSituação = new System.Windows.Forms.Label();
            this.cboSituação = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvEntrevistados = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPreencher = new System.Windows.Forms.Button();
            this.lblNomeGrid = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.btnFiltrarNome = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGerarResultado = new System.Windows.Forms.Button();
            this.btnApagarList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrevistados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNome.Location = new System.Drawing.Point(3, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(190, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblSituação
            // 
            this.lblSituação.AutoSize = true;
            this.lblSituação.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSituação.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSituação.Location = new System.Drawing.Point(5, 100);
            this.lblSituação.Name = "lblSituação";
            this.lblSituação.Size = new System.Drawing.Size(67, 17);
            this.lblSituação.TabIndex = 6;
            this.lblSituação.Text = "Situação:";
            // 
            // cboSituação
            // 
            this.cboSituação.FormattingEnabled = true;
            this.cboSituação.Location = new System.Drawing.Point(64, 100);
            this.cboSituação.Name = "cboSituação";
            this.cboSituação.Size = new System.Drawing.Size(190, 21);
            this.cboSituação.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSalvar.Location = new System.Drawing.Point(36, 127);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 40);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(64, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(85, 20);
            this.txtId.TabIndex = 12;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblId.Location = new System.Drawing.Point(3, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Id:";
            // 
            // dgvEntrevistados
            // 
            this.dgvEntrevistados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrevistados.Location = new System.Drawing.Point(383, 26);
            this.dgvEntrevistados.MultiSelect = false;
            this.dgvEntrevistados.Name = "dgvEntrevistados";
            this.dgvEntrevistados.ReadOnly = true;
            this.dgvEntrevistados.RowHeadersVisible = false;
            this.dgvEntrevistados.ShowRowErrors = false;
            this.dgvEntrevistados.Size = new System.Drawing.Size(459, 288);
            this.dgvEntrevistados.TabIndex = 13;
            this.dgvEntrevistados.EditModeChanged += new System.EventHandler(this.btnSalvar_Click);
            this.dgvEntrevistados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntrevistados_CellDoubleClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnLimpar.Location = new System.Drawing.Point(201, 127);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 40);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPreencher
            // 
            this.btnPreencher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPreencher.Location = new System.Drawing.Point(16, 218);
            this.btnPreencher.Name = "btnPreencher";
            this.btnPreencher.Size = new System.Drawing.Size(153, 36);
            this.btnPreencher.TabIndex = 15;
            this.btnPreencher.Text = "Preencher Lista";
            this.btnPreencher.UseVisualStyleBackColor = true;
            this.btnPreencher.Click += new System.EventHandler(this.btnPreencher_Click);
            // 
            // lblNomeGrid
            // 
            this.lblNomeGrid.AutoSize = true;
            this.lblNomeGrid.Location = new System.Drawing.Point(545, 9);
            this.lblNomeGrid.Name = "lblNomeGrid";
            this.lblNomeGrid.Size = new System.Drawing.Size(143, 13);
            this.lblNomeGrid.TabIndex = 17;
            this.lblNomeGrid.Text = "Lista dos dados Cadastrados";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnExcluir.Location = new System.Drawing.Point(383, 326);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(173, 29);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir Item";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSexo);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.btnFiltrarNome);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.cboSituação);
            this.groupBox1.Controls.Add(this.lblSituação);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Location = new System.Drawing.Point(7, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 173);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(64, 73);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(190, 21);
            this.cboSexo.TabIndex = 18;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSexo.Location = new System.Drawing.Point(5, 74);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(43, 17);
            this.lblSexo.TabIndex = 17;
            this.lblSexo.Text = "Sexo:";
            // 
            // btnFiltrarNome
            // 
            this.btnFiltrarNome.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrarNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFiltrarNome.FlatAppearance.BorderSize = 0;
            this.btnFiltrarNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnFiltrarNome.ForeColor = System.Drawing.Color.Transparent;
            this.btnFiltrarNome.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarNome.Image")));
            this.btnFiltrarNome.Location = new System.Drawing.Point(257, 41);
            this.btnFiltrarNome.Name = "btnFiltrarNome";
            this.btnFiltrarNome.Size = new System.Drawing.Size(26, 28);
            this.btnFiltrarNome.TabIndex = 16;
            this.btnFiltrarNome.UseVisualStyleBackColor = false;
            this.btnFiltrarNome.Click += new System.EventHandler(this.btnFiltrarNome_Click);
            // 
            // btnGerarResultado
            // 
            this.btnGerarResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnGerarResultado.Location = new System.Drawing.Point(187, 218);
            this.btnGerarResultado.Name = "btnGerarResultado";
            this.btnGerarResultado.Size = new System.Drawing.Size(153, 36);
            this.btnGerarResultado.TabIndex = 20;
            this.btnGerarResultado.Text = "Gerar Resultado";
            this.btnGerarResultado.UseVisualStyleBackColor = true;
            this.btnGerarResultado.Click += new System.EventHandler(this.btnGerarResultado_Click);
            // 
            // btnApagarList
            // 
            this.btnApagarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnApagarList.Location = new System.Drawing.Point(669, 326);
            this.btnApagarList.Name = "btnApagarList";
            this.btnApagarList.Size = new System.Drawing.Size(173, 29);
            this.btnApagarList.TabIndex = 21;
            this.btnApagarList.Text = "Apagar Cadastros";
            this.btnApagarList.UseVisualStyleBackColor = true;
            this.btnApagarList.Click += new System.EventHandler(this.btnApagarList_Click);
            // 
            // frmCadEntrevistado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 371);
            this.Controls.Add(this.btnApagarList);
            this.Controls.Add(this.btnGerarResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblNomeGrid);
            this.Controls.Add(this.btnPreencher);
            this.Controls.Add(this.dgvEntrevistados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCadEntrevistado";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadEntrevistado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrevistados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSituação;
        private System.Windows.Forms.ComboBox cboSituação;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvEntrevistados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPreencher;
        private System.Windows.Forms.Button btnFiltrarNome;
        private System.Windows.Forms.Label lblNomeGrid;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnGerarResultado;
        private System.Windows.Forms.Button btnApagarList;
    }
}

