using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class ResultadoGrafico : Form
    {
        public ResultadoGrafico()
        {
            InitializeComponent();
        }
        //Texto da porcentagem
        private void ResultadoGrafico_Load(object sender, EventArgs e)
        {
            lblEmpH.Text = Jovem.PorcentHomemEmp().ToString() + " %";
            lblDesH.Text = Jovem.PorcentHomemDesem().ToString() + " %";
            lblEmpM.Text = Jovem.PorcentMulherEmp().ToString() + " %";
            lblDesM.Text = Jovem.PorcentMulherDesem().ToString() + " %";
            lblNumeroFinal.Text = Jovem.TotalDeEntrevistados().ToString();
            GraficoColunas();
            
        }
        #region Gráfico
        public void GraficoColunas()
        {
            // Legenda
            Legend legend = new Legend();
            chtGraficoResultado.Legends.Add(legend);
            chtGraficoResultado.Legends[0].Title = "Legenda";

            // Titulo X e Y
            chtGraficoResultado.ChartAreas["ChartArea1"].AxisX.Title = "Tipo de Entrevistados";
            chtGraficoResultado.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Ariel", 12, FontStyle.Bold);

            chtGraficoResultado.ChartAreas["ChartArea1"].AxisY.Title = "Nº de Entrevistados";
            chtGraficoResultado.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Ariel", 12, FontStyle.Bold);

            //Grade vertical
            chtGraficoResultado.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;

            //Dados do Grafico
            chtGraficoResultado.Titles.Add("Resultado Pesquisa");
            chtGraficoResultado.Series.Add("Grafico");
            chtGraficoResultado.Series["Grafico"].ChartType = SeriesChartType.Column;
            chtGraficoResultado.Series["Grafico"].BorderWidth =5;
            chtGraficoResultado.Series["Grafico"].Points.AddXY("Mulher Empr.", Jovem.ResultadoFemininoEmpregado());
            chtGraficoResultado.Series["Grafico"].Points.AddXY("Mulher Desemp.", Jovem.ResultadoFemininoDesempregado());
            chtGraficoResultado.Series["Grafico"].Points.AddXY("Homem Empr.", Jovem.ResultadoMasculinoEmpregado());
            chtGraficoResultado.Series["Grafico"].Points.AddXY("Homem Desemp.", Jovem.ResultadoMasculinoDesempregado());
        }
        #endregion

        private void btnFecharRelatorio_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
