using System;
/*
2- O cardápio de uma casa de lanches é dado pela tabela abaixo:
Código Produto Preço Unitário (R$)
---------------------------------
100  Cachorro quente   R$ 1,70
101   Bauru Simples    R$ 2,30
102   Bauru com ovo    R$ 2,60
103   Hamburguer       R$ 2,40
104   Cheeseburguer    R$ 2,50
105   Refrigerante     R$ 1,00
----------------------------------
Escreva um algoritmo que leia o código do item adquirido pelo consumidor e a
quantidade, calculando e mostrando o valor a pagar. Não será necessário exibir o produto
e o valor, somente o valor final
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
    else 
    {
      Console.WriteLine("Entrada errada!");
    }

    
  }
  public static void lanchonete (){
    double result;
    string a, b;
    int quant, item;

    Console.WriteLine(" 100  Cachorro quente   R$ 1,70 \r\n 101   Bauru simples    R$ 2,30 \r\n 102   Bauru com ovo    R$ 2,60 \r\n 103   Hamburguer       R$ 2,40 \r\n 104   Cheeseburguer    R$ 2,50 \r\n 105   Refrigerante     R$ 1,00");

    
    Console.WriteLine("Digite o codigo do item Desejado :");
        a = Console.ReadLine();
        item = int.Parse(a);

    switch (item)
    {
      case 100:
      Console.WriteLine("Quantos cachorros quentes vai querer ? :");
      b = Console.ReadLine();
      quant = int.Parse(b);
      result = quant * 1.70; 
      Console.WriteLine("TOTAL a pagar:" + result);   
        break;

      case 101:
      Console.WriteLine("Quantos Bauru Simples vai querer ? :");
      b = Console.ReadLine();
      quant = int.Parse(b);
      result = quant * 2.30; 
      Console.WriteLine("TOTAL a pagar:" + result);   
        break;

      case 102:
      Console.WriteLine("Quantos Bauru com ovos vai querer ? :");
      b = Console.ReadLine();
      quant = int.Parse(b);
      result = quant * 2.60; 
      Console.WriteLine("TOTAL a pagar:" + result);   
        break;

      case 103:
      Console.WriteLine("Quantos Hamburguers vai querer ? :");
      b = Console.ReadLine();
      quant = int.Parse(b);
      result = quant * 2.40; 
      Console.WriteLine("TOTAL a pagar:" + result);   
        break;

      case 104:
      Console.WriteLine("Quantos Cheeseburguer vai querer ? :");
      b = Console.ReadLine();
      quant = int.Parse(b);
      result = quant * 2.50; 
      Console.WriteLine("TOTAL a pagar:" + result);   
        break;

      case 105:
      Console.WriteLine("Quantos Refrigerantes vai querer ? :");
      b = Console.ReadLine();
      quant = int.Parse(b);
      result = quant * 1.00; 
      Console.WriteLine("TOTAL a pagar: " + result );   
        break;

      default:
        Console.WriteLine("Entrada Incorreta !!!");
        break;
 
    }

  }

  public static void Main (string[] args) {
    //calculadora();
    lanchonete();
  }
}