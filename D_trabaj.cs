using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GestorEmpleados
{
    private SqlConnection conn;

    public GestorEmpleados(string connectionString)
    {
        conn = new SqlConnection(connectionString);
    }

    public void AgregarEmpleado(string nombre, string ciudad, string telefono, string turno, byte activo = 1)
    {
        conn.Open();

        string consulta = "INSERT INTO EMPLEADOS (Nombre, Ciudad, Teléfono, Turno, Activo) VALUES (@nombre, @ciudad, @telefono, @turno, @activo)";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@nombre", nombre);
        comando.Parameters.AddWithValue("@ciudad", ciudad);
        comando.Parameters.AddWithValue("@telefono", telefono);
        comando.Parameters.AddWithValue("@turno", turno);
        comando.Parameters.AddWithValue("@activo", activo);

        try
        {
            comando.ExecuteNonQuery();
            MessageBox.Show("Empleado agregado con éxito");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al agregar empleado: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    public void EditarEmpleado(string nombre, string ciudad, string telefono, string turno, int id)
    {
        conn.Open();

        string consulta = "UPDATE EMPLEADOS SET Nombre = @nombre, Ciudad = @ciudad, Teléfono = @telefono, Turno = @turno WHERE IdEmpleado = @id AND Activo = 1";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@nombre", nombre);
        comando.Parameters.AddWithValue("@ciudad", ciudad);
        comando.Parameters.AddWithValue("@telefono", telefono);
        comando.Parameters.AddWithValue("@turno", turno);
        comando.Parameters.AddWithValue("@id", id);

        try
        {
            comando.ExecuteNonQuery();
            MessageBox.Show("Empleado editado con éxito");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al editar empleado: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    public void OcultarEmpleado(int id)
    {
        conn.Open();

        string consulta = "UPDATE EMPLEADOS SET Activo = 0 WHERE IdEmpleado = @id";
        SqlCommand comando = new SqlCommand(consulta, conn);
        comando.Parameters.AddWithValue("@id", id);

        try
        {
            int rowsAffected = comando.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Empleado eliminado con éxito");
            }
            else
            {
                MessageBox.Show("No se encontró el empleado con el ID proporcionado");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar empleado: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }
}
