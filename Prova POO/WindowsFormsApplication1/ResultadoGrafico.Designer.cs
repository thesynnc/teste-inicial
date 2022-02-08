namespace WindowsFormsApplication1
{
    partial class ResultadoGrafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lblJovemMasEmpr = new System.Windows.Forms.Label();
            this.lblJovemMasDesmp = new System.Windows.Forms.Label();
            this.lblJovemFemEmpr = new System.Windows.Forms.Label();
            this.lblJovemFemDesmp = new System.Windows.Forms.Label();
            this.lblEmpH = new System.Windows.Forms.Label();
            this.lblDesH = new System.Windows.Forms.Label();
            this.lblEmpM = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDesM = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chtGraficoResultado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnFecharRelatorio = new System.Windows.Forms.Button();
            this.lblNumeroEntrev = new System.Windows.Forms.Label();
            this.lblNumeroFinal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficoResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJovemMasEmpr
            // 
            this.lblJovemMasEmpr.AutoSize = true;
            this.lblJovemMasEmpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblJovemMasEmpr.Location = new System.Drawing.Point(7, 42);
            this.lblJovemMasEmpr.Name = "lblJovemMasEmpr";
            this.lblJovemMasEmpr.Size = new System.Drawing.Size(243, 20);
            this.lblJovemMasEmpr.TabIndex = 0;
            this.lblJovemMasEmpr.Text = "Taxa de Empregados(Homem):";
            // 
            // lblJovemMasDesmp
            // 
            this.lblJovemMasDesmp.AutoSize = true;
            this.lblJovemMasDesmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblJovemMasDesmp.Location = new System.Drawing.Point(7, 94);
            this.lblJovemMasDesmp.Name = "lblJovemMasDesmp";
            this.lblJovemMasDesmp.Size = new System.Drawing.Size(272, 20);
            this.lblJovemMasDesmp.TabIndex = 1;
            this.lblJovemMasDesmp.Text = "Taxa de Desempregados(Homem):";
            // 
            // lblJovemFemEmpr
            // 
            this.lblJovemFemEmpr.AutoSize = true;
            this.lblJovemFemEmpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblJovemFemEmpr.Location = new System.Drawing.Point(7, 146);
            this.lblJovemFemEmpr.Name = "lblJovemFemEmpr";
            this.lblJovemFemEmpr.Size = new System.Drawing.Size(235, 20);
            this.lblJovemFemEmpr.TabIndex = 2;
            this.lblJovemFemEmpr.Text = "Taxa de Empregados(Mulher):";
            // 
            // lblJovemFemDesmp
            // 
            this.lblJovemFemDesmp.AutoSize = true;
            this.lblJovemFemDesmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblJovemFemDesmp.Location = new System.Drawing.Point(7, 198);
            this.lblJovemFemDesmp.Name = "lblJovemFemDesmp";
            this.lblJovemFemDesmp.Size = new System.Drawing.Size(264, 20);
            this.lblJovemFemDesmp.TabIndex = 3;
            this.lblJovemFemDesmp.Text = "Taxa de Desempregados(Mulher):";
            // 
            // lblEmpH
            // 
            this.lblEmpH.AutoSize = true;
            this.lblEmpH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblEmpH.Location = new System.Drawing.Point(335, 44);
            this.lblEmpH.Name = "lblEmpH";
            this.lblEmpH.Size = new System.Drawing.Size(46, 18);
            this.lblEmpH.TabIndex = 5;
            this.lblEmpH.Text = "label1";
            // 
            // lblDesH
            // 
            this.lblDesH.AutoSize = true;
            this.lblDesH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblDesH.Location = new System.Drawing.Point(335, 96);
            this.lblDesH.Name = "lblDesH";
            this.lblDesH.Size = new System.Drawing.Size(46, 18);
            this.lblDesH.TabIndex = 6;
            this.lblDesH.Text = "label2";
            // 
            // lblEmpM
            // 
            this.lblEmpM.AutoSize = true;
            this.lblEmpM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblEmpM.Location = new System.Drawing.Point(335, 148);
            this.lblEmpM.Name = "lblEmpM";
            this.lblEmpM.Size = new System.Drawing.Size(46, 18);
            this.lblEmpM.TabIndex = 7;
            this.lblEmpM.Text = "label3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDesM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblEmpM);
            this.groupBox1.Controls.Add(this.lblDesH);
            this.groupBox1.Controls.Add(this.lblEmpH);
            this.groupBox1.Controls.Add(this.lblJovemFemDesmp);
            this.groupBox1.Controls.Add(this.lblJovemFemEmpr);
            this.groupBox1.Controls.Add(this.lblJovemMasDesmp);
            this.groupBox1.Controls.Add(this.lblJovemMasEmpr);
            this.groupBox1.Location = new System.Drawing.Point(5, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 260);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblDesM
            // 
            this.lblDesM.AutoSize = true;
            this.lblDesM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblDesM.Location = new System.Drawing.Point(335, 200);
            this.lblDesM.Name = "lblDesM";
            this.lblDesM.Size = new System.Drawing.Size(46, 18);
            this.lblDesM.TabIndex = 8;
            this.lblDesM.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chtGraficoResultado);
            this.groupBox2.Location = new System.Drawing.Point(507, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 386);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // chtGraficoResultado
            // 
            this.chtGraficoResultado.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            chartArea4.Area3DStyle.Inclination = 60;
            chartArea4.Name = "ChartArea1";
            this.chtGraficoResultado.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtGraficoResultado.Legends.Add(legend4);
            this.chtGraficoResultado.Location = new System.Drawing.Point(14, 14);
            this.chtGraficoResultado.Name = "chtGraficoResultado";
            this.chtGraficoResultado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chtGraficoResultado.Size = new System.Drawing.Size(427, 362);
            this.chtGraficoResultado.TabIndex = 0;
            this.chtGraficoResultado.Text = "chart1";
            // 
            // btnFecharRelatorio
            // 
            this.btnFecharRelatorio.Location = new System.Drawing.Point(372, 442);
            this.btnFecharRelatorio.Name = "btnFecharRelatorio";
            this.btnFecharRelatorio.Size = new System.Drawing.Size(233, 58);
            this.btnFecharRelatorio.TabIndex = 11;
            this.btnFecharRelatorio.Text = "Fechar Relatorio";
            this.btnFecharRelatorio.UseVisualStyleBackColor = true;
            this.btnFecharRelatorio.Click += new System.EventHandler(this.btnFecharRelatorio_Click);
            // 
            // lblNumeroEntrev
            // 
            this.lblNumeroEntrev.AutoSize = true;
            this.lblNumeroEntrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNumeroEntrev.Location = new System.Drawing.Point(13, 50);
            this.lblNumeroEntrev.Name = "lblNumeroEntrev";
            this.lblNumeroEntrev.Size = new System.Drawing.Size(184, 18);
            this.lblNumeroEntrev.TabIndex = 12;
            this.lblNumeroEntrev.Text = "Numero de Entrevistados: ";
            // 
            // lblNumeroFinal
            // 
            this.lblNumeroFinal.AutoSize = true;
            this.lblNumeroFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFinal.Location = new System.Drawing.Point(224, 50);
            this.lblNumeroFinal.Name = "lblNumeroFinal";
            this.lblNumeroFinal.Size = new System.Drawing.Size(52, 18);
            this.lblNumeroFinal.TabIndex = 13;
            this.lblNumeroFinal.Text = "label1";
            // 
            // ResultadoGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 515);
            this.Controls.Add(this.lblNumeroFinal);
            this.Controls.Add(this.lblNumeroEntrev);
            this.Controls.Add(this.btnFecharRelatorio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "ResultadoGrafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultadoGrafico";
            this.Load += new System.EventHandler(this.ResultadoGrafico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficoResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJovemMasEmpr;
        private System.Windows.Forms.Label lblJovemMasDesmp;
        private System.Windows.Forms.Label lblJovemFemEmpr;
        private System.Windows.Forms.Label lblJovemFemDesmp;
        private System.Windows.Forms.Label lblEmpH;
        private System.Windows.Forms.Label lblDesH;
        private System.Windows.Forms.Label lblEmpM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFecharRelatorio;
        private System.Windows.Forms.Label lblDesM;
        private System.Windows.Forms.Label lblNumeroEntrev;
        private System.Windows.Forms.Label lblNumeroFinal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraficoResultado;
    }
}