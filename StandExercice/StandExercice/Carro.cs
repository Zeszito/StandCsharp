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
        public override string ToString()
        {
            return "O carro custa " + Valor + "euros, a marca é " + Marca + " e o modelo é " + Modelo + "\n";
        }
    }
}
