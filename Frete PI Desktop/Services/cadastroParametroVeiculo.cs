using Frete_PI_Desktop.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frete_PI_Desktop.Services
{
    internal class cadastroParametroVeiculo
    {
        public bool cadastrarParametroVeiculo(ParametroVeiculo parametroVeiculo) 
        {
            SqlConnection sqlConexaoBanco = null;
            try
            {
                sqlConexaoBanco = new SqlConnection(ConexaoBanco.conexaoBanco);
                sqlConexaoBanco.Open();

                string insert = "INSERT INTO Veiculo_Parametro (id_Veiculo_VParametro, data_veiculo_parametro, consumo_combustivel_veiculo, rcc_valor_capital_investido, rcc_taxa_remuneracao_atual, rcc_meses,clc_valor_anual_licenciamento_chassi, cde_valorInicialEquipamento, cde_vidaUtilEquipamentoMeses)" +
                                "VALUES (@Id, @Data, @ConsumoCombustivel, @CapitalInvestido, @TaxaRemuneracao, @Meses, @Licenciamento, @ValorEquipamento, @VidaEquipamento)";

                SqlCommand comandoSql = sqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;
           
                comandoSql.Parameters.AddWithValue("@Id", parametroVeiculo.Id_Veiculo_Parametro);
                comandoSql.Parameters.AddWithValue("@Data",parametroVeiculo.Data_Veiculo_Parametro);
                comandoSql.Parameters.AddWithValue("@ConsumoCombustivel", parametroVeiculo.ConsumoConbustivel);
                comandoSql.Parameters.AddWithValue("@CapitalInvestido", parametroVeiculo.ValorCapitalInvestido);
                comandoSql.Parameters.AddWithValue("@TaxaRemuneracao", parametroVeiculo.TaxaRemunaracaoAtual);
                comandoSql.Parameters.AddWithValue("@Meses", parametroVeiculo.RccMeses);
                comandoSql.Parameters.AddWithValue("@Licenciamento", parametroVeiculo.ValorAnualLicenciamentoChassi);
                comandoSql.Parameters.AddWithValue("@ValorEquipamento", parametroVeiculo.ValorInicialEquipamento);
                comandoSql.Parameters.AddWithValue("@VidaEquipamento", parametroVeiculo.VidaUtilEquipamento);

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método cadastroParametroVeiculo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
