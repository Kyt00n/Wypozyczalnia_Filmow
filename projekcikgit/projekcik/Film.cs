using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekcik
{
    public enum EnumGatunek { komedia, dramat, melodramat, fantasy, kryminał, horror, przygodowy, musical, sensacyjny, wojenny, western }
    class Film
    {
        public string nazwaFilmu;
        public EnumGatunek gatunekfilm;
        int dl_w_min;
        string rezyser;
        string krajProdukcji;
        int cena_w_zl;

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

        public override string ToString()
        {
            return $"{cena_w_zl}zł - {nazwaFilmu} {dl_w_min}min., {krajProdukcji}; Gat. {gatunekfilm}, Reż. {rezyser}";
        }
    }
}
