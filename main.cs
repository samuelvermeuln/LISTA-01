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

    double num1, num2, result;
    string a, b, c;
    char caractere;

    Console.WriteLine ("digite o primeiro valor: ");
    a = Console.ReadLine();
    num1 = double.Parse(a);

    Console.WriteLine ("Digite o segundo valor: ");
    b = Console.ReadLine();
    num2 = double.Parse(b);

    Console.WriteLine ("Digite qual operação deseja realizar!");

    Console.WriteLine ("multiplicação(*), divisão(/), subtração(-), soma(+): ");
  }

  public static void Main (string[] args) {
    calculadora();
  }
}