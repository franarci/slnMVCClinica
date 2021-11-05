using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Admin
{
    public static class AdmMedico
    {
    //    public static List<Medico> Listar()  //Modelo conectado
    //    {
    //        string consulta = "SELECT Id,Nombre,Apellido,NroMatricula,EspecialidadId FROM dbo.Medico";
    //
    //        SqlCommand comando = new SqlCommand(consulta, AdminDB.ConectarBase());
    //        SqlDataReader reader;
    //
    //        //crear el reader
    //        reader = comando.ExecuteReader();
    //
    //        //Recorrer leer los datos hacia adelante
    //        List<Medico> lista = new List<Medico>();
    //
    //        while (reader.Read())
    //        {
    //            lista.Add(
    //                new Medico(
    //                    Convert.ToInt32(reader["Id"]),
    //                    reader["Nombre"].ToString(),
    //                    reader["Apellido"].ToString(),
    //                    Convert.ToInt32(reader["NroMatricula"]),
    //                    Convert.ToInt32(reader["EspecialidadId"])
    //                    ));
    //        }
    //        AdminDB.ConectarBase().Close();
    //        return lista;
    //    }
    //
    //    public static DataTable Listar(int especialidadId)
    //    {
    //        string consultaSQL = "select Id,Nombre,Apellido,NroMatricula,EspecialidadId from dbo.Medico where EspecialidadId=@EspecialidadId";
    //
    //        SqlConnection conexion = AdminDB.ConectarBase();
    //
    //        SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, conexion);
    //
    //
    //        adapter.SelectCommand.Parameters.Add("@EspecialidadId", SqlDbType.Int).Value = especialidadId;
    //
    //        DataSet ds = new DataSet();
    //
    //        adapter.Fill(ds, "Especialidad");
    //
    //        AdminDB.ConectarBase().Close();
    //        return ds.Tables["Especialidad"];
    //    }
    //
    //    public static int Crear(Medico medico)
    //    {
    //        string consulta = "INSERT INTO dbo.Medico(Nombre,Apellido,NroMatricula,EspecialidadId)VALUES(@Nombre ,@Apellido,@Matricula,@Especialidad)";
    //        SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConectarBase());
    //
    //
    //        adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = medico.Nombre;
    //        adapter.SelectCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = medico.Apellido;
    //        adapter.SelectCommand.Parameters.Add("@Matricula", SqlDbType.Int).Value = medico.NroMatricula;
    //        adapter.SelectCommand.Parameters.Add("@Especialidad", SqlDbType.Int, 50).Value = medico.EspecialidadId;
    //
    //        int filasAfectadas = adapter.SelectCommand.ExecuteNonQuery();
    //
    //        AdminDB.ConectarBase().Close();
    //        return filasAfectadas;
    //    }
    //
    //    public static DataTable TraerUno(int id)
    //    {
    //        string querySql = "SELECT Id,Nombre,Apellido,NroMatricula,EspecialidadId FROM dbo.Medico WHERE Id = @Id";
    //
    //        SqlDataAdapter adapter = new SqlDataAdapter(querySql, AdminDB.ConectarBase());
    //
    //        //Declarar parametros
    //        adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;
    //
    //        //Crear DataSet
    //        DataSet ds = new DataSet();
    //        adapter.Fill(ds, "Medico");
    //
    //        AdminDB.ConectarBase().Close();
    //        return ds.Tables["Medico"];
    //    }
    //
    //    public static int Eliminar(int id)
    //    {
    //        string consulta = "DELETE FROM dbo.Medico WHERE Id = @Id";
    //
    //        SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConectarBase());
    //
    //        adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;
    //        int filasAfectadas = adapter.SelectCommand.ExecuteNonQuery();
    //
    //        AdminDB.ConectarBase().Close();
    //        return filasAfectadas;
    //    }
    //
    //    public static int Modificar(Medico medico)
    //    {
    //        string consulta = "UPDATE dbo.Medico SET Nombre = @Nombre ,Apellido = @Apellido,NroMatricula = @NroMatricula, EspecialidadId = @EspecialidadId WHERE Id = @Id";
    //
    //
    //        SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConectarBase());
    //        adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = medico.Nombre;
    //        adapter.SelectCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = medico.Apellido;
    //        adapter.SelectCommand.Parameters.Add("@NroMatricula", SqlDbType.Int).Value = medico.NroMatricula;
    //        adapter.SelectCommand.Parameters.Add("@EspecialidadId", SqlDbType.Int, 50).Value = medico.EspecialidadId;
    //        adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = medico.Id;
    //
    //        int filasAfectadas = adapter.SelectCommand.ExecuteNonQuery();
    //
    //        AdminDB.ConectarBase().Close();
    //        return filasAfectadas;
    //    }
    }
}
