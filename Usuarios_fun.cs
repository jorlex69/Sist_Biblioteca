using Microsoft.Data.SqlClient;
using Sist_Biblioteca.Diseños;
using System.Security.Cryptography;
using System.Text;
namespace EncriptandoTexto;

public class GestorUsuarios
{
    private SqlConnection conn;

    public GestorUsuarios(string connectionString)
    {
        conn = new SqlConnection(connectionString);
    }

    public void AgregarUsuario(string nombre, string correo, string Rol, string contrasena, byte ac = 1)
    {
        conn.Open();

        string consulta = "INSERT INTO USUARIOS (Nombre, Correo, Password, Rol, Activo) VALUES (@nombre, @Correo, @Password, @Rol, @Activo)";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@nombre", nombre);
        comando.Parameters.AddWithValue("@Correo", correo);
        comando.Parameters.AddWithValue("@Password", Encrypt.GetSHA256(contrasena));
        comando.Parameters.AddWithValue("@Activo", ac);
        comando.Parameters.AddWithValue("@Rol", Rol);

        try
        {
            comando.ExecuteNonQuery();
            MessageBox.Show("Usuario Agregado Con éxito");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al agregar usuario: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }


    public void EditarUsuario(string nombre, string correo, string contrasena ,int id)
    {
        conn.Open();

        string consulta = "UPDATE USUARIOS SET Nombre= @nombre, Correo= @Correo, Password = @password WHERE ID = @id";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@nombre", nombre);
        comando.Parameters.AddWithValue("@Correo", correo);
        comando.Parameters.AddWithValue("@password", Encrypt.GetSHA256(contrasena));
        comando.Parameters.AddWithValue("@id", id);

        try
        {
            comando.ExecuteNonQuery();
            MessageBox.Show("Usuario Editado Con éxito");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al Editar usuario: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    public void OcultarUsuario(int id)
    {
        conn.Open();

        string consulta = "UPDATE USUARIOS SET Activo = 0 WHERE ID = @id";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@id", id);

        try
        {
            int rowsAffected = comando.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Usuario Eliminado con éxito");
            }
            else
            {
                MessageBox.Show("No se encontró el usuario con el ID proporcionado");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al Eliminar usuario: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }

  
}



