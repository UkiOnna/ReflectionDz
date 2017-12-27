using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            string password = "qwerty";
            string login = "endless2008";

            Console.WriteLine("Задание 2:");

            user.Login = login;
            user.Password = password;

            Type type = typeof(User);

            var properties = type.GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                var name = properties[i];
                Console.WriteLine(properties[i] + "  " + properties[i].GetValue(user));
            }

            Console.ReadLine();

            Task1();
            Console.ReadLine();
        }

        private static void Task1()
        {
            Console.WriteLine("Задание 1: ");

            Type type = typeof(Console);

            var membersInfo = type.GetMethods();

            foreach (var info in membersInfo)
            {
                Console.WriteLine(info);
            }
        }
    }
}
