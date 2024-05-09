using hello.Models;
using System.Diagnostics;


int numero = 5;

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}



//Calculadora calc = new Calculadora();

//calc.Somar(5, 5);
//calc.Subtrair(10, 80);
//calc.Multiplicar(20, 2);
//calc.Divisao(20, 2);
//calc.Potencia(3, 3);
//calc.Seno(30);
//calc.Tangente(30);
//calc.Coseno(30);

//Console.WriteLine("teste");










//Console.WriteLine("Digite um letra");
//string letra = Console.ReadLine();


//switch (letra)
//{
// case "a":
// case "e":
// case "i":
// case "o":
// case "u":

// Console.WriteLine("Vogal2");
// break;

//default:
// Console.WriteLine("Não é vogal");
// break;


//}





//if (letra == "a" || letra == "e" || letra == "o" || letra == "u" || letra == "i")
//{
//Console.WriteLine("Vogal");

//}
//else
//{
// Console.WriteLine("Não é vogal");
//}



//Pessoa p = new Pessoa();

//Pessoa pessoa1 = new Pessoa();  

//p.Nome = "Michel de Alcantarea";
//p.Idade = 25;

//pessoa1.Nome = "Diego Palareti";
//pessoa1.Idade = 100;

//DateTime dataAtual = DateTime.Now.AddDays(2);

//conversão de variavel - a diferença do ToInt para o Parse e que se você passar um null o ToInt ele vai retorna 0 não dando erro já o Parse se isso acontecer ela vai dar um erro.
//int e = Convert.ToInt32("5");
//int i = int.Parse("40");


//string t = "15-";

//int alerta = 0;

//int.TryParse(t, out alerta);

//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
//Console.WriteLine(alerta);

//pessoa1.Apresentar();
//p.Apresentar();

//p.Apresentar();

//int quantidadeEmEstoque = 10;

//int quantidadeCompra = 40;

//if (quantidadeEmEstoque >= quantidadeCompra)
//{
//Console.WriteLine("Venda realizada.");      
//}
//else
//{
//Console.WriteLine("Desculpe. Não temos a quantodade desejada em estoque");
//}
