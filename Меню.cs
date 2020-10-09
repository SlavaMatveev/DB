using System;
using System.Collections.Generic;

namespace Restaurant
{
    public partial class Меню
    {
        public Меню()
        {
            ЗаказКодБлюда2кодБлюдаNavigation = new HashSet<Заказ>();
            ЗаказКодБлюда3кодБлюдаNavigation = new HashSet<Заказ>();
            ЗаказКодБлюдаNavigation = new HashSet<Заказ>();
        }

        public long ОбъёмИнгридиента1 { get; set; }
        public long ВремяПриготовления { get; set; }
        public long НаименованиеБлюда { get; set; }
        public long КодБлюда { get; set; }
        public long ОбъёмИнгридиента2 { get; set; }
        public long ОбъёмИнгридиента3 { get; set; }
        public long Стоимость { get; set; }
        public long КодИнгредиента { get; set; }
        public long КодИнгридиента3кодИнгредиента { get; set; }
        public long КодИнгридиента2кодИнгредиента { get; set; }

        public virtual Склад КодИнгредиентаNavigation { get; set; }
        public virtual Склад КодИнгридиента2кодИнгредиентаNavigation { get; set; }
        public virtual Склад КодИнгридиента3кодИнгредиентаNavigation { get; set; }
        public virtual ICollection<Заказ> ЗаказКодБлюда2кодБлюдаNavigation { get; set; }
        public virtual ICollection<Заказ> ЗаказКодБлюда3кодБлюдаNavigation { get; set; }
        public virtual ICollection<Заказ> ЗаказКодБлюдаNavigation { get; set; }
    }
}
