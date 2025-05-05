using Frete_PI_Desktop.Models;
using Frete_PI_Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frete_PI_Desktop.Views
{
    public partial class frmCadastroParam : Form
    {
        public int? id_veiculo_selecionado = null;
        public frmCadastroParam()
        {
            InitializeComponent();
        }

        private void btnCadastrarParametro_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtIdVeiculoParametro.Text) &&
                    !string.IsNullOrWhiteSpace(txtDataVeiculoParametro.Text) &&
                    !string.IsNullOrWhiteSpace(txtConsumoCombustivel.Text) &&
                    !string.IsNullOrWhiteSpace(txtValorCapital.Text) &&
                    !string.IsNullOrWhiteSpace(txtTaxaRemuneracao.Text) &&
                    !string.IsNullOrWhiteSpace(txtLicenciamento.Text) &&
                    !string.IsNullOrWhiteSpace(txtValorEquipamento.Text) &&
                    !string.IsNullOrWhiteSpace(txtVidaEquipamento.Text)
                   )
                {
                    ParametroVeiculo paramVeiculo = ColetarDadosParametro();

                    cadastroParametroVeiculo cadParametroVeiculo = new cadastroParametroVeiculo();

                    if (cadParametroVeiculo.cadastrarParametroVeiculo(paramVeiculo)) //usa como base os valores dentro de veiculo para fazer a função cadastrarVeiculo
                    {
                        MessageBox.Show($"Parametros foram cadastrados com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar os Parametros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Veículo: btnCadastrarParametro - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private ParametroVeiculo ColetarDadosParametro()
        {
            return new ParametroVeiculo
            {
                Id_Veiculo_Parametro = int.Parse(txtIdVeiculoParametro.Text.Trim()),
                Data_Veiculo_Parametro = DateTime.Parse(txtDataVeiculoParametro.Text.Trim()),
                ConsumoConbustivel = decimal.Parse(txtConsumoCombustivel.Text.Trim()),
                ValorCapitalInvestido = decimal.Parse(txtValorCapital.Text.Trim()),
                TaxaRemunaracaoAtual = decimal.Parse(txtTaxaRemuneracao.Text.Trim()),
                RccMeses = int.Parse(txtMesesUso.Text.Trim()),
                ValorAnualLicenciamentoChassi = decimal.Parse(txtLicenciamento.Text.Trim()),
                VidaUtilEquipamento = int.Parse(txtVidaEquipamento.Text.Trim())
            };
        }

        private void btnBuscarParametro_Click(object sender, EventArgs e)
        {

        }
    }
}
