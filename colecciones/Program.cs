using System;
using System.Collections;

namespace colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
            /////////////////////////////////////////////////////////////////////////////////////////
            //declarar arraylist

            ArrayList arraylist = new ArrayList();
            
            //Agregar elementos (se incertan en la ultima posicion
            arraylist.Add(12);
            arraylist.Add("gero");
            arraylist.Add(13);

            //incertar elementos en una posicion determinada
            arraylist.Insert(0, 1);

            //mostrar el contenido de una posicion
            Console.WriteLine("Posicion{0} " + arraylist[0]);

            //eliminar un elemento en concreto
            arraylist.RemoveAt(0);

            //mostramos de nuevo para ver que se borro (otro pasa a ocupar su lugar)
            Console.WriteLine("Posicion{0} " + arraylist[0]);

            //modificar un dato
            arraylist[0] = 44;

            //conocer cantidad de elementos que contiene
            int capacidad = arraylist.Capacity;
            Console.WriteLine("capacidad " + capacidad);

            //buscar un dato para ver si existe, si no existe devuelve -1
            int indice = arraylist.IndexOf(12);
            Console.WriteLine("Buscar " + indice);

            //limpiar el arraylist por completo
            //arraylist.Clear();

            //recorrer el arraylist con foreach (solo cuando son del mismo tipo)

            /*foreach (int valor in arraylist)
            {
                Console.WriteLine("Valores: " +valor);
            }
            */

            //recorrer el arraylist con for (cuando sus datos son de distinto tipo)

            for (int i=0; i<arraylist.Count; i++)
            {
                Console.WriteLine("Valores: " + arraylist[i]);
            }
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
            /////////////////////////////////////////////////////////////////////////////////////////
            //stack o pila (LIFO)

            Stack pila = new Stack();

            //agregar un dato con push
            pila.Push(1);
            pila.Push(21);
            pila.Push(17);

            //POP extraer datos (se extrae el ultimo dato y se elimina)
            int valor = 0;
            valor = (int)pila.Pop();
            Console.WriteLine("Extraccion de la pila con eliminacion: " + valor);

            //PEEK devuelve el ultimo valor sin eliminarlo
            valor = (int)pila.Peek();
            Console.WriteLine("Extraccion sin eliminar: " + valor);

            //recorrer pila con foreach

            foreach (int value in pila)
            {
                Console.WriteLine("Pila: " + value);
            }

            //cantidad de elementos que tiene la pila con un count
            int cont = pila.Count;
            Console.WriteLine("Contador de pila: " + cont);

            //buscar elemento en pila 
            bool buscar = false;
            buscar = pila.Contains(2);
            Console.WriteLine("Buscador pila: " + buscar);

            //limpiar los elementos de la pila
            pila.Clear();

            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
            /////////////////////////////////////////////////////////////////////////////////////////
            //Cola FIFO

            Queue cola = new Queue();

            //agregar elemento
            cola.Enqueue(7); //se agrega al final de la cola

            //extraer elemento y eliminarlo
            valor = (int)cola.Dequeue();

            Console.WriteLine("Cola: " + valor);

            //buscar un elemento para ver si esta contenido
            buscar = cola.Contains(7);
            Console.WriteLine("Buscar en cola:" + buscar);

            //borra todo el contenido de la cola
            //cola.Clear();

            //PEEK, traer sin borrar el ultimo elemento

            //cola.Peek();



            Console.ReadKey();


            


        }
    }
}
