
// // // int lessonNumber = 5; 
// // // int totalLessons = 1; 
// // // while (lessonNumber >= totalLessons)
// // // {
// // //     Console.WriteLine($"Пара {lessonNumber}");
// // //     lessonNumber--;
// // // }
// // // Console.WriteLine("Пары закончились");


// // // Console.WriteLine("Вводите оценки по одной, для завершения введите −1:");
// // // int grade = int.Parse(Console.ReadLine());
// // // int count = 0; 

// // // while (grade != -1)
// // // {
// // //     Console.WriteLine($"Оценка принята: {grade}");
// // //     grade = int.Parse(Console.ReadLine());
// // //     count++;
// // // }
// // // Console.WriteLine($"Всего введено оценок: {count}");

int sum = 0;
int count = 0;
int max = int.MinValue; 

Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

while (grade != -1)
{
    sum += grade;
    count++;

    if (grade > max)
        max = grade;

    grade = int.Parse(Console.ReadLine());
}

if (count > 0)
{
    Console.WriteLine($"Средний балл: {(double)sum / count}");
    Console.WriteLine($"Максимальная оценка: {max}");
}
else
{
    Console.WriteLine("Оценок не было введено");
}

string correctPassword = "qwerty123";
int attempts = 0;

while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();
    attempts++;

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешён");
        Console.WriteLine($"Попыток потребовалось: {attempts}");
        break;
    }
    Console.WriteLine("Неверный пароль, попробуйте снова");
}

// string answer;
// do
// {
//     Console.Write("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");
//     Console.Write("Добавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");
// Console.WriteLine("Дневник сохранён");
// 
// А
// int N = 7; 
// int i = 1;

// Console.WriteLine($"Таблица умножения на {N}:");
// while (i <= 10)
// {
//     Console.WriteLine($"{N} × {i} = {N * i}");
//     i++;
// }

// // Г
// int number;

// while (true)
// {
//     Console.Write("Введите целое число: ");
//     number = int.Parse(Console.ReadLine());

//     if (number % 7 == 0)
//     {
//         Console.WriteLine("Найдено!");
//         break;
//     }
// }

// System.Console.WriteLine("Введите целое число");
// int N = int.Parse(Console.ReadLine());
// int a = 1;
// while (a<=N)
// {
//     System.Console.WriteLine($"{a}^2={a * a}");
//     a++;

// }
// int code = 1234;
// bool flag = false;
// while (flag == false)
// {
//     System.Console.WriteLine("Введите код домофона");
//     int cod = int.Parse(Console.ReadLine());
//     if (cod == code)
//     {
//         flag = true;
//     }
// }
// System.Console.WriteLine("Дверь открыта");

