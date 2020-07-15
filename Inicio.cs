using System;
using System.Collections.Generic;
using System.Linq;

namespace EXAMENPROG2
{
    class Inicio
    {
        static void Main(string[] args)
        {

            List<Docente> doc = new List<Docente>();

            doc.Add(new Docente("Maria Lopez", 45, "ML447", 84986398));
            doc.Add(new Docente("Servio Gutierrez", 38, "SG789", 87326984));
            doc.Add(new Docente("Fernando Quiroz", 30, "FG236", 84236574));
            doc.Add(new Docente("Thais Samuel", 25, "TS753", 83369542));

            List<Curso> curs = new List<Curso>();
            curs.Add(new Curso("Calculo III", "Integrales dobles y triples", doc[0]));
            curs.Add(new Curso("Español I", "Redaccion Tecnica", doc[1]));
            curs.Add(new Curso("Programacion II", "Programas en consola en C#", doc[2]));
            curs.Add(new Curso("Mercadeo I", "Estrategias de ventas en redes sociales", doc[3]));

            List<Periodo> per = new List<Periodo>();
            per.Add(new Periodo(new DateTime(2020, 4, 15), new DateTime(2020, 8, 15), "I cuatrimestre",curs.GetRange(0,3)));

            Console.WriteLine("Ingrese el periodo para ver los cursos disponibles");
            int prd = Convert.ToInt32(Console.ReadLine());
            Periodo p1 = per[prd];









            Console.WriteLine("Digite el numero de identificación");
            string id_ma = Console.ReadLine();

            var profesor = (from p in doc where (p.Num_id == id_ma) select p).First();
            if(profesor == null)
            {
                Console.WriteLine("Este maestro no existe");
            }
            else
            {
                var cursos = (from c in curs where (c.Docente == profesor) select c);
                Console.WriteLine($"El maestro es:{profesor.Nombred}\n");
                foreach (var crs in cursos)
                {
                   
                    Console.WriteLine(crs.ToString());
                }              
            }

            





            foreach (var d in doc)
            {
                Console.WriteLine(d.ToString());
            }

            foreach (var c in curs)
            {
                Console.WriteLine(c.ToString());
            }

            foreach (var pr in per)
            {
                Console.WriteLine(pr.ToString());
            }












        }
    }
}
