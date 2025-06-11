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

        public byte[] GetImagenPorCategoria(int idCategoria)
        {
            byte[] imagenData = null;


            SqlConnection connection = CreateConnection();
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = @"
            SELECT i.Imagen 
            FROM Imagenes i
            INNER JOIN CategoriaImagen ci ON ci.id_Imagen = i.id_Imagen
            WHERE ci.id_Categorias = @id";

            command.Parameters.AddWithValue("@id", idCategoria);

            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                imagenData = (byte[])result;
            }
            connection.Close();
            return imagenData;
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
