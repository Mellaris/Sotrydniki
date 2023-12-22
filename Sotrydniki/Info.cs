using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotrydniki
{
    internal class Info
    {
        protected int id;
        protected string name;
        protected int age;
        protected int description;
        public void Sozdan(List<Nachal> sotr)
        {
            Console.WriteLine("Необходимо создать 10 сотрудников");
            while (sotr.Count < 10)
            {
                Console.ReadKey();
                Console.Clear();
                sotr.Add(new Nachal());
                Nachal info = sotr.Last();
                info.Inform();
            }
            Console.WriteLine("Сотрудники успешно созданы");
        }
        protected void Inform()
        {
            Console.Write("Введите имя сотрудника: ");
            name = Console.ReadLine();
            Console.Write("Введите возраст сотрудника: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите отдел сотрудника(1 или 2): ");
            description = Convert.ToInt32(Console.ReadLine());
        }
    }
}