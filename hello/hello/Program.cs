using hello.Models;

Pessoa p = new Pessoa();

Pessoa pessoa1 = new Pessoa();  

p.Nome = "Michel de Alcantarea";
p.Idade = 25;

pessoa1.Nome = "Diego Palareti";
pessoa1.Idade = 100;

DateTime dataAtual = DateTime.Now.AddDays(2);

Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

//pessoa1.Apresentar();
//p.Apresentar();

//p.Apresentar();