using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace explorar.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunos(){
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
        }
        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso de {Nome}");
            for(int i = 0; i < Alunos.Count; i++){

                string texto = $"N° {i + 1} - {Alunos[i].NomeCompleto}";

                Console.WriteLine(texto);
            }
        }
    }
}