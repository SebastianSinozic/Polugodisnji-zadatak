using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinozicSebastian_PolugodisnjiZadatak
{
    class Automobil
    {
        string marka;
        string model;
        int godiste;
        string status;
        public string Naziv { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Godiste { get => godiste; set => godiste = value; }
        public string Status { get => status; set => status = value; }

        public Automobil(string marka, string model, int godiste)
        {
            this.marka = marka;
            this.model = model;
            this.godiste = godiste;
        }

        public override string ToString()
        {
            string ispis = this.marka + "          " + this.model + "          " + this.godiste + "          " + this.status;
            return ispis;
        }
    }
}
