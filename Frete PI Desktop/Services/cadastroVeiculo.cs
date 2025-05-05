using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Frete_PI_Desktop.Models;
using Microsoft.Data.SqlClient;
using Mysqlx.Crud;
using Microsoft.VisualBasic;

namespace Frete_PI_Desktop.Services
{
	internal class cadastroVeiculo
	{
		/* 
			placa_veiculo char(26) not null,
			renavam_veiculo char (12) not null,
			modelo_Veiculo varchar(50) not null,
			anoFabricação_veiculo int not null,
			cor_veiculo varchar(50) not null, 
			tipo_veiculo varchar(50) not null, 
			capacidade_carga_veiculo int not null,
			obs_veiculo varchar(255) null, 
			status_veiculo varchar(100) not null default'ATIVO'
         */

        // método de cadastro de veiculo

        public bool cadastrarVeiculo(Veiculo veiculo)
        {
            SqlConnection sqlConexaoBanco = null;
            try
            {
                sqlConexaoBanco = new SqlConnection(ConexaoBanco.conexaoBanco);
                sqlConexaoBanco.Open();
                 
                string insert = "INSERT INTO Veiculo (placa_veiculo, renavam_veiculo, modelo_Veiculo, anoFabricação_veiculo, cor_veiculo, tipo_veiculo, capacidade_carga_veiculo, obs_veiculo, status_veiculo) " +
                                "VALUES (@Placa, @Renavam, @Modelo, @AnoFabricação, @Cor, @Tipo, @Capacidade, @Observacao, @Status)";

                SqlCommand comandoSql = sqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.Parameters.AddWithValue("@Placa", veiculo.PlacaVeiculo);
                comandoSql.Parameters.AddWithValue("@Renavam", veiculo.RenavamVeiculo);
                comandoSql.Parameters.AddWithValue("@Modelo", veiculo.ModeloVeiculo);
                comandoSql.Parameters.AddWithValue("@AnoFabricação", veiculo.AnoFabricacao);
                comandoSql.Parameters.AddWithValue("@Cor", veiculo.CorVeiculo);
                comandoSql.Parameters.AddWithValue("@Tipo", veiculo.TipoVeiculo);
                comandoSql.Parameters.AddWithValue("@Capacidade", veiculo.CapacidadeVeiculo);
                comandoSql.Parameters.AddWithValue("@Observacao", veiculo.ObservacaoVeiculo);
                comandoSql.Parameters.AddWithValue("@Status", veiculo.StatusVeiculo);

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método cadastrarVeiculo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (sqlConexaoBanco != null)
                {
                    sqlConexaoBanco.Close();
                }
            }

        }

        public bool atualizarVeiculo(Veiculo veiculo, int? id_veiculo_selecionado)
        {
            SqlConnection sqlConexaoBanco = null;
            try
            {
                sqlConexaoBanco = new SqlConnection(ConexaoBanco.conexaoBanco);
                sqlConexaoBanco.Open();

                string update = "UPDATE Veiculo SET placa_veiculo = @Placa, renavam_veiculo =  @Renavam, modelo_Veiculo = @Modelo, anoFabricação_veiculo = @AnoFabricação, cor_veiculo = @Cor, tipo_veiculo = @Tipo, capacidade_carga_veiculo = @Capacidade, obs_veiculo = @Observacao, status_veiculo = @Status "
                                 + "WHERE id_veiculo = @id";

                SqlCommand comandoSql = sqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.Parameters.AddWithValue("@id", id_veiculo_selecionado);
                comandoSql.Parameters.AddWithValue("@Placa", veiculo.PlacaVeiculo);
                comandoSql.Parameters.AddWithValue("@Renavam", veiculo.RenavamVeiculo);
                comandoSql.Parameters.AddWithValue("@Modelo", veiculo.ModeloVeiculo);
                comandoSql.Parameters.AddWithValue("@AnoFabricação", veiculo.AnoFabricacao);
                comandoSql.Parameters.AddWithValue("@Cor", veiculo.CorVeiculo);
                comandoSql.Parameters.AddWithValue("@Tipo", veiculo.TipoVeiculo);
                comandoSql.Parameters.AddWithValue("@Capacidade", veiculo.CapacidadeVeiculo);
                comandoSql.Parameters.AddWithValue("@Observacao", veiculo.ObservacaoVeiculo);
                comandoSql.Parameters.AddWithValue("@Status", veiculo.StatusVeiculo);

                int rowsAffected = comandoSql.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    throw new Exception("Nenhum registro foi atualizado. Verifique se o ID do veículo está correto.");
                }
                ;
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método atualizarVeiculo " + ex.Message);
                return false;
            }
            finally
            {
                if (sqlConexaoBanco != null)
                {
                    sqlConexaoBanco.Close();
                }

            }
        }

          public bool deletarVeiculo(Veiculo veiculo, int? id_veiculo_selecionado)
        {
            SqlConnection sqlConexaoBanco = null;
            try
            {
                sqlConexaoBanco = new SqlConnection(ConexaoBanco.conexaoBanco);
                sqlConexaoBanco.Open();

                string delete = "DELETE Veiculo WHERE id_veiculo = @id";
                                

                SqlCommand comandoSql = sqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = delete;

                comandoSql.Parameters.AddWithValue("@id", id_veiculo_selecionado);
                comandoSql.Parameters.AddWithValue("@Placa", veiculo.PlacaVeiculo);
                comandoSql.Parameters.AddWithValue("@Renavam", veiculo.RenavamVeiculo);
                comandoSql.Parameters.AddWithValue("@Modelo", veiculo.ModeloVeiculo);
                comandoSql.Parameters.AddWithValue("@AnoFabricação", veiculo.AnoFabricacao);
                comandoSql.Parameters.AddWithValue("@Cor", veiculo.CorVeiculo);
                comandoSql.Parameters.AddWithValue("@Tipo", veiculo.TipoVeiculo);
                comandoSql.Parameters.AddWithValue("@Capacidade", veiculo.CapacidadeVeiculo);
                comandoSql.Parameters.AddWithValue("@Observacao", veiculo.ObservacaoVeiculo);
                comandoSql.Parameters.AddWithValue("@Status", veiculo.StatusVeiculo);

                int rowsAffected = comandoSql.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    throw new Exception("Nenhum registro foi atualizado. Verifique se o ID do veículo está correto.");
                }
                ;
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método atualizarVeiculo " + ex.Message);
                return false;
            }
            finally
            {
                if (sqlConexaoBanco != null)
                {
                    sqlConexaoBanco.Close();
                }

            }




        }
	}
}
