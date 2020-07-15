using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMENPROG2
{
    class Periodo
    {
        private DateTime fecha_In;
        private DateTime fecha_fin;
        private string descripcion;
        private List<Curso> curs_disp;

        public Periodo()
        {
        }

        public Periodo(DateTime fecha_In, DateTime fecha_fin, string descripcion, List<Curso> curs_disp)
        {
            this.fecha_In = fecha_In;
            this.fecha_fin = fecha_fin;
            this.descripcion = descripcion;
            this.curs_disp = curs_disp;
        }

        public DateTime Fecha_In
        {
            get { return fecha_In; }
            set { fecha_In = value; }
        }
        public DateTime Fecha_fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public List<Curso> Curs_disp
        {
            get { return curs_disp; }
            set { curs_disp = value; }
        }
        
        
        public override string ToString()
        {
            return $"Fecha Inicio: {this.fecha_In} Fecha Final: {this.fecha_fin} Descripcion: {this.descripcion}";
        }
    }
}
     



    

