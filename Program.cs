using System;
using System.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Homework1
{
    

    }
class Employee
{


    public int salary { get; set; }
    public string name { get; set; }
    public string post { get; set; }
    static void Main(string[] args)
    {
        Console.WriteLine("Приветствуем вас в системе работник!");
        Employee employee1 = new Employee();
        Employee employee2 = new Employee();
        Employee employee3 = new Employee();
        Employee employee4 = new Employee();
        Employee employee5 = new Employee();
        int[] array = new int[5];
        array[0] = 1000;
        array[1] = 2000;
        array[2] = 1500;
        array[3] = 1497;
        array[4] = 1867;
        string[] array2 = new string[5];
        array2[0] = "Менеджер";
        array2[1] = "Доставщик";
        array2[2] = "Доктор";
        array2[3] = "Повар";
        array2[4] = "Учитель";
        employee1.name = "Кирилл";
        employee1.post = array2[0];
        employee1.salary = array[0];
        employee2.name = "Вадим";
        employee2.post = array2[1];
        employee2.salary = array[1];
        employee3.name = "Таня";
        employee3.post = array2[2];
        employee3.salary = array[2];
        employee4.name = "Оля";
        employee4.post = array2[3];
        employee4.salary = array[3];
        employee5.name = "Игорь";
        employee5.post = array2[4];
        employee5.salary = array[4];
        int[] numbers = { array[0], array[1], array[2], array[3], array[4] };
        int biggestNumber = numbers.Max();
        if (biggestNumber == array[0])
        {
            Console.WriteLine($"Наибольшая зарплата у {employee1.name}, должность {employee1.post}, зарплата {employee1.salary}");
        }
        else if (biggestNumber == array[1])
        {
            Console.WriteLine($"Наибольшая зарплата у {employee2.name}, должность {employee2.post}, зарплата {employee2.salary}");
        }
        else if (biggestNumber == array[2])
        {
            Console.WriteLine($"Наибольшая зарплата у {employee3.name}, должность {employee3.post}, зарплата {employee3.salary}");
        }
        else if (biggestNumber == array[3])
        {
            Console.WriteLine($"Наибольшая зарплата у {employee4.name}, должность {employee4.post}, зарплата {employee4.salary}");
        }
        else if (biggestNumber == array[4])
        {
            Console.WriteLine($"Наибольшая зарплата у {employee5.name}, должность {employee5.post}, зарплата {employee5.salary}");
        }
        string s1;
        Console.WriteLine("Выберете должность- Менеджер, Доставщик, Доктор, Повар, Учитель");
        s1 = Console.ReadLine();



        if (s1 == array2[0])
        {
            Console.WriteLine($"{s1} схожие должности {array2[0]} , работает на ней {employee1.name}");
        }
        else if (String.Equals(s1, array2[1]))
        {
            Console.WriteLine($"{s1} схожие должности {array2[1]} , работает на ней {employee2.name}");
        }
        else if (String.Equals(s1, array2[2]))
        {
            Console.WriteLine($"{s1} схожие должности {array2[2]} , работает на ней {employee3.name}");
        }
        else if (String.Equals(s1, array2[3]))
        {
            Console.WriteLine($"{s1} схожие должности {array2[3]} , работает на ней {employee4.name}");
        }
        else if (String.Equals(s1, array2[4]))
        {
            Console.WriteLine($"{s1} схожие должности {array2[4]} , работает на ней {employee5.name}");
        }
        else
        {
            Console.WriteLine("Никто не работает на данной должности");
        }





    }
}





/*int act = rnd.Next(0, 3);
if (act == 0)
{
    Console.WriteLine("Черизард атакует,осторожно");
    Pokemon1.Attack1(Pokemon2);

}
else if (act == 1)
{
    Console.WriteLine("Черизард блокирует,его броня ослабла");
    Pokemon1.Block1(Pokemon2);

}
else if (act == 2)
{
    Console.WriteLine("Черизард уворачивается,его ловкость уменьшилась)");
    Pokemon1.Evasion1(Pokemon2);
*/