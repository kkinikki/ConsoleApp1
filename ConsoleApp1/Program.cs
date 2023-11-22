using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualBasic;
using System.Windows.Forms;
namespace ConsoleApp1
{
    internal class Program
    {
        static void task2()
        {
            string name = Interaction.InputBox("Введите свое имя: ");
            string surname = Interaction.InputBox("Введите свою фамилию: ");
            MessageBox.Show(
                $"Ваше имя и фамилия: {name} " +
                $"{surname}");
        }
        static void task3()
        {
            string name;
            name = Interaction.InputBox(
                "Введите имя и фамилию");

            string age;
            age = Interaction.InputBox(
                "Введите сколько вам лет");
            MessageBox.Show("Имя и фамилия студента и возраст :" + name +  " " + $"{age}");
        }
        static void task5()
        {
            string month;
            month = Interaction.InputBox(
                "Введите название месяца: ");

            string days;
            days = Interaction.InputBox(
                "Введите количество дней в этом месяце: ");

            MessageBox.Show($"Месяц {month} содержит {days} дней");



        }
        static void task4()
        {
            string week;
            week = Interaction.InputBox(
                "День недели: ");

            string month;
            month = Interaction.InputBox(
                "Текущий месяц: ");

            string days;
            days = Interaction.InputBox(
                "Число: ");

            MessageBox.Show($"День недели {week} число {days} месяц {month}");



        }
        static void task6()
        {
            string res, txt;
            int year = 2023, age, born;
            res = Interaction.InputBox("Год рождения:");
            born = Int32.Parse(res);
            age = year - born;
            txt = "Вам " + age + " лет";
            MessageBox.Show(txt, "Возраст");
        }

        static void task7()
        {
            string name;
            name = Interaction.InputBox(
                "Введите имя и фамилию");
            string res;
            int born,year = 2023;
            
            res = Interaction.InputBox("Введите ваш год рождения:");
            born = Int32.Parse(res);
            int age = year - born;
            MessageBox.Show(
                $"Вас зовут : {name} и вам {age}");
        }

        static void task8()
        {
            string age;
            age = Interaction.InputBox(
                "Введите сколько вам лет");
            int age1 = Int32.Parse(age); 
            int year = 2023;
            int result = year - age1;

            MessageBox.Show(
                $"Вы родились в {result} году");
        }

        static void task9() 
        {
            string num1, num2;

            num1 = Interaction.InputBox(
                "Введите первое число: ");
            num2 = Interaction.InputBox(
                "Введите второе число: ");

            int num3 = Int32.Parse(num1);
            int num4 = Int32.Parse(num2);

            int result = num3 + num4;

            MessageBox.Show(
                $"Сумма заданных чисел равна = {result}");

        }

        static void task10()
        {
            string num1;
            num1 = Interaction.InputBox(
                "Введите число: ");
            int num2 = Int32.Parse(num1);

            MessageBox.Show(
                $"{num2 - 1} , {num2} , {num2 + 1}");
        }

        static void task11()
        {
            string num1,num2;
            num1 = Interaction.InputBox(
                "Введите первое число: ");
            num2 = Interaction.InputBox(
                "Введите второе число: ");

            int num3 = Int32.Parse(num1);
            int num4 = Int32.Parse(num2);

            int result = num3 - num4;
            int result1 = num3 + num4;

            MessageBox.Show($"Разность чисел равна: {result}" + " " + $"Сумма чисел равна: {result1}");

        }
        static void Main(string[] args)
        {
            /*task2();*/
            /*task3();*/
            /*task4();*/
            /*task5();*/
            /*task6();*/
            /*task7();*/
            /*task8();*/
            /*task9();*/
            /*task10();*/
            /*task11();*/
        }
    }
}
