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
                Name = "Окунь",
                Weight = "1кг",
                Distribution_area = "водоемы",
                TypeOfAnimal = "рыбы"

            });
            X.Add(new Animal
            {
                Name = "Карась",
                Weight = "1кг",
                Distribution_area = "водоемы",
                TypeOfAnimal = "рыбы"

            });
            X.Add(new Animal
            {
                Name = "Щука",
                Weight = "1кг",
                Distribution_area = "водоемы",
                TypeOfAnimal = "рыбы"

            });
            X.Add(new Animal
            {
                Name = "Сорока",
                Weight = "0,4кг",
                Distribution_area = "наземно-воздушная",
                TypeOfAnimal = "города, леса"

            });
            X.Add(new Animal
            {
                Name = "Синица",
                Weight = "0,1кг",
                Distribution_area = "наземно-воздушная",
                TypeOfAnimal = "леса, сады, короче где есть деревья"

            });
            X.Add(new Animal
            {
                Name = "Кукушка",
                Weight = "0,2кг",
                Distribution_area = "лес",
                TypeOfAnimal = "птицы"

            });
            X.Add(new Animal
            {
                Name = "Муравей",
                Weight = "0.01кг",
                Distribution_area = "везде",
                TypeOfAnimal = "насекомое"

            });
            X.Add(new Animal
            {
                Name = "Стрекоза",
                Weight = "0.01кг",
                Distribution_area = "пресные водоемы",
                TypeOfAnimal = "насекомое"

            });
            X.Add(new Animal
            {
                Name = "Колорадский жук",
                Weight = "1кг",
                Distribution_area = "сельскохозяйственная местность",
                TypeOfAnimal = "насекомое"

            });
            

        }
        public Animal GetName(string name)
        {
            return X.Find(e => e.Name == name);

        }

    }
}
