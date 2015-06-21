using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBaseDatos
{
    public class Empleado
    {
        public static List<Empleado> lstEmpleados = new List<Empleado>();

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
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        private DateTime fechaIngreso;

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }

        }
        private Puesto puesto;

        internal Puesto Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        private List<Pago> pagos;

        public List<Pago> Pagos
        {
            get { return pagos; }
            set { pagos = value; }
        }
    }
}
