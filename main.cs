using System;


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
  public static void votação (){
    int jose = 0, joana = 0, roberto = 0, branco = 0, nulo = 0;
    int eleitores;
    int votacao, vencedor = 0;
    int votantes = 0;

    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.WriteLine(" SISTEMA DE CONTAGEM DE VOTOS ");
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

    Console.Write("Digite o numero de Eleitores: ");
    eleitores = int.Parse(Console.ReadLine());

    Console.WriteLine(" 33 - José Couve \n\r 25 - Joana Bravo \n\r 10 - Roberto Nove \n\r 0  - Voto branco \n\r 4  - Voto nulo");
    
    do 
    {

    Console.Write("Digite o numero do candidato: ");
    votacao = int.Parse(Console.ReadLine());
    votantes = votantes + 1;
    // sistema para saber qual candidato venceu
    vencedor = votacao;
    if (votacao > vencedor);
    vencedor = votacao;    

    switch (votacao){

    case 33:    
      jose++;
      break;

    case 25:    
      joana++;
      break;

    case 10:    
      roberto++;
      break;

    case 0:    
      branco++;
      break;

    case 4:    
      nulo++;
      break;

    default:    
      Console.WriteLine("Numero do canditado incorreto !");
      break;
  
      }

    } while (votantes < eleitores);
    //Console.WriteLine("vencedor {0} ", vencedor);
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.WriteLine("Numeros de votos do José: " + jose);
    Console.WriteLine("Numeros de votos da Joana: " + joana);
    Console.WriteLine("Numeros de votos do Roberto: "+ roberto);
    Console.WriteLine("votos brancos: " + branco);
    Console.WriteLine("votos nulos: " + nulo);

  }


  public static void Main (string[] args) {
    //calculadora();
    //lanchonete();
    //votação();
  }
}