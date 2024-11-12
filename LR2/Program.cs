using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ИсторияПродаж История = new ИсторияПродаж();
            История.НоваяЗапись(new ЗаписьПродаж(new ОписаниеТоваров("Мяч футбольный", 1500, СпортТовары.Футбол) 4, 5));
            Console.WriteLine(История.ConvertString()); 
        }
    }
}
