using System.Drawing;

namespace PhucHN3
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string mess) : base(mess) { }
    }
    internal class Program
    {
        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            bool next = true;
            while (next)
            {
                Console.Clear();
                Console.WriteLine("1. Variables and Data Types");
                Console.WriteLine("2. Conditional Statements");
                Console.WriteLine("3. Loops");
                Console.WriteLine("4. Arrays and Lists");
                Console.WriteLine("5. Boxing and Unboxing");
                Console.WriteLine("6. Value Type and Reference Type");
                Console.WriteLine("7. Struct");
                Console.WriteLine("8. DateTime");
                Console.WriteLine("9. Working with Strings");
                Console.WriteLine("10. Exception Handling");
                Console.WriteLine("11. Functions");
                Console.WriteLine("12. Classes and Objects");
                Console.WriteLine("13. Inheritance");
                Console.WriteLine("14. Polymorphism");
                Console.WriteLine("15. Exception Handling with Custom Exceptions");
                Console.WriteLine("16. Recursion in Functions");
                Console.WriteLine("17. Using Enumerations");
                Console.WriteLine("18. Properties in Classes");
                Console.WriteLine("19. Using Tuples");
                Console.WriteLine("20. Collections");
                Console.WriteLine("21. Working with Files");
                Console.WriteLine("22. Using Nullable Types");
                Console.WriteLine("23. Debugging Basics");
                Console.Write("chosse number: ");
                int n = int.Parse(Console.ReadLine());
                if (n == 0 || n == null)
                {
                    Console.Write("khong so nao duoc chon.");
                    return;
                }
                switch (n)
                {
                    case 1:
                        Console.Clear();
                        VariablesAndDataTypes();
                        next = NextOrStop();
                        break;
                    case 2:
                        Console.Clear();
                        IfElse();
                        next = NextOrStop();
                        break;
                    case 3:
                        Console.Clear();
                        Loop();
                        next = NextOrStop();
                        break;
                    case 4:
                        Console.Clear();
                        ArrayList();
                        next = NextOrStop();
                        break;
                    case 5:
                        Console.Clear();
                        BoxingandUnboxing();
                        next = NextOrStop();
                        break;
                    case 6:
                        Console.Clear();
                        Type();
                        next = NextOrStop();
                        break;
                    case 7:
                        Console.Clear();
                        Struct();
                        next = NextOrStop();
                        break;
                    case 8:
                        Console.Clear();
                        DateTime1();
                        next = NextOrStop();
                        break;
                    case 9:
                        Console.Clear();
                        WorkString();
                        next = NextOrStop();
                        break;
                    case 10:
                        Console.Clear();
                        Exception();
                        next = NextOrStop();
                        break;
                    case 11:
                        Console.Clear();
                        Functions();
                        next = NextOrStop();
                        break;
                    case 12:
                        Console.Clear();
                        Student student = new Student("PhucHN3", 10);
                        Console.WriteLine("Student Details:");
                        student.Display();
                        List<int> scores = new List<int> { 1, 2, 3, 4, 5, 6 };
                        double average = student.CalculateAverageMarks(scores);
                        Console.WriteLine($"Average Marks: {average}");
                        next = NextOrStop();
                        break;
                    case 13:
                        Console.Clear();
                        Car car = new Car("Toyota", "Corolla", "Petrol");
                        car.DisplayCarInfo();
                        next = NextOrStop();
                        break;
                    case 14:
                        Console.Clear();
                        Shape rectangle = new Rectangle(5, 10);
                        Console.WriteLine(rectangle.CalculateArea());

                        Shape circle = new Circle(7);
                        Console.WriteLine(circle.CalculateArea());
                        next = NextOrStop();
                        break;
                    case 15:
                        Console.Clear();
                        CustomException();
                        next = NextOrStop();
                        break;
                    case 16:
                        Console.Clear();
                        Recursion();
                        next = NextOrStop();
                        break;
                    case 17:
                        Console.Clear();
                        Enumeration();
                        next = NextOrStop();
                        break;
                    case 18:
                        Console.Clear();
                        Console.WriteLine("Enter the book title:");
                        string bookTitle = Console.ReadLine();

                        Console.WriteLine("\nEnter the author is name:");
                        string bookAuthor = Console.ReadLine();

                        Book myBook = new Book(bookTitle, bookAuthor);
                        Console.WriteLine(myBook.ToString());
                        next = NextOrStop();
                        break;
                    case 19:
                        Console.Clear();
                        Tuples();
                        next = NextOrStop();
                        break;
                    case 20:
                        Console.Clear();
                        Collections();
                        next = NextOrStop();
                        break;
                    case 21:
                        Console.Clear();
                        WorkingWithFiles();
                        next = NextOrStop();
                        break;
                    case 22:
                        Console.Clear();
                        NullableTypes();
                        next = NextOrStop();
                        break;
                }
            }
        }
        static bool NextOrStop()
        {
            Console.WriteLine("\nDo you want choose example(ok or exit)? : ");
            var value = Console.ReadLine();
            if (value != "ok") return false;
            return true;
        }
        //1.Variables and Data Types
        static void VariablesAndDataTypes()
        {
            int intVar = 10;
            double doubleVar = 5.5;
            string strVar = "Hello, World!";
            bool boolVar = false;
            char charVar = 'P';

            Console.WriteLine("Initial values:");
            Console.WriteLine($"Integer: {intVar}");
            Console.WriteLine($"Double: {doubleVar}");
            Console.WriteLine($"String: {strVar}");
            Console.WriteLine($"Boolean: {boolVar}");
            Console.WriteLine($"Character: {charVar}");

            double addition = intVar + doubleVar;
            double subtraction = intVar - doubleVar;
            double multipliation = intVar * doubleVar;
            double division = intVar / doubleVar;

            Console.WriteLine("Arithmetic operations:");
            Console.WriteLine($"Sum (intVar + doubleVar) = {intVar}");
            Console.WriteLine($"Subtraction (intVar - doubleVar) = {subtraction}");
            Console.WriteLine($"Multipliation (intVar * doubleVar) = {multipliation}");
            Console.WriteLine($"division (intVar / doubleVar) = {division}");

            // String concatenation
            string message = strVar + ", My name is: " + charVar;
            Console.WriteLine("String concatenation:");
            Console.WriteLine(message);
        }
        //2. Conditional Statements
        static void IfElse()
        {
            string input;
            int number;
            int day;
            while (true)
            {
                Console.Write("Nhap mot so: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    if (number > 0)
                    {
                        Console.WriteLine($"{number} là so dương.");
                    }
                    else if (number < 0)
                    {
                        Console.WriteLine($"{number} là so am.");
                    }
                    else
                    {
                        Console.WriteLine($"{number} là số không (zero).");
                    }

                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Monday");
                            break;
                        case 2:
                            Console.WriteLine("Tuesday");
                            break;
                        case 3:
                            Console.WriteLine("Wednesday");
                            break;
                        case 4:
                            Console.WriteLine("Thursday");
                            break;
                        case 5:
                            Console.WriteLine("Friday");
                            break;
                        case 6:
                            Console.WriteLine("Saturday");
                            break;
                        case 7:
                            Console.WriteLine("Sunday");
                            break;
                        default:
                            Console.WriteLine("So khong hop le! Vui long nhap tu 1 đen 7.");
                            continue;
                    };
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sai. nhap lai!");
                    Console.ResetColor();
                }
            }
        }
        //3. Loops
        static void Loop()
        {
            //Write a for loop to print all even numbers from 1 to 50
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //Use a while loop to calculate the factorial of a given number.
            Console.Write("\nEnter a number to calculate its factorial:");
            int input = int.Parse(Console.ReadLine());
            int number = 1;
            int counter = input;
            while (counter > 0)
            {
                number *= counter;
                counter--;
            }
            Console.WriteLine($"Factorial of {input} is: {number}");
            //Implement a do-while loop to repeatedly prompt the user for input until they type "exit".
            string strInput;
            do
            {
                Console.Write("\nEnter type 'exit':");
                strInput = Console.ReadLine();
                if (strInput != "exit")
                {
                    Console.WriteLine($"You typed: {strInput}");
                }
            }
            while (strInput != "exit");
        }
        //4. Arrays and Lists
        static void ArrayList()
        {
            //Create an array of integers and find the maximum and minimum values.
            int[] arrayInt;
            arrayInt = new int[10];
            for (int i = 0; i < arrayInt.Length; i++)
            {

                Console.Write("Enter number:");
                arrayInt[i] = int.Parse(Console.ReadLine());
            }
            int maxNum = arrayInt.Max();
            int minNum = arrayInt.Min();
            Console.Write($"\nMax number: {maxNum}");
            Console.Write($"\nMin number: {minNum}");
            Thread.Sleep(3000);
            Console.Clear();
            //Use a List<string> to store names, then add, remove, and display elements.
            List<string> name = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter name:");
                name.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join(", ", name));
            Console.Write("\nWho want you remove: ");
            string searchName = Console.ReadLine();
            if (name.Contains(searchName))
            {
                name.Remove(searchName);
                Console.WriteLine(string.Join(", ", name));
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list.");
            }
        }
        //5. Boxing and Unboxing
        static void BoxingandUnboxing()
        {
            int number = 123;
            Console.WriteLine(number.GetType());
            object boxing = number;
            Console.WriteLine(boxing.GetType());
            number = (int)boxing;
            Console.WriteLine(number.GetType());
        }
        //6. Value Type and Reference Type
        struct MyStruct
        {
            public int value;
        }

        class MyClass
        {
            public int value;
        }

        static void Type()
        {
            // Demonstrate Value Type behavior
            Console.WriteLine("\nValue Type :");
            MyStruct struct1 = new MyStruct { value = 10 };
            MyStruct struct2 = struct1;
            struct2.value = 20;

            Console.WriteLine($"\nstruct1.Value = {struct1.value}");
            Console.WriteLine($"\nstruct2.Value = {struct2.value}");

            // Demonstrate Reference Type behavior
            Console.WriteLine("\nReference Type :");
            MyClass class1 = new MyClass { value = 10 };
            MyClass class2 = class1;
            class2.value = 20;

            Console.WriteLine($"\nclass1.Value = {class1.value}");
            Console.WriteLine($"\nclass2.Value = {class2.value}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        public struct Point
        {

            public int X;
            public int Y;
            int Z => X + Y;
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public override string ToString() => $"{X} + {Y} = {Z}";
        }
        //7. Struct
        static void Struct()
        {
            Point p1 = new Point(10, 20);

            Point p2 = p1;
            p2.X = 40;
            //p2.Y = 50;
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
        //8. DateTime
        static void DateTime1()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine($"\n{DateTime.Now}");
            Console.Write("Enter date 1 (yyyy-mm-dd): ");
            var input1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter date 2 (yyyy-mm-dd): ");
            var input2 = DateTime.Parse(Console.ReadLine());


            TimeSpan Calculate = input2 - input1;
            int resulf = Math.Abs(Calculate.Days);
            Console.WriteLine(resulf);
            string formattedDate = date.ToString("MM/dd/yyyy");
            Console.WriteLine($"\n date now: {formattedDate}");
        }
        //9. Working with Strings
        static void WorkString()
        {
            string input = "Hello World";
            Console.WriteLine("\nChuoi ban dau: " + input);
            // Reverse the string
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            Console.WriteLine("\nReversed String: " + reversed);

            // Count vowels and consonants
            int vowelCount = 0, consonantCount = 0;
            string lowerStr = input.ToLower();
            foreach (var item in lowerStr)
            {
                if ("aeiou".IndexOf(item) >= 0)
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
            Console.WriteLine("Vowels: " + vowelCount);
            Console.WriteLine("Consonants: " + consonantCount);

            // String manipulation using Substring, Replace, and IndexOf
            string substring = input.Substring(0, 5);
            string replaced = input.Replace("World", "Everyone");
            int indexOfSpace = input.IndexOf(' ');
            string manipulated = $"Substring: {substring}, Replaced: {replaced}, Index of Space: {indexOfSpace}";
            Console.WriteLine("Manipulated String: " + manipulated);
        }
        //10. Exception Handling
        static void Exception()
        {
            int numerator = 10;
            int denominator = 2;

            StreamWriter file = null;

            try
            {
                file = new StreamWriter("result.txt");

                int result = numerator / denominator;
                Console.WriteLine("Result: " + result);
                file.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                file?.WriteLine("Error: Cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
                file?.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                    Console.WriteLine("End.");
                }
            }
        }
        static int Calculate(int num)
        {
            return num * num;
        }
        static bool IsPrime(int num)
        {
            if (num == 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
        static int SumArray(int[] array)
        {
            int numb = 0;
            foreach (var item in array)
            {
                numb += item;
            }
            return numb;
        }
        //11. Functions
        static void Functions()
        {
            int number = 5;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int square = Calculate(number);
            Console.WriteLine("Square of " + number + " is: " + square);

            bool isPrime = IsPrime(number);
            if (isPrime)
            {
                Console.WriteLine(number + " is a prime");
            }
            else
            {
                Console.WriteLine(number + " isn't a prime");
            }

            int Sum = SumArray(array);
            Console.WriteLine("the sum of array: " + Sum);
        }
        //15. Exception Handling with Custom Exceptions
        static void CustomException()
        {
            try
            {
                Console.WriteLine("Enter your age:");
                int age = int.Parse(Console.ReadLine());

                if (age < 18)
                {
                    throw new InvalidAgeException("chua du tuoi, phai tren 18, nhap lai.");
                }

                Console.WriteLine("da du toi");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                // nhập không phải số
                Console.WriteLine("Please enter a valid numeric value for age.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("End.");
            }
        }
        //16. Recursion in Functions
        static void Recursion()
        {
            static int Fibonacci(int num)
            {
                if (num <= 1) return num;

                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }

            static int GCD(int a, int b)
            {
                if (b == 0) return a;
                return GCD(b, a % b);
            }

            Console.WriteLine("Tinh Fibonacci");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Fibonacci({n}): {Fibonacci(n)}");

            Console.WriteLine("Tinh GCD");
            Console.WriteLine("nhap so dau tien:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu hai:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"GCD: {GCD(a, b)}");

        }
        //17. Using Enumerations
        static void Enumeration()
        {
            DayOfWeek currentDay = DateTime.Now.DayOfWeek;
            Days day = (Days)Enum.Parse(typeof(Days), currentDay.ToString());
            Console.WriteLine($"Today is {day}.");
        }
        //19. Using Tuples
        static void Tuples()
        {
            static (int sum, int product) Excample(int a, int b)
            {
                int sum = a + b;
                int product = a * b;
                return (sum, product);
            }

            Console.WriteLine("Enter the number 1:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number 2:");
            int number2 = int.Parse(Console.ReadLine());

            (int sum, int product) = Excample(number1, number2);
            Console.WriteLine($"Sum: {sum} and Product: {product}");
        }
        //20. Collections
        static void Collections()
        {
            Dictionary<string, string> country = new Dictionary<string, string>();
            country.Add("VietNam", "HoChiMinh");
            country.Add("France", "Paris");
            country.Add("Japan", "Tokyo");

            Console.Write("We have VietNam, France, Japan");
            Console.WriteLine("What are you find country:");
            var input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Khong co quoc gia");
            }
            else if (country.TryGetValue(input, out string capital))
            {
                Console.WriteLine($"{input} : {capital}.");
            }
            else
            {
                Console.WriteLine("khong co thanh pho can tim");
            }

            HashSet<int> uniqueNumbers = new HashSet<int>();
            Console.WriteLine("\nEnter numbers (nhap 'done' de ket thuc):");
            while (true)
            {
                string input2 = Console.ReadLine();
                if (input2.ToLower() == "done")
                    break;

                if (int.TryParse(input, out int number))
                {
                    if (uniqueNumbers.Add(number))
                    {
                        Console.WriteLine($"Number {number} added.");
                    }
                    else
                    {
                        Console.WriteLine($"Number {number} is already in the set.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            Console.WriteLine("\nUnique numbers entered:");
            foreach (int num in uniqueNumbers)
            {
                Console.WriteLine(num);
            }
        }
        //21. Working with Files
        static void WorkingWithFiles()
        {
            Console.WriteLine("Enter anything: ");
            var input = Console.ReadLine();

            string logFolderName = "log/";
            if (!Directory.Exists(logFolderName))
            {
                // Kiểm tra thư mục log có tồn tại không? Nếu chưa có thì tạo mới
                Directory.CreateDirectory(logFolderName);
            }
            string logFileName = "useinput.txt";
            DateTime now = DateTime.Now;

                string fullFileLog = Path.Combine(logFolderName, logFileName);
            try
            {
                using (StreamWriter file = new StreamWriter(fullFileLog, append: true))
                {

                    file.WriteLine("User vua nhap: {0} - {1}", input, now);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }

            Console.WriteLine("End.");

            // Read and show each line from the file.
            string line = "";
            using(StreamReader readFile = new StreamReader(fullFileLog))
            {
                while ((line = readFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        //22. Using Nullable Types
        static void NullableTypes()
        {
            int? nullable = null;
            int? nullableInt = null;
            Console.WriteLine("Nhap gia tri number: ");
            var input = Console.ReadLine();
            if (input != "") nullable = int.Parse(input);
            if (nullable.HasValue)
            {
                Console.Write("Gia tri ban vua nhap: {0}", nullable.Value);
            }
            else
            {
                Console.Write("Gia tri là null.");
            }

            // Gán giá trị cho nullableInt
            nullableInt = 42;

            // Kiểm tra lại nullableInt
            if (nullableInt.HasValue)
            {
                Console.WriteLine($"\nnullableInt có giá trị: {nullableInt.Value}");
            }

            // Sử dụng toán tử null-coalescing để cung cấp giá trị mặc định
            int defaultValue = nullableInt ?? -1;
            Console.WriteLine($"\nDùng toán tử ??, giá trị là: {defaultValue}");

            // Khi nullableInt là null
            nullableInt = null;
            defaultValue = nullableInt ?? -1;
            Console.WriteLine($"\nKhi nullableInt là null, giá trị là: {defaultValue}");
        }
    }
}
