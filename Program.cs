using System;
using System.Linq;

namespace Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Proyecto project = new Proyecto();
            project.proyectos = project.AgregarProyecto2();
            var proys = project.proyectos;


            //1 Obtener los proyectos cuya duracion sea mayor a 6 y menor a 12
            Console.WriteLine("Proyectos con duración mayor a 6 y menor a 12");
            var Dur = proys.Where(x => x.Duracion > 6 &&  x.Duracion < 12).ToList();
            project.ImprimirProyectos(Dur);

            //"2 Proy que empiecen por b
            Console.WriteLine("proyectos que empiezan por S");
            var proyectoB=from p in Proys
                          where (p.Nombre.StartsWhith("S"))
                          select p;

            //3 Proy con codigo mutiplo de 7
            Console.WriteLine("Proyectos con codigo mutiplo de 7");
            var multiplos = proys.Where(x => x.Codigo % 7 ==0).ToList();
            project.ImprimirProyectos(multiplos);
            
            //4 Agrupar proyectos con duracion >6, <10, >10
            Console.WriteLine(" proyectos con duracion mayor a 6, menor a 10 y mayor a 10");
            var durGrup = proys.GroupBy(x =>
            { if (x.Duracion >6)
                    {
                    return "Son mayores que 6";
             }else if (x.Duracion <10)
                    {
                    return "Son menores que 10";
              }
                else
                    {
                    return "Son mayores que 10";
                    }
                
             });

            foreach (var grupoPro in durGrup)
                {
                console.WriteLine("Grupo de proyectos"+ grupoPro.key + "Duración"+ grupoPro.Count());
                }

            //5 Promedio de la duracion de los proyectos
            Console.WriteLine("Promedio de duración de todos los proyectos");
            var prom = proys.Average(x => x.Duracion);
            Console.WriteLine("El promedio de la duración de todos los proyectos es:"+ prom);
            Console.WriteLine();

            //6 Nombre del proyecto con mas duración
            Console.WriteLine("Proyecto con mas duración");
            var maxDur = Proys.Max(x => x.Duracion);
            Console.WriteLine("El proyecto con mayor duracion es:"+ maxDur);
            Console.WriteLine();
            
            //7 seleccionar el nombre y el area del proyecto con duracion mayor a seis
            Console.WriteLine("Nombre y area del proyecto con duracion mayor a seis");
            var mayor= proys.FirsOrDefault(x => x.Duracion > 6);
            if (mayor != null) {
            Console.WriteLine($"Nombre: {mayor.Nombre}");
            Console.WriteLine($"Codigo: {mayor.Codigo}");
            Console.WriteLine($"Duración: {mayor.Duracion}");
            }else
            {
                Console.WriteLine("Objeto nulo");
            }

            //8 Proyectos con duración mayor a 24
            Console.WriteLine("Proyectos con duración mayor a 24");
            var Dur = proys.Where(x => x.Duracion > 70).ToList();
            project.ImprimirProyectos(Dur);

            //9 suma de las duraciones con codigo mayor a 20
            Console.WriteLine("Suma de las duraciones con codigo mayor a 20");
            var sumDur = proys.Where(x => x.Codigo > 20).Sum(x => x.Duracion);
            Console.WriteLine("Suma de las duraciones con codigo mayor a 20" + sumDur);
            Console.WriteLine();

            //10 Tomar los dos primeros proyectos con codigo mayor a 30
            Console.WriteLine("primeros proyectos con codigo mayor a 30");
            var numPro = proys. Take(2). ToList();
            project.ImprimirProyectos(numPro);
            Console.WriteLine();
        }
    }
}
