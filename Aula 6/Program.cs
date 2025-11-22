//definir as constantes
const int DEZOITO = 18;
const int ZERO = 0;

// Escrevendo no console uma string pedindo idade do usuario
Console.WriteLine("Qual a sua idade?");

//Ler a resposta do usuario
string resposta = Console.ReadLine();


//Converter a resposta para inteiro
int idade = int.Parse(resposta);

// tenta transformar a string resposta em um int idade,
// atribui o resultado a uma variavel bool
bool ehValido = int.TryParse(resposta, out int result);


//verifica se a tentativa de parse funcionou
if (ehValido) 
{ 

   
    if (idade >= DEZOITO)
    {
        Console.WriteLine("Usuario é maior de idade");

    }
    else if (idade < ZERO)
    {
        Console.WriteLine("idade invalida");
    }
    else

    {
        Console.WriteLine("Usuario é menor de idade");
    }
}
//caso nao tenha funcionado
else
{
    Console.WriteLine("o Valor informado é invalido" + result);
}