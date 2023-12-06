using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class GestorLibros
{
    private SqlConnection conn;

    public GestorLibros(string connectionString)
    {
        conn = new SqlConnection(connectionString);
    }

    public void AgregarLibro(string titulo, string autor, string editorial, int existencia)
    {
        conn.Open();

        string consulta = "INSERT INTO LIBROS VALUES (@Titulo, @Autor, @Editorial, @Existencia)";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@Titulo", titulo);
        comando.Parameters.AddWithValue("@Autor", autor);
        comando.Parameters.AddWithValue("@Editorial", editorial);
        comando.Parameters.Add("@Existencia", SqlDbType.Int).Value = existencia;

       // comando.Parameters.AddWithValue("@Existencia", existencia);

        try
        {
            comando.ExecuteNonQuery();
            MessageBox.Show("Libro Agregado Con éxito");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al agregar Libro: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }
}