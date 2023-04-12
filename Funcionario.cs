using System;

namespace Biblioteca
{
    public class Funcionario : Pessoa
    {
        public int Id { get; set; }
        public string Cargo { get; set; }
        public DateTime DataAdmissao { get; set; }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"ID: {Id}\nCargo: {Cargo}\nData de Admissão: {DataAdmissao.ToShortDateString()}");
        }
    }
}
