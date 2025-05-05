using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frete_PI_Desktop.Models
{
    public class ParametroVeiculo
    {
		/*
         id_Veiculo_Parametro  int  not null   identity  Primary Key,
	id_Veiculo_VParametro  int  not null,     
	data_veiculo_parametro  date  not null,     
	consumo_combustivel_veiculo  decimal(10,2)  not null,     
	rcc_valor_capital_investido  decimal(10,2)  not null,     
	rcc_taxa_remuneracao_atual  decimal(10,2)  not null,     
	rcc_meses  int  not null,     
	clc_valor_anual_licenciamento_chassi  int  not null,     
	cde_valorInicialEquipamento  decimal(10,2)  not null,     
	cde_vidaUtilEquipamentoMeses  int  not null     
         */

		private int id_Veiculo_Parametro;
		private DateTime data_Veiculo_Parametro;
		private decimal consumoCombustivel;
		private decimal valorCapitalInvestido;
		private decimal taxaRemuneracaoAtual;
		private int rccMeses;
		private decimal valorAnualLicenciamentoChassi;
		private decimal valorInicialEquipamento;
		private int vidaUtilEquipamento;

		public int Id_Veiculo_Parametro { get { return id_Veiculo_Parametro; } set { id_Veiculo_Parametro = value; } }
		public DateTime Data_Veiculo_Parametro { get { return data_Veiculo_Parametro; } set { data_Veiculo_Parametro = value; } }
		public decimal ConsumoConbustivel { get { return consumoCombustivel; } set { consumoCombustivel = value; } }
		public decimal ValorCapitalInvestido { get { return valorCapitalInvestido; } set { valorCapitalInvestido = value; } }
		public decimal TaxaRemunaracaoAtual { get { return taxaRemuneracaoAtual; } set { taxaRemuneracaoAtual = value; } }
		public int RccMeses { get { return rccMeses; } set { rccMeses = value; } }
		public decimal ValorAnualLicenciamentoChassi { get { return valorAnualLicenciamentoChassi; } set { valorAnualLicenciamentoChassi = value; } }
		public decimal ValorInicialEquipamento { get { return valorInicialEquipamento; } set { valorInicialEquipamento = value; } }
		public int VidaUtilEquipamento { get { return vidaUtilEquipamento; } set { vidaUtilEquipamento = value; } }


	}
}
