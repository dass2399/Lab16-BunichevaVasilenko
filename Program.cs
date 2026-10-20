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

// int[] GenerateScheduleSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = i + 1;
//     }
//     return slots;
// }

// int[] GenerateEvenSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = (i + 1) * 2;
//     }
//     return slots;
// }

// Console.WriteLine("Все уроки:");
// int[] slots = GenerateScheduleSlots(6);
// foreach (int slot in slots)
// {
//     Console.WriteLine(slot);
// }

// Console.WriteLine("Только четные уроки:");
// int[] evenSlots = GenerateEvenSlots(6);
// foreach (int slot in evenSlots)
// {
//     Console.WriteLine(slot);
// }

// int[] numbers = { 5, 2, 8, 1, 9 };
// Array.Sort(numbers);

// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
// }


//Самостоятельные задания

//А
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());

// int[] squares = new int[n];
// for (int i = 0; i < n; i++)
// {
//     squares[i] = (i + 1) * (i + 1);
// }

// foreach (int sq in squares)
// {
//     Console.WriteLine(sq);
// }

//Б
// int[] arr = { -5, 3, -1, 0, 7, -9, 4 };

// for (int i = 0; i < arr.Length; i++) {
//     if (arr[i] < 0) {
//         arr[i] = 0;
//     }
// }

// foreach (int x in arr) {
//     Console.WriteLine(x);
// }

//В
// int[] arr = { 8, 3, 5, 1, 9, 2 };

// for (int i = 0; i < arr.Length - 1; i++) {
//     for (int j = 0; j < arr.Length - 1 - i; j++) {
//         if (arr[j] < arr[j + 1]) {
//             int temp = arr[j];
//             arr[j] = arr[j + 1];
//             arr[j + 1] = temp;
//         }
//     }
// }

// foreach (int x in arr) {
//     Console.WriteLine(x);
// }

//Г

// int[] GenerateEvenNumbers(int n) {
//     int count = n / 2;
//     int[] result = new int[count];
//     for (int i = 0; i < count; i++) {
//         result[i] = (i + 1) * 2;
//     }
//     return result;
// }

// int[] evens = GenerateEvenNumbers(10);
// foreach (int e in evens) {
//     Console.WriteLine(e);
// }

// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
// if (string.IsNullOrEmpty(surname)) { 
// Console.WriteLine("Фамилия не введена. Завершение работы."); 
// return; 
// } 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
// var assigned = Enumerable.Range(1, 10) 
// .OrderBy(_ => rnd.Next()) 
// .Take(2) 
// .OrderBy(x => x) 
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}"); 


//Буничева 3 вариант

// string[] names = { "Мария", "Алексей", "Ольга", "Борис", "Дмитрий" };

// for (int i = 0; i < names.Length - 1; i++) {
//     for (int j = 0; j < names.Length - 1 - i; j++) {
//         if (string.Compare(names[j], names[j + 1]) > 0) {
//             string temp = names[j];
//             names[j] = names[j + 1];
//             names[j + 1] = temp;
//         }
//     }
// }

// foreach (string name in names) {
//     Console.WriteLine(name);
// }

// //Буничева 8 вариант
// double[] temps = { -5.5, 3.2, -0.1, 10.0, -20.3, 7.8 };

// for (int i = 0; i < temps.Length; i++) {
//     if (temps[i] < 0) {
//         temps[i] = 0;
//     }
// }

// foreach (double t in temps) {
//     Console.WriteLine(t);
// }




//Василенко № 2
int[] arr = { 3, 4, 9, 10, 12, 7, 15, 8 };

for (int i = 0; i < arr.Length; i++) {
    if (arr[i] % 3 == 0) {
        arr[i] = -1;
    }
}
foreach (int x in arr)
{
    Console.WriteLine(x);
}

//Василенко №9
int[] MergeArrays(int[] first, int[] second) {
    int[] result = new int[first.Length + second.Length];
    for (int i = 0; i < first.Length; i++) {
        result[i] = first[i];
    }
    for (int i = 0; i < second.Length; i++) {
        result[first.Length + i] = second[i];
    }
    return result;
}