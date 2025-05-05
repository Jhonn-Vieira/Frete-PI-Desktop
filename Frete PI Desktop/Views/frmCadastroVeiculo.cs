using Frete_PI_Desktop.Models;
using Frete_PI_Desktop.Services;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frete_PI_Desktop
{
    public partial class frmCadastroVeiculo : Form
    {
        public int? id_veiculo_selecionado = null;
        public frmCadastroVeiculo()
        {
            InitializeComponent();
            cmbTipoVeiculo.Items.Add("Van");
            cmbTipoVeiculo.Items.Add("Caminhão");
            cmbTipoVeiculo.Items.Add("Moto");

            cmbStatusVeiculo.Items.Add("Ativo");
            cmbStatusVeiculo.Items.Add("Não Ativo");
            lstvVeiculos.View = View.Details;
            lstvVeiculos.LabelEdit = true;
            lstvVeiculos.AllowColumnReorder = true;
            lstvVeiculos.FullRowSelect = true;
            lstvVeiculos.GridLines = true;
            carregar_veiculos();
        }

        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtPlaca.Text) &&
                    !string.IsNullOrWhiteSpace(txtRenavam.Text) &&
                    !string.IsNullOrWhiteSpace(txtModelo.Text) &&
                    !string.IsNullOrWhiteSpace(txtCorVeiculo.Text) &&
                    !string.IsNullOrWhiteSpace(txtCapacidadeVeiculo.Text) &&
                    !string.IsNullOrWhiteSpace(txtAnoVeiculo.Text) &&
                     cmbStatusVeiculo.SelectedItem != null &&
                     cmbTipoVeiculo.SelectedItem != null)
                {
                    //coletar os dados do formulario de cadastro
                    Veiculo veiculo = ColetarDadosVeiculo();

                    cadastroVeiculo cadVeiculo = new cadastroVeiculo();

                    if (cadVeiculo.cadastrarVeiculo(veiculo)) //usa como base os valores dentro de veiculo para fazer a função cadastrarVeiculo
                    {
                        MessageBox.Show($"{veiculo.ModeloVeiculo} foi cadastrado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        carregar_veiculos();
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o veículo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Veículo: btnCadastrarVeiculo - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConexaoBanco = null;
            try
            {
                sqlConexaoBanco = new SqlConnection(ConexaoBanco.conexaoBanco);
                sqlConexaoBanco.Open();
                MessageBox.Show("Conexão com o banco de dados aberta com sucesso.");

                SqlCommand comandoSql = sqlConexaoBanco.CreateCommand();
                comandoSql.Connection = sqlConexaoBanco;

                comandoSql.CommandText = "SELECT * FROM Veiculo WHERE placa_veiculo LIKE @query";
                comandoSql.Prepare();
                comandoSql.Parameters.AddWithValue("@query", "%" + txtBuscar.Text + "%");

                // Use SqlDataReader em vez de MySqlDataReader
                SqlDataReader reader = comandoSql.ExecuteReader();
                MessageBox.Show("Consulta SQL executada.");

                lstvVeiculos.Items.Clear();

                while (reader.Read())
                {
                    string[] row = new string[10];

                    row[0] = reader["id_veiculo"].ToString();
                    row[1] = reader["placa_veiculo"].ToString();
                    row[2] = reader["renavam_veiculo"].ToString();
                    row[3] = reader["modelo_Veiculo"].ToString();
                    row[4] = reader["anoFabricação_veiculo"].ToString();
                    row[5] = reader["cor_veiculo"].ToString();
                    row[6] = reader["tipo_veiculo"].ToString();
                    row[7] = reader["capacidade_carga_veiculo"].ToString();
                    row[8] = reader["obs_veiculo"].ToString();
                    row[9] = reader["status_veiculo"].ToString();
                    MessageBox.Show("Dados Filtrados ao ListView.");



                    var linha_listview = new ListViewItem(row);
                    lstvVeiculos.Items.Add(linha_listview);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar o veículo: " + ex.Message);
            }
            finally
            {
                if (sqlConexaoBanco != null)
                {
                    sqlConexaoBanco.Close();
                }
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtPlaca.Text) &&
                  !string.IsNullOrWhiteSpace(txtRenavam.Text) &&
                  !string.IsNullOrWhiteSpace(txtModelo.Text) &&
                  !string.IsNullOrWhiteSpace(txtCorVeiculo.Text) &&
                  !string.IsNullOrWhiteSpace(txtCapacidadeVeiculo.Text) &&
                  !string.IsNullOrWhiteSpace(txtAnoVeiculo.Text) &&
                   cmbStatusVeiculo.SelectedItem != null &&
                   cmbTipoVeiculo.SelectedItem != null)
                {
                    //verificação via messagebox
                    DialogResult confirmação = MessageBox.Show("Você tem certeza que deseja atualizar os dados do veículo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //se for "sim"
                    if (confirmação == DialogResult.Yes)
                    {
                        cadastroVeiculo cadVeiculo = new cadastroVeiculo();
                        Veiculo veiculo = ColetarDadosVeiculo();//cria a variavel veiculo com base no modelo Veiculo e coleta os dados nos textbox na tela de cadastro de veiculo

                        if (cadVeiculo.atualizarVeiculo(veiculo, id_veiculo_selecionado)) //usa como base os valores dentro de veiculo e id_veiculo_selecionado para fazer a função atualizar veiculo
                        {
                            MessageBox.Show("veiculo atualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            carregar_veiculos();
                            id_veiculo_selecionado = null;
                        }
                        else
                        {
                            MessageBox.Show("nao foi possivel atualizar o veiculo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            id_veiculo_selecionado = null;
                        }
                    }
                    //se for "não"
                    else
                    {
                        MessageBox.Show("Atualização cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        id_veiculo_selecionado = null;
                    }

                }

                //se os campos estiverem vazios
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos ou selecione um veiculo para atualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //catch para erros
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro - btnAtualizar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtPlaca.Text) &&
                  !string.IsNullOrWhiteSpace(txtRenavam.Text) &&
                  !string.IsNullOrWhiteSpace(txtModelo.Text) &&
                  !string.IsNullOrWhiteSpace(txtCorVeiculo.Text) &&
                  !string.IsNullOrWhiteSpace(txtCapacidadeVeiculo.Text) &&
                  !string.IsNullOrWhiteSpace(txtAnoVeiculo.Text) &&
                   cmbStatusVeiculo.SelectedItem != null &&
                   cmbTipoVeiculo.SelectedItem != null && id_veiculo_selecionado != null)
                {
                    DialogResult confirmação = MessageBox.Show("Você tem certeza que deseja deletar os dados do veículo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //se for "sim"
                    if (confirmação == DialogResult.Yes)
                    {
                        cadastroVeiculo cadVeiculo = new cadastroVeiculo();

                        Veiculo veiculo = ColetarDadosVeiculo();

                        if (cadVeiculo.deletarVeiculo(veiculo, id_veiculo_selecionado))
                        {
                            MessageBox.Show("veiculo deletado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            carregar_veiculos();
                            id_veiculo_selecionado = null;
                        }
                        else
                        {
                            MessageBox.Show("nao foi possivel atualizar o veiculo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            id_veiculo_selecionado = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Exclusão cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        id_veiculo_selecionado = null;
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, selecione um item para ser deletado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro - btnDeletar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void carregar_veiculos()
        {
            SqlConnection sqlConexaoBanco = null;
            try
            {
                sqlConexaoBanco = new SqlConnection(ConexaoBanco.conexaoBanco);
                sqlConexaoBanco.Open();


                SqlCommand comandoSql = sqlConexaoBanco.CreateCommand();
                comandoSql.Connection = sqlConexaoBanco;

                comandoSql.CommandText = "SELECT * FROM Veiculo";
                comandoSql.Prepare();

                // Use SqlDataReader em vez de MySqlDataReader
                SqlDataReader reader = comandoSql.ExecuteReader();


                lstvVeiculos.Items.Clear();

                while (reader.Read())
                {
                    string[] row = new string[10];

                    row[0] = reader["id_veiculo"].ToString();
                    row[1] = reader["placa_veiculo"].ToString();
                    row[2] = reader["renavam_veiculo"].ToString();
                    row[3] = reader["modelo_Veiculo"].ToString();
                    row[4] = reader["anoFabricação_veiculo"].ToString();
                    row[5] = reader["cor_veiculo"].ToString();
                    row[6] = reader["tipo_veiculo"].ToString();
                    row[7] = reader["capacidade_carga_veiculo"].ToString();
                    row[8] = reader["obs_veiculo"].ToString();
                    row[9] = reader["status_veiculo"].ToString();





                    var linha_listview = new ListViewItem(row);
                    lstvVeiculos.Items.Add(linha_listview);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar o veículo: " + ex.Message);
            }
            finally
            {
                if (sqlConexaoBanco != null)
                {
                    sqlConexaoBanco.Close();
                }
            }
        }

        private void lstvVeiculos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itensSelecionados = lstvVeiculos.SelectedItems;

            foreach (ListViewItem item in itensSelecionados)
            {
                id_veiculo_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                //pega o valor da coluna e atribui ao textbox
                txtPlaca.Text = item.SubItems[1].Text;
                txtRenavam.Text = item.SubItems[2].Text;
                txtModelo.Text = item.SubItems[3].Text;
                txtAnoVeiculo.Text = item.SubItems[4].Text;
                txtCorVeiculo.Text = item.SubItems[5].Text;
                cmbTipoVeiculo.SelectedItem = item.SubItems[6].Text;
                txtCapacidadeVeiculo.Text = item.SubItems[7].Text;
                cmbStatusVeiculo.SelectedItem = item.SubItems[9].Text;
                txtObservacaoVeiculo.Text = item.SubItems[8].Text;
            }
        }

        private Veiculo ColetarDadosVeiculo()
        {
            return new Veiculo
            {
                PlacaVeiculo = txtPlaca.Text.ToUpper().Trim(),
                RenavamVeiculo = txtRenavam.Text.Trim(),
                ModeloVeiculo = txtModelo.Text.Trim(),
                AnoFabricacao = int.Parse(txtAnoVeiculo.Text),
                CorVeiculo = txtCorVeiculo.Text.ToUpper().Trim(),
                CapacidadeVeiculo = int.Parse(txtCapacidadeVeiculo.Text.Trim()),
                ObservacaoVeiculo = txtObservacaoVeiculo.Text.Trim(),
                TipoVeiculo = cmbTipoVeiculo.SelectedItem.ToString().Trim(),
                StatusVeiculo = cmbStatusVeiculo.SelectedItem.ToString().Trim(),
            };
        }

        private void btnNovoVeiculo_Click(object sender, EventArgs e)
        {
            int? id_veiculo_selecionado = null;
            LimparCampos();
        }

        private void LimparCampos() 
        {
            txtAnoVeiculo.Clear();
            txtBuscar.Clear();
            txtCapacidadeVeiculo.Clear();
            txtCorVeiculo.Clear();
            txtModelo.Clear();
            txtObservacaoVeiculo.Clear();
            txtPlaca.Clear();
            txtRenavam.Clear();
            cmbStatusVeiculo.SelectedIndex = -1;
            cmbTipoVeiculo .SelectedIndex = -1;

        }
    }
}
