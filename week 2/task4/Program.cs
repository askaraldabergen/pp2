using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = "file.txt";//строка файл.тхт

            string path = @"C:\Users\Sony\Desktop\askar2";//путь первой папки
            string path1 = @"C:\Users\Sony\Desktop\askar3";//путь второй папки

            string source = Path.Combine(path, f);//объединил путь первой папки и названия файла
            string dest = Path.Combine(path1, f);//объединил путь второй папки и названия файла

            FileStream fs = File.Create(source);//создаю файлстрим и создаю файл
            StreamWriter sr = new StreamWriter(fs);//создаю стримрайтер
         //ввод строки в файл
        //закрываю стрирайтер
            fs.Close();//закрываю файлстрим



            File.Copy(source, dest, true);//копирую в другую папку

            File.Delete(source);//удаляю первоначальный файл

        }
    }
}