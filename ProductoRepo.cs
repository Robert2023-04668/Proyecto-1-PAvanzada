using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_PAvanzada
{
    public class ProductoRepo
    {

        public IConfiguration configuration;
        public ProductoRepo(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IEnumerable<C_Productos> GetProductos()
        {
            var products = new List<C_Productos>();
            SqlConnection connection = CreateConnection();

            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"select Productos.*
from Productos";

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var Productos = new C_Productos();
                Productos.Id = (int)reader["id"];
                Productos.Nombre_Producto = (string)reader["Nombre_Producto"];
                Productos.Descripcion_Producto = (string)reader["Descripcion_Producto"];
                Productos.Precio_Unitario = (decimal)reader["Precio_Unitario"];
                Productos.P_Fecha_Creacion = (DateTime)reader["P_Fecha_Creacion"];
                Productos.P_Fecha_Modificacion = (DateTime)reader["P_Fecha_Modificacion"];
                Productos.P_EstadoId = (int)reader["P_EstadoId"];
                Productos.id_Categoria = (int)reader["id_Categoria"];
                Productos.id_Suplidor = (int)reader["id_Suplidor"];

                products.Add(Productos);
            }
           
            connection.Close();
            return products;
            
        }

        public IEnumerable<C_Categorias> GetCategorias()
        {
            var categorias = new List<C_Categorias>();
            SqlConnection sqlConnection = CreateConnection();

            sqlConnection.Open();
            var command = sqlConnection.CreateCommand();
            command.CommandText = @"select Categorias.id_Categorias,Categorias.Nombre_Categoria
from Categorias";

            var datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                var categorias1 = new C_Categorias();
                categorias1.id_Categorias = (int)datareader["id_Categorias"];
                categorias1.Nombre_Categoria = (string)datareader["Nombre_Categoria"];
                categorias.Add(categorias1);
            }
            sqlConnection.Close();
            return categorias;
        }

        public IEnumerable<C_Suplidoress> GetSuplidores()
        {
            var suplidores = new List<C_Suplidoress>();
            using (var connection = CreateConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT id_Suplidores, Nombre_Empresa FROM Suplidores";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    suplidores.Add(new C_Suplidoress
                    {
                        id_Suplidores = (int)reader["id_Suplidores"],
                        Nombre_Empresa = (string)reader["Nombre_Empresa"]
                    });
                }
            }
            return suplidores;
        }

        public IEnumerable<C_Estados> GetEstados()
        {
            var estados = new List<C_Estados>();
            SqlConnection connection = CreateConnection();
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = @"Select id_Estado, Nombre_Estado
                from Estados ";


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

        public void create (C_Productos c_Productos)
        {
            var connection = CreateConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
INSERT INTO [dbo].[Productos]
           ([Nombre_Producto]
           ,[Descripcion_Producto]
           ,[Precio_Unitario]
           ,[P_EstadoId]
           ,[id_Categoria]
           ,[id_Suplidor])
     VALUES
           (@Nombre_Producto
           ,@Descripcion_Producto
           ,@Precio_Unitario
           ,@P_EstadoId
           ,@id_Categoria
           ,@id_Suplidor)";
            
           command.Parameters.AddWithValue("@Nombre_Producto", c_Productos.Nombre_Producto);
           command.Parameters.AddWithValue("@Descripcion_Producto", c_Productos.Descripcion_Producto);
           command.Parameters.AddWithValue("@Precio_Unitario", c_Productos.Precio_Unitario);
           command.Parameters.AddWithValue("@P_EstadoId", c_Productos.P_EstadoId);
           command.Parameters.AddWithValue("@id_Categoria", c_Productos.id_Categoria);
           command.Parameters.AddWithValue("@id_Suplidor", c_Productos.id_Suplidor);


            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update (C_Productos c_Productos)
        {
            var connection = CreateConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
          UPDATE [dbo].[Productos]
          SET [Nombre_Producto] = @Nombre_Producto
         ,[Descripcion_Producto] = @Descripcion_Producto
         ,[Precio_Unitario] = @Precio_Unitario
         ,[P_Fecha_Modificacion] = GETDATE()
         ,[P_EstadoId] = @P_EstadoId
         ,[id_Categoria] = @id_Categoria
         ,[id_Suplidor] = @id_Suplidor
          WHERE id = @id";
            command.Parameters.AddWithValue("@id", c_Productos.Id);
            command.Parameters.AddWithValue("@Nombre_Producto", c_Productos.Nombre_Producto);
            command.Parameters.AddWithValue("@Descripcion_Producto", c_Productos.Descripcion_Producto);
            command.Parameters.AddWithValue("@Precio_Unitario", c_Productos.Precio_Unitario);
            command.Parameters.AddWithValue("@P_EstadoId", c_Productos.P_EstadoId);
            command.Parameters.AddWithValue("@id_Categoria", c_Productos.id_Categoria);
            command.Parameters.AddWithValue("@id_Suplidor", c_Productos.id_Suplidor);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int  id)
        {
            var connection = CreateConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"Delete from Productos where id = @id";
            command.Parameters.AddWithValue("id",id);
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

    public class C_Productos
    {
        public int Id { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion_Producto { get; set; }
        public decimal Precio_Unitario { get; set; }
        public DateTime P_Fecha_Creacion { get; set; }
        public DateTime P_Fecha_Modificacion { get; set; }
        public int P_EstadoId { get; set; }
        public int id_Categoria { get; set; }
        public int id_Suplidor { get; set; }
       
    }

   
}
