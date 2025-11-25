//Exercício 1 – Validação de Senha
//Crie um programa que peça ao usuário uma senha. O programa deve permitir até 3 tentativas.
//A senha correta é "12345".
//Se o usuário digitar a senha correta E tiver mais de 18 anos (idade informada previamente), o acesso é liberado.
//Caso contrário, o programa informa que o acesso foi negado.

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

//Exercício 2 – Números Pares e Ímpares
//Peça ao usuário um número inteiro positivo. O programa deve imprimir todos os números de 1 até esse número.
//Para cada número, informe se ele é par ou ímpar.
//Se o número for par e múltiplo de 5 ao mesmo tempo, destaque com a mensagem "Par e múltiplo de 5".



//Exercício 3 – Caixa Registradora
//Simule uma caixa registradora simples.
//O programa deve pedir o valor de cada produto até que o usuário digite 0 para encerrar.
//Ao final, mostre o total da compra.
//Se o total for maior que R$ 100 OU o cliente tiver um cupom de desconto (informado como CUPOM10), aplique 10% de desconto.