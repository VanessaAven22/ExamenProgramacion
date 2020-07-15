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
            per.Add(new Periodo(new DateTime(2020, 4, 15), new DateTime(2020, 8, 15), "II cuatrimestre", new List<Curso>{curs[3]}));

            int prd = 0;
            do
            {
                Console.WriteLine("Ingrese el periodo para ver los cursos disponibles");

                for (int i = 0; i < per.Count; i++)
                {
                    Console.WriteLine($"{i}. {per[i].ToString()}");
                }

                prd = Convert.ToInt32(Console.ReadLine());
            } while (prd >= per.Count || prd < 0);


            Periodo p1 = per[prd];

            Console.WriteLine("Cursos del Período");

            foreach(var c in p1.Curs_disp)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine();

            Console.WriteLine("Docentes disponibles");

            foreach (var c in p1.Curs_disp)
            {
                Console.WriteLine(c.Docente.ToString());
            }

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


            Console.WriteLine();



            Console.WriteLine("Docentes");
            foreach (var d in doc)
            {
                Console.WriteLine(d.ToString());
            }
            Console.WriteLine("Cursos");
            Console.WriteLine();
            foreach (var c in curs)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("Periodos");
            Console.WriteLine();
            foreach (var pr in per)
            {
                Console.WriteLine(pr.ToString());
            }
            Console.WriteLine();











        }
    }
}
