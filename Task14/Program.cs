using System.ComponentModel.Design;
using System;
using System.Collections.Generic;

// Написать программу, которая задает пользователю вопрос (вопрос полагает однозначный ответ, типа да нет).
// Проверить правильность вопроса. Дать пользователю несколько подсказок и попыток ответить на вопрос.
// Если он угадал спросить у него имя, и вывести на экран поздравление, которое есть конкатенацией нескольких строк, дважды использовав его имя.

Random rnd = new Random();
List<Question> q = new List<Question>();
q.Add(new Question("Какого цвета небо?  \n1.Голубой\n2.Жёлтый\n3.Зелёный\n4.Красный ", new string[] { "Подсказка: оттенок синего"}, 1));
q.Add(new Question("Какой формы планета земля?\n1.Куб\n2.Пирамида\n3.Шар\n4.Тарелка", new string[] { "Подсказка: шар" }, 3));
q.Add(new Question("Какой полюс холоднее?\n1.Северный\n2.Южный", new string[] {"Подсказка: всё не так как кажется" }, 2));
    while (q.Count > 0)
    {
        Question current_question = q[rnd.Next(0, q.Count)];
        Console.WriteLine(current_question.question);
        int input = WriteAndGetAnswer(current_question);
        if (input == current_question.correct_answer)
        {
            Console.WriteLine("Верный ответ!");
        }
        q.Remove(current_question);
        Console.WriteLine();
    }
        
 
int WriteAndGetAnswer(Question q)
{
    Console.Write("Введите номер ответа:");
    int input = int.Parse(Console.ReadLine());
    if (q.correct_answer == input){
        return q.correct_answer;
    }
    else
    {
        while(input != q.correct_answer) {
        Console.WriteLine($"Неверно! {q.tips[q.correct_answer - q.correct_answer]}");
        input = int.Parse(Console.ReadLine());
        }
        return input;
    }
        }
    
 
    public class Question
    {
        public string question;
        public string[] tips;
        public int correct_answer;
 
        public Question(string question, string[] tips, int correct_answer)
        {
            this.question = question;
            this.tips = tips;
            this.correct_answer = correct_answer;
        }
    }
