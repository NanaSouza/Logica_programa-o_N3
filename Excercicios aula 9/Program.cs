//Tabuada: Faça um programa que receba um número e, usando laços de repetição, calcule e mostre a tabuada desse número.
//Console.WriteLine("Informe um numero");
//int Num = int.Parse(Console.ReadLine());
//int count = 0;
//int x = 1;

//do
//{

//    Console.WriteLine(Num + "x" + x + "=" + (Num * x));

//    x++;
//    count++;

//}while(count <= 10);

//Console.WriteLine("Informe um número");
//string entradaUsuario = Console.ReadLine();
//bool valido = int.TryParse(entradaUsuario, out int numero);

//if(valido)
//{

//    for (int contador = 1; contador > 0; contador++) 
//    {
//        Console.WriteLine(contador + " * " + numero + " = " + (contador * numero));
//    }

//}
//else
//{
//    Console.WriteLine("O valor informado não é valido");
//}






//Validação de Nota: Faça um programa que peça uma nota entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

//bool invalido = true;
//do
//{
//    Console.WriteLine("insira uma nota entra 0 e 10:");
//    string entradaUsuario = Console.ReadLine();

//    bool valido = int.TryParse(entradaUsuario, out int nota);

//    if (!valido || nota < 0 || nota > 10) 
//    {
//        Console.WriteLine("Informe uma nota valida");

//    }
//    else
//    {
//        Console.WriteLine(nota + "nota valida");
//    }
//} while (invalido);


//Controle de peso: Faça um programa que receba a idade e o peso de sete pessoas. Calcule e mostre:
//A quantidade de pessoas com mais de 90 quilos;
//A média das idades das sete pessoas;
//using System.Reflection.PortableExecutable;

//const int QTD_PESSOAS = 7;
//int contadorPessoas90kg = 0;
//int somaIdadePessoas = 0;

//string entradaUsuario;

//for (int contador = 0; contador < QTD_PESSOAS; contador++)
//{
//    Console.WriteLine("Informe sua idade:");
//    entradaUsuario = Console.ReadLine();
//    int.TryParse(entradaUsuario, out int idade);

//    Console.WriteLine("Informe seu peso:");
//    entradaUsuario = Console.ReadLine();
//    int.TryParse(entradaUsuario, out int peso);

//    somaIdadePessoas += idade;

//    if (peso > 90)
//    {
//        contadorPessoas90kg++;
//    }
//}
//Console.WriteLine("Pessoas com mais de 90kg:" + contadorPessoas90kg);
//Console.WriteLine("A media das idades é:" + (somaIdadePessoas / QTD_PESSOAS));