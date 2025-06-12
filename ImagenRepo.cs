using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_PAvanzada
{
    public class ImagenRepo
    {
        public IConfiguration configuration;
        public ImagenRepo(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IEnumerable<byte[]> GetImagenPorCategoria(int idCategoria)
        {
            var imagenes = new List<byte[]>();
            SqlConnection sqlConnection = CreateConnection();

            sqlConnection.Open();
            var command = sqlConnection.CreateCommand();
            command.CommandText = @"
            SELECT i.Imagen 
            FROM Imagenes i
            INNER JOIN CategoriaImagen ci ON ci.id_Imagen = i.id_Imagen
            WHERE ci.id_Categorias = @idCategoria";
            command.Parameters.AddWithValue("@idCategoria", idCategoria);

            var datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                var imagen = (byte[])datareader["Imagen"];
                imagenes.Add(imagen);
            }

            sqlConnection.Close();
            return imagenes;
        }
        public void InsertarImagenYCategoria(byte[] imagen, int idCategoria)
        {
            SqlConnection connection = CreateConnection();

            var command = connection.CreateCommand();
            command.CommandText = @"INSERT INTO Imagenes (Imagen) OUTPUT INSERTED.id_Imagen VALUES (@Imagen)";

            command.Parameters.AddWithValue("@Imagen", imagen);
            connection.Open();
            int idImagen = (int)command.ExecuteScalar();
            connection.Close();

            command.CommandText = @"INSERT INTO CategoriaImagen (id_Categorias, id_Imagen) VALUES (@id_Categorias, @id_Imagen)";


            command.Parameters.AddWithValue("@id_Categorias", idCategoria);
            command.Parameters.AddWithValue("@id_Imagen", idImagen);
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


    public class C_Imagen
    {
        public int Id { get; set; }
        public byte[] Datos { get; set; }
    }


    public class C_CategoriaImagen
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public int ImagenId { get; set; }
    }
}
