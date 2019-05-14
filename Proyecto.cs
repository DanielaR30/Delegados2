using System;
using System.Collections.Generic;
using System.Text;

namespace Delegados
{
    class Proyecto
    {
        public List<Proyecto> proyectos = new List<Proyecto>();

        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }

        public List<Proyecto> AgregarProyecto()
        {
            Console.WriteLine("Escriba Y para ingresar");
            var res = Console.ReadLine();
            while( res == "Y")
            {
                Console.WriteLine("Escriba el nombre del proyecto");
                var nom = Console.ReadLine();
                Console.WriteLine("Escriba el codigo del proyecto");
                var cod = Console.ReadLine();
                var miProyecto = new Proyecto()
                {
                    Nombre = nom,
                    Codigo = int.Parse(cod)
                };
                proyectos.Add(miProyecto);
                Console.WriteLine("Escriba Y para ingresar");
                res = Console.ReadLine();
            }
            return proyectos;
        }
        public List<Proyecto> AgregarProyecto2()
        {
            var proys = new List<Proyecto>() {
                new Proyecto()
                {
                    Nombre = "Bancaria",
                    Codigo = 23,
                    Area = "Comercio",
                    Duracion = 6
                },
                new Proyecto()
                {
                    Nombre = "Mercadeo",
                    Codigo = 23,
                    Area = "Talento Humano",
                    Duracion = 12
                },
                new Proyecto()
                {
                    Nombre = "Atencion Primaria",
                    Codigo = 27,
                    Area = "AIPI",
                    Duracion = 18
                },
                new Proyecto()
                {
                    Nombre = "Adsi",
                    Codigo = 32,
                    Area = "Sistemas",
                    Duracion = 24
                },
                new Proyecto()
                {
                    Nombre = "Gastronomia",
                    Codigo = 29,
                    Area = "Postres",
                    Duracion = 12
                }
            };
            return proys;
        }
        public void ImprimirProyectos(List<Proyecto>anonimo) {
            foreach (var item in anonimo)
            {
                    Console.WriteLine($"{item.Nombre}");
                    Console.WriteLine($"____{item.Codigo}___");
                    Console.WriteLine($"{item.Area}");
                    Console.WriteLine($"{item.Duracion}");
            }
        }
        public void prueba(){
           
        }        
    }
}
