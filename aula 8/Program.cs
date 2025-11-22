//Votação iniciada
//5 votos 

using System.Linq.Expressions;

Console.WriteLine("Escolha Qual criaça vai pro passeio da escola");
Console.WriteLine("Carlos");
Console.WriteLine("Miranda");
Console.WriteLine("Lucas");
Console.WriteLine("Marcelo");
Console.WriteLine("Larissa");

string Voto = Console.ReadLine();
int Carlos = 0;
int Miranda = 0;
int Lucas = 0;
int Marcelo = 0;
int Larissa = 0;

switch(Voto)
{

    case "Carlos":
        Carlos++; 
        break;
    case "Miranda":
        Miranda++; 
        break;
    case "Lucas":
        Lucas++;
        break;
    case "Marcelo":
        Marcelo++; 
        break;
    case "Larissa":
        Larissa++; 
        break;
        
       
}
int Vencedor = 0;

if (Vencedor < Carlos)
{
    Vencedor = Carlos;
}
if (Vencedor < Miranda)
{
    Vencedor = Miranda;
}
if (Vencedor < Lucas)
{
    Vencedor = Lucas;
}
if (Vencedor < Marcelo)
{
    Vencedor = Marcelo;
}
if (Vencedor < Larissa)
{
    Vencedor = Larissa;
}

if (Vencedor == Carlos )
{
    Console.WriteLine("O Vencedor é o Carlos");
}
else if (Vencedor == Miranda )
{
    Console.WriteLine("A Vencedora é:" + Miranda);
}
else if (Vencedor == Lucas )
{
    Console.WriteLine("O Vencedor é:" + Lucas);
}
else if (Vencedor == Marcelo )
{
    Console.WriteLine("O Vencedor é:" + Marcelo);
}
else if (Vencedor == Larissa )
{
    Console.WriteLine("A vencedora é:" + Larissa);
}
  

Console.WriteLine("O vencedor e o unico a ir ao passeio é" +  Vencedor);