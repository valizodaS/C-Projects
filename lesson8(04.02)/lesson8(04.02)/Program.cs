using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чтобы выйти нажмите q где угодно!");
            string q;
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Вставить /n2. Показать все /n3. Выбрать по id/n4. Обновить /n5. Удалить ");
                Console.Write("Ваш выбор: ");

                q = Console.ReadLine();
                if (q == "q")
                {
                    Console.WriteLine("Спасибо за использование!");
                    return;
                }
                int x = Convert.ToInt32(q);
                var person = new Person();
                if (x == 1)
                {
                    Console.Write("Вводите имя: ");
                    var name = Console.ReadLine();
                    Console.Write("Вводите фамилию: ");
                    var lastname = Console.ReadLine();
                    Console.Write("Вводите отчество: ");
                    var middlename = Console.ReadLine();
                    Console.Write("Вводите дату рождение[yyyy-mm-dd]: ");
                    var birthday = Console.ReadLine();
                    person.Insert(name, lastname, middlename, birthday);
                }
                else if (x == 2)
                {
                    person.SellectAll();
                }
                else if (x == 3)
                {
                    person.SellectAll();
                    Console.Write("Вводите id человека которого хотите увидеть: ");
                    var id = Convert.ToInt32(Console.ReadLine());
                    person.SellectById(id);
                }
                else if (x == 4)
                {
                    person.SellectAll();
                    Console.Write("Вводите id человека которого хотите изменить: ");
                    var id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Вводите номера параметров которые хотите менять(1-4)/n Например 134 то есть имя отчество и дата рождение ");
                    Console.WriteLine("1)FirstName 2)LastName 3)MiddleName 4)Birthdate ");
                    Console.Write("Ваши выборы: ");
                    String ss = Console.ReadLine();
                    string choice = (((ss.Replace("1", "FirstName")).Replace("2", "LastName")).Replace("3", "MiddleName")).Replace("4", "Birthdate");
                    string sd = (((ss.Replace("1", "Имя")).Replace("2", " Фамилия")).Replace("3", " Отчество")).Replace("4", " Дата рождене");
                    Console.Write("Вводите  "+sd);
                    var newinfo = Console.ReadLine();

                    person.Update(id, choice, newinfo);
                }
                else if (x == 5)
                {
                    Console.Write("Вводите id человека чтобы удалить его:");
                    var id = Convert.ToInt32(Console.ReadLine());
                    person.Delete(id);
                }
                else
                    Console.WriteLine("Вы ввели неправильно. /n");
            }
        }
        class Person
        {
            public void con(string con)
            {
                string conString = @"Data Source=sa; Initial Catalog=sami;Integrated Security=True";
                SqlConnection connection = new SqlConnection(conString);

                try
                {

                    Console.WriteLine(conString);
                    connection.Open();

                    Console.WriteLine(conString);
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand command = connection.CreateCommand();
                        command.CommandText = con;
                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Console.WriteLine("ID = " + reader["id"]);
                            Console.WriteLine("FirstName: " + reader["FirstName"]);
                            Console.WriteLine("LastName: " + reader["LastName"]);
                            Console.WriteLine("MiddleName: " + reader["MiddleName"]);
                            Console.WriteLine("BirthDate: " + reader["BirthDate"]);
                            Console.WriteLine();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }

            }
            public void Insert(string firstname, string lastname, string middlename, string birthday)
            {
                var comtext = "Insert into PesonTable(" + "FirstName," + "LastName," + "MiddleName," + "Birthdate) Values(" + "'" + firstname + "'," + "'" + lastname + "'," + "'" + middlename + "'," + "'" + birthday + "')";
                con(comtext);
                Console.WriteLine("Добавлено!");


            }
            public void SellectAll()
            {
                var comtext = "SELECT * FROM PesonTable";
                con(comtext);
            }
            public void SellectById(int id)
            {
                var comtext = "SELECT * FROM PesonTable  where Id = '" + id + "'";
                con(comtext);
            }
            public void Update(int id, string choice, string newinfo)
            {
                var comtext = "UPDATE PesonTable  SET " + choice + " = '" + newinfo + "' WHERE Id=" + id;
                con(comtext);
            }
            public void Delete(int id)
            {
                var comtext = "DELETE FROM PesonTable WHERE Id = '" + id + "'";
                Console.WriteLine("Удалено !!");
                con(comtext);
            }
        }

    }
}