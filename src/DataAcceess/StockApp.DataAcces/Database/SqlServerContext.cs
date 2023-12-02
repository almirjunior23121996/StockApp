using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAcces.Database
{
    internal class SqlServerContext
    {
        internal static string ConexaoSemBanco => @"Data Source=.\SQLEXPRESS;Initial Catalog=StockPhone;User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";
        internal static string ConexaoComBanco => @"Data Source=.\SQLEXPRESS;Initial Catalog=StockPhone;User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";
    }
}
