using System;
using System.Collections.Generic;

namespace Restaurant
{
    public partial class Склад
    {
        public Склад()
        {
            МенюКодИнгредиентаNavigation = new HashSet<Меню>();
            МенюКодИнгридиента2кодИнгредиентаNavigation = new HashSet<Меню>();
            МенюКодИнгридиента3кодИнгредиентаNavigation = new HashSet<Меню>();
        }

        public long СрокГодности { get; set; }
        public long КодИнгредиента { get; set; }
        public long НаименованиеИнгредиента { get; set; }
        public long ДатаВыпуска { get; set; }
        public long Объём { get; set; }
        public long Поставщик { get; set; }
        public long Стоимость { get; set; }

        public virtual ICollection<Меню> МенюКодИнгредиентаNavigation { get; set; }
        public virtual ICollection<Меню> МенюКодИнгридиента2кодИнгредиентаNavigation { get; set; }
        public virtual ICollection<Меню> МенюКодИнгридиента3кодИнгредиентаNavigation { get; set; }
    }
}
