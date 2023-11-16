using System;

namespace labatym10
{
    class Program
    {
        static void Main()
        {
            bool tasksEnd = false;
            string taskNumber;

            do
            {
                Console.WriteLine("Лаба Тумакова 10");
                Console.WriteLine("Подсказка:\n" +
                                  "Упражнение 10.1.              -   цифра 1\n" +
                                  "Домашнее задание 10.1.        -   цифра 2\n" +
                                  "Закончить выполнение заданий и выйти из программы                    -   цифра 0\n");

                Console.Write("Введите номер задания: ");
                taskNumber = Console.ReadLine();

                switch (taskNumber)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Упражнение 10.1");

                        Console.WriteLine("Первый способ шифрования");
                        Console.Write("Введите строку для шифорвания: ");

                        ACipher firstMessage = new ACipher(Console.ReadLine());
                        firstMessage.Encode();
                        Console.WriteLine($"Сообщение зашифровано: {firstMessage.Message}");

                        firstMessage.Decode();
                        Console.WriteLine($"Сообщение расшифровано: {firstMessage.Message}");

                        Console.WriteLine("Второй способ шифрования");
                        Console.Write("Введите строку для шифорвания: ");

                        BCipher secondMessage = new BCipher(Console.ReadLine());
                        secondMessage.Encode();
                        Console.WriteLine($"Сообщение зашифровано: {secondMessage.Message}");

                        secondMessage.Decode();
                        Console.WriteLine($"Сообщение расшифровано: {secondMessage.Message}");

                        Console.Write("Нажмите на любую кнопку ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Домашнее упражнение 10.2");

                        Point point = new Point("red", true);
                        Circle circle = new Circle(10, "blue", false);
                        Rectangle rectangle = new Rectangle(5, 10.3, "yellow", true);

                        point.DisplayingFigureData();
                        circle.DisplayingFigureData();
                        rectangle.DisplayingFigureData();
                        Console.WriteLine();

                        point.ChangingColorOfFigure("yellow");
                        circle.ChangingColorOfFigure("black");
                        rectangle.ChangingColorOfFigure("white");

                        point.FigureStatusSurvey();
                        circle.FigureStatusSurvey();
                        rectangle.FigureStatusSurvey();
                        Console.WriteLine();

                        point.MovementHorizontally();
                        circle.MovementHorizontally();
                        circle.MovementHorizontally();
                        rectangle.MovementVertically();

                        circle.CalculationOfArea();
                        rectangle.CalculationOfArea();
                        Console.WriteLine();

                        point.DisplayingFigureData();
                        circle.DisplayingFigureData();
                        rectangle.DisplayingFigureData();
                        Console.WriteLine();

                        Console.Write("Нажмите на любую кнопку ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("Завершение работы");
                        tasksEnd = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Такого задания не сущ");
                        break;
                }
            } while (!tasksEnd);
        }
    }
}