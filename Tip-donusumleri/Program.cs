using System;

namespace Tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            //Büyük kapasiteliden küçük kapasiteliye bilinçsiz dönüşüm yapılamıyor
            Console.WriteLine("*******Implicit Conversion************");

            byte b=5;
            sbyte sb=30;
            short s=10;

            int i=b+sb+s;
            Console.WriteLine("i: " + i);

            long l=i;
            Console.WriteLine("l: "+l);

            float f=l;
            Console.WriteLine("f: "+f);

            string st="Sami";
            char c='s';
            object o=st+c+i;
            Console.WriteLine("o: "+o);

            //Explicit Conversion (Bilinçli Dönüşüm)

            Console.WriteLine("***********Explicit Conversion*************");

            int ii=4;
            byte bb=(byte)ii;
            Console.WriteLine("bb: "+bb);

            int x=100;
            byte y=(byte)x;
            Console.WriteLine("y: "+y);

            float w=10.3f;
            byte v=(byte)w;
            Console.WriteLine("v: "+v);
                //ToString Methodu
                Console.WriteLine("***********ToString Methodu*************");
        }
    }
}
