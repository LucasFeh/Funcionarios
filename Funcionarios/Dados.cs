using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionarios
{
    class Dados
    {

        public int Id;
        public string Nome;
        public double Salario;

        public Dados(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void Aumento(double porcent)
        {
            Salario += Salario * (porcent / 100);
        }
        public override string ToString()
        {
            return Id + ", " + Nome + ", $" + Salario;

        }


















    }
}
