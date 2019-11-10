using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotores
{
    class Producto
    {
        int codigo;
        string nombre;
        double precio;
        int tipo;
        string color;
        string detalle;
        int modelo;
        int stock_min;
        int stock_actual;

        public int pCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double pPrecio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int pTipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string pColor
        {
            get { return color; }
            set { color = value; }
        }

        public string pDetalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public int pModelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int pStockMin
        {
            get { return stock_min; }
            set { stock_min = value; }
        }

        public int pStockActual
        {
            get { return stock_actual; }
            set { stock_actual = value; }
        }

        public string toString()
        {
            return "Producto: " + this.nombre + " Precio: " + this.precio;
        }
    }
}
