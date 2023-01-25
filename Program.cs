using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger =2;
            string degisken = null;
            Console.WriteLine("Hello World!");
            byte b = 5;     // 1 byte 
            sbyte c= 5;     // 1 byte
            short d = 7;    // 2 byte
            ushort e = 8;   // 2 byte
            int i = 2;      // 4 byte
            Int32 i32 = 2;  // 4 byte
            Int64 i64 = 2;  // 8 byte
            uint ui = 4;    // 4 byte
            long l = 5;     // 8 byte
            ulong ul = 5;   // 8 byte
            float  f = 5; 
            double  db = 8;  // 8 byte
            long   dc = 6;  // 16 byte
            bool b1 = true;
            bool b2 = false;
            
            string str1 ="mehmet";
             // Tarih ve saat için
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            object o1 ="2";
            object o2 ="y";
            object o3 =4;
            object o4 = 4.2;
            
            // string tanımlama yöntemleri
            string str2 =string.Empty;
            str2 ="mehmetali";
            string name ="enes";
            string lastname ="yilmaz";
            string tanımlanmisad = name +""+lastname;
            
            // integer tanımlama yöntemleri
            int integer1 = 5;
            int integer2 =3;
            int integer3 = integer1 + integer2;


            bool bool1 = 10<15;

            // degişken dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();

            Console.WriteLine(yeniDeger);

            int int30 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int30);

            int int31 = int20 + int.Parse(str20);
            Console.WriteLine(int31);

            string datatime = DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(datatime);


            
           
        }       
    }
}
