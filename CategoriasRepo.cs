using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_PAvanzada
{
    public class CategoriasRepo
    {
        public readonly IConfiguration configuration;

        public CategoriasRepo(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IEnumerable<C_Categorias> GetCategorias()
        {
            var categorias = new List<C_Categorias>();
            SqlConnection sqlConnection = CreateConnection();

            sqlConnection.Open();
            var command = sqlConnection.CreateCommand();
            command.CommandText = @"Select Categorias.* from Categorias";

            var datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                var categorias1 = new C_Categorias();
                categorias1.id_Categorias = (int)datareader["id_Categorias"];
                categorias1.Nombre_Categoria = (string)datareader["Nombre_Categoria"];
                categorias1.Descripcion = (string)datareader["Descripcion"];
                categorias1.C_Fecha_Creacion = (DateTime)datareader["C_Fecha_Creacion"];
                categorias1.C_Fecha_Modificacion = (DateTime)datareader["C_Fecha_Modificacion"];
                categorias1.C_EstadoId = (int)datareader["C_EstadoId"];
                categorias.Add(categorias1);
            }
            sqlConnection.Close();
            return categorias;
        }

        public void Create(C_Categorias c_Categorias)
        {
            SqlConnection sqlConnection = CreateConnection();
            var command = sqlConnection.CreateCommand();
            command.CommandText =
                @"Insert into Categorias (Nombre_Categoria,Descripcion,C_EstadoId)
                 Values (@Nombre_Categoria,@Descripcion,@C_EstadoId)
                ";

            command.Parameters.AddWithValue("@Nombre_Categoria", c_Categorias.Nombre_Categoria);
            command.Parameters.AddWithValue("@Descripcion", c_Categorias.Descripcion);
            command.Parameters.AddWithValue("@C_EstadoId", c_Categorias.C_EstadoId);

            sqlConnection.Open();
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void Update(C_Categorias c_Categorias)
        {

            SqlConnection connection = CreateConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
              
            UPDATE [dbo].[Categorias]
            SET 
                [Nombre_Categoria] = @Nombre_Categoria,
                [Descripcion] = @Descripcion,
                [C_EstadoId] = @C_EstadoId,
                [C_Fecha_Modificacion] = GETDATE()
            WHERE id_Categorias = @id_Categorias"
            ;

            command.Parameters.AddWithValue("@id_Categorias", c_Categorias.id_Categorias);
            command.Parameters.AddWithValue("@Nombre_Categoria", c_Categorias.Nombre_Categoria);
            command.Parameters.AddWithValue("@Descripcion", c_Categorias.Descripcion);
            command.Parameters.AddWithValue("@C_EstadoId", c_Categorias.C_EstadoId);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
        public void Delete(int id_Categorias)
        {
            SqlConnection connection = CreateConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
              delete from Categorias 
              where id_Categorias = @id_Categorias";

            command.Parameters.AddWithValue("@id_Categorias", id_Categorias);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }



        private SqlConnection CreateConnection()
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var connection = new SqlConnection(connectionString);
            return connection;
        }
    }
    public class C_Categorias
    {
        public int id_Categorias { get; set; }
        public string Nombre_Categoria { get; set; }
        public string Descripcion { get; set; }
        public DateTime C_Fecha_Creacion { get; set; }
        public DateTime C_Fecha_Modificacion { get; set; }
        public int C_EstadoId { get; set; }
    }
}
