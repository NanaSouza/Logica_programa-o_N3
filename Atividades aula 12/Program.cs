//Atividade 1
//Crie um programa que peça ao usuário uma temperatura em graus Celsius.
//Converta para Fahrenheit usando a fórmula: F = (Cx9 / 5) + 32
//Exiba o resultado.




//Atividade 2
//Solicite dois números inteiros ao usuário.
//Armazene-os em variáveis.
//Calcule e exiba a soma, subtração, multiplicação e divisão.


Console.WriteLine("Informe um numero inteiro:");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe mais um numero inteiro:");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("A soma é:" + (n1 + n2));
Console.WriteLine("A Subtração é:" +  (n1 - n2));
Console.WriteLine("A multiplicação é:" + (n1 * n2));
Console.WriteLine("A Divisão é:" + (n1/ n2));

//Atividade 3
//Peça ao usuário um número inteiro.
//Informe se ele é múltiplo de 3, de 5 ou de ambos.

Console.WriteLine("Informe um número inteiro");
bool inteiro = int.TryParse(Console.ReadLine(), out int numero);
bool multiplo3 = numero % 3 == 0;
bool multiplo5 = numero % 5 == 0;

if (multiplo3 && multiplo5)
{
    Console.WriteLine(numero + "é multiplo de ambos");
}
else if (multiplo3)
{
    Console.WriteLine(numero + "é multplo de 3");
}
else if (multiplo5) 
{
    Console.WriteLine(numero + "é multplo de 5");
}
else
{
    Console.WriteLine("Não é multplo");
}


//Atividade 4
//Solicite ao usuário um número de 1 a 7.
//Exiba o dia da semana correspondente (1 = Domingo, 2 = Segunda, etc.).

Console.WriteLine("Informe um numero de 1 a 7:");
int dias = int.Parse(Console.ReadLine());

switch (dias)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2: 
        Console.WriteLine("Segunda");
        break;
    case 3:
        Console.WriteLine("Terça");
        break;
    case 4:
        Console.WriteLine("Quarta");
        break;
    case 5:
        Console.WriteLine("Quinta");
        break;
    case 6:
        Console.WriteLine("Sexta");
        break;
    case 7:
        Console.WriteLine("Sabado");
        break;
    default:
        Console.WriteLine("invalido");
        break;


}

//Atividade 5
//Crie um programa que exiba todos os números de 1 a 20 usando for.

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}

//Atividade 6
//Solicite ao usuário um número.
//Continue pedindo novos números até que ele digite 0.
//Ao final, mostre quantos números foram digitados.

int contador = 0;
int respostaUsuario = -1;

while (contador != 0)
{
    Console.WriteLine("Digite um numero");

    if (respostaUsuario != 0)
    {
        contador++;
    }
    
}
Console.WriteLine(contador);



//Atividade 7
//Peça ao usuário para digitar uma palavra.
//Use um laço de repetição para percorrer cada letra.
//Conte quantas vogais (a, e, i, o, u) existem na palavra.
//Exiba o total de vogais encontradas.



//Atividade 8
//Crie um programa que armazene 5 nomes em um array.
//Depois, exiba todos os nomes na tela.
const int CINCO = 5;
string[] nomes = new string[CINCO];

for (int i = 0; i < CINCO; i++)
{
    Console.WriteLine("insira um nome:");
    nomes[i] = Console.ReadLine();
}
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}
    


//Atividade 9
//Crie uma lista de números inteiros.
//Peça ao usuário para digitar 5 números e armazene-os na lista.
//Exiba o maior e o menor número digitado.



//Atividade 10
//Solicite ao usuário 4 notas (armazenadas em uma lista).
//Calcule a média.
//Use if/else para informar se o aluno está aprovado (média ≥ 7) ou reprovado.