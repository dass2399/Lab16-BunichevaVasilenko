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

// int[] points = { 4, 7, 12, 9, 15 };

// for (int i = 0; i < points.Length; i++)
// {
//     if (points[i] < 10)
//     {
//         points[i] = points[i] + 1;
//     }
// }

// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }


// int[] grades = { 4, 5, 3, 5, 4, 2 };

// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[j] < grades[j + 1]) 
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

int[] GenerateScheduleSlots(int lessonsCount)
{
    int[] slots = new int[lessonsCount];
    for (int i = 0; i < lessonsCount; i++)
    {
        slots[i] = i + 1;
    }
    return slots;
}

int[] GenerateEvenSlots(int lessonsCount)
{
    int[] slots = new int[lessonsCount];
    for (int i = 0; i < lessonsCount; i++)
    {
        slots[i] = (i + 1) * 2;
    }
    return slots;
}

Console.WriteLine("Все уроки:");
int[] slots = GenerateScheduleSlots(6);
foreach (int slot in slots)
{
    Console.WriteLine(slot);
}

Console.WriteLine("Только четные уроки:");
int[] evenSlots = GenerateEvenSlots(6);
foreach (int slot in evenSlots)
{
    Console.WriteLine(slot);
}