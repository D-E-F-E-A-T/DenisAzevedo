using System;
using System.Collections.Generic;
using System.Linq;

namespace Questao1
{
    class Program
    {
        class Candidato
        {
            public string nome;
            public int qtdVotos = 1;
        }

        private void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe a quantidade de votos:");
                List<Candidato> votos = new List<Candidato>();
                Candidato voto;
                int qtdVotos = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i < qtdVotos + 1; i++)
                {
                    Console.WriteLine($"Informe o nome do candidato para o voto nº{i}:");
                    string nomeCandidato = Console.ReadLine().ToUpper();
                    voto = new Candidato { nome = nomeCandidato };
                    if (!votos.Exists(v => v.nome == voto.nome))
                        votos.Add(voto);
                    else
                        votos.Where(v => v.nome.ToUpper() == voto.nome.ToUpper()).FirstOrDefault().qtdVotos++;
                }
                Console.WriteLine($"O candidato mais votado é o(a): {vencedor(votos)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

        }

        private string vencedor(List<Candidato> votos)
        {
            return votos.Where(v => v.qtdVotos == votos.Max(c => c.qtdVotos))
                        .OrderBy(v => v.nome)
                        .FirstOrDefault().nome
                        .ToString();
        }
    }
}
