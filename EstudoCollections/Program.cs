using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> listaNumeros = new List<int>();
            for (int i = 0; i <= 19; i++)
            {
                listaNumeros.Add(i);
            }
            listaNumeros.Remove(5);
            listaNumeros.RemoveAt(2);
            listaNumeros.Reverse();
            Console.WriteLine("O número 15 está na posição {0}", listaNumeros.IndexOf(15));
            foreach (int numero in listaNumeros)
            {
                Console.WriteLine("{0}", numero);
            }*/
            /*Dictionary<string, string> meuDicionario = new Dictionary<string, string>();
            meuDicionario.Add("Adicionar", "Adicionar significa somar");
            meuDicionario.Add("Subtrair", "Subtrair significa diminuir");
            foreach (string chave in meuDicionario.Keys)
            {
                Console.WriteLine("{0} significa {1}", chave, meuDicionario[chave]);
            }*/
            Dictionary<int, string> meuDicionario = new Dictionary<int, string>();
            meuDicionario.Add(1, "Número baixo");
            meuDicionario.Add(5, "Número médio");
            meuDicionario.Add(8, "Número alto");
            foreach (int chave in meuDicionario.Keys)
            {
                Console.WriteLine("{0} é um {1}", chave, meuDicionario[chave]);
            }
            Console.ReadKey();
        }
    }
}
