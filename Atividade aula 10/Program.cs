//Exercício 1 – Validação de Senha
//Crie um programa que peça ao usuário uma senha. O programa deve permitir até 3 tentativas.
//A senha correta é "12345".
//Se o usuário digitar a senha correta E tiver mais de 18 anos (idade informada previamente), o acesso é liberado.
//Caso contrário, o programa informa que o acesso foi negado.

using System.ComponentModel.Design;

const int SENHA = 12345;
const int IDADE = 18;

for (int contador = 0; contador <3; contador++)
{
    Console.WriteLine("Informe a senha correta:");
    string entradaUsuario = Console.ReadLine();
    int.TryParse(entradaUsuario, out int senha);

    Console.WriteLine("Informe a sua idade:");
    string entradaUsuario1 = Console.ReadLine();
    int.TryParse(entradaUsuario1, out int idade);

    if (senha == SENHA &&  idade >= IDADE)
    {
        Console.WriteLine("Acesso Permitido");
    }
    else
    {
        Console.WriteLine("Acesso negado");
    }  
}




const string SENHA_CORRETA = "12345";

Console.WriteLine("Insira a sua idade:");
bool idadeValida = int.TryParse(Console.ReadLine(), out int idade);

if (!idadeValida)
{
    Console.WriteLine("Idade invalida!");
}
else
{
    int tentativas = 0;
    string senha;
    
    do
    {
        Console.WriteLine("Insira a senha: (tentativas" + tentativas + ")");
        tentativas++;
        senha = Console.ReadLine();

        if (senha == SENHA_CORRETA && idade >= 18)
        {
            Console.WriteLine("Acesso Liberado...");
        }
        else
        {
            Console.WriteLine("Acesso negado...");
        }
    }while (tentativas <3 && senha != SENHA_CORRETA);
}

//Exercício 2 – Números Pares e Ímpares
//Peça ao usuário um número inteiro positivo. O programa deve imprimir todos os números de 1 até esse número.
//Para cada número, informe se ele é par ou ímpar.
//Se o número for par e múltiplo de 5 ao mesmo tempo, destaque com a mensagem "Par e múltiplo de 5".

Console.WriteLine("Informe um numero inteiro positivo");
bool inteiro = int.TryParse(Console.ReadLine(),out int numero);

if (inteiro && numero > 0)
{
    for (int contador = 1; contador < numero; contador++)
    {
        bool par = contador % 2 == 0;
        bool multiplo5 = contador % 5 == 0;

        if (par && multiplo5)
        {
            Console.WriteLine(contador + " - é par e multplo de 5");
        }
        else if (par && !multiplo5)
        {
            Console.WriteLine(contador + "- é par");
        }
        else
        {
            Console.WriteLine(contador + "- é impar");
        }
    }
    
}
else
{
    Console.WriteLine("O numero informado não é valido");
}



//Exercício 3 – Caixa Registradora
//Simule uma caixa registradora simples.
//O programa deve pedir o valor de cada produto até que o usuário digite 0 para encerrar.
//Ao final, mostre o total da compra.
//Se o total for maior que R$ 100 OU o cliente tiver um cupom de desconto (informado como CUPOM10), aplique 10% de desconto.
const string CUPOM10 = "CUPOM10";
double valor = -1;
double total =0;

while (valor != 0)
{
    Console.WriteLine("Informe o valor dos produto:");
    valor = double.Parse(Console.ReadLine());
    if (valor > 0)
    {
        total += valor;
    }
}

Console.WriteLine("Insira o cupom de desconto:");
string cupom = Console.ReadLine();

if (cupom == CUPOM10 || total > 100)
{
    Console.WriteLine("O valor total da compra com 10% de desconto é:" + (total * 0.9));
}
else
{
    Console.WriteLine("O valor total é R$" + total);
}