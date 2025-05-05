using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frete_PI_Desktop.Models
{
    public class Veiculo
    {
        private int id;
        private string placaVeiculo;
        private string renavamVeiculo;
        private string modeloVeiculo;
        private int anoFabricacaoVeiculo;
        private string corVeiculo;
        private string tipoVeiculo;
        private int capacidadeVeiculo;
        private string observacaoVeiculo;
        private string statusVeiculo;

        public int Id { get { return id; } set { id = value; } }
        public string PlacaVeiculo { get { return placaVeiculo; } set { placaVeiculo = value; } }
        public string RenavamVeiculo { get { return renavamVeiculo; } set { renavamVeiculo = value; } }
        public string ModeloVeiculo { get { return modeloVeiculo; } set { modeloVeiculo = value; } }
        public int AnoFabricacao { get { return anoFabricacaoVeiculo; } set { anoFabricacaoVeiculo = value; } }
        public string CorVeiculo { get { return corVeiculo; } set { corVeiculo = value; } }
        public string TipoVeiculo { get { return tipoVeiculo; } set { tipoVeiculo = value; } }
        public int CapacidadeVeiculo { get { return capacidadeVeiculo; } set { capacidadeVeiculo = value; } }
        public string ObservacaoVeiculo { get { return observacaoVeiculo; } set { observacaoVeiculo = value; } }
        public string StatusVeiculo { get { return statusVeiculo; } set { statusVeiculo = value; } }
    }
}
