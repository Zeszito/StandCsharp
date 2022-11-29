using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandExercice
{
    class Stand
    {
        public string nome;

        public List<Moto> motos;
        public List<Carro> carros;

        public Stand(string nome)
        {
            this.nome = nome;
            motos = new List<Moto>();
            carros = new List<Carro>();
        }
            public int NCarrosRenault()
        {
            int countR = 0;
            int contador = 0;
            while (carros.Count > contador)
            {
                if (carros[contador].Marca == "Renault")
                {
                    countR++;
                }
                contador++;
            }
            return countR;
        }

        /**region Methods Region**/
        //Um método que diz quantos Carros Renault tem.


        //Um método que dá a mota mais cara.
        public string MotaMaisCara()
        {
            int maiscara = 0;
            string motaatual = "";

            foreach (Moto motoASerTestada in motos)
            {
                if (motoASerTestada.Valor > maiscara)
                {
                    maiscara = motoASerTestada.Valor;
                    motaatual = motoASerTestada.ToString();
                }
            }

            return motaatual;
        }


        //Um override de to string que nos dá uma lista de todos os veículos, ordenados por valor.Separados por Carros e Motas.
         
        public override string ToString()
        {
            string stringfinal = "O " + nome + " apresenta:\n";
            stringfinal += "**C4RRU5**\n";
            for (int i = 0; i < carros.Count; i++)
            {
                stringfinal += carros[i].ToString();

            }

            stringfinal += "**M0t4**\n";
            foreach (Moto item in motos)
            {
                stringfinal += item.ToString();

            }


            return stringfinal;
        }

        //Sabendo que estamos em 2022 queremos um métodos
        ////que devolve uma Lista de Carros que tenham menos de 5 anos.
        public List<Carro> MenosDe5Anos()
        {
            List<Carro> listaDeCarrosComMenosDe5Anos = new List<Carro>();

            //ir buscar o ano actual
            int anoActual = DateTime.Now.Year;

            foreach (Carro carroASerTestado in carros)
            {
              
                if (anoActual - carroASerTestado.Ano < 5)
                {
                    listaDeCarrosComMenosDe5Anos.Add(carroASerTestado);
                    
                }
            }

            return listaDeCarrosComMenosDe5Anos;
        }

        //Um método que nos dá o preço do Carro mais recente, entre os usados.
        public int ValorDoCarroMaisRecenteDosUsados()
        {
            int valor = 0;
            int anoActual = DateTime.Now.Year;
            int maisActual = 1000;

            for (int i = 0; i < carros.Count; i++)
            {
                if (!carros[i].Dono.ToLower().Trim().Contains("novo"))
                {
                    if (anoActual-carros[i].Ano < maisActual)
                    {
                        maisActual = anoActual - carros[i].Ano;
                        valor = carros[i].Valor;
                    }
                }
            }

            return  valor;
        }

        //Um método que recebe um valor e devolve uma lista de Motos abaixo desse valor.
        public List<Moto> MotosABaixoDeX(int valorSolicitado)
        {
            List<Moto> motasBaratas = new List<Moto>();

            foreach (Moto item in motos)
            {
                if(item.Valor <= valorSolicitado)
                {
                    motasBaratas.Add(item);
                }
            }

            return motasBaratas;
        }
        
        /** end region**/

    }
}
