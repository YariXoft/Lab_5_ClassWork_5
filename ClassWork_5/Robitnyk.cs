using System;

namespace RobitnykNamespace
{
    public class Robitnyk
    {
        private string name;
        private double zarplata;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Zarplata
        {
            get { return zarplata; }
            set { zarplata = value; }
        }

        public Robitnyk(string name, double zarplata)
        {
            Name = name;
            Zarplata = zarplata;
        }

        // перевантажуємо + скількі добавити грошей с зарплати
        public static Robitnyk operator +(Robitnyk rob, double summa)
        {
            rob.Zarplata += summa;
            return rob;
        }

        // перевантажуємо - скількі убрати грошей
        public static Robitnyk operator -(Robitnyk rob, double summa)
        {
            rob.Zarplata -= summa;
            return rob;
        }

        // Перевантажуємо == чи рівні зарплати
        public static bool operator ==(Robitnyk rob1, Robitnyk rob2)
        {
            return rob1.Zarplata == rob2.Zarplata;
        }

        // Перевантажуємо != (пара к перевантаженню ==) чи НЕ рівні зарплати
        public static bool operator !=(Robitnyk rob1, Robitnyk rob2)
        {
            return rob1.Zarplata != rob2.Zarplata;
        }

        // Перевантажуємо < чи перша меньша другої type:bool
        public static bool operator <(Robitnyk rob1, Robitnyk rob2)
        {
            return rob1.Zarplata < rob2.Zarplata;
        }

        // Перевантажуємо >(пара к перевантаженню <) чи перша більша другої type:bool
        public static bool operator >(Robitnyk rob1, Robitnyk rob2)
        {
            return rob1.Zarplata > rob2.Zarplata;
        }
    }
}
