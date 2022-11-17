using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Globalization;

namespace CapaDatos
{
    public class AdminisMascota : DatosConexion
    {
        public int abmMascota(string accion, Mascota objMascota)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = $"insert into Mascota values ('{objMascota.nombreProp}','{objMascota.tipoProp}','{objMascota.observacionProp}','{objMascota.fechaNacimientoProp}','{objMascota.retiradoProp}',{objMascota.duenioIdProp})";
            if (accion == "Modificar")
                orden = $"update Mascota set nombre = '{objMascota.nombreProp}' where id = {objMascota.idProp}; update Mascota set tipo = '{objMascota.tipoProp}' where id = {objMascota.idProp}; update Mascota set observacion = '{objMascota.observacionProp}' where id = {objMascota.idProp}; update Mascota set fechaNacimiento = '{objMascota.fechaNacimientoProp}' where id = {objMascota.idProp}; update Mascota set retirado = '{objMascota.retiradoProp}' where id = {objMascota.idProp}; update Mascota set duenioId = {objMascota.duenioIdProp} where id = {objMascota.idProp};";
            if (accion == "Baja")
                orden = $"delete from Mascota where id = {objMascota.idProp}; ";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Errror al tratar de guardar,borrar o modificar {objMascota} ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoMascotas(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = $"select * from Mascota where id = {int.Parse(cual)};";
            else
                orden = "select * from Mascota;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar mascotas", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet listadoMascotasBusqueda(string cual)
        {
            string orden = $"select * from Mascota where id like '%{cual}%' or nombre like '%{cual}%' or tipo like '%{cual}%' or observacion like '%{cual}%' or fechaNacimiento like '%{cual}%';";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar la mascota", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

    }
}
