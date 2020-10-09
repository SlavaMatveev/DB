using System;
using System.Collections.Generic;

namespace Restaurant
{
    public partial class Сотрудники
    {
        public long КодСотрудника { get; set; }
        public long Фио { get; set; }
        public long Возраст { get; set; }
        public long Пол { get; set; }
        public long Адрес { get; set; }
        public long Телефон { get; set; }
        public long ПаспортныеДанные { get; set; }
        public long? КодДолжности { get; set; }
        public long КодЗаказа { get; set; }

        public virtual Должности КодДолжностиNavigation { get; set; }
        public virtual Заказ КодЗаказаNavigation { get; set; }
    }
}
