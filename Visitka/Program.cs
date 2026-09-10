Console.WriteLine("      ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА");

string studentName = "Волков Борис Николаевич"; // Создаем переменную studentName и присваиваем ему текст
string groupName = "ИСП-252";
int courseNumber = 2;
const string specialityNumbers = "09.02.07"; // Делаем так, чтобы переменную specialityNumbers нельзя было случайно изменить
double averageScore = (5 + 4 + 3) / 3; // Средний балл по 3-м оценкам
bool isScholarship = true;
int instructionalWeeks = 16;

System.Console.WriteLine($"ФИО:             {studentName}");
System.Console.WriteLine($"Группа:          {groupName}");
System.Console.WriteLine($"Курс:            {courseNumber}");
System.Console.WriteLine($"Специальность:   {specialityNumbers}");
System.Console.WriteLine();
System.Console.WriteLine($"Средний балл за 3 работы: {averageScore}");
System.Console.WriteLine($"Стипендия положена (>= 4.0): {isScholarship}");
System.Console.WriteLine();
System.Console.WriteLine($"Учебных недель осталось в семестре: {instructionalWeeks}");
