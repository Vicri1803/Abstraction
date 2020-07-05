using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;    //Jika menggunakan Abstract Class
using Abstraction.Interface;        //Jika menggunakan Interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama\t: Muhammad Vicri Ariadi");
            Console.WriteLine("NIM\t: 19.11.2785");
            Console.WriteLine("Kelas\t: 19 IF 03");

            Console.WriteLine();
            Console.WriteLine("++++ Negara ++++");
            Console.WriteLine();

            Negara negara;

            negara = new Indonesia();
            negara.nmanegara();
            negara.nmaik();
            negara.populasi();

            Console.WriteLine();
            negara = new Rusia();
            negara.nmanegara();
            negara.nmaik();
            negara.populasi();

            Console.WriteLine();
            negara = new Jepang();
            negara.nmanegara();
            negara.nmaik();
            negara.populasi();



            Console.WriteLine();
            Console.WriteLine("++++ Music Genre ++++");
            Console.WriteLine();

            IGenre genre;

            genre = new Pop();
            genre.jenis();
            genre.info();

            Console.WriteLine();
            genre = new Jazz();
            genre.jenis();
            genre.info();

            Console.WriteLine();
            genre = new Hiphop();
            genre.jenis();
            genre.info();

            Console.ReadKey();
        }
    }
}
