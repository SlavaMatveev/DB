using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Restaurant
{
    public partial class restaurantMP31Context : DbContext
    {
        public restaurantMP31Context()
        {
        }

        public restaurantMP31Context(DbContextOptions<restaurantMP31Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Должности> Должности { get; set; }
        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Меню> Меню { get; set; }
        public virtual DbSet<Склад> Склад { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\PC-01\\Desktop\\SQLiteStudio\\restaurant-MP-31.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Должности>(entity =>
            {
                entity.HasKey(e => e.КодДолжности);

                entity.Property(e => e.КодДолжности)
                    .HasColumnName("Код_должности")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.НаименованиеДолжности)
                    .HasColumnName("Наименование_должности")
                    .HasColumnType("INT");

                entity.Property(e => e.Обязанности).HasColumnType("INT");

                entity.Property(e => e.Оклад).HasColumnType("INT");

                entity.Property(e => e.Требования).HasColumnType("INT");
            });

            modelBuilder.Entity<Заказ>(entity =>
            {
                entity.HasKey(e => e.КодЗаказа);

                entity.Property(e => e.КодЗаказа)
                    .HasColumnName("Код_заказа")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Время).HasColumnType("INT");

                entity.Property(e => e.Дата).HasColumnType("INT");

                entity.Property(e => e.КодБлюда)
                    .HasColumnName("Код_блюда")
                    .HasColumnType("INT");

                entity.Property(e => e.КодБлюда2кодБлюда)
                    .HasColumnName("Код_блюда_2Код_блюда")
                    .HasColumnType("INT");

                entity.Property(e => e.КодБлюда3кодБлюда)
                    .HasColumnName("Код_блюда_3Код_блюда")
                    .HasColumnType("INT");

                entity.Property(e => e.ОтметкаОВыполнении)
                    .HasColumnName("Отметка_о_выполнении")
                    .HasColumnType("INT");

                entity.Property(e => e.Стоимость).HasColumnType("INT");

                entity.Property(e => e.Телефон).HasColumnType("INT");

                entity.Property(e => e.ФиоЗаказчика)
                    .HasColumnName("ФИО_заказчика")
                    .HasColumnType("INT");

                entity.HasOne(d => d.КодБлюдаNavigation)
                    .WithMany(p => p.ЗаказКодБлюдаNavigation)
                    .HasForeignKey(d => d.КодБлюда)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодБлюда2кодБлюдаNavigation)
                    .WithMany(p => p.ЗаказКодБлюда2кодБлюдаNavigation)
                    .HasForeignKey(d => d.КодБлюда2кодБлюда)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодБлюда3кодБлюдаNavigation)
                    .WithMany(p => p.ЗаказКодБлюда3кодБлюдаNavigation)
                    .HasForeignKey(d => d.КодБлюда3кодБлюда)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Меню>(entity =>
            {
                entity.HasKey(e => e.КодБлюда);

                entity.Property(e => e.КодБлюда)
                    .HasColumnName("Код_блюда")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ВремяПриготовления)
                    .HasColumnName("Время_приготовления")
                    .HasColumnType("INT");

                entity.Property(e => e.КодИнгредиента)
                    .HasColumnName("Код_ингредиента")
                    .HasColumnType("INT");

                entity.Property(e => e.КодИнгридиента2кодИнгредиента)
                    .HasColumnName("Код_ингридиента_2Код_ингредиента")
                    .HasColumnType("INT");

                entity.Property(e => e.КодИнгридиента3кодИнгредиента)
                    .HasColumnName("Код_ингридиента_3Код_ингредиента")
                    .HasColumnType("INT");

                entity.Property(e => e.НаименованиеБлюда)
                    .HasColumnName("Наименование_блюда")
                    .HasColumnType("INT");

                entity.Property(e => e.ОбъёмИнгридиента1)
                    .HasColumnName("Объём_ингридиента_1")
                    .HasColumnType("INT");

                entity.Property(e => e.ОбъёмИнгридиента2)
                    .HasColumnName("Объём_ингридиента_2")
                    .HasColumnType("INT");

                entity.Property(e => e.ОбъёмИнгридиента3)
                    .HasColumnName("Объём_ингридиента_3")
                    .HasColumnType("INT");

                entity.Property(e => e.Стоимость).HasColumnType("INT");

                entity.HasOne(d => d.КодИнгредиентаNavigation)
                    .WithMany(p => p.МенюКодИнгредиентаNavigation)
                    .HasForeignKey(d => d.КодИнгредиента)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодИнгридиента2кодИнгредиентаNavigation)
                    .WithMany(p => p.МенюКодИнгридиента2кодИнгредиентаNavigation)
                    .HasForeignKey(d => d.КодИнгридиента2кодИнгредиента)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодИнгридиента3кодИнгредиентаNavigation)
                    .WithMany(p => p.МенюКодИнгридиента3кодИнгредиентаNavigation)
                    .HasForeignKey(d => d.КодИнгридиента3кодИнгредиента)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Склад>(entity =>
            {
                entity.HasKey(e => e.КодИнгредиента);

                entity.Property(e => e.КодИнгредиента)
                    .HasColumnName("Код_ингредиента")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ДатаВыпуска)
                    .HasColumnName("Дата_выпуска")
                    .HasColumnType("INT");

                entity.Property(e => e.НаименованиеИнгредиента)
                    .HasColumnName("Наименование_ингредиента")
                    .HasColumnType("INT");

                entity.Property(e => e.Объём).HasColumnType("INT");

                entity.Property(e => e.Поставщик).HasColumnType("INT");

                entity.Property(e => e.СрокГодности)
                    .HasColumnName("Срок_годности")
                    .HasColumnType("INT");

                entity.Property(e => e.Стоимость).HasColumnType("INT");
            });

            modelBuilder.Entity<Сотрудники>(entity =>
            {
                entity.HasKey(e => e.КодСотрудника);

                entity.Property(e => e.КодСотрудника)
                    .HasColumnName("Код_сотрудника")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Адрес).HasColumnType("INT");

                entity.Property(e => e.Возраст).HasColumnType("INT");

                entity.Property(e => e.КодДолжности)
                    .HasColumnName("Код_должности")
                    .HasColumnType("INT");

                entity.Property(e => e.КодЗаказа)
                    .HasColumnName("Код_заказа")
                    .HasColumnType("INT");

                entity.Property(e => e.ПаспортныеДанные)
                    .HasColumnName("Паспортные_данные")
                    .HasColumnType("INT");

                entity.Property(e => e.Пол).HasColumnType("INT");

                entity.Property(e => e.Телефон).HasColumnType("INT");

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasColumnType("INT");

                entity.HasOne(d => d.КодДолжностиNavigation)
                    .WithMany(p => p.Сотрудники)
                    .HasForeignKey(d => d.КодДолжности);

                entity.HasOne(d => d.КодЗаказаNavigation)
                    .WithMany(p => p.Сотрудники)
                    .HasForeignKey(d => d.КодЗаказа)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
