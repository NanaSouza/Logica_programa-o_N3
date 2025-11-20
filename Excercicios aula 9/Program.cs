//Tabuada: Faça um programa que receba um número e, usando laços de repetição, calcule e mostre a tabuada desse número.
Console.WriteLine("Informe um numero");
int Num = int.Parse(Console.ReadLine());
int count = 0;
int x = 1;

do
{
    
    Console.WriteLine(Num + "x" + x + "=" + (Num * x));

    x++;
    count++;

}while(count <= 10);


























//Validação de Nota: Faça um programa que peça uma nota entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.



//Controle de peso: Faça um programa que receba a idade e o peso de sete pessoas. Calcule e mostre:
//A quantidade de pessoas com mais de 90 quilos;
//A média das idades das sete pessoas;