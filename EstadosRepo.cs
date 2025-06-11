using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_PAvanzada
{
    public class EstadosRepo
    {
        public IConfiguration configuration;
        public EstadosRepo(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

       
        public IEnumerable<C_Estados> GetEstados()
        {
            var estados = new List<C_Estados>();
            SqlConnection connection = CreateConnection();
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = @"Select e.id_Estado, e.Nombre_Estado
                from Estados e";


            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                C_Estados estado = new C_Estados();
                estado.id_Estado = (int)reader["id_Estado"];
                estado.Nombre_Estado = (string)reader["Nombre_Estado"];
                estados.Add(estado);
            }
            connection.Close();
            return estados;
        }
    

        private SqlConnection CreateConnection()
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var connection = new SqlConnection(connectionString);
            return connection;
        }
    }


    public class C_Estados
    {
        public int id_Estado { get; set; }
        public string Nombre_Estado { get; set; }
    }
}
