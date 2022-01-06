using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EtiquetasClippStore
{
    public partial class ImpressãoPreVisualizar : Form
    {
        

        public ImpressãoPreVisualizar()
        {
            InitializeComponent();
        }

        private void ImpressãoPreVisualizar_Load(object sender, EventArgs e)
        {

            this.etiquetasImp.RefreshReport();
        }

        private void ImpressãoPreVisualizar_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet3.IMPRESSAO_ETIQUETAS'. Você pode movê-la ou removê-la conforme necessário.
            this.IMPRESSAO_ETIQUETASTableAdapter.Fill(this.dataSet3.IMPRESSAO_ETIQUETAS);
            // TODO: esta linha de código carrega dados na tabela 'Firebird_CLIPP.IMPRESSAO_ETIQUETAS'. Você pode movê-la ou removê-la conforme necessário.
            //this.IMPRESSAO_ETIQUETASTableAdapter.Fill(this.dataSet3.IMPRESSAO_ETIQUETAS);
            /*
            BindingSource bindingSource1 = new BindingSource();
            DataTable dados = new DataTable("Etiquetas");
            DataSet etq = new DataSet();
            dados = AcessoFB.fb_GetDadosEtiquetas();
            etq.Tables.Add(dados);
            bindingSource1.DataSource = dados;
            var dataTable = new DataTable();
            dataTable = dados;
            var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("Etiquetas", dataTable);
            this.etiquetasImp.LocalReport.DataSources.Clear();
            this.etiquetasImp.LocalReport.DataSources.Add(dataSource);
            this.etiquetasImp.RefreshReport();
            */
            this.etiquetasImp.RefreshReport();


        }

        private void ImpressãoPreVisualizar_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                AcessoFB.fb_DeletarTabelaImpressao();
                AcessoFB.fb_DeletarTabelaQuantidades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }
        

        private void EtiquetasImp_Load(object sender, EventArgs e)
        {

        }
    }
}
