using LINQExercises.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Windows\";
            //GetFilesNamesAndSizeWithoutLinq(path);
            //Console.WriteLine();
            //GetTop5LargestFileUsingLinq(path);
            //Console.WriteLine();
            // GetCulturesWithCommaSeparatorWithoutLinq();
            //Console.WriteLine();
            //GetCulturesWithCommaSeparatorUsingLinq();
            // GetDayNames("Alban");
            //CountUniqueDateTimePatterns();
            //Console.WriteLine();
            //ShowFibonacciNumbers5();

            NumberOfPlayersInTeams();

            Console.ReadLine();
        }

        // 1.0.2 Zmodyfikuj powyższy program tak, aby wyświetlał tylko 5 największych plików z podanej ścieżki

        private static void GetFilesNamesAndSizeWithoutLinq(string path)
        {
            var directoryInfo = new DirectoryInfo(path);
            var filesInfo = directoryInfo.GetFiles();
            // Array.Sort(filesInfo, new FileSizeComparer());

            filesInfo.First();
            filesInfo.Skip(5).Take(6);

            foreach (var fi in filesInfo.OrderByDescending(fi => fi.Length).Take(5))
            {
                Console.WriteLine($"{fi.Name,-25} size: {fi.Length,10:N0}");
            }
        }

        //  1.0.3 Za statyczną metodą GetFilesNamesAndSizeWithoutLinq umieść nową metodę:

        private static void GetTop5LargestFileUsingLinq(string path)
        {
            var directoryInfo = new DirectoryInfo(path);
            var filesInfo = from file in directoryInfo.GetFiles()
                            orderby file.Length descending
                            select file;
            foreach (var fi in filesInfo.Take(5))
            {
                Console.WriteLine($"{fi.Name,-25} size: {fi.Length,10:N0}");
            }
        }

        // 1.0.4 Utwórz kolejną metodę:

        private static void GetCulturesWithCommaSeparatorWithoutLinq()
        {
            var availableCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (var ci in availableCultures)
            {
                if (ci.NumberFormat.NumberDecimalSeparator == ",")
                {
                    Console.WriteLine($"{ci.Name}");
                }
            }
        }

        // 1.0.5 Utwórz nową metodę, zwracającą te same dane co w 1.0.4, ale używając LINQ – użyj tym razem 
        // właściwości DisplayName zamiast Name

        private static void GetCulturesWithCommaSeparatorUsingLinq()
        {
            var availableCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            foreach (var ci in availableCultures.Where(ci => ci.NumberFormat.NumberDecimalSeparator == ","))
            {
                Console.WriteLine($"{ci.DisplayName}, separator {ci.NumberFormat.NumberDecimalSeparator}");
            }
        }

        //  1.0.6 Ile z obsługiwanych kultur używa przecinka jako separatora dziesiętnego, a ile kropki?
        // Wskazówka: .Count()

        private static void CountCulturesWithCommaSeparatorUsingLinq()
        {
            var availableCultures = CultureInfo.GetCultures(CultureTypes.AllCultures).Where(ci => ci.NumberFormat.NumberDecimalSeparator == ",").Count();
            {
                Console.WriteLine($"liczba kultur gdzie uzywa sie przecinka to: {availableCultures}");
            }
        }

        // 1.0.7 Wyświetl nazwy dni w kulturze o DisplayName=”Albanian”
        // Wskazówka: DateTimeFormat.DayNames, wybierz pierwsza tablicę string poleceniem First()

        private static void GetDayNames(string StarsWith)
        {
            var foreignCulture = CultureInfo.GetCultures(CultureTypes.AllCultures).First(ci => ci.EnglishName.StartsWith(StarsWith));
            {
                foreach (var day in foreignCulture.DateTimeFormat.DayNames)
                {
                    Console.WriteLine(day);
                }

            }
        }

        // 1.0.8 Ile jest dostępnych unikalnych wzorów na pełny dzień i czas?

        private static void CountUniqueDateTimePatterns()
        {
            var availableCultures = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();
            var test = from ci in availableCultures select ci.DateTimeFormat.FullDateTimePattern;
            var test2 = availableCultures.Select(ci => ci.DateTimeFormat.FullDateTimePattern);
            var uniquePatterns = test.Distinct();

            Console.WriteLine(uniquePatterns.Count());
            //foreach (var culture in availableCultures)           
            //{
            //    Console.WriteLine($"liczba unikalnych wzorów to {culture.DateTimeFormat.FullDateTimePattern.Count()}");
            //}
        }
        // 1.0.9 Funkcja wyświetlająca liczby z tablicy, będące większe niż 2:

        private static void ShowFibonacciNumbers()
        {
            int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
            // query created, but not yet executed
            IEnumerable<int> numbersGreaterThanTwoQuery = fibonacci.Where(x => x > 2);
            fibonacci[0] = 99;
            // query goes executed
            foreach (var number in numbersGreaterThanTwoQuery)
            {
                Console.WriteLine(number);
            }
        }
        // Dlaczego mogliśmy wyedytować pierwszy element tablicy? Kiedy zapytanie LINQ jest procesowane?


        //1.0.10 Wyświetl unikalne wartości z tablicy w zadaniu 1.0.9, a 
        // następnie pierwszy i ostatni element (Distinct(), First(), Last())

        private static void ShowFibonacciNumbers2()
        {
            int[] fibonacci = { 0, 1, 1, 2, 3, 5 };

            IEnumerable<int> numbersGreaterThanTwoQuery = fibonacci.Where(x => x > 2);
            fibonacci[0] = 99;
            var uniqeNumbers = fibonacci.Distinct().ToList();
            foreach (var number in uniqeNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($" firstnumber {fibonacci.First()}, LastNumber {fibonacci.Last()}");


        }

        // 1.0.11 Zmodyfikuj funkcję z zadania 1.0.9 do postaci:

        private static void ShowFibonacciNumbers3()
        {
            int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
            // query created, and immediately executed
            var numbersGreaterThanTwo = fibonacci.Where(x => x > 2).ToArray();
            fibonacci[0] = 99;
            foreach (var number in numbersGreaterThanTwo)
            {
                Console.WriteLine(number);
            }
        }
        //Dlaczego nie widzimy liczby 99?


        // 1.0.12 Wyświetl co drugą liczbę z tablicy fibonacci

        private static void ShowFibonacciNumbers4()
        {
            int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
            // query created, and immediately executed
            var everySecondNumber = fibonacci.Where((x, indexer) => x % 2 == 0).ToList();
            fibonacci[0] = 99;
            foreach (var number in everySecondNumber)
            {
                Console.WriteLine(number);
            }
        }

        // 1.0.13 Pomiń pierwsze 2 elementy z tablicy i wyświetl kolejne 2 elementy (Skip(), Take())

        private static void ShowFibonacciNumbers5()
        {
            int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
            // query created, and immediately executed
            var everySecondNumber = fibonacci.Skip(2).Take(2);
            fibonacci[0] = 99;
            foreach (var number in everySecondNumber)
            {
                Console.WriteLine(number);
            }
        }

        // 1.0.14 Utwórz nową klasę i metodę:
        // Następnie wyświetl wszystkich pracowników zarabiajacych więcej niż 4000 oraz minimalne, średnie i maksymalne zarobki

        private static void Filtering()
        {
            List<Employee> employees = new List<Employee>();
            employees.AddRange(new Employee[]{
               new Employee()
               {
                   Name = "Marianna",
                   Surname = "Mazur",
                   Salary = 5300,
                   HireDate = DateTime.Now.AddYears(-1),
               },
               new Employee()
               {
                   Name = "Marcin",
                   Surname = "Lewandowski",
                   Salary = 3200,
                   HireDate = DateTime.Now.AddYears(-3),
               },
               new Employee()
               {
                   Name = "Maciej",
                   Surname = "Pietrzak",
                   Salary = 6700,
                   HireDate = DateTime.Now.AddYears(-3),
               },
               new Employee()
               {
                   Name = "Kamil",
                   Surname = "Kolargol",
                   Salary = 3300,
                   HireDate = DateTime.Now.AddYears(-3),
               },
               new Employee()
               {
                   Name = "Jan",
                   Surname = "Drzymala",
                   Salary = 4500,
                   HireDate = DateTime.Now.AddYears(-3),
               },
               new Employee()
               {
                   Name = "Zuzanna",
                   Surname = "Marianna",
                   Salary = 8800,
                   HireDate = DateTime.Now.AddYears(-3),
               },
               new Employee()
               {
                   Name = "Mariusz",
                   Surname = "Knor",
                   Salary = 6200,
                   HireDate = DateTime.Now.AddYears(-3),
               }
           });

            var wellPaid = employees.Where(e => e.Salary > 4000);
            Console.WriteLine("Well Paid  Employees");
            foreach (var employee in wellPaid)
            {
                Console.WriteLine(employee.Surname);
            }

            var Salaries = employees.Select(e => e.Salary).ToList();

            var MaxSalary = Salaries.Max();
            var MinSalary = Salaries.Min();

            var empLow = employees.Where(emp => emp.Salary == MinSalary).First();
            Console.WriteLine($"empLow.Name = {empLow.Name }");
            var AvgSalary = Salaries.Average();
            Console.WriteLine($"MaxSalary {MaxSalary} MinSalary {MinSalary} AvgSalary{AvgSalary}");

        }

        // 1.0.15 Dodaj tablicę różnych obiektów:

        private static void Filtering2()
        {
            object[] objects =
                {
                new Employee()
                {
                    Name = "Marianna",
                    Surname = "Mazur",
                    Salary = 5300,
                    HireDate = DateTime.Now.AddYears(-1),
                },
                "napis",
                34.5,
                new Employee()
                {
                Name = "Marcin",
                Surname = "Lewandowski",
                Salary = 3200,
                HireDate = DateTime.Now.AddYears(-3),
                },
                4
            };

            // następnie Zastosuj na tablicy filtr OfType<Employee>().ToArray() - jakie elementy
            // widzisz w nowo utworzonej tablicy?
            var newEmployees = objects.OfType<Employee>().ToArray();
            Console.WriteLine("employees z OfType()");
            foreach (var emp in newEmployees)
            {
                Console.WriteLine(emp.Name);
            }
            //Zamiast operatora OfType<>() użyj operatora Cast<>(). Co się stanie jeżeli użyjemy operatora Cast?

            var newEmployees2 = objects.Cast<Employee>().ToArray();
            Console.WriteLine("employees z Cast()");
            foreach (var emp in newEmployees)
            {
                Console.WriteLine(emp.Name);
            }
        }

        // 1.0.16 Utwórz 2 zmienne:
        private static void Filtering3()
        {
            string[] penPineapple = { "Pen", "Pineapple" };
            string[] applePen = { "Apple", "Pen" };

            // Używając metody Concat() złącz dwie powyższe tablice w jedną i wyświetl jej zawartość. Następnie 
            // zamiast metody Concat() użyj metody Union(). Czym różnią się metody?

            var joined = penPineapple.Concat(applePen);
            foreach (var item in joined)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var joined2 = penPineapple.Union(applePen);
            foreach (var item in joined2)
            {
                Console.WriteLine(item);
            }
        }

        //1.0.17 Posortuj pracowników najpierw po zarobkach(od najwyższych), a nastepnie po dacie zatrudnienia

        private static void Filtering4()
        {
            List<Employee> employees = new List<Employee>();
            employees.AddRange(new Employee[]{
               new Employee()
               {
                   Name = "Marianna",
                   Surname = "Mazur",
                   Salary = 5300,
                   HireDate = DateTime.Now.AddYears(-1),
               },
               new Employee()
               {
                   Name = "Marcin",
                   Surname = "Lewandowski",
                   Salary = 3200,
                   HireDate = DateTime.Now.AddYears(-6),
               },
               new Employee()
               {
                   Name = "Maciej",
                   Surname = "Pietrzak",
                   Salary = 6700,
                   HireDate = DateTime.Now.AddYears(-3),
               },
               new Employee()
               {
                   Name = "Kamil",
                   Surname = "Kolargol",
                   Salary = 3300,
                   HireDate = DateTime.Now.AddYears(-4),
               },
               new Employee()
               {
                   Name = "Jan",
                   Surname = "Drzymala",
                   Salary = 4500,
                   HireDate = DateTime.Now.AddYears(-34),
               },
               new Employee()
               {
                   Name = "Zuzanna",
                   Surname = "Marianna",
                   Salary = 8800,
                   HireDate = DateTime.Now.AddYears(-12),
               },
               new Employee()
               {
                   Name = "Mariusz",
                   Surname = "Knor",
                   Salary = 6200,
                   HireDate = DateTime.Now.AddYears(-3),
               }
           });

            var employeesSortedBySalary = employees.OrderByDescending(em => em.Salary);
            foreach (var employee in employeesSortedBySalary)
            {
                Console.WriteLine($"{employee.Surname} {employee.Salary}");
            }

            var employeesSortedByHireDate = employees.OrderByDescending(em => em.HireDate);
            Console.WriteLine();
            foreach (var employee in employeesSortedBySalary)
            {
                Console.WriteLine($"{employee.Surname} {employee.HireDate}");
            }

            // 1.0.18 Sprawdź, czy wszyscy zarabiają powyżej 3000 (All())

            var AllOver3k = employees.All(emp => emp.Salary > 3000);
            Console.WriteLine("AllOver3k");
            Console.WriteLine(AllOver3k);

            // 1.0.19 Sprawdź, czy ktokolwiek zarabia mniej niz 3000(Any())

            var AnyOver3k = employees.Any(emp => emp.Salary > 3000);
            Console.WriteLine("AnyOver3k");
            Console.WriteLine(AnyOver3k);

            // 1.0.20 Pogrupuj pracowników wg daty zatrudnienia – użyj anonimowych
            // obiektów do stworzenia raportu hierarchicznego – Data zatrudnienia -> pracownicy

            var employeesGroupedByHireDate = employees.Select(em => new { DataZatrudnienia = em.HireDate.Year, Pracownik = em.Surname }).GroupBy(em => em.DataZatrudnienia);
            Console.WriteLine();
            foreach (var group in employeesGroupedByHireDate)
            {
                foreach (var emp in group)
                {                                   
                Console.WriteLine($"{emp.DataZatrudnienia}, {emp.Pracownik}");
                }
            }
        }

        // 1.0.21  ,  dodaj do projektu EF (NuGet Package Manager) i odpowiednie klasy dla DB Ekstraklasa
        // Używając LINQ, wyświetl trenerów nie mających klubu

        private static void GetTrainersUnemployed()
        {
            using (var dbContext = new Ekstraklasa())
            {
                var trainers = dbContext.Trener.Where(tr => !tr.Klub.Any());
                foreach (var trener in trainers)
                {
                    Console.WriteLine(trener.Nazwisko);
                }
            }         

        }

        // 1.0.22 Ilu zawodników mają poszczególne kluby (pogrupuj po klubie)?

        private static void NumberOfPlayersInTeams()
        {
            using (var ekstContext = new Ekstraklasa())
            {
                var kluby = ekstContext.Klub;
                var ileZawodnikowNaDruzyne = kluby.Select(k => new { klub = k.Nazwa, LiczbaZawodnikow = k.Zawodnik.Count() });
                foreach (var klub in ileZawodnikowNaDruzyne)
                {
                    Console.WriteLine( $"{klub.klub} {klub.LiczbaZawodnikow }");
                }

            }

        }

    }

}
