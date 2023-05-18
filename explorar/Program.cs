using explorar.models;
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

Pessoa p1 = new Pessoa(nome: "joao henrique",sobrenome: "de jesus");
Pessoa p2 = new Pessoa(nome: "pedro",sobrenome: "sampaio");

p2.Nome = "Pedro";
p2.Sobrenome = "Sampaio";

Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Ingles";
CursoDeIngles.Alunos = new List<Pessoa>();

CursoDeIngles.AdicionarAluno(p1);
CursoDeIngles.AdicionarAluno(p2);
CursoDeIngles.ListarAlunos();


decimal ValorMonetario = 1326.45M;          
Console.WriteLine($"{ValorMonetario:C}");




























//p1.Nome = "Joao Henrique";
//p1.Sobrenome = "de Jesus";
//p1.Idade = 18;
//p1.Apresentar();