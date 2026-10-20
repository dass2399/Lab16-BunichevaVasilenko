// Console.Write("Сколько студентов в группе? ");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];

// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
// }

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// double sum = 0;
// for (int i = 0; i < grades.Length; i++)
// {
//     sum += grades[i];
// }
// double average = sum / grades.Length;
// Console.WriteLine($"Средний балл группы: {average:F2}");

int[] points = { 4, 7, 12, 9, 15 };

for (int i = 0; i < points.Length; i++)
{
    if (points[i] < 10)
    {
        points[i] = points[i] + 1;
    }
}

foreach (int point in points)
{
    Console.WriteLine(point);
}