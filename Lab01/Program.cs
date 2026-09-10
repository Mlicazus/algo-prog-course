// string myName = "Волков Борис";
// string groupName = "ИСП-252";
// int courseNumber = 2;
// double averageGrade = 4.6;
// bool isBudget = true;
// System.Console.WriteLine("Знакомство");
// System.Console.WriteLine($"Студент: {myName}");
// System.Console.WriteLine($"Группа: {groupName}");
// System.Console.WriteLine($"Курс: {courseNumber}");
// System.Console.WriteLine($"Средний балл: {averageGrade}");
// System.Console.WriteLine($"Бюджетное место: {isBudget}");

// System.Console.WriteLine();
// System.Console.WriteLine("Ремонт: комната");
// double roomWidth = 3.5;
// double roomLength = 4.2;
// double roomArea = roomWidth * roomLength;
// double roomPerimeter = (roomWidth + roomLength) * 2;
// System.Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
// System.Console.WriteLine($"Площадь: {roomArea} кв.м");
// System.Console.WriteLine($"Периметр: {roomPerimeter} м");

// System.Console.WriteLine();
// System.Console.WriteLine("Покупка ноутбука в рассрочку");
// int laptopPrice = 65000;
// int monthsCount = 12;
// double interestRate = 0.8;
// double totalWithInterest = laptopPrice * (1 + interestRate);
// double monthlyPayment = totalWithInterest / monthsCount;
// System.Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
// System.Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
// System.Console.WriteLine($"Платеж в месяц: {monthlyPayment} руб.");

// System.Console.WriteLine();
// System.Console.WriteLine("Внимание: деление int");
// int totalStudents = 25;
// int groupsCount = 4;
// int studentsPerGroupWrong = totalStudents / groupsCount;
// double studentsPerGroupCorrect = (double)totalStudents / groupsCount;
// System.Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
// System.Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");

// System.Console.WriteLine();
// System.Console.WriteLine("Способы собрать строку");
// string firstName = "Анна";
// string lastName = "Смирнова";
// // Способ 1
// string fullNameConcat = firstName + " " + lastName;
// // Способ 2
// string fullNameInterp = $"{firstName} {lastName}";
// // Способ 3
// string fullNameConcatMethod = string.Concat(firstName, " ", lastName);
// System.Console.WriteLine(fullNameConcat);
// System.Console.WriteLine(fullNameInterp);
// System.Console.WriteLine(fullNameConcatMethod);
// System.Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");

// System.Console.WriteLine();
// System.Console.WriteLine("Константы");
// const double VatRate = 0.20;
// const string CollegeName = "ВФ ВолГУ";
// double productPrice = 1000;
// double priceWithVat = productPrice * (1 + VatRate);
// System.Console.WriteLine($"Учебное заведение: {CollegeName}");
// System.Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}):{priceWithVat}");

// 1 блок : Создаем переменные разных типов и выписываем в терминал


/* 2-4 блоки : Решает арифметические задачи и выводим результат
   Так же в 3 блоке мы используем неявное приведение типов
   В то время как в 4 блоке явное приведение типов

*/

// В 5 блоке мы попробовали конкатенацию и интерполяцию, в 6 константы

int scholarship = 621;
int monthlyExpenses = 620;
const int MonthsInSemester = 4;
System.Console.WriteLine($"К концу месяца останется: {scholarship - monthlyExpenses} руб.");
System.Console.WriteLine($"К концу семестра останется: {(scholarship - monthlyExpenses) * MonthsInSemester} руб.");