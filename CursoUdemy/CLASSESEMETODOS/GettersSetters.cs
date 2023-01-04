using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.CLASSESEMETODOS
{
    internal class GettersSetters
    {
        public class Moto
        {
            private string Marca;
            private string Modelo;
            private int Cilindrada;

            public Moto(string marca, string modelo, int cilindrada)
            {
                //Construtor

                //Marca = marca;
                //Modelo = modelo;
                //Cilindrada = cilindrada;

                SetModelo(modelo);
                SetMarca(marca);
                SetCilindrada(cilindrada);
            }

            public Moto() { }

            public string GetMarca() { return Marca; }

            public void SetMarca(string marca) { Marca = marca; }

            public string GetModelo() { return Modelo; }

            public void SetModelo(string modelo) { Modelo = modelo; }

            public int GetCilindrada() { return Cilindrada; }

            public void SetCilindrada(int cilindrada)
            {
                //if (cilindrada > 0)
                //{
                //    Cilindrada = cilindrada;
                //}

                Cilindrada = Math.Abs(cilindrada);
            }
        }
        public static void Executar()
        {
            var moto1 = new Moto("BMW", "GS1200", 1200);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            Console.WriteLine("");

            var moto2 = new Moto();
            moto2.SetMarca("HONDA");
            moto2.SetCilindrada(-300);
            moto2.SetModelo("CB300");
            Console.WriteLine(moto2.GetMarca());
            Console.WriteLine(moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());

        }
    }
}
