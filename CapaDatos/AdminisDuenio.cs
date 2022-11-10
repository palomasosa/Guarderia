﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace CapaDatos
{
    public class AdminisDuenio : DatosConexion 
    {
        public int abmDuenio(string accion, Duenio objDuenio)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = $"insert into Duenio values ({objDuenio.dniProp},'{objDuenio.nombreProp}','{objDuenio.apellidoProp}',{objDuenio.telefonoProp})";
            if (accion == "Modificar")
                orden = $"update Duenio set DNI = {objDuenio.dniProp} where id = {objDuenio.idProp}; update Duenio set nombre = '{objDuenio.nombreProp}' where id = {objDuenio.idProp}; update Duenio set apellido = '{objDuenio.apellidoProp}' where id = {objDuenio.idProp}; update Duenio set telefono = {objDuenio.telefonoProp} where id = {objDuenio.idProp}; ";
            
            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Errror al tratar de guardar,borrar o modificar ",e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoDuenios(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = $"select * from Duenio where id = {int.Parse(cual)};";
            else
                orden = "select * from Duenio;";
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
                throw new Exception("Error al listar duenios", e);
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