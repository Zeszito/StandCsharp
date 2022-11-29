using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stand teste = new Stand("Stand Do Gaspar");

            //Motas
            Moto m1 = new Moto(3000, 2020, "CBR", "Honda", "João");
            Moto m2 = new Moto(5000, 2019, "mt09", "Yamaha", "Alberto");
            Moto m3 = new Moto(4500, 2017, "YZF", "Yamaha", "Candido");
            Moto m4 = new Moto(5500, 2017, "Transalp", "Honda", "Felisbelo");
            Moto m5 = new Moto(40000, 2019, "H2", "Yamaha", "Jorge");
            Moto m6 = new Moto(7000, 2022, "panigale V4s", "ducati", "João");

            //Carros
            Carro c1 = new Carro(6000, 2014, "VelSatis", "Renault", "Moises");
            Carro c2 = new Carro(10000, 2020, "Cyber Truck", "Tesla", "Elon Musk");
            Carro c3 = new Carro(10000, 2021, "C4", "Citroen", "António");
            Carro c4 = new Carro(2000, 2014, "Megane2", "Renault", "Monica");
            Carro c5 = new Carro(15000, 1997, "C-180", "Mercedes-Benz", "Alexandre");


            teste.motos.Add(m1);
            teste.motos.Add(m2);
            teste.motos.Add(m3);
            teste.motos.Add(m4);
            teste.motos.Add(m5);
            teste.motos.Add(m6);

            teste.carros.Add(c1);
            teste.carros.Add(c2);
            teste.carros.Add(c3);
            teste.carros.Add(c4);
            teste.carros.Add(c5);

            Console.WriteLine(teste.NCarrosRenault());
            Console.WriteLine(teste.MotaMaisCara());
            Console.WriteLine(teste);

        }
    }
}
