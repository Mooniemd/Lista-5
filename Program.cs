/*Console.WriteLine("Digite um número!");
int num = int.Parse(Console.ReadLine()!);
  if ( num < 0){
    Console.WriteLine("Seu valor (" + num + ") é negativo!");
  } else if ( num > 0 ){
    Console.WriteLine("Seu valor (" + num + ") é positivo!");
  } else {
    Console.WriteLine("Seu número é nulo!");
  }
  */

/*Console.WriteLine("Me fale um número!");
  int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Agora me fale outro número!");
  int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Informe a operação ( + , - , * , / )");
char sinal = char.Parse(Console.ReadLine()!);
int total;

  switch(sinal){
    case '+': total = num1 + num2;
    Console.WriteLine("A soma total de seus números é:" + total);
    break;

    case '-': total = num1 - num2;
    Console.WriteLine("A soma total de seus números é:" + total);
    break;

    case '*': total = num1 * num2;
    Console.WriteLine("A soma total de seus números é:" + total);
    break;

    case '/': 
    if(num2 != 0){
      total = num1 / num2;
    } else{
      Console.WriteLine("Não dá pra dividir por 0!");
    }
    total = num1 / num2;
    Console.WriteLine("A soma total de seus números é:" + total);
    break;

    default: Console.WriteLine("Informe uma informação válida!");
    break;
  }
*/

Console.WriteLine("Escolha sua classe! (Guerreiro, Mago ou Arqueiro)");
string? classe = Console.ReadLine()!.ToLower();

switch(classe){
  case "guerreiro":
  Console.WriteLine("Você é um guerreiro!");
  break;
  case "mago":
  Console.WriteLine("Você é um mago!");
  break;
  case "arqueiro":
  Console.WriteLine("Você é um arqueiro!");
  break;

  default: Console.WriteLine("Você inseriu uma classe inválida!");
  break;
}

/*
for(int i = 1; i <= 10; i++){
Console.WriteLine(i);
}
*/
/*
                    __
         .,-;-;-,. /'_\
       _/_/_/_|_\_\) /
     '-<_><_><_><_>=/\
      `/_/====/_/-'\_\
        ""     ""    ""
        noted by: moonie */