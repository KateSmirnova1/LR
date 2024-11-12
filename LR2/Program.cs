using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ОписаниеТоваров> Товары = new List<ОписаниеТоваров>()
            {
                new ОписаниеТоваров("Ракетка теннисная",1500,СпортТовары.Теннис),
                new ОписаниеТоваров("Мяч футбольный",500,СпортТовары.Футбол),
                new ОписаниеТоваров("Сетка волейбольная",2300,СпортТовары.Волейбол),
                new ОписаниеТоваров("Кольцо баскетбольное",3000,СпортТовары.Баскетбол)
            };
        }
    }
}
