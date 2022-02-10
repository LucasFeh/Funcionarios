using System;
using System.Collections.Generic;

namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Dados> lista = new List<Dados>();
            Dados p;
            Console.Write("Numero funcionarios a serem registrados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Funcionario #"+(i+1));
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                lista.Add(new Dados(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Deseja acrescentar ao salario de algum dos funcionarios?  s/n: ");
            char r = char.Parse(Console.ReadLine());
            while (r == 'S'|| r == 's')
            {
                Console.Write("\nID do funcionario: ");
                int Scid = int.Parse(Console.ReadLine());
                p = lista.Find(x => x.Id == Scid);
                if (p != null )
                {
                    Console.Write("\nPorcentagem a ser incrementada: ");
                    double porcent = double.Parse(Console.ReadLine());
                    p.Aumento(porcent);
                    Console.Write("\nDseja aumentar novamente? s/n: ");
                    r = char.Parse(Console.ReadLine());                  
                }
                else
                {
                    Console.WriteLine("\nO ID que você digitou está incorreto ou não existe!!");
                    Console.Write("Dseja digitar o id novamente? s/n: ");
                    r = char.Parse(Console.ReadLine());               
                }

            }
            Console.WriteLine("\nLista de funcionarios atualizada: ");
           
            foreach (Dados obj in lista)
            {
                Console.WriteLine(obj);
            }
            

        }
    }
}
