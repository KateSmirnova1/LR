using System;
using System.Collections.Generic;


namespace LR2
{
    public class ИсторияПродаж
    {
        private List<ЗаписьПродаж> Записи = new List<ЗаписьПродаж>();

        // Метод для добавления новой записи
        public void ДобавитьЗапись(ЗаписьПродаж запись)
        {
            Записи.Add(запись);
        }

        // Метод для подсчёта суммы проданного по товарной группе
        public double РассчитатьСтоимостьПоГруппе(СпортТовары группа)  
        {
            double общаяСтоимость = 0;
            
            foreach (var запись in Записи) 
            {
                if (запись.Товар.GetGroup() == группа) 
                {
                    общаяСтоимость += запись.Товар.GetPrice()* запись.GetKol();
                }
            }

            return общаяСтоимость;
        }

        // Метод для вывода истории продаж
        public void ВывестиИсторию()
        {
            foreach (var запись in Записи)
            {
                Console.WriteLine($"День: {запись.GetDay()}, Товар: {запись.Товар.GetTitle()}, Количество: {запись.GetKol()}");
            }
        }

    }
}
