using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();

            Pacientes data1 = new Pacientes(5, "Pedro", "Caceres Pérez");
            Pacientes data2 = new Pacientes(2, "Lucero", "Arostegui Rieta");
            Pacientes data3 = new Pacientes(10, "Lucia", "Mendez Palomo");
            Pacientes data4 = new Pacientes(100, "Luis Miguel", "Rodriguez Pardo");
            Pacientes data5 = new Pacientes(1, "Yumi", "Diaz Lopez");
            Pacientes data6 = new Pacientes(3, "Melisa", "Molleda Vargas");

            arbol.InsertarNodo(data1);
            arbol.InsertarNodo(data2);
            arbol.InsertarNodo(data3);
            arbol.InsertarNodo(data4);
            arbol.InsertarNodo(data5);
            arbol.InsertarNodo(data6);
     
            Console.WriteLine("Sistema de almacenamiento de Fichas Médicas: Maku Consulting");


            Console.WriteLine("\nDatos Preorder:\n");
            arbol.Preorden(arbol.GetRaiz());

            Console.WriteLine("\nDatos Inorder:\n");
            arbol.Inorden(arbol.GetRaiz());

            Console.WriteLine("\nDatos Postorder:\n");
            arbol.Postorden(arbol.GetRaiz());
    
            Console.WriteLine("\nEliminar ID Ficha: 100 y 1\n");
            arbol.Eliminar(arbol.GetRaiz(), data4.id);
            arbol.Eliminar(arbol.GetRaiz(), data5.id);


            Console.WriteLine("\nDatos Preorder:\n");
            arbol.Preorden(arbol.GetRaiz());

            Console.WriteLine("\nDatos Inorder:\n");
            arbol.Inorden(arbol.GetRaiz());

            Console.WriteLine("\nDatos Postorder:\n");
            arbol.Postorden(arbol.GetRaiz());

            Console.ReadKey();
        }
    }
}
