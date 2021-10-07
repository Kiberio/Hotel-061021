using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class hospedes
    {
        //Declaração das variaveis da classe
        public string Nome { get; set; }
        public string Email { get; set; }

        //Declaração do construtor
        public hospedes(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        //Formatação do to string
        public override string ToString()
        {
            return Nome + " , " + Email;
        }
    }
}
