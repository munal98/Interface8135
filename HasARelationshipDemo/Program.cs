using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasARelationshipDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar1 = new Bilgisayar()
            {
                Marka = "ASUS",
                Model = "ROG",
                Islemci = new Islemci()
                {
                    GHz = 4,
                    IntelMi = true,
                    Modeli = "i9"
                },
                Hafiza = new Hafiza()
                {
                    Marka = "Kingston",
                    GB = 32
                }
            };


            Console.WriteLine("Marka: " + bilgisayar1.Marka
                             + "\nModel: " +bilgisayar1.Model
                             + "\nislemci:\nMarkası: " +
                             (bilgisayar1.Islemci.IntelMi ==true ? "Intel" : "AMD")
                             + "\nModeli: " +bilgisayar1.Islemci.Modeli
                             + "\nHız: " + bilgisayar1.Islemci.GHz.ToString()
                             + "\nHafıza:\nMarkası: " +bilgisayar1.Hafiza.Marka
                             + "\nKapasite: " + bilgisayar1.Hafiza.GB);
            Console.ReadLine();
        }
    }

    class Bilgisayar
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        // işlemci

        public Islemci Islemci { get; set; }
      public Hafiza Hafiza { get; set; }
    }

    class Islemci
    {
        public double GHz { get; set; }
        public bool IntelMi { get; set; }
        public string Modeli { get; set; }
    }

    class Hafiza
    {
        public short GB { get; set; }
        public string Marka { get; set; }
    }
}
