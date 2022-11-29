using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandExercice
{
    public class Veiculo
    {
        //Atributos valores,Rodas, Ano, Modelo, Marca, Dono
        //Motas e Carros devem herdar isto

        private int valor;
        private int ano;
        private string modelo;
        private string marca;
        private string dono;
        private int rodas;

        public Veiculo(int valor, int ano, string modelo, string marca, string dono)
        {
            this.valor = valor;
            this.ano = ano;
            this.modelo = modelo;
            this.marca = marca;
            this.dono = dono;
            this.Rodas = 0;
        }

        public int Valor { get => valor; set => valor = value; }
        public int Ano { get => ano; set => ano = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Dono { get => dono; set => dono = value; }
        public int Rodas { get => rodas; set => rodas = value; }
    }
}
