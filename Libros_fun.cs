using EncriptandoTexto;
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

    public void AgregarLibro(string titulo, string autor, string editorial, int existencia, byte ac = 1)
    {
        conn.Open();


        string consulta = "INSERT INTO LIBROS   (Titulo, Autor, Editorial, Activo, Existencia  ) VALUES (@titulo, @autor, @editorial, @activo, @existencia)";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@Titulo", titulo);
        comando.Parameters.AddWithValue("@Autor", autor);
        comando.Parameters.AddWithValue("@Editorial", editorial);
        comando.Parameters.AddWithValue("@activo", ac);
        comando.Parameters.Add("@Existencia", SqlDbType.Int).Value = existencia;
        

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

    public void EditarLibros(string titulo, string autor, string editorial, int existencia, int id)
    {
        conn.Open();


        string consulta = "UPDATE LIBROS SET Titulo = @titulo, Autor = @autor, Editorial = @editorial,  Existencia = @existencia WHERE IdLibro = @id AND Activo = 1";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@Titulo", titulo);
        comando.Parameters.AddWithValue("@Autor", autor);
        comando.Parameters.AddWithValue("@Editorial", editorial);
        comando.Parameters.Add("@Existencia", SqlDbType.Int).Value = existencia;
        comando.Parameters.Add("@id", SqlDbType.Int).Value = id;

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


    public void Ocultarlibro(int id)
    {
        conn.Open();

        string consulta = "UPDATE LIBROS SET Activo = 0 WHERE IdLibro = @id ";
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