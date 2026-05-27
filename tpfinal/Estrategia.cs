
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Windows.Forms;
using tp1;

namespace tpfinal
{

	public class Estrategia
	{
	
		public String Consulta1(List<string> datos)
		{
			string resutl = "Implementar";
            return resutl;
		}


		public String Consulta2(List<string> datos)
		{
			string result = "Implementar";
            
            return result;
        }

		

		public String Consulta3(List<string> datos)
		{
			string result = "Implementar";

            return result;
		}


        public void BuscarConOtro(List<string> datos, int cantidad, List<Dato> collected)
        {
            Dictionary<string, int> contador = new Dictionary<string, int>();

            foreach (string texto in datos)
            {
                if (contador.ContainsKey(texto)) // si existe la ocurrencia por la clave 
                {
                    contador[texto]++; //suma esa ocurrencia al contador
                }
                else
                {
                    contador[texto] = 1; //sino le asigna un 1
                }
            }

            List<Dato> listaDatos = new List<Dato>(); // crea lista de datos con la estructura Dato

            foreach (var item in contador)
            {
                listaDatos.Add(new Dato(item.Value, item.Key)); //agrega el valor y la clave del dato en la lista de datos
            }

            //bubble sort descendente
            for (int i = 0; i < listaDatos.Count - 1; i++) // recorre la lista menos el ultimo elemento que ya está ordenado
            {
                for (int j = 0; j < listaDatos.Count - i - 1; j++) // resta la vuelta que ya dió y la ultima que ya queda ordenada para repetir vueltas innecesarias
                {
                    if (listaDatos[j].ocurrencia < listaDatos[j + 1].ocurrencia) //compara entre un numero de ocurrencia y el de al lado
                    { //intercambio de posiciones
                        Dato aux = listaDatos[j]; //guarda temporalmente en aux el primer dato de comparacion de la izquierda
                        listaDatos[j] = listaDatos[j + 1]; //asigna la ocurrencia de la derecha en la posicion del dato de la izquierda
                        listaDatos[j + 1] = aux; // asigna la ocurrencia guardada en aux a la posicion de la derecha
                    }
                }
            }

            for (int i = 0; i < cantidad && i < listaDatos.Count; i++) // agrega la lista de datos en la lista collected recorriendo entre la cantidad de resultados elegidos por el usuario y la cantidad de elementos de la lista de datos
            {
                collected.Add(listaDatos[i]);
            }
        }


        public void BuscarConHeap(List<string> datos, int cantidad, List<Dato> collected)
        {
            //Implementar
        }




    }
}