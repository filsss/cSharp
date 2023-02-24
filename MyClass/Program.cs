using System;

namespace MyClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);
            Book.SetPrice(12);
            b1.Show();
            Console.WriteLine("\n Итоговая стоимость аренды: {0} p.",b1.PriceBook(3));
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013);
            b2.Show();
            Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
            b3.Show();
            Triangle t1 = new Triangle(2,4,47);
            t1.SideShow();
            t1.Perimetr();
            t1.Area();
            t1.Check();
            IntTable it1 = new IntTable(2);
            it1.ReadArrey();
            it1.ShowArray();
            it1.Summ();
            it1.Scalar();
            it1.ShowArray();
            Console.ReadKey();

        }
    }
}