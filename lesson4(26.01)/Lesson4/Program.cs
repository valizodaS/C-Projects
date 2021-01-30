using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            DZ1 dz1 = new DZ1();
            dz1.Task3();
            DZ2 dz2 = new DZ2();
            //dz2.Task2();
            Console.ReadLine();
        }
    }

    class DZ1
    {
        public void Task1()
        {
            Console.WriteLine("Вводите стороны прямоугольника через пробел: ");
            String s = Console.ReadLine();
            double side1 = Convert.ToDouble(s.Split(' ')[0]);
            double side2 = Convert.ToDouble(s.Split(' ')[1]);
            Rectangle pryamougolnik = new Rectangle(side1, side2);
            Console.WriteLine("Плошадь прямоугольника = {0:F2}", pryamougolnik.Area);
            Console.WriteLine("Периметр прямоугольника = {0:F2}", pryamougolnik.Perimeter);

        }

        public void Task2()
        {
            Console.WriteLine("Вводите Титл:");
            string title = Console.ReadLine();
            Console.WriteLine("Вводите ФИО автора:");
            string author = Console.ReadLine();
            Console.WriteLine("Вводите контент:");
            string content = Console.ReadLine();
            Book kniga = new Book(title, author, content);
            kniga.Show();

        }
        public void Task3()
        {
            Car mercedes = new Car(name: "Mercedes-Benz", brand: "Mercedes", fuelSource:"Benzene", yearOfIndustry: 2018);
            mercedes.ShowInfo();
            mercedes.Drive();
        }
    }
    class DZ2
    {
        public void Task1()
        {
            double usd, eur, rub;
            Console.WriteLine("Вводите сколбко USD будет 1 сомон:");
            usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вводите сколбко EUR будет 1 сомон:");
            eur = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вводите сколбко RUB будет 1 сомон:");
            rub = Convert.ToDouble(Console.ReadLine());
            Converter converter = new Converter(usd, eur, rub);
            Console.WriteLine(converter.ToEur(50.25) + "EUR");
            Console.WriteLine(converter.ToUsd(50.25) + "USD");
            Console.WriteLine(converter.ToRub(50.25) + "RUB");
            Console.WriteLine(converter.FromEur(50.25) + "Сомони");
            Console.WriteLine(converter.FromUsd(50.25) + "Сомони");
            Console.WriteLine(converter.FromRub(50.25) + "Сомони");

        }
        public void Task2()
        {
            Console.WriteLine("Вводите Фамилию и Имя Сотрудника:");
            string surname = Console.ReadLine();
            string name = surname.Split(' ')[1];
            surname = surname.Split(' ')[0];
            Console.WriteLine("Вводите уровень должности сотрудника:");
            int dolj = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вводите стаж сотрудника:");
            int staj = Convert.ToInt32(Console.ReadLine());
            Employee emp = new Employee(surname, name);
            emp.doljnost = dolj;
            emp.staj = staj;
            emp.ShowInfo();

        }
    }




    //task1 for dz1
    class Rectangle
    {
        public double side1, side2;
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter {
            get
            {
                return PerimeterCalculator();
            }
        }
        public double AreaCalculator()
        {
            return this.side2 * this.side1;
        }
        public double PerimeterCalculator()
        {
            return 2 * (this.side2 + this.side1);
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
    }

    // task2 for dz1
    class Title
    {
        public String title { get; set; }
        public void Show() {
            Console.WriteLine("Название книги:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Author
    {
        public String FIO { get; set; }
        public void Show()
        {
            Console.WriteLine("ФИО писателя:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(FIO);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Content
    {
        public String txt { get; set; }
        public void Show()
        {
            Console.WriteLine("Содержание книги:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(txt);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Book
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content();

        public Book(String title, String author, String content)
        {
            this.title.title = title;
            this.author.FIO = author;
            this.content.txt = content;
        }
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }

    // task3 for dz1
    class Car
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string FuelSource;
        public int YearOfIndustry;

        public void Drive()
        {
            Console.WriteLine("Зажигаем Мотор. ");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Нажимаем на педали.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Скорость 10");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Скорость 50");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Скорость 100");
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("И мы Летим :)......");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("Мы в пункте назначение!");
        }
        public void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Название: " + Name);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Брэнд: " + Brand);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Горючее: " + FuelSource);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Год выпуска: " + YearOfIndustry.ToString());

        }

        public Car(String name, string brand, string fuelSource, int yearOfIndustry)
        {
            Name = name;
            Brand = brand;
            FuelSource = fuelSource;
            YearOfIndustry = yearOfIndustry;
        }

    }



    //task1 for DZ2
    class Converter
    {
        public double usd { get; set; }
        public double eur { get; set; }
        public double rub { get; set; }

        public double ToUsd(double amount)
        {
            return amount * usd;
        }
        public double ToEur(double amount)
        {
            return amount * eur;
        }
        public double ToRub(double amount)
        {
            return amount * rub;
        }
        public double FromUsd(double amount)
        {
            return amount / usd;
        }
        public double FromEur(double amount)
        {
            return amount / eur;
        }
        public double FromRub(double amount)
        {
            return amount / rub;
        }
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
    }
    //task2 for DZ2
    class Employee
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int doljnost { get; set; }// uroven 1 2 3 4 5 
        public int staj { get; set; }

        public double oklad()
        {
            return 1000 + (staj / 5) * 500 + doljnost * 1000;
        }
        public double nalogi()
        {
            return oklad() * 0.14;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Фамилия Имя Должность(Уровень) ==> " + Surname +" "+ Name+ " " + doljnost);
            Console.WriteLine("Оклад сотрудника состовляет {0} руб", oklad());
            Console.WriteLine("Налоги состовляют {0} руб", nalogi());
            Console.WriteLine("Итого сотрудник на руки получает {0} руб", oklad()-nalogi());

        }
        public Employee(string surname, string name)
        {
            Surname = surname;
            Name = name;
            doljnost = 3;
            staj = 16;
        }
    }
}
