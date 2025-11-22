const string AMARELO = "AMARELO";
const string AZUL = "AZUL";
const string VERDE = "VERDE";

const string MSG_VOTO = "Qual é o seu voto? (AMARELO, AZUL ou VERDE)";

string voto;

int votosAmarelo = 0;
int votosVerde = 0;
int votosAzul = 0;
int abs = 0;

// Votação


// Apuração

int count = 0;
do
{
    Console.WriteLine(MSG_VOTO);
    voto = Console.ReadLine();
    switch (voto)
    {
        case AMARELO:
            votosAmarelo++;

            break;
        case AZUL:
            votosAzul++;
            break;
        case VERDE:
            votosVerde++;
            break;
        default:
            abs++;
            break;
    }
    count++;
} while (count < 5);

for (int contagem = 0; contagem < 5; contagem++)
{
    Console.WriteLine(MSG_VOTO);
    voto = Console.ReadLine();
    switch (voto)
    {
        case AMARELO:
            votosAmarelo++;
            break;
        case AZUL:
            votosAzul++;
            break;
        case VERDE:
            votosVerde++;
            break;
        default:
            abs++;
            break;
    }
}





// Resultado
int vencedor = 0;

if (vencedor < votosAmarelo)
{
    vencedor = votosAmarelo;
}

if (vencedor < votosAzul)
{
    vencedor = votosAzul;
}

if (vencedor < votosVerde)
{
    vencedor = votosVerde;
}

if (vencedor < abs)
{
    vencedor = abs;
}

if (vencedor == votosAmarelo)
{
    Console.WriteLine("O Amarelo é o vencedor.");
}

if (vencedor == votosAzul)
{
    Console.WriteLine("O Azul é o vencedor.");
}

if (vencedor == votosVerde)
{
    Console.WriteLine("O Verde é o vencedor.");
}

if (vencedor == abs)
{
    Console.WriteLine("Não há vencedor dado o número de abstenções.");
}