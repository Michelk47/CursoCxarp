using hello.Models;

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

int quantidadeEmEstoque = 10;

int quantidadeCompra = 40;

if (quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda realizada.");      
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantodade desejada em estoque");
}
