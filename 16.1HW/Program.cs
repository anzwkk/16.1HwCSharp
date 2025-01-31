//мета - створити програму, яка копіює вміст одного текстового файлу в інший. Користувач повинен ввести шлях
//до вихідного файлу та шлях до файлу, в який потрібно скопіювати дані. Після виконання копіювання виведіть повідомлення про успішне завершення.

using System;
using System.IO;

class Program
{
    static void Main()
    {

        try
        {

            Console.Write("Введіть шлях до вихідного файлу: ");
            string sourcePath = Console.ReadLine();

            Console.Write("Введіть шлях до файлу, в який потрібно скопіювати дані: ");
            string destinationPath = Console.ReadLine();

            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, destinationPath, true);
                Console.WriteLine("Файл успішно скопійовано!");
            }
            else
            {
                Console.WriteLine("Вихідний файл не знайдено");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сталася помилка: {ex.Message}");
        }
    }
}