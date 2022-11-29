using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandExercice
{
    class Carro : Veiculo
    {
        public Carro(int valor, int ano, string modelo, string marca, string dono) : base(valor, ano, modelo, marca, dono)
        {
            this.Rodas = 4;
        }
    }
}
