using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Duenio
    {

        #region Atributos
        private string nombre;
        public string apellido;
        public long telefono;
        public long DNI;
        #endregion

        #region Propiedades
        public string nombreProp
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string apellidoProp
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public long telefonoProp
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public long dniProp
        {
            get { return DNI; }
            set { DNI = value; }
        }
        #endregion

        #region Constructores
        public Duenio() { }
        public Duenio(string nom, string ape, long tel, long dni)
        {
            nombre = nom;
            apellido = ape;
            telefono = tel;
            DNI = dni;
        }
        #endregion

        #region Metodos

        #endregion
    }
}
