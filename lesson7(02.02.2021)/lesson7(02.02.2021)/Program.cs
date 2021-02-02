using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_02._02._2021_
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone sams = new MobilePhone("Samsung Galaxy S12", "Korea", 2020, true);
            sams.CheckLicence();
            Console.WriteLine("Memory = {0}GB \nRAM = {1}", sams.Memory, sams.RAM);

            Console.ReadLine();
        }
        class MobilePhone
        {
            public string Name ;
            public string MadeIn ;
            public int MadeYear ;
            public int LicenceMonth = 36;
            public double Memory = 128;
            public double RAM = 3.5;
            public bool New;

            public bool CheckLicence()
            {
                if (MadeYear + LicenceMonth/12.0 < DateTime.Now.Year)
                {
                    Console.WriteLine("Licence is out of date!!!\nBuy new phone or prolongate your licence!");
                    return false;
                }
                Console.WriteLine("Your Licance is Up toDate! You have " + (MadeYear * 12 + LicenceMonth - DateTime.Now.Year*12).ToString() + " months left!");
                return true;
            }

            public MobilePhone(string name, string madeIn, int madeYear, Boolean neW)
        {
            this.Name = name;
            this.MadeIn = madeIn;
            this.MadeYear = madeYear;
            this.New = neW;
        }
        }
    }
}
