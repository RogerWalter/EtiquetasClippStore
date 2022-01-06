using FirebirdSql.Data.FirebirdClient;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using System.Globalization;

namespace EtiquetasClippStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Carregando carrega = new Carregando();
        int pontoDeParada = 0;
        private void preencheGridProdutos()
        {
            try
            {
                dgProdutos.DataSource = AcessoFB.fb_GetDadosProdutos().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void preencheGridProdutosPorNome() //Função que busca e ordena os dados por nome
        {
            try
            {
                dgProdutos.DataSource = AcessoFB.fb_GetDadosProdutosOrdenadoNome().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void preencheGridNFE()
        {
            try
            {
                dgProdutos.DataSource = AcessoFB.fb_GetDadosNFE().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void preencheGridNFEPorNome() //Função que preenche o grid de NFE ordenado por nome do fornecedor
        {
            try
            {
                dgProdutos.DataSource = AcessoFB.fb_GetDadosNFEOrdenadoNome().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void limpaCamposItem()
        {
            nfeNumero.Text = "";
            labelNFEnumero.Text = "Número";
            labelNFEvalor.Text = "0,00";
            labelNFEforn.Text = "Fornecedor";
            produtoInfo.Text = "";
            labelDescEtq.Text = "Descrição";
            labelValorEtq.Text = "0,00";
            labelCodigoEtq.Text = "Código";
            quantidadeInfo.Text = "";
        }

        private void posicionaGridPesquisaProduto(Produto produto)
        {
            var idAPesquisar = produto.Codigo;
            var indice = -1;
            foreach (DataGridViewRow linha in dgProdutos.Rows)
            {
                if (Convert.ToInt32(linha.Cells["CODIGO"].Value) == idAPesquisar)
                {
                    indice = linha.Index;
                    break;
                }
            }
            if (indice != -1)
            {
                dgProdutos.CurrentCell = dgProdutos.Rows[indice].Cells[0];
            }
        }

        private void posicionaGridPesquisaNFE(NFE nfe)
        {
            var idAPesquisar = nfe.Numero;
            var indice = -1;
            foreach (DataGridViewRow linha in dgProdutos.Rows)
            {
                if (Convert.ToInt32(linha.Cells["NUMERO"].Value) == idAPesquisar)
                {
                    indice = linha.Index;
                    break;
                }
            }
            if (indice != -1)
            {
                dgProdutos.CurrentCell = dgProdutos.Rows[indice].Cells[0];
            }
        }

        private void preencheDadosProduto(Produto prod)
        {
            if (prod.Descricao == null)
            {
                MessageBox.Show("O produto informado não existe!", "Pesquisa do Produto");
                return;
            }


            produtoInfo.Text = prod.Codigo.ToString();
            labelDescEtq.Text = prod.Descricao.ToString();

            string valor = prod.Valor.ToString("C", CultureInfo.CurrentCulture); //Faz a conversão para R$

            labelValorEtq.Text = valor;
            labelCodigoEtq.Text = prod.Codigo.ToString();


        }

        private void preencheDadosNFE(NFE nfe)
        {
            if (nfe.Fornecedor == null)
            {
                MessageBox.Show("A Nota Fiscal de Compra informada não existe!", "Pesquisa  da NFE");
                return;
            }


            nfeNumero.Text = nfe.Numero.ToString();
            labelNFEnumero.Text = nfe.Numero.ToString();

            string valor = nfe.Valor.ToString("C", CultureInfo.CurrentCulture); //Faz a conversão para R$

            labelNFEvalor.Text = valor;
            labelNFEforn.Text = nfe.Fornecedor.ToString();


        }

        public void CarregaFormPrincipal()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => this.Hide()));
            }
            else
            {
                this.Hide();
            }

            AcessoFB.fb_VerificarTabelaImp();
            AcessoFB.fb_VerificarTabelaQuantidades();
            AcessoFB.fb_DeletarTabelaQuantidades();
            AcessoFB.fb_DeletarTabelaImpressao();

            if (CBLinha.InvokeRequired)
            {
                CBLinha.Invoke(new Action(() => CBLinha.SelectedItem = "1"));
            }
            else
            {
                CBLinha.SelectedItem = "1";
            }

            if (CBColuna.InvokeRequired)
            {
                CBColuna.Invoke(new Action(() => CBColuna.SelectedItem = "1"));
            }
            else
            {
                CBColuna.SelectedItem = "1";
            }
            //CBLinha.SelectedItem = "1";
            //CBColuna.SelectedItem = "1";

            // TODO: esta linha de código carrega dados na tabela 'dataSet2.ETIQUETAS_QUANTIDADES'. Você pode movê-la ou removê-la conforme necessário.
            //this.eTIQUETAS_QUANTIDADESTableAdapter.Fill(this.dataSet2.ETIQUETAS_QUANTIDADES);
            // TODO: esta linha de código carrega dados na tabela 'firebird_CLIPP.IMPRESSAO_ETIQUETAS'. Você pode movê-la ou removê-la conforme necessário.
            //this.iMPRESSAO_ETIQUETASTableAdapter.Fill(this.firebird_CLIPP.IMPRESSAO_ETIQUETAS);
            //preencheGrid();
            pontoDeParada = 1;
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => this.Show()));
            }
            else
            {
                this.Show();
            }

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => this.WindowState = FormWindowState.Normal));
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            carrega.Show();
            carrega.BringToFront();
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            if (backgroundWorker2.IsBusy != true)
            {
                backgroundWorker2.RunWorkerAsync();
            }

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CarregaFormPrincipal();
        }

        public void fechaCarregamento()
        {
            if (carrega.InvokeRequired)
            {
                carrega.Invoke(new Action(() => carrega.Close()));
            }
            else
            {
                carrega.Close();
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int num = 0;
            do
            {
                num = pontoDeParada;

            } while (num != 1);
            fechaCarregamento();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void produtoInfo_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void BotaoGerar_Click(object sender, EventArgs e)
        {

            Produto produto = new Produto();
            produto.Codigo = Convert.ToInt32(labelCodigoEtq.Text);
            produto.Descricao = labelDescEtq.Text;
            produto.Valor = Convert.ToDouble(labelValorEtq.Text);
            ImpressãoPreVisualizar impressao = new ImpressãoPreVisualizar();
            impressao.Show();

        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {

        }

        private void QuantidadeInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = new int();
            if (GBProduto.Enabled == true && GBNfe.Enabled == false)
            {
                try
                {
                    codigo = Convert.ToInt32(dgProdutos.Rows[e.RowIndex].Cells[0].Value);
                }
                catch 
                {
                    //MessageBox.Show("Não é ordenar a coluna por nome. Altere o tipo de pesquisa!", "Erro");
                }

                Produto produto = new Produto();
                try
                {
                    produto = AcessoFB.fb_ProcuraDadosProdutos(codigo);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }

                preencheDadosProduto(produto);
            }
            if (GBNfe.Enabled == true && GBProduto.Enabled == false)
            {
                int numero = Convert.ToInt32(dgProdutos.Rows[e.RowIndex].Cells[0].Value);
                NFE nfe = new NFE();
                try
                {
                    nfe = AcessoFB.fb_ProcuraDadosNFE(numero);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }

                preencheDadosNFE(nfe);
            }
        }



        private void BotaoPesquisar_Click(object sender, EventArgs e)
        {

            if (RBCodigo.Checked == true && RBNome.Checked == false)
            {
                if (produtoInfo.Text == null || produtoInfo.Text == "")
                {
                    MessageBox.Show("Código do produto não foi informado!", "Código Produto");
                    return;
                }
                int codigo = Convert.ToInt32(produtoInfo.Text);
                Produto produto = new Produto();
                try
                {
                    produto = AcessoFB.fb_ProcuraDadosProdutos(codigo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }
                preencheDadosProduto(produto);
                posicionaGridPesquisaProduto(produto);
            }
            if (RBNome.Checked == true && RBCodigo.Checked == false)
            {
                if (produtoInfoNome.Text == null || produtoInfoNome.Text == "")
                {
                    MessageBox.Show("Nome do produto não foi informado!", "Nome Produto");
                    return;
                }
                String pesquisa = Convert.ToString(produtoInfoNome.Text);
                Produto produto = new Produto();
                try
                {
                    produto = AcessoFB.fb_ProcuraDadosProdutosNome(pesquisa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }
                preencheDadosProduto(produto);
                posicionaGridPesquisaProduto(produto);
            }

        }
        private void VerificarIniciarEm()
        {
            int etqVazia = new int();
            if (Convert.ToInt32(CBLinha.SelectedItem) == 1 && Convert.ToInt32(CBColuna.SelectedItem) == 1)
                etqVazia = 0;
            if (Convert.ToInt32(CBLinha.SelectedItem) == 1 && Convert.ToInt32(CBColuna.SelectedItem) == 2)
                etqVazia = 1;
            if (Convert.ToInt32(CBLinha.SelectedItem)  == 1 && Convert.ToInt32(CBColuna.SelectedItem) == 3)
                etqVazia = 2;
            if (Convert.ToInt32(CBLinha.SelectedItem) == 2 && Convert.ToInt32(CBColuna.SelectedItem) == 1)
                etqVazia = 3;
            if (Convert.ToInt32(CBLinha.SelectedItem) == 2 && Convert.ToInt32(CBColuna.SelectedItem) == 2)
                etqVazia = 4;
            if (Convert.ToInt32(CBLinha.SelectedItem) == 2 && Convert.ToInt32(CBColuna.SelectedItem) == 3)
                etqVazia = 5;
            if (Convert.ToInt32(CBLinha.SelectedItem) == 3 && Convert.ToInt32(CBColuna.SelectedItem) == 1)
                etqVazia = 6;
            if (Convert.ToInt32(CBLinha.SelectedItem) == 3 && Convert.ToInt32(CBColuna.SelectedItem) == 2)
                etqVazia = 7;
            if (Convert.ToInt32(CBLinha.SelectedItem) == 3 && Convert.ToInt32(CBColuna.SelectedItem) == 3)
                etqVazia = 8;
            if (Convert.ToInt32(CBLinha.SelectedItem) == 4 && Convert.ToInt32(CBColuna.SelectedItem) == 1)
                etqVazia = 9;
            if (Convert.ToInt32(CBLinha.SelectedItem) == 4 && Convert.ToInt32(CBColuna.SelectedItem) == 2)
                etqVazia = 10;
            if (Convert.ToInt32(CBLinha.SelectedItem) == 4 && Convert.ToInt32(CBColuna.SelectedItem) == 3)
                etqVazia = 11;
            if (Convert.ToInt32(CBLinha.SelectedItem) == 5 && Convert.ToInt32(CBColuna.SelectedItem) == 1)
                etqVazia = 12;
            if (Convert.ToInt32(CBLinha.SelectedItem) == 5 && Convert.ToInt32(CBColuna.SelectedItem) == 2)
                etqVazia = 13;
            if (Convert.ToInt32(CBLinha.SelectedItem) == 5 && Convert.ToInt32(CBColuna.SelectedItem) == 3)
                etqVazia = 14;

            AcessoFB.AdicionarEtiquetasVazias(etqVazia);

        }
        int terminou1 = 0;
        public void finalizaImpressao()
        {
            AcessoFB.fb_DeletarTabelaQuantidades();
            AtualizaGrid();
            limpaCamposItem();
            CBLinha.SelectedItem = "1";
            CBColuna.SelectedItem = "1";
            radioProduto.Checked = false;
            radioNFE.Checked = false;
            GBTipoPesqNfe.Visible = false;
            GBTipoPesqProd.Visible = false;
            label3.Visible = false;
            nfeNumero.Visible = false;
            label7.Visible = false;
            nfeFornecedor.Visible = false;
            RBCodigo.Checked = false;
            RBNome.Checked = false;
            RBNumNFE.Checked = false;
            RBNomeForn.Checked = false;
            CBIniciarEm.Enabled = false;
            CBIniciarEm.Checked = false;
            GBProduto.Enabled = false;
            label2.Visible = false;
            produtoInfo.Visible = false;
            label4.Visible = false;
            produtoInfoNome.Visible = false;
            RBCodigo.Checked = false;
            RBNome.Checked = false;
            RBNumNFE.Checked = false;
            RBNomeForn.Checked = false;
            CBIniciarEm.Enabled = false;
            CBIniciarEm.Checked = false;
        }

        public void insereDadosImpressao()
        {
            AcessoFB.fb_PreencheTabelaImpressao();
            terminou1 = 1;
        }

        Carregando carregando = new Carregando();
        public void BotaoGerar_Click_1(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto = AcessoFB.fb_ProcuraDadosQuantidades();
            if (produto.Descricao == null || produto.Descricao == "")
            {
                MessageBox.Show("Não foram adicionados produtos à lista de impressão!", "Erro ao Gerar");
                return;
            }

            carregando.Show();
            carregando.BringToFront();

            if (backgroundWorker3.IsBusy != true)
            {
                backgroundWorker3.RunWorkerAsync();
            }
            if (backgroundWorker4.IsBusy != true)
            {
                backgroundWorker4.RunWorkerAsync();
            }
        }
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CBIniciarEm.Checked == true)
            {
                VerificarIniciarEm();
            }
            insereDadosImpressao();
            
            ImpressãoPreVisualizar impressao = new ImpressãoPreVisualizar();
            impressao.ShowDialog();

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => this.finalizaImpressao()));
            }
            else
            {
                this.finalizaImpressao();
            }
            terminou1 = 1;
        }

        public void fechaCarregamentoImp()
        {
            if (carregando.InvokeRequired)
            {
                carregando.Invoke(new Action(() => carregando.Close()));
            }
            else
            {
                carregando.Close();
            }
        }
        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            int num = 0;
            do
            {
                num = terminou1;

            } while (num != 1);
            fechaCarregamentoImp();
        }

        private void BotaoSair_Click_1(object sender, EventArgs e)
        {
            //AcessoFB.fb_DeletarTabelaQuantidades();
            Application.Exit();
        }

        private void ProdutoNomeEtiq_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LabelDescEtq_Click(object sender, EventArgs e)
        {

        }

        private void LabelValorEtq_Click(object sender, EventArgs e)
        {

        }

        private void ProdutoInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void ProdutoInfo_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (produtoInfo.Text == null || produtoInfo.Text == "")
                {
                    MessageBox.Show("Código do produto não foi informado!", "Código Produto");
                    return;
                }
                int codigo = Convert.ToInt32(produtoInfo.Text);
                Produto produto = new Produto();
                try
                {
                    produto = AcessoFB.fb_ProcuraDadosProdutos(codigo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }
                preencheDadosProduto(produto);
                posicionaGridPesquisaProduto(produto);
            }
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void QuantidadeInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GBProduto.Enabled = true;
            GBNfe.Enabled = false;
            GBTipoPesqProd.Enabled = true;
            GBTipoPesqProd.Visible = true;
            GBTipoPesqNfe.Enabled = false;
            GBTipoPesqNfe.Visible = false;
            label3.Visible = false;
            nfeNumero.Visible = false;
            label7.Visible = false;
            nfeFornecedor.Visible = false;
            RBCodigo.Checked = false;
            RBNome.Checked = false;
            RBNumNFE.Checked = false;
            RBNomeForn.Checked = false;
            CBIniciarEm.Enabled = false;
            CBIniciarEm.Checked = false;
            this.dgProdutos.DataSource = null;
            dgProdutos.Refresh();
            limpaCamposItem();
            /*this.dgProdutos.DataSource = null;
            dgProdutos.Refresh();
            preencheGridProdutos();*/

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GBNfe.Enabled = true;
            GBProduto.Enabled = false;
            GBTipoPesqProd.Enabled = false;
            GBTipoPesqProd.Visible = false;
            GBTipoPesqNfe.Enabled = true;
            GBTipoPesqNfe.Visible = true;
            label2.Visible = false;
            produtoInfo.Visible = false;
            label4.Visible = false;
            produtoInfoNome.Visible = false;
            RBCodigo.Checked = false;
            RBNome.Checked = false;
            RBNumNFE.Checked = false;
            RBNomeForn.Checked = false;
            CBIniciarEm.Enabled = false;
            CBIniciarEm.Checked = false;
            this.dgProdutos.DataSource = null;
            dgProdutos.Refresh();
            limpaCamposItem();
            /*this.dgProdutos.DataSource = null;
            dgProdutos.Refresh();
            preencheGridNFE();*/


        }

        private void BrPesquisaNFE_Click(object sender, EventArgs e)
        {
            if (RBNumNFE.Checked == true && RBNomeForn.Checked == false)
            {
                if (nfeNumero.Text == null || nfeNumero.Text == "")
                {
                    MessageBox.Show("Número da NFE não foi informado!", "Número NFE");
                    return;
                }
                int numero = Convert.ToInt32(nfeNumero.Text);
                NFE nfe = new NFE();
                try
                {
                    nfe = AcessoFB.fb_ProcuraDadosNFE(numero);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }
                preencheDadosNFE(nfe);
                posicionaGridPesquisaNFE(nfe);
            }
            if (RBNumNFE.Checked == false && RBNomeForn.Checked == true)
            {
                if (nfeFornecedor.Text == null || nfeFornecedor.Text == "")
                {
                    MessageBox.Show("Nome do Fornecedor da NFE não foi informado!", "Nome do Fornecedor");
                    return;
                }
                String nomeF = Convert.ToString(nfeFornecedor.Text);
                NFE nfe = new NFE();
                try
                {
                    nfe = AcessoFB.fb_ProcuraDadosNFEFornecedor(nomeF);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }
                preencheDadosNFE(nfe);
                posicionaGridPesquisaNFE(nfe);
            }
        }

        private void NfeNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (nfeNumero.Text == null || nfeNumero.Text == "")
                {
                    MessageBox.Show("Número da NFE não foi informado!", "Número NFE");
                    return;
                }
                int numero = Convert.ToInt32(nfeNumero.Text);
                NFE nfe = new NFE();
                try
                {
                    nfe = AcessoFB.fb_ProcuraDadosNFE(numero);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }
                preencheDadosNFE(nfe);
                posicionaGridPesquisaNFE(nfe);
            }
        }

        private void NfeNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (GBProduto.Enabled == false && GBNfe.Enabled == true)
            {
                if (nfeNumero.Text == null || nfeNumero.Text == "")
                {
                    MessageBox.Show("Não foi informada uma NFE", "NFE");
                    return;
                }

                int numero = Convert.ToInt32(nfeNumero.Text);

                NFE nfe = new NFE();
                AcessoFB.fb_BuscaProdutosNota(numero);
                limpaCamposItem();
                AtualizaGrid();
            }


            if (GBNfe.Enabled == false && GBProduto.Enabled == true)
            {
                if (quantidadeInfo.Text == null || quantidadeInfo.Text == "")
                {
                    MessageBox.Show("A quantidade de etiquetas não foi informada!", "Quantidade");
                    return;
                }
                if (produtoInfo.Text == null || produtoInfo.Text == "")
                {
                    MessageBox.Show("Código do produto não foi informado!", "Código Produto");
                    return;
                }

                int codigo = Convert.ToInt32(produtoInfo.Text);
                Produto produto = new Produto();
                try
                {
                    produto = AcessoFB.fb_ProcuraDadosProdutos(codigo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }

                preencheDadosProduto(produto);

                AcessoFB.fb_VerificarTabelaImp();
                Produto prod = new Produto();
                prod.Codigo = Convert.ToInt32(labelCodigoEtq.Text);
                prod.Descricao = labelDescEtq.Text;

                String valorSalvar = labelValorEtq.Text.Substring(3, (labelValorEtq.Text.Length - 3));

                prod.Valor = Convert.ToDouble(valorSalvar);


                prod.Quantidade = Convert.ToInt32(quantidadeInfo.Text);

                try
                {
                    AcessoFB.fb_InserirDados(prod);
                    preencheGridProdutos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }
                limpaCamposItem();
                AtualizaGrid();
            }


        }

        private void AtualizaGrid()
        {
            dgETQ.Refresh();

            BindingSource bindingSource1 = new BindingSource();
            DataTable etiquetas = new DataTable("Etiquetas");
            DataSet etq = new DataSet();
            etiquetas = AcessoFB.fb_buscaEtiquetasParaGrid();
            etq.Tables.Add(etiquetas);
            bindingSource1.DataSource = etiquetas;
            dgETQ.DataSource = bindingSource1;

            dgETQ.Refresh();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //AcessoFB.fb_DeletarTabelaQuantidades();
            //AcessoFB.fb_DropaTabelas();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //AcessoFB.fb_DeletarTabelaQuantidades();
            AcessoFB.fb_DropaTabelas();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*
            dgETQ.Columns.CheckBoxColuna
            
            if(CheckBoxColuna.ValueType == true)

            if (dgETQ.SelectedRows.Count > 0)
            {
                Aluno alunoSelecionado = dgAlunos.SelectedRows[0]
                                                                .DataBoundItem as Aluno;
                gerenciador.RemoverAluno(alunoSelecionado.Id);
                MessageBox.Show("Aluno apagado com sucesso!");
                CarregarDados();
            }

            foreach (DataGridViewRow dr in dgETQ.Rows)
            {
                if (bool.Parse(dr.Cells[0].EditedFormattedValue.ToString()))
                {
                }
            } */

            // Navegamos por todas as linhas de item ticaso
            for (int row = 0; row < this.dgETQ.Rows.Count; row++)
            {
                // Se o valor não for nulo e for verdadeiro, verificamos se é nulo pois esse valor se baseia em um System.Object
                //  Na primeira coluna está meu CheckBox
                if (this.dgETQ[0, row].Value != null && (bool)this.dgETQ[0, row].Value)
                {
                    // Na segunda coluna tenho o código do item.
                    AcessoFB.fb_ExcluiProdutoDgETQ(Convert.ToInt32(this.dgETQ[1, row].Value));
                }
            }

            AtualizaGrid();

            CheckBoxDG.Checked = false;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AtualizaQuantidadeGrid();
        }

        public void AtualizaQuantidadeGrid()
        {
            int novaQTD, codigo = new int();
            novaQTD = Convert.ToInt32(dgETQ.CurrentCell.OwningRow.Cells["ColunaQuantidades"].Value);
            codigo = Convert.ToInt32(dgETQ.CurrentCell.OwningRow.Cells["ColunaCodigo"].Value);
            AcessoFB.fb_AtualizaQuantidade(codigo, novaQTD);
        }



        private void QuantidadeInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (quantidadeInfo.Text == null || quantidadeInfo.Text == "")
                {
                    MessageBox.Show("A quantidade de etiquetas não foi informada!", "Quantidade");
                    return;
                }
                if (produtoInfo.Text == null || produtoInfo.Text == "")
                {
                    MessageBox.Show("Código do produto não foi informado!", "Código Produto");
                    return;
                }

                int codigo = Convert.ToInt32(produtoInfo.Text);
                Produto produto = new Produto();
                try
                {
                    produto = AcessoFB.fb_ProcuraDadosProdutos(codigo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }

                preencheDadosProduto(produto);

                AcessoFB.fb_VerificarTabelaImp();
                Produto prod = new Produto();
                prod.Codigo = Convert.ToInt32(labelCodigoEtq.Text);
                prod.Descricao = labelDescEtq.Text;
                prod.Valor = Convert.ToDouble(labelValorEtq.Text);
                prod.Quantidade = Convert.ToInt32(quantidadeInfo.Text);

                try
                {
                    AcessoFB.fb_InserirDados(prod);
                    preencheGridProdutos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }
                limpaCamposItem();
                AtualizaGrid();

            }
        }

        private void DgETQ_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            AtualizaQuantidadeGrid();
        }

        private void CheckBoxDG_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow gvLinha in dgETQ.Rows)
            {
                if (CheckBoxDG.Checked)
                {
                    gvLinha.Cells["CheckBoxColuna"].Value = true;
                }
                else
                {
                    gvLinha.Cells["CheckBoxColuna"].Value = false;
                }
            }
        }

        private void NfeNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void DgETQ_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var value = (e.FormattedValue ?? string.Empty).ToString();
            if (string.IsNullOrWhiteSpace(value) == true)
            {
                MessageBox.Show("Quantidade deve ser informada!");
                e.Cancel = true;

            }
        }

        private void DgETQ_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewTextBoxEditingControl)

            {

                e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);

            }
        }
        void Control_KeyPress(object sender, KeyPressEventArgs e)

        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void TBLinhaInic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void TBColunaInic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void RBCodigo_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            produtoInfo.Visible = true;
            label4.Visible = false;
            produtoInfoNome.Visible = false;
            CBIniciarEm.Enabled = true;
            limpaCamposItem();
            this.dgProdutos.DataSource = null;
            dgProdutos.Refresh();
            preencheGridProdutos();

        }

        private void RBNome_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            produtoInfo.Visible = false;
            label4.Visible = true;
            produtoInfoNome.Visible = true;
            CBIniciarEm.Enabled = true;
            limpaCamposItem();
            this.dgProdutos.DataSource = null;
            dgProdutos.Refresh();
            preencheGridProdutosPorNome();

            
        }

        private void ProdutoInfoNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (produtoInfoNome.Text == null || produtoInfoNome.Text == "")
                {
                    MessageBox.Show("Nome do produto não foi informado!", "Nome Produto");
                    return;
                }
                String pesquisa = Convert.ToString(produtoInfoNome.Text);
                Produto produto = new Produto();
                try
                {
                    produto = AcessoFB.fb_ProcuraDadosProdutosNome(pesquisa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }
                preencheDadosProduto(produto);
                posicionaGridPesquisaProduto(produto);

            }
        }

        private void RBNumNFE_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            nfeNumero.Visible = true;
            label7.Visible = false;
            nfeFornecedor.Visible = false;
            CBIniciarEm.Enabled = true;
            limpaCamposItem();
            this.dgProdutos.DataSource = null;
            dgProdutos.Refresh();
            preencheGridNFE();
        }

        private void RBNomeForn_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            nfeNumero.Visible = false;
            label7.Visible = true;
            nfeFornecedor.Visible = true;
            CBIniciarEm.Enabled = true;
            limpaCamposItem();
            this.dgProdutos.DataSource = null;
            dgProdutos.Refresh();
            preencheGridNFEPorNome();


        }

        private void NfeFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (nfeFornecedor.Text == null || nfeFornecedor.Text == "")
                {
                    MessageBox.Show("Nome do Fornecedor da NFE não foi informado!", "Nome do Fornecedor");
                    return;
                }
                String nomeF = Convert.ToString(nfeFornecedor.Text);
                NFE nfe = new NFE();
                try
                {
                    nfe = AcessoFB.fb_ProcuraDadosNFEFornecedor(nomeF);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }
                preencheDadosNFE(nfe);
                posicionaGridPesquisaNFE(nfe);
            }
        }

        private void DgProdutos_Click(object sender, EventArgs e)
        {

        }

        private void DgProdutos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DgProdutos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CBIniciarEm.Checked == true)
                GBIniciarEm.Enabled = true;
            if (CBIniciarEm.Checked == false)
                GBIniciarEm.Enabled = false;

        }

        

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBLinha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 
    }
}
