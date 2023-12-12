using System.ComponentModel.Design;

// Написать программу, которая задает пользователю вопрос (вопрос полагает однозначный ответ, типа да нет).
// Проверить правильность вопроса. Дать пользователю несколько подсказок и попыток ответить на вопрос.
// Если он угадал спросить у него имя, и вывести на экран поздравление, которое есть конкатенацией нескольких строк, дважды использовав его имя.


List<string> questions = new List<string>() // обьявление списка вопросов
{"Год рождения Николая Васильевича Гоголя - 1809г?(1 да, 0 нет):",
 "C# это обьектно-ориентированный язык?(1 да, 0 нет):",
 "Первым человеком полетевшим в космос является Гагарин?(1 да, 0 нет):",
 "Земля плоская?(1 да, 0 нет):"
};

Menu(questions); // вызов функции

void Menu(List<string> question) { 
    Random rnd = new Random();
    int RandomQuestion = rnd.Next(0,questions.Count); // генерация случайного числа для выбора вопроса
    int res;
    string name;
    switch (RandomQuestion)
    {
        case 0: 
            Console.WriteLine(questions[0]);
            res = int.Parse(Console.ReadLine());
                for(;res < 1;) {
                    if(res == 0) 
                    {
                        Console.WriteLine("Подумайте внимательно :)");
                        Console.WriteLine("Подсказка: число заканчивается на 09");
                        Console.WriteLine(questions[0]);
                        res = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Вы правильно ответили на вопрос!!!  Введите Ваше имя латиницей:");
                name = Console.ReadLine();
                Console.WriteLine($"\n{name}, от всей души поздравляем Вас!!! Все цветы у Ваших ног, {name}");
            break;
        case 1: 
            Console.WriteLine(questions[1]);
            res = int.Parse(Console.ReadLine());
                for(;res < 1;) {
                    if(res == 0) 
                    {
                        Console.WriteLine("Подумайте внимательно :)");
                        Console.WriteLine("Подсказка: да");
                        Console.WriteLine(questions[1]);
                        res = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Вы правильно ответили на вопрос!!!  Введите Ваше имя латиницей:");
                name = Console.ReadLine();
                Console.WriteLine($"\n{name}, от всей души поздравляем Вас!!! Все цветы у Ваших ног, {name}");
            break;
        case 2: 
            Console.WriteLine(questions[2]);
            res = int.Parse(Console.ReadLine());
                for(;res < 1;) {
                    if(res == 0) 
                    {
                        Console.WriteLine("Подумайте внимательно :)");
                        Console.WriteLine("Подсказка: Его имя - Юрий");
                        Console.WriteLine(questions[2]);
                        res = int.Parse(Console.ReadLine());
                    }
             }
                Console.WriteLine("Вы правильно ответили на вопрос!!!  Введите Ваше имя латиницей:");
                name = Console.ReadLine();
                Console.WriteLine($"\n{name}, от всей души поздравляем Вас!!! Все цветы у Ваших ног, {name}");
            break;
        case 3: 
            Console.WriteLine(questions[3]);
            res = int.Parse(Console.ReadLine());
                for(;res >= 1;) {
                    if(res == 1) 
                    {
                        Console.WriteLine("Подумайте внимательно :)");
                        Console.WriteLine("Подсказка: Теория плоской земли является вымышленной");
                        Console.WriteLine(questions[3]);
                        res = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Вы правильно ответили на вопрос!!!  Введите Ваше имя латиницей:");
                name = Console.ReadLine();
                Console.WriteLine($"\n{name}, от всей души поздравляем Вас!!! Все цветы у Ваших ног, {name}");
            break;
    }
}
