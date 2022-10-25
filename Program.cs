//                      ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 3

// // ЗАДАЧА 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// //            является ли оно полиндромом

// void CheckPolyndrom(int number)
// {
//     int first = number / 10000;
//     int last = number % 10;
//     int second = (number / 1000) % 10;
//     int penultimate = (number % 100) /10;
//     if(first == last & second == penultimate) Console.WriteLine($"The entered number {number} is a polyndrome");
//     else Console.WriteLine($"The entered number {number} is not a polyndrome");
// }


// Console.WriteLine("Enter any five-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number < 10000 | number > 99999) Console.WriteLine($"The entered number {number} does not match the condition");
// else CheckPolyndrom(number);

// // ЗАДАЧА 21. Напишите программу, которая принимает на вход координаты двух точек и находит
// //            расстояние между ними в 3D пространстве

// double LengthSegment(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
// {
//     double result = Math.Sqrt((X1 - X2)*(X1 - X2) + (Y1 - Y2)*(Y1 - Y2) + (Z1 - Z2)*(Z1 - Z2));
//     return result;
// }

// Console.WriteLine("Enter the value of the X coordinate of the first point: ");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the value of the Y coordinate of the first point: ");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the value of the Z coordinate of the first point: ");
// int Z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the value of the X coordinate of the second point: ");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the value of the Y cootdinate of the second point: ");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the value of the Z coordinate of the second point: ");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double distance = LengthSegment(X1, Y1, Z1, X2, Y2, Z2);
// Console.WriteLine($"The distance between the specified points is {Math.Round(distance, 2)}");

// // ЗАДАЧА 23. Напишите программу, которая принимает на вход число (N) 
// //            и выдает таблицу кубов от 1 до N

// void CubNumbers(int number)
// {
//     for(int i = 1; i <= number; i++)
//     {
//         Console.WriteLine($"{i*i*i}");
//     }
// }

// Console.Write("Enter any integer greater than zero: ");
// double check = Convert.ToDouble(Console.ReadLine());
// int number = 0;
// if(check % 1 == 0) 
// {
//     number = Convert.ToInt32(check);
//     if(number > 0) CubNumbers(number);
//     else Console.WriteLine($"The entered number {number} is not greater than zero"); 
// }
// else Console.WriteLine($"The entered number {number} is not an integer");



























































// // ЗАДАЧА : Напишите программу, которая по заданному номеру четверти,
// //          показывает диапазон возможных координат точек в этой четверти (x и y) (их знаки)


// void Quoters(int quater)
// {
//     if(quater == 1) Console.WriteLine("В первой четверти X>0, Y>0");
//     else if(quater == 2) Console.WriteLine("Во второй четверти X>0, Y<0");
//     else if(quater == 3) Console.WriteLine("В третьей четверти X<0, Y<0");
//     else if(quater == 4) Console.WriteLine("В четвертой четверти X<0, Y>0");
//     else Console.WriteLine("Такой четверти не существует");
// }

// Console.Write("Введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Quoters(num);

// // ЗАДАЧА 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
// //           причем Х не равно 0 и Y не равно 0 и выдает номер четверти плоскости,
// //           в которой находится эта точка

// void QuarterNumber(int X, int Y)
// {
//     if(X > 0 & Y > 0) Console.WriteLine("The specified point is in first quarter");
//     else if(X > 0 & Y < 0) Console.WriteLine("The specified point is in second quarter");
//     else if(X < 0 & Y < 0) Console.WriteLine("The specified point is in the third quarter");
//     else if(X < 0 & Y > 0) Console.WriteLine("The specified point is in the fourth quarter");
//     else Console.WriteLine("Incorrect data entered");
// }

// Console.WriteLine("Enter the X value: ");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the Y value: ");
// int Y = Convert.ToInt32(Console.ReadLine());
// QuarterNumber(X, Y);


// // ЗАДАЧА 3: Напишите программу, которая принимает на вход число (N) 
// //           и выдает таблицу квадратов чисел от 1 до N

// void Squares(int number)
// {
//     // int result = 1;
//     // int index = 1;
//     // while(index <= number)
//     // {
//     //     result = index * index;
//     //     Console.WriteLine(result);
//     //     index++;
//     // }

//     for(int i = 1; i <= number; i++)
//     {
//         Console.WriteLine($"{i * i}");
//     }
// }

// Console.WriteLine("Enter any positive number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number >= 1)
// {
//     Squares(number);
// }
// else
// {
//    Console.WriteLine("Введено неверное значение");
// }

// // ЗАДАЧА 4: Напишите программу, которая принимает на вход координаты двух точек 
// //           и находит расстояние между ними в 2D пространстве


// double Line(int X1, int Y1, int X2, int Y2)
// {
//     double result = Math.Sqrt((X2-X1)*(X2-X1) + (Y2-Y1)*(Y2-Y1));
//     return result;
// }

// Console.WriteLine("Enter the X value of the first point");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the Y value of the first point");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the X value of the second point");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the Y value of the second point");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// double lin = Line(X1, Y1, X2, Y2);
// Console.WriteLine($"The distance between points ({X1}, {Y1}) and ({X2}, {Y2}) is equal to {lin}");