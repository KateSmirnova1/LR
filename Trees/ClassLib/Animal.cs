using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Animal
    {
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Distribution_area { get; set; }
        public string TypeOfAnimal { get; set; }

        public static Dictionary<string, string> Aliases = new Dictionary<string, string>()
        {
            { nameof(Name), "Название"},
            { nameof(Weight), "Вес"},
            {nameof(Distribution_area), "Зона распространения" },
            {nameof(TypeOfAnimal), "Тип животного" }
        };

    }
}
