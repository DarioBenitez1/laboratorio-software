using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using _03_Dominio.Entidades;
using _03_Dominio.Repositorio;
using _04_PersistenciaDatos.MySQLConnector;

namespace _04_PersistenciaDatos
{
    public class ProductoRepositorioMySQL : ProductoRepo
    {
        private MySqlConnection connection;

        public ProductoRepositorioMySQL()
        {
            MySQLConnectionSingleton dbSingleton = MySQLConnectionSingleton.Instance(
                "127.0.0.1",
                "test",
                "root",
                "future"
            );
            this.connection = dbSingleton.GetConnection();
        }

        public void Grabar(Producto producto)
        {
            using (MySqlCommand comando = new MySqlCommand(
                "INSERT INTO productos (id, nombre, cantidad, precio, estado) VALUES (@id, @nombre, @cantidad, @precio, @estado)",
                this.connection
            ))
            {
                comando.Parameters.Add("@id", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = producto.Id();
                comando.Parameters.Add("@nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = producto.Nombre();
                comando.Parameters.Add("@cantidad", MySql.Data.MySqlClient.MySqlDbType.Int16).Value = producto.Cantidad();
                comando.Parameters.Add("@precio", MySql.Data.MySqlClient.MySqlDbType.Int16).Value = producto.Precio();
                comando.Parameters.Add("@estado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = producto.Estado();
                comando.ExecuteNonQuery();
            }
        }

        public List<Producto> Listar()
        {
            List<Producto> productos = new List<Producto>();
            using (MySqlCommand command = new MySqlCommand(
                "SELECT id, nombre, cantidad, precio, estado FROM productos",
                this.connection
            ))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Guid id = reader.GetGuid(0);
                        String nombre = reader.GetString(1);
                        int cantidad = reader.GetInt16(2);
                        int precio = reader.GetInt16(3);
                        String estado = reader.GetString(4);

                        Producto producto = new Producto(id, nombre, cantidad, precio, estado);
                        productos.Add(producto);
                    }
                }
            }

            return productos;
        }

        public void Borrar(Guid id)
        {
            using (MySqlCommand comando = new MySqlCommand(
               "DELETE FROM productos WHERE id = @id;",
               this.connection
            ))
            {
                comando.Parameters.Add("@id", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = id;
                comando.ExecuteNonQuery();
            }
                  
        }
        public void Actualizar(Producto producto)
        {
            using (MySqlCommand comando = new MySqlCommand(
              "UPDATE productos SET id = @id, nombre = @nombre, cantidad = @cantidad, precio = @precio, estado = @estado  WHERE id = @id;",
              this.connection
           ))
            {
                comando.Parameters.Add("@id", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = producto.Id();
                comando.Parameters.Add("@nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = producto.Nombre();
                comando.Parameters.Add("@cantidad", MySql.Data.MySqlClient.MySqlDbType.Int16).Value = producto.Cantidad();
                comando.Parameters.Add("@precio", MySql.Data.MySqlClient.MySqlDbType.Int16).Value = producto.Precio();
                comando.Parameters.Add("@estado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = producto.Estado();
                comando.ExecuteNonQuery();
            }
        }
    }
}
