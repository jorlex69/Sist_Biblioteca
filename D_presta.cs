using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GestorPrestamos
{
    private SqlConnection conn;

    public GestorPrestamos(string connectionString)
    {
        conn = new SqlConnection(connectionString);
    }

    public void AgregarPrestamo(string tituloLibro, string idEmpleado, int idEstudiante, string nombreEstudiante, DateTime fechaPrestamo, DateTime fechaDevolucion, int dias, string estado, byte activo = 1)
    {
        conn.Open();

        string consulta = "INSERT INTO PRESTAMOS (Titulo_Libro, IdEmpleado, IdEstudiante, Nombre_Estudiante, Fech_Prestamo, Fecha_Devolución, Días, Estado, Activo) VALUES (@tituloLibro, @idEmpleado, @idEstudiante, @nombreEstudiante, @fechaPrestamo, @fechaDevolucion, @dias, @estado, @activo)";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@tituloLibro", tituloLibro);
        comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
        comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
        comando.Parameters.AddWithValue("@nombreEstudiante", nombreEstudiante);
        comando.Parameters.AddWithValue("@fechaPrestamo", fechaPrestamo);
        comando.Parameters.AddWithValue("@fechaDevolucion", fechaDevolucion);
        comando.Parameters.AddWithValue("@dias", dias);
        comando.Parameters.AddWithValue("@estado", estado);
        comando.Parameters.AddWithValue("@activo", activo);

        try
        {
            comando.ExecuteNonQuery();
            MessageBox.Show("Préstamo agregado con éxito");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al agregar préstamo: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    public void EditarPrestamo(string tituloLibro, string idEmpleado, int idEstudiante, string nombreEstudiante, DateTime fechaPrestamo, DateTime fechaDevolucion, int dias, string estado, int id)
    {
        conn.Open();

        string consulta = "UPDATE PRESTAMOS SET Titulo_Libro = @tituloLibro, IdEmpleado = @idEmpleado, IdEstudiante = @idEstudiante, Nombre_Estudiante = @nombreEstudiante, Fech_Prestamo = @fechaPrestamo, Fecha_Devolución = @fechaDevolucion, Días = @dias, Estado = @estado WHERE IdPrestamo = @id AND Activo = 1";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@tituloLibro", tituloLibro);
        comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
        comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
        comando.Parameters.AddWithValue("@nombreEstudiante", nombreEstudiante);
        comando.Parameters.AddWithValue("@fechaPrestamo", fechaPrestamo);
        comando.Parameters.AddWithValue("@fechaDevolucion", fechaDevolucion);
        comando.Parameters.AddWithValue("@dias", dias);
        comando.Parameters.AddWithValue("@estado", estado);
        comando.Parameters.AddWithValue("@id", id);

        try
        {
            comando.ExecuteNonQuery();
            MessageBox.Show("Préstamo editado con éxito");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al editar préstamo: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    public void OcultarPrestamo(int id)
    {
        conn.Open();

        string consulta = "UPDATE PRESTAMOS SET Activo = 0 WHERE IdPrestamo = @id";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@id", id);

        try
        {
            int rowsAffected = comando.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Préstamo eliminado con éxito");
            }
            else
            {
                MessageBox.Show("No se encontró el préstamo con el ID proporcionado");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar préstamo: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }
}
