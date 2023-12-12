using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GestorEstudiantes
{
    private SqlConnection conn;

    public GestorEstudiantes(string connectionString)
    {
        conn = new SqlConnection(connectionString);
    }

    public void AgregarEstudiante(string nombre, string ciudad, string telefono, string carrera, byte activo = 1)
    {
        conn.Open();

        string consulta = "INSERT INTO ESTUDIANTES (Nombre, Ciudad, Teléfono, Carrera, Activo) VALUES (@nombre, @ciudad, @telefono, @carrera, @activo)";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@nombre", nombre);
        comando.Parameters.AddWithValue("@ciudad", ciudad);
        comando.Parameters.AddWithValue("@telefono", telefono);
        comando.Parameters.AddWithValue("@carrera", carrera);
        comando.Parameters.AddWithValue("@activo", activo);

        try
        {
            comando.ExecuteNonQuery();
            MessageBox.Show("Estudiante agregado con éxito");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al agregar estudiante: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    public void EditarEstudiante(string nombre, string ciudad, string telefono, string carrera, int id)
    {
        conn.Open();

        string consulta = "UPDATE ESTUDIANTES SET Nombre = @nombre, Ciudad = @ciudad, Teléfono = @telefono, Carrera = @carrera WHERE IdEstudiante = @id AND Activo = 1";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@nombre", nombre);
        comando.Parameters.AddWithValue("@ciudad", ciudad);
        comando.Parameters.AddWithValue("@telefono", telefono);
        comando.Parameters.AddWithValue("@carrera", carrera);
        comando.Parameters.AddWithValue("@id", id);

        try
        {
            comando.ExecuteNonQuery();
            MessageBox.Show("Estudiante editado con éxito");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al editar estudiante: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    public void OcultarEstudiante(int id)
    {
        conn.Open();

        string consulta = "UPDATE ESTUDIANTES SET Activo = 0 WHERE IdEstudiante = @id";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@id", id);

        try
        {
            int rowsAffected = comando.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Estudiante eliminado con éxito");
            }
            else
            {
                MessageBox.Show("No se encontró el estudiante con el ID proporcionado");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar estudiante: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }
}
