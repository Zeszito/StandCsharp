using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandExercice
{
    public class Moto : Veiculo
    {
        public Moto(int valor, int ano, string modelo, string marca, string dono) : base(valor, ano, modelo, marca, dono)
        {
            this.Rodas = 2;
        }
        public override string ToString()
        {
            return "A mota custa " + Valor + "euros, a marca é " + Marca + " e o modelo é " + Modelo + "\n";
        }
    }
}
