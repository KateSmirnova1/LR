using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public struct ЗаписьПродаж
    {
        public int День; 
        public int Количество { get; set; }
        public ОписаниеТоваров Товар { get; set; }

        // Конструктор
        public ЗаписьПродаж(ОписаниеТоваров товар, int день, int количество)
        {
            Товар = товар;
            День = день;
            Количество = количество;
        } 
        
        public int GetDay ()
        {
            return День;
        }

        public int GetKol()
        {
            return Количество ;
        }
        public ОписаниеТоваров GetGoods()
        {
            return Товар;
        }


        

    }
}
