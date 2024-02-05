using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_Abstraction
{
    public abstract class Fashion
    {
        public abstract void Sepatu();
    }
    public class Sneakers : Fashion
    {
        public override void Sepatu()
        {
            Console.WriteLine("Sneakers biasa digunakan dalam kegiatan casual");
            Console.WriteLine("Digemari oleh kalangan anak muda");
        }
    }
    public class Pantofel : Fashion
    {
        public override void Sepatu()
        {
            Console.WriteLine("Pantofel biasa digunakan dalam kegiatan Formal");
            Console.WriteLine("Pekerja kantoran biasanya menggunakan sepatu ini");
        }
    }
    public class Heels : Fashion
    {
        public override void Sepatu()
        {
            Console.WriteLine("Heels biasa digunakan dalam kegiatan semi-formal");
            Console.WriteLine("Digemari oleh kalangan wanita");
        }
    }
}
