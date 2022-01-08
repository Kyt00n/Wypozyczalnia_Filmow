using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekcik
{
    [Serializable]
    public enum EnumGatunek { komedia, dramat, melodramat, fantasy, kryminał, horror, przygodowy, musical, sensacyjny, wojenny, western }
    [Serializable]
    public class Film : IComparable<Film>, ICloneable
    {
        private string nazwaFilmu;
        private EnumGatunek gatunekfilm;
        int dl_w_min;
        string rezyser;
        string krajProdukcji;
        int cena_w_zl;

        public string NazwaFilmu { get => nazwaFilmu; set => nazwaFilmu = value; }
        public EnumGatunek Gatunekfilm { get => gatunekfilm; set => gatunekfilm = value; }
        public int Dl_w_min { get => dl_w_min; set => dl_w_min = value; }
        public string Rezyser { get => rezyser; set => rezyser = value; }
        public string KrajProdukcji { get => krajProdukcji; set => krajProdukcji = value; }
        public int Cena_w_zl { get => cena_w_zl; set => cena_w_zl = value; }

        public Film()
        {
        }

        public Film(string nazwaFilmu, EnumGatunek gatunekfilm, int dl_w_min, string rezyser, string krajProdukcji, int cena_w_zl) : this()
        {
            this.nazwaFilmu = nazwaFilmu;
            this.gatunekfilm = gatunekfilm;
            this.dl_w_min = dl_w_min;
            this.rezyser = rezyser;
            this.krajProdukcji = krajProdukcji;
            this.cena_w_zl = cena_w_zl;
        }

        public int CompareTo(Film other)
        {
            int x = NazwaFilmu.CompareTo(other.NazwaFilmu);
            if (x != 0) return x;
            return Rezyser.CompareTo(other.rezyser);
        }

        public override string ToString()
        {
            return $"{cena_w_zl}zł - {nazwaFilmu} {dl_w_min}min., {krajProdukcji}; Gat. {gatunekfilm}, Reż. {rezyser}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
