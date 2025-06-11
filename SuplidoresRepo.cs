using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_1_PAvanzada
{
    public class SuplidoresRepo
    {
        private readonly IConfiguration configuration;

        public SuplidoresRepo(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IEnumerable<C_Suplidoress> GetSuplidores()
        {
            var suplidores = new List<C_Suplidoress>();
            SqlConnection connection = CreateConnection();

            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"            
SELECT Suplidores.*
FROM Suplidores";


            var datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                var suplidoress = new C_Suplidoress();
                suplidoress.id_Suplidores = (int)datareader["id_Suplidores"];
                suplidoress.Nombre_Empresa = (string)datareader["Nombre_Empresa"];
                suplidoress.Nombre_Contacto = (string)datareader["Nombre_Contacto"];
                suplidoress.Telefono = (string)datareader["Telefono"];
                suplidoress.Correo = (string)datareader["Correo"];
                suplidoress.Sitio_Web = (string)datareader["Sitio_Web"];
                suplidoress.S_Fecha_Creacion = Convert.ToDateTime(datareader["S_Fecha_Creacion"]);
                suplidoress.S_Fecha_Modificacion = Convert.ToDateTime(datareader["S_Fecha_Modificacion"]);
                suplidoress.S_EstadoId = Convert.ToInt32(datareader["S_EstadoId"]);
                suplidores.Add(suplidoress);
            }

            connection.Close();
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
        private SqlConnection CreateConnection()
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var connection = new SqlConnection(connectionString);
            return connection;
        }
        public void Create(C_Suplidoress c_Suplidoress)
        {

            SqlConnection connection = CreateConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
              
INSERT INTO [dbo].[Suplidores]
           ([Nombre_Empresa]
           ,[Nombre_Contacto]
           ,[Telefono]
           ,[Correo]
           ,[Sitio_Web]
           ,[S_EstadoId])
     VALUES
           (@Nombre_Empresa
           ,@Nombre_Contacto
           ,@Telefono
           ,@Correo
           ,@Sitio_Web
           ,@S_EstadoId)"
            ;

            command.Parameters.AddWithValue("@Nombre_Empresa", c_Suplidoress.Nombre_Empresa);
            command.Parameters.AddWithValue("@Nombre_Contacto", c_Suplidoress.Nombre_Contacto);
            command.Parameters.AddWithValue("@Telefono", c_Suplidoress.Telefono);
            command.Parameters.AddWithValue("@Correo", c_Suplidoress.Correo);
            command.Parameters.AddWithValue("@Sitio_Web", c_Suplidoress.Sitio_Web);
            command.Parameters.AddWithValue("@S_EstadoId", c_Suplidoress.S_EstadoId);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
        public void Update(C_Suplidoress c_Suplidoress)
        {

            SqlConnection connection = CreateConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
              
UPDATE [dbo].[Suplidores]
            SET 
                [Nombre_Empresa] = @Nombre_Empresa,
                [Nombre_Contacto] = @Nombre_Contacto,
                [Telefono] = @Telefono,
                [Correo] = @Correo,
                [Sitio_Web] = @Sitio_Web,
                [S_EstadoId] = @S_EstadoId,
                [S_Fecha_Modificacion] = GETDATE()
            WHERE id_Suplidores = @id_Suplidores"
            ;

            command.Parameters.AddWithValue("@id_Suplidores", c_Suplidoress.id_Suplidores);
            command.Parameters.AddWithValue("@Nombre_Empresa", c_Suplidoress.Nombre_Empresa);
            command.Parameters.AddWithValue("@Nombre_Contacto", c_Suplidoress.Nombre_Contacto);
            command.Parameters.AddWithValue("@Telefono", c_Suplidoress.Telefono);
            command.Parameters.AddWithValue("@Correo", c_Suplidoress.Correo);
            command.Parameters.AddWithValue("@Sitio_Web", c_Suplidoress.Sitio_Web);
            command.Parameters.AddWithValue("@S_EstadoId", c_Suplidoress.S_EstadoId);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
        public void Delete(int id_Sulidores)
        {
            SqlConnection connection = CreateConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
              delete from Suplidores 
              where id_Suplidores = @id_suplidores";

            command.Parameters.AddWithValue("@id_Suplidores", id_Sulidores);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
    public class C_Suplidoress
    {
        public int id_Suplidores { get; set; }
        public string Nombre_Empresa { get; set; }
        public string Nombre_Contacto { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Sitio_Web { get; set; }
        public DateTime S_Fecha_Creacion { get; set; }
        public DateTime S_Fecha_Modificacion { get; set; }
        public int S_EstadoId { get; set; }

    }
}
