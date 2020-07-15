using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMENPROG2
{
    class Curso
    {
        private string nombre;
        private string descripcion;
        private Docente docente;
        
        public Curso()
        {
        }

        public Curso(string nombre, string descripcion, Docente docente)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.docente = docente;
          
        }

        public string Nombre   
        {
            get { return nombre; }  
            set { nombre = value; }  
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Docente Docente
        {
            get { return docente; }
            set { docente = value; }
        }


        public override string ToString()
        {
            return $"Nombre: {this.nombre} Descripción: {this.descripcion}";
        }


    }







}
