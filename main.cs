using System;
/*
1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.
*/

class MainClass {
  public static void calculadora () {
    Console.WriteLine ("Calculadora !");

    double num1, num2, result, result1, result2, result3;
    string a, b, c;
    char caractere;

    Console.WriteLine ("digite o primeiro valor: ");
    a = Console.ReadLine();
    num1 = double.Parse(a);

    Console.WriteLine ("Digite o segundo valor: ");
    b = Console.ReadLine();
    num2 = double.Parse(b);

    result = num1 + num2;
    result1 = num1 - num2;
    result2 = num1 * num2;
    result3 = num1 / num2;

    Console.WriteLine ("Digite qual operação deseja realizar!");

    Console.WriteLine ("multiplicação( * ), divisão( / ), subtração( - ), soma( + ): ");
    c = Console.ReadLine();
    caractere = char.Parse(c);

    if (caractere == '+')
    {
      Console.WriteLine("soma :" + result);
    }
    else if (caractere == '-')
    {
      Console.WriteLine("subtração: " + result1);
    }
    else if (caractere == '*')
    {
      Console.WriteLine("multiplicação: " + result2);
    }
    else if (caractere == '/')
    {
      Console.WriteLine("divisão: " + result3);
    }

    
  }

  public static void Main (string[] args) {
    calculadora();
  }
}