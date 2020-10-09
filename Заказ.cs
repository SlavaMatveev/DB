using System;
using System.Collections.Generic;

namespace Restaurant
{
    public partial class Заказ
    {
        public Заказ()
        {
            Сотрудники = new HashSet<Сотрудники>();
        }

        public long Время { get; set; }
        public long Дата { get; set; }
        public long ОтметкаОВыполнении { get; set; }
        public long Стоимость { get; set; }
        public long ФиоЗаказчика { get; set; }
        public long Телефон { get; set; }
        public long КодЗаказа { get; set; }
        public long КодБлюда { get; set; }
        public long КодБлюда2кодБлюда { get; set; }
        public long КодБлюда3кодБлюда { get; set; }

        public virtual Меню КодБлюда2кодБлюдаNavigation { get; set; }
        public virtual Меню КодБлюда3кодБлюдаNavigation { get; set; }
        public virtual Меню КодБлюдаNavigation { get; set; }
        public virtual ICollection<Сотрудники> Сотрудники { get; set; }
    }
}
