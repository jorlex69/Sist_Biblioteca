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

    public void AgregarUsuario(string nombre, string correo, string contrasena)
    {
        conn.Open();

        string consulta = "INSERT INTO USUARIOS VALUES (@nombre, @Correo, @contrasena)";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@nombre", nombre);
        comando.Parameters.AddWithValue("@Correo", correo);
        comando.Parameters.AddWithValue("@contrasena", Encrypt.GetSHA256(contrasena));

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

 


}

    

