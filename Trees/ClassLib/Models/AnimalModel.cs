using System.Collections.Generic;

namespace ClassLib.Models
{
    public class AnimalModel
    {
        public List<Animal> X { get; }
        public string Name { get; private set; }

        public AnimalModel()
        {
            X = new List<Animal>();

            X.Add(new Animal
            {
                Name = "Голубь",
                Weight = "1кг",
                Distribution_area = "везде",
                TypeOfAnimal = "птицы"


            });
        }
        public Animal GetName(string name)
        {
            return X.Find(e => e.Name == Name);

        }

    }
}
