using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBaseDatos
{
    public class Pago
    {
        #region ATRIBUTOS
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private long descuento;

        public long Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        private long incentivo;

        public long Incentivo
        {
            get { return incentivo; }
            set { incentivo = value; }
        }
        private DateTime fechaPago;

        public DateTime FechaPago
        {
            get { return fechaPago; }
            set { fechaPago = value; }
        }
        private long pagoFinal;

        public long PagoFinal
        {
            get { return pagoFinal; }
            set { pagoFinal = value; }
        }
        #endregion

        #region METODOS
        #endregion
    }
}
