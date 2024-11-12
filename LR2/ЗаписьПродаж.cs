using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public struct ЗаписьПродаж
    {
        public int количество;
        public int День;
        public ОписаниеТоваров ОписаниеТоваров;


        public ЗаписьПродаж(ОписаниеТоваров Т, int День_, int количество_)
        {
            ОписаниеТоваров = Т;           
            День = День_;
            количество = количество_;
        }

    }
}
