using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmCadEntrevistado : Form
    {
        public frmCadEntrevistado()
        {
            InitializeComponent();
        }

        //Carregamento Automático
        private void frmCadEntrevistado_Load(object sender, EventArgs e)
        {
            ConfigurarToolTip();
            cboSituação.DataSource = Enum.GetNames(typeof(Jovem.SituaçãoTrab));
            cboSexo.DataSource = Enum.GetNames(typeof(Jovem.SexoP));
            dgvEntrevistados.DataSource = Jovem.Consultar();
            PreencherGrid(Jovem.Consultar());
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length == 0)
            {
                Jovem c = new Jovem(
                txtNome.Text,
                (Jovem.SituaçãoTrab)cboSituação.SelectedIndex,
                (Jovem.SexoP)cboSexo.SelectedIndex
                );
                c.Incluir();
                PreencherGrid(Jovem.Consultar());
                MessageBox.Show("Dados Cadastrados com Sucesso.", "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                Jovem c = new Jovem(
                    int.Parse(txtId.Text),
                   txtNome.Text,
                   (Jovem.SituaçãoTrab)cboSituação.SelectedIndex,
                   (Jovem.SexoP)cboSexo.SelectedIndex
                   );
                c.Alterar();
                MessageBox.Show("Dados alterados com sucesso.",
                    "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            PreencherGrid(Jovem.Consultar());
            LimparCampos();
        }
            
        private void LimparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            cboSituação.SelectedIndex = 0;
            cboSexo.SelectedIndex = 0;

        }

        //Clicuqe Botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //Clique Botão Preencher
        private void btnPreencher_Click(object sender, EventArgs e)
        {
            var PerguntPreencher = DialogResult;
            PerguntPreencher = MessageBox.Show("Deseja gerar uma lista aleatória?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (PerguntPreencher == DialogResult.Yes)
            {
                Jovem.Preencher();
                PreencherGrid(Jovem.Consultar());
            }
            else
                Refresh();
        }

        //Povoar Grid
        private void PreencherGrid(List<Jovem> ListaGrid)
        {
            dgvEntrevistados.DataSource = "";
            dgvEntrevistados.DataSource = new BindingList<Jovem>(ListaGrid);
        }

        //Filtrar Nome
        private void btnFiltrarNome_Click(object sender, EventArgs e)
        {
            PreencherGrid(Jovem.Consultar(txtNome.Text));
        }

        //Grid doubleclick
        private void dgvEntrevistados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = (int)dgvEntrevistados["Id", e.RowIndex].Value;
            Jovem c = new Jovem(id);
            txtId.Text = c.Id.ToString();
            txtNome.Text = c.Nome;
            cboSituação.SelectedIndex = (int)c.Situação;
            cboSexo.SelectedIndex = (int)c.Sexo;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length != 0)
            {
                Jovem.Exluir(int.Parse(txtId.Text));
                MessageBox.Show("Registro excluído com sucesso.",
                   "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                PreencherGrid(Jovem.Consultar());
                LimparCampos();
            }
            else
                MessageBox.Show("Selecione um registro para excluir.",
                 "Aviso", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation);
        }

        private void btnApagarList_Click(object sender, EventArgs e)
        {
            var PerguntApagarList = DialogResult;
            PerguntApagarList = MessageBox.Show("Tem certeza que deseja apagar a lista?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (PerguntApagarList == DialogResult.Yes)
            {
                dgvEntrevistados.Rows.Clear();
                Jovem.LimparGrid();
            }
            else
                dgvEntrevistados.Refresh();
            
        }


        //Caixa de Dicas
        private void ConfigurarToolTip()
        {
            toolTip1.AutoPopDelay = 4000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 200;

            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;

            toolTip1.SetToolTip(btnExcluir, "Dê duplo clique para selecionar o item para excluir");
            toolTip1.SetToolTip(btnSalvar, "Salvar cadastro");
            toolTip1.SetToolTip(btnPreencher, "Preencher Automaticamente a lista");
            toolTip1.SetToolTip(btnFiltrarNome, "Pesquisa de Nome (Lucas, L , l)");
            toolTip1.SetToolTip(btnLimpar, "Limpa os dados na caixa de texto");
            toolTip1.SetToolTip(lblId, "Id do usuário");
            toolTip1.SetToolTip(txtNome, "Digite o nome do entrevistado");
            toolTip1.SetToolTip(cboSexo, "Escolha o sexo");
            toolTip1.SetToolTip(cboSituação, "Escolha a situação trabalhista do entrevistado");
            toolTip1.SetToolTip(btnApagarList, "Apaga a lista de dados dos entrevistados");
        }

        private void btnGerarResultado_Click(object sender, EventArgs e)
        {
            ResultadoGrafico Rg = new ResultadoGrafico();
            Rg.TopLevel = true;
            Rg.Visible = true;
            Rg.Show();
        }
    }
}
