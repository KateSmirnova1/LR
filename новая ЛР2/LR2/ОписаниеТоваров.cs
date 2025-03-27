using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class ОписаниеТоваров
    {
        private string Название { get; set; }
        private double Цена { get;  set; }
        private СпортТовары Группа { get;  set; }

        // Конструктор
        public ОписаниеТоваров(string название, double цена, СпортТовары группа)
        {
            Название = название;
            Цена = цена;
            Группа = группа;
        }
        public double GetPrice()
        {
            return Цена;
        }
        public string GetTitle()
        {
            return Название;
        }
        public СпортТовары GetGroup()
        {
            return Группа;
        }










    }
}
