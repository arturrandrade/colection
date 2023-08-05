using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Cliente
    {
        private int id;
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id não pode ser menor que zero");
                }
                else { this.id = value; }
            }
        }
        public string Nome { get; set; }

        public Cliente(int id, string nome)
        {
            this.id = id;
            this.Nome = nome;
        }
    }
}
