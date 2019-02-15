using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_POO
{
    public class FiguraGeometrica
    {
        private int id;
        private string nombre;
        private double lado1;
        private double lado2;
        private string descripcion;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }
        public double Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public void CrearFiguraGeometrica(FiguraGeometrica nuevaFigura)
        {

        }

        public void CalcularArea(FiguraGeometrica figura)
        {

        }
        public void CalcularPerimetro(FiguraGeometrica figura)
        {

        }

    }
}
