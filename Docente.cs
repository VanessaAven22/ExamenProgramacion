using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMENPROG2
{
    class Docente
    {
        private string nombred;
        private int edad;
        private string num_id;
        private int num_tef;
        

        public Docente()
        {
        }

        public Docente(string nombred, int edad, string num_id, int num_tef)
        {
            this.nombred = nombred;
            this.edad = edad;
            this.num_id = num_id;
            this.num_tef = num_tef;
           
        }

        public string Nombred
        {
            get { return nombred; }
            set { nombred = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Num_id
        {
            get { return num_id; }
            set { num_id = value; }
        }
        public int  Num_tef
        {
            get { return num_tef; }
            set { num_tef = value; }
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombred} Edad: {this.edad} Identificacion: {this.num_id} Telefono: {this.num_tef} \n";
        }



    }

}
