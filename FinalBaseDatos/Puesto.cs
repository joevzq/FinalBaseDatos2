using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBaseDatos
{
    class Puesto
    {
        public static List<Puesto> lstPuestos = new List<Puesto>();
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private long salarioBase;

        public long SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }
    }
}
