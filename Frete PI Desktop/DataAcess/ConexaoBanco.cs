using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Frete_PI_Desktop.Models
{
    static class ConexaoBanco
    {
        private const string servidor = "localhost";
        private const string bancoDados = "t16_PI_Frete1";
        private const string usuario = "sa";
        private const string senha = "Jhonnata90.";

        static public string conexaoBanco = $"Server={servidor};Database={bancoDados};User Id={usuario};Password={senha};TrustServerCertificate=True;";
    }
}
