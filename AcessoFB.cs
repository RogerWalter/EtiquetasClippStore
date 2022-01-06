using System;
using System.Collections.Generic;
using System.Linq;
using FirebirdSql.Data.FirebirdClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace EtiquetasClippStore
{
    public class AcessoFB
    {
        private static readonly AcessoFB instanciaFireBird = new AcessoFB();
        private AcessoFB() { }

        public static AcessoFB getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            return new FbConnection(conn);
        }

        public static DataTable fb_GetDadosProdutos()
        {

            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "SELECT ID_ESTOQUE AS CODIGO, DESCRICAO, PRC_VENDA AS VALOR FROM TB_ESTOQUE ORDER BY ID_ESTOQUE";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();

                    DataTable dt = new DataTable("PRODUTOS");
                    DataColumn coluna1, coluna2, coluna3;
                    coluna1 = new DataColumn();
                    coluna2 = new DataColumn();
                    coluna3 = new DataColumn();

                    coluna1.DataType = System.Type.GetType("System.Int32");
                    coluna1.ColumnName = "CODIGO";
                    coluna1.ReadOnly = false;
                    coluna1.Unique = false;
                    dt.Columns.Add(coluna1);

                    coluna2.DataType = System.Type.GetType("System.String");
                    coluna2.ColumnName = "DESCRICAO";
                    coluna2.ReadOnly = false;
                    coluna2.Unique = false;
                    dt.Columns.Add(coluna2);

                    coluna3.DataType = System.Type.GetType("System.String");
                    coluna3.ColumnName = "VALOR";
                    coluna3.ReadOnly = false;
                    coluna3.Unique = false;
                    dt.Columns.Add(coluna3);

                    int col1;
                    Decimal ajuste;
                    String col2, col3;

                    while (dr.Read())
                    {
                        DataRow linha;
                        linha = dt.NewRow();

                        col1 = Convert.ToInt32(dr[0]);
                        col2 = dr[1].ToString();

                        ajuste = Convert.ToDecimal(dr[2]);
                        string valor = ajuste.ToString("C", CultureInfo.CurrentCulture); //Faz a conversão para R$

                        col3 = valor;

                        linha["CODIGO"] = col1;
                        linha["DESCRICAO"] = col2;
                        linha["VALOR"] = col3;

                        dt.Rows.Add(linha);
                    }
                    return dt;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static DataTable fb_GetDadosProdutosOrdenadoNome()
        {

            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "SELECT ID_ESTOQUE AS CODIGO, DESCRICAO, PRC_VENDA AS VALOR FROM TB_ESTOQUE ORDER BY DESCRICAO";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();

                    DataTable dt = new DataTable("PRODUTOS");
                    DataColumn coluna1, coluna2, coluna3;
                    coluna1 = new DataColumn();
                    coluna2 = new DataColumn();
                    coluna3 = new DataColumn();

                    coluna1.DataType = System.Type.GetType("System.Int32");
                    coluna1.ColumnName = "CODIGO";
                    coluna1.ReadOnly = false;
                    coluna1.Unique = false;
                    dt.Columns.Add(coluna1);

                    coluna2.DataType = System.Type.GetType("System.String");
                    coluna2.ColumnName = "DESCRICAO";
                    coluna2.ReadOnly = false;
                    coluna2.Unique = false;
                    dt.Columns.Add(coluna2);

                    coluna3.DataType = System.Type.GetType("System.String");
                    coluna3.ColumnName = "VALOR";
                    coluna3.ReadOnly = false;
                    coluna3.Unique = false;
                    dt.Columns.Add(coluna3);

                    int col1;
                    Decimal ajuste;
                    String col2, col3;

                    while (dr.Read())
                    {
                        DataRow linha;
                        linha = dt.NewRow();

                        col1 = Convert.ToInt32(dr[0]);
                        col2 = dr[1].ToString();

                        ajuste = Convert.ToDecimal(dr[2]);
                        string valor = ajuste.ToString("C", CultureInfo.CurrentCulture); //Faz a conversão para R$

                        col3 = valor;

                        linha["CODIGO"] = col1;
                        linha["DESCRICAO"] = col2;
                        linha["VALOR"] = col3;

                        dt.Rows.Add(linha);
                    }
                    return dt;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static DataTable fb_GetDadosNFE()
        {

            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "SELECT DISTINCT D.NF_NUMERO AS NUMERO, E.NOME AS FORNECEDOR, CAST(F.VLR_PAGTO AS NUMERIC (15,2)) AS VALOR FROM TB_NFC_ITEM A JOIN TB_NFCOMPRA D ON A.ID_NFCOMPRA = D.ID_NFCOMPRA JOIN TB_FORNECEDOR E ON D.ID_FORNEC = E.ID_FORNEC JOIN TB_NFCOMPRA_FMAPAGTO F ON A.ID_NFCOMPRA = F.ID_NFCOMPRA ORDER BY D.NF_NUMERO";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();

                    DataTable dt = new DataTable("NFE");
                    DataColumn coluna1, coluna2, coluna3;
                    coluna1 = new DataColumn();
                    coluna2 = new DataColumn();
                    coluna3 = new DataColumn();

                    coluna1.DataType = System.Type.GetType("System.Int32");
                    coluna1.ColumnName = "NUMERO";
                    coluna1.ReadOnly = false;
                    coluna1.Unique = false;
                    dt.Columns.Add(coluna1);

                    coluna2.DataType = System.Type.GetType("System.String");
                    coluna2.ColumnName = "FORNECEDOR";
                    coluna2.ReadOnly = false;
                    coluna2.Unique = false;
                    dt.Columns.Add(coluna2);

                    coluna3.DataType = System.Type.GetType("System.String");
                    coluna3.ColumnName = "VALOR";
                    coluna3.ReadOnly = false;
                    coluna3.Unique = false;
                    dt.Columns.Add(coluna3);

                    int col1;
                    Decimal ajuste;
                    String col2, col3;

                    while (dr.Read())
                    {
                        DataRow linha;
                        linha = dt.NewRow();

                        col1 = Convert.ToInt32(dr[0]);
                        col2 = dr[1].ToString();

                        ajuste = Convert.ToDecimal(dr[2]);
                        string valor = ajuste.ToString("C", CultureInfo.CurrentCulture); //Faz a conversão para R$

                        col3 = valor;

                        linha["NUMERO"] = col1;
                        linha["FORNECEDOR"] = col2;
                        linha["VALOR"] = col3;

                        dt.Rows.Add(linha);
                    }
                    return dt;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static DataTable fb_GetDadosNFEOrdenadoNome()
        {

            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "SELECT DISTINCT D.NF_NUMERO AS NUMERO, E.NOME AS FORNECEDOR, CAST(F.VLR_PAGTO AS NUMERIC (15,2)) AS VALOR FROM TB_NFC_ITEM A JOIN TB_NFCOMPRA D ON A.ID_NFCOMPRA = D.ID_NFCOMPRA JOIN TB_FORNECEDOR E ON D.ID_FORNEC = E.ID_FORNEC JOIN TB_NFCOMPRA_FMAPAGTO F ON A.ID_NFCOMPRA = F.ID_NFCOMPRA ORDER BY E.NOME";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();

                    DataTable dt = new DataTable("NFE");
                    DataColumn coluna1, coluna2, coluna3;
                    coluna1 = new DataColumn();
                    coluna2 = new DataColumn();
                    coluna3 = new DataColumn();

                    coluna1.DataType = System.Type.GetType("System.Int32");
                    coluna1.ColumnName = "NUMERO";
                    coluna1.ReadOnly = false;
                    coluna1.Unique = false;
                    dt.Columns.Add(coluna1);

                    coluna2.DataType = System.Type.GetType("System.String");
                    coluna2.ColumnName = "FORNECEDOR";
                    coluna2.ReadOnly = false;
                    coluna2.Unique = false;
                    dt.Columns.Add(coluna2);

                    coluna3.DataType = System.Type.GetType("System.String");
                    coluna3.ColumnName = "VALOR";
                    coluna3.ReadOnly = false;
                    coluna3.Unique = false;
                    dt.Columns.Add(coluna3);

                    int col1;
                    Decimal ajuste;
                    String col2, col3;

                    while (dr.Read())
                    {
                        DataRow linha;
                        linha = dt.NewRow();

                        col1 = Convert.ToInt32(dr[0]);
                        col2 = dr[1].ToString();

                        ajuste = Convert.ToDecimal(dr[2]);
                        string valor = ajuste.ToString("C", CultureInfo.CurrentCulture); //Faz a conversão para R$

                        col3 = valor;

                        linha["NUMERO"] = col1;
                        linha["FORNECEDOR"] = col2;
                        linha["VALOR"] = col3;

                        dt.Rows.Add(linha);
                    }
                    return dt;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void fb_BuscaProdutosNota(int num)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "select a.ID_IDENTIFICADOR as CODIGO, c.DESCRICAO, cast(c.prc_venda as numeric (15,2))  as VALOR, a.qtd_item AS QUANTIDADE from TB_NFC_ITEM a join TB_EST_IDENTIFICADOR b on a.id_identificador = b.id_identificador join TB_ESTOQUE c on b.id_estoque = c.id_estoque join TB_NFCOMPRA d on a.id_nfcompra = d.id_nfcompra where d.nf_numero = " + num;
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Produto produto = new Produto();
                    while (dr.Read())
                    {
                        produto.Codigo = Convert.ToInt32(dr[0]);
                        produto.Descricao = dr[1].ToString();
                        produto.Valor = Convert.ToDouble(dr[2]);
                        produto.Quantidade = Convert.ToInt32(dr[3]);
                        
                        string mSQL1 = "INSERT INTO ETIQUETAS_QUANTIDADES (CODIGO, DESCRICAO, VALOR, QUANTIDADE) VALUES (" + produto.Codigo + ",'" + produto.Descricao + "', replace('" + produto.Valor + "', ',', '.')," + produto.Quantidade + ")";
                        FbCommand cmd1 = new FbCommand(mSQL1, conexaoFireBird);
                        cmd1.ExecuteNonQuery();                        
                    }            
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static Produto fb_ProcuraDadosProdutos(int id)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "select id_estoque as Codigo, descricao as Descricao, cast(prc_venda as numeric(15,2)) as Valor from tb_estoque where id_estoque = " + id;
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Produto produto = new Produto();
                    while (dr.Read())
                    {
                        produto.Codigo = Convert.ToInt32(dr[0]);
                        produto.Descricao = dr[1].ToString();
                        produto.Valor = Convert.ToDouble(dr[2]);                
                    }
                    return produto;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static Produto fb_ProcuraDadosProdutosNome(String pesquisa)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "select first 1 id_estoque as Codigo, descricao as Descricao, cast(prc_venda as numeric(15,2)) as Valor from tb_estoque where descricao like '" + pesquisa + "%' order by descricao";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Produto produto = new Produto();
                    while (dr.Read())
                    {
                        produto.Codigo = Convert.ToInt32(dr[0]);
                        produto.Descricao = dr[1].ToString();
                        produto.Valor = Convert.ToDouble(dr[2]);
                    }
                    return produto;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static Produto fb_ProcuraDadosQuantidades()
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "select * from ETIQUETAS_QUANTIDADES";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Produto produto = new Produto();
                    while (dr.Read())
                    {
                        produto.Codigo = Convert.ToInt32(dr[0]);
                        produto.Descricao = dr[1].ToString();
                        produto.Valor = Convert.ToDouble(dr[2]);
                    }
                    return produto;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }


        public static NFE fb_ProcuraDadosNFE(int id)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "select distinct d.nf_numero as Numero, e.nome as Fornecedor, cast(f.vlr_pagto as numeric (15,2)) as Valor from TB_NFC_ITEM a join TB_NFCOMPRA d on a.id_nfcompra = d.id_nfcompra join TB_FORNECEDOR e on d.id_fornec = e.id_fornec join TB_NFCOMPRA_FMAPAGTO f on a.id_nfcompra = f.id_nfcompra where d.nf_numero = " + id;
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    NFE nfe = new NFE();
                    while (dr.Read())
                    {
                        nfe.Numero = Convert.ToInt32(dr[0]);
                        nfe.Fornecedor = dr[1].ToString();
                        nfe.Valor = Convert.ToDecimal(dr[2]);
                    }
                    return nfe;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static NFE fb_ProcuraDadosNFEFornecedor(String nomeF)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "select first 1 distinct d.nf_numero as Numero, e.nome as Fornecedor, cast(f.vlr_pagto as numeric (15,2)) as Valor from TB_NFC_ITEM a join TB_NFCOMPRA d on a.id_nfcompra = d.id_nfcompra join TB_FORNECEDOR e on d.id_fornec = e.id_fornec join TB_NFCOMPRA_FMAPAGTO f on a.id_nfcompra = f.id_nfcompra where e.nome like '" + nomeF + "%' order by e.nome";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    NFE nfe = new NFE();
                    while (dr.Read())
                    {
                        nfe.Numero = Convert.ToInt32(dr[0]);
                        nfe.Fornecedor = dr[1].ToString();
                        nfe.Valor = Convert.ToDecimal(dr[2]);
                    }
                    return nfe;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void AdicionarEtiquetasVazias(int qtdEtqVazia)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    int QTDnaTabela = new int();

                    for (int i = 1; i <= qtdEtqVazia; i++)
                    {
                        QTDnaTabela = QTDnaTabela + 1;
                        string mSQL1 = "INSERT INTO IMPRESSAO_ETIQUETAS (NUMERO_QTD, DESCRICAO, VALOR, CODIGO) VALUES (" + QTDnaTabela + ",'','', NULL)";
                        FbCommand cmd1 = new FbCommand(mSQL1, conexaoFireBird);
                        cmd1.ExecuteNonQuery();

                    }
                    conexaoFireBird.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Não inseriu nada", MessageBoxButtons.OK);
                }
            }
        }

        public static int ContaRegistrosTabelaImpressao()
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                int iniciaDaqui = new int();
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "SELECT COUNT (NUMERO_QTD) FROM IMPRESSAO_ETIQUETAS";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    int qtd = new int();
                    while (dr.Read())
                    {
                        qtd = Convert.ToInt32(dr[0]);
                    }

                    iniciaDaqui = qtd;
                    conexaoFireBird.Close();
                    //return iniciaDaqui;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Não inseriu nada", MessageBoxButtons.OK);
                }
                return iniciaDaqui;
            }   
            
        }

        public static void fb_PreencheTabelaImpressao()
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "select CODIGO, DESCRICAO, cast(VALOR as numeric (15,2)), QUANTIDADE from ETIQUETAS_QUANTIDADES";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Produto produto = new Produto();
                    int QTDnaTabela = new int();
                    QTDnaTabela = ContaRegistrosTabelaImpressao();
                    while (dr.Read())
                    {
                        produto.Codigo = Convert.ToInt32(dr[0]);
                        produto.Descricao = dr[1].ToString();
                        produto.Valor = Convert.ToDouble(dr[2]);

                        string valor = produto.Valor.ToString("C", CultureInfo.CurrentCulture);

                        produto.Quantidade = Convert.ToInt32(dr[3]);


                        for (int i = 1; i <= produto.Quantidade; i++)
                        {
                            QTDnaTabela = QTDnaTabela + 1;
                            string mSQL1 = "INSERT INTO IMPRESSAO_ETIQUETAS (NUMERO_QTD, DESCRICAO, VALOR, CODIGO) VALUES (" + QTDnaTabela + ",'" + produto.Descricao + "','" + valor + "','" + produto.Codigo + "')";
                            FbCommand cmd1 = new FbCommand(mSQL1, conexaoFireBird);
                            cmd1.ExecuteNonQuery();
                            
                        }                       
                    }
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void fb_PreencheTabelaQuantidades(Produto produto)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "INSERT INTO  ETIQUETAS_QUANTIDADES (CODIGO, DESCRICAO, VALOR, QUANTIDADE) VALUES (" + produto.Codigo + ",'" + produto.Descricao + "', replace('" + produto.Valor + "', ',', '.'),'" + produto.Quantidade + "')";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                    conexaoFireBird.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Não inseriu nada", MessageBoxButtons.OK);
                }
            }
        }


        public static void fb_InserirDados(Produto produto)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    //fb_PreencheTabelaImpressao(produto);
                    fb_PreencheTabelaQuantidades(produto);
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void fb_VerificarTabelaImp()
        {
            using (FbConnection conexaoFirebird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFirebird.Open();
                    string mSQL = "SELECT COUNT(*) QTDE FROM RDB$RELATIONS WHERE RDB$FLAGS=1 and RDB$RELATION_NAME='IMPRESSAO_ETIQUETAS'";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFirebird);
                    FbDataReader dr = cmd.ExecuteReader();
                    int teste = new int();
                    while (dr.Read())
                    {
                        teste = Convert.ToInt32(dr[0]);
                    }
                    if(teste == 1)
                    {
                        int codigo = 1;                   
                        if (AcessoFB.fb_ProcuraDadosProdutos(codigo) != null)
                        {
                            fb_DeletarTabelaImpressao();
                        }
                        return;
                    }
                    else
                    {
                 
                        string mSQL_criarTB = "CREATE TABLE IMPRESSAO_ETIQUETAS (NUMERO_QTD INTEGER, DESCRICAO VARCHAR(50), VALOR VARCHAR(14), CODIGO INTEGER);";
                        FbCommand cmd_criarTB = new FbCommand(mSQL_criarTB, conexaoFirebird);
                        cmd_criarTB.ExecuteNonQuery();
                        return;
                    }

                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFirebird.Close();
                }
            }
        }


        public static void fb_VerificarTabelaQuantidades()
        {
            using (FbConnection conexaoFirebird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFirebird.Open();
                    string mSQL = "SELECT COUNT(*) QTDE FROM RDB$RELATIONS WHERE RDB$FLAGS=1 and RDB$RELATION_NAME='ETIQUETAS_QUANTIDADES'";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFirebird);
                    FbDataReader dr = cmd.ExecuteReader();
                    int teste = new int();
                    while (dr.Read())
                    {
                        teste = Convert.ToInt32(dr[0]);
                    }
                    if (teste == 0)
                    {
                        string mSQL_criarTB = "CREATE TABLE ETIQUETAS_QUANTIDADES (CODIGO INTEGER, DESCRICAO VARCHAR(50), VALOR NUMERIC(18,2), QUANTIDADE INTEGER);";
                        FbCommand cmd_criarTB = new FbCommand(mSQL_criarTB, conexaoFirebird);
                        cmd_criarTB.ExecuteNonQuery();
                        return;
                    }  
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFirebird.Close();
                }
            }
        }


        public static void fb_DeletarTabelaImpressao()
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "DELETE FROM IMPRESSAO_ETIQUETAS";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void fb_DeletarTabelaQuantidades()
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "DELETE FROM ETIQUETAS_QUANTIDADES";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
        public static DataTable fb_PreencherRelatorioEtiquetas()
        {
            using (FbConnection conexaoFirebird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFirebird.Open();
                    string mSQL = "SELECT * FROM IMPRESSAO_ETIQUETAS";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFirebird);
                    FbDataAdapter da = new FbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt; 
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFirebird.Close();
                }
            }
        }

        public static void fb_ExcluiProdutoDgETQ(int cod)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "DELETE FROM ETIQUETAS_QUANTIDADES WHERE CODIGO = " + cod;
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void fb_AtualizaQuantidade(int cod, int QTD)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "UPDATE ETIQUETAS_QUANTIDADES SET QUANTIDADE = " + QTD + "  WHERE CODIGO = " + cod;
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void fb_DropaTabelas()
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "DROP TABLE ETIQUETAS_QUANTIDADES";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();

                    string mSQL1 = "DROP TABLE IMPRESSAO_ETIQUETAS";
                    FbCommand cmd1 = new FbCommand(mSQL1, conexaoFireBird);
                    cmd1.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
        public static DataTable fb_buscaEtiquetasParaGrid()
        {

            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "SELECT CODIGO, DESCRICAO, VALOR, QUANTIDADE FROM ETIQUETAS_QUANTIDADES";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();

                    DataTable dt = new DataTable("Etiquetas_Quantidades");
                    DataColumn coluna1, coluna2, coluna3, coluna4;
                    coluna1 = new DataColumn();
                    coluna2 = new DataColumn();
                    coluna3 = new DataColumn();
                    coluna4 = new DataColumn();

                    coluna1.DataType = System.Type.GetType("System.Int32");
                    coluna1.ColumnName = "CODIGO";
                    coluna1.ReadOnly = false;
                    coluna1.Unique = false;
                    dt.Columns.Add(coluna1);

                    coluna2.DataType = System.Type.GetType("System.String");
                    coluna2.ColumnName = "DESCRICAO";
                    coluna2.ReadOnly = false;
                    coluna2.Unique = false;
                    dt.Columns.Add(coluna2);

                    coluna3.DataType = System.Type.GetType("System.String");
                    coluna3.ColumnName = "VALOR";
                    coluna3.ReadOnly = false;
                    coluna3.Unique = false;
                    dt.Columns.Add(coluna3);

                    coluna4.DataType = System.Type.GetType("System.Int32");
                    coluna4.ColumnName = "QUANTIDADE";
                    coluna4.ReadOnly = false;
                    coluna4.Unique = false;
                    dt.Columns.Add(coluna4);

                    int col1, col4;
                    Decimal ajuste;
                    String col2, col3;

                    while (dr.Read())
                    {
                        DataRow linha;
                        linha = dt.NewRow();

                        col1 = Convert.ToInt32(dr[0]);
                        col2 = dr[1].ToString();

                        ajuste = Convert.ToDecimal(dr[2]);
                        string valor = ajuste.ToString("C", CultureInfo.CurrentCulture); //Faz a conversão para R$

                        col3 = valor;
                        col4 = Convert.ToInt32(dr[3]);

                        linha["CODIGO"] = col1;
                        linha["DESCRICAO"] = col2;
                        linha["VALOR"] = col3;
                        linha["QUANTIDADE"] = col4;

                        dt.Rows.Add(linha);
                    }
                    return dt;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static DataTable fb_GetDadosEtiquetas()
        {

            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {   
                    conexaoFireBird.Open();
                    string mSQL = "SELECT NUMERO_QTD, DESCRICAO, VALOR, CODIGO FROM IMPRESSAO_ETIQUETAS";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();

                    DataTable dt = new DataTable("IMPRIMIR");
                    DataColumn coluna1, coluna2, coluna3, coluna4;
                    coluna1 = new DataColumn();
                    coluna2 = new DataColumn();
                    coluna3 = new DataColumn();
                    coluna4 = new DataColumn();

                    coluna1.DataType = System.Type.GetType("System.Int32");
                    coluna1.ColumnName = "NUMERO_QTD";
                    coluna1.ReadOnly = false;
                    coluna1.Unique = false;
                    dt.Columns.Add(coluna1);

                    coluna2.DataType = System.Type.GetType("System.String");
                    coluna2.ColumnName = "DESCRICAO";
                    coluna2.ReadOnly = false;
                    coluna2.Unique = false;
                    dt.Columns.Add(coluna2);

                    coluna3.DataType = System.Type.GetType("System.String");
                    coluna3.ColumnName = "VALOR";
                    coluna3.ReadOnly = false;
                    coluna3.Unique = false;
                    dt.Columns.Add(coluna3);

                    coluna4.DataType = System.Type.GetType("System.Int32");
                    coluna4.ColumnName = "CODIGO";
                    coluna4.ReadOnly = false;
                    coluna4.Unique = false;
                    dt.Columns.Add(coluna4);

                    int col1, col4;
                    Decimal ajuste;
                    String col2, col3;

                    while (dr.Read())
                    {
                        DataRow linha;
                        linha = dt.NewRow();

                        col1 = Convert.ToInt32(dr[0]);
                        col2 = dr[1].ToString();
                        col3 = dr[2].ToString();
                        col4 = Convert.ToInt32(dr[3]);

                        linha["NUMERO_QTD"] = col1;
                        linha["DESCRICAO"] = col2;
                        linha["VALOR"] = col3;
                        linha["CODIGO"] = col4;

                        dt.Rows.Add(linha);
                    }
                    return dt;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

    }  
}
