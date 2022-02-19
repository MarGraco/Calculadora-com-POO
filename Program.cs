using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculadora cal = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma: " + cal.Somar(10, 10));
            System.Console.WriteLine("Resultado da segunda soma: " + cal.Somar(10, 10, 20));





        }
    }
}

        // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Documento = "12345";
            // p1.Idade = 20;
            // p1.Nota = 10;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Leo";
            // p2.Documento = "12345";
            // p2.Idade = 50;
            // p2.Salario = 7000;
            // p2.Apresentar();

// valores validos
           
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);
            // r.ObterArea();
            // System.Console.WriteLine($"Área: {r.ObterArea()}");
            // // valores invalidos
            // Retangulo r2 = new Retangulo();
            // r.DefinirMedidas(0,0);
            // r.ObterArea();
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");
// ---------------------------------------------------------------------
            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Apresentar();
