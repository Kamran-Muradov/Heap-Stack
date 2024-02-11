///////CLASSWORK////////

//int[] arr = { 1, 2, 3, 6, 8, 9 };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 3)
//    {
//        Console.WriteLine("Found - " + arr[i]);
//        break;
//    }
//}

//int[] arr = { 1, 2, 3, 2, 8, 9 };

//int count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 2)
//    { 
//        count++;
//        if (count == 2)
//        {
//            Console.WriteLine("Found min 2 times - " + arr[i]);
//            break;
//        }
//    }
//}

//int a = 5;

//int b = a;

//b = 100;

//Console.WriteLine(a);
//Console.WriteLine(b);

//int[] arr1 = { 1, 2, 3, 4 };

//arr1[0] = 100;

//int[] arr2 = arr1;

//arr2[0] = 200;

//arr2[0] = arr1[0] + arr2[0];

//arr1[0] = 3;

//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);

//string name1 = "test";

//string name2 = name1;

//name2 = "salam";

//Console.WriteLine(name1);
//Console.WriteLine(name2);

//var name = "test";

//var age = 100;

//var isMarried = false;

//List<string> data = new List<string>();

//var lastName = "test";

//lastName = "salam";

//int[] arr = { 1, 2, 3, 4, 5 };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 2)
//    {
//        continue;
//    }
//    if (arr[i] == 4)
//    {
//        break;
//    }
//    Console.WriteLine(arr[i]);
//}

//int a = 6;

//int b = ++a;

//Console.WriteLine(a);
//Console.WriteLine(b);

//int a = 5;

//int b = a + 10;

//Console.WriteLine(a);
//Console.WriteLine(b);

//int a = 15;

//int b = --a;

//int c = ++b;

//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);



///////HOMEWORK////////

//Task 1: n - ededinin faktorialini hesablayin.

//int n = 5;

//int factorial = 1;

//for (int i = 2; i <= n; i++)
//{
//    factorial *= i;
//}

//Console.WriteLine(factorial);

//Task 2: Verilmis arrayin icerisinde cut ededlerin ceminin kvadratini hesablayin.

//int[] numbers = { 5, 4, 45, 2 };

//int sum = 0;
//int square;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        sum += numbers[i];
//    }
//}
//square = sum * sum;

//Console.WriteLine(square);

//Task 3: n ededi gelir. n - ededinin 2-ni hansisa quvvete yukseltdikde alinan edede beraber olub-olmadigini tapin.
//Meselen : n ededi 4,8,16 ve s. gelirse yazilsin ki, 2-nin quvettidir. Eks halda quvveti deil yazilsin.

//int n = 64;

//int count = 0;

//for (int i = 2; i <= n; i *= 2)
//{
//    if (n % i != 0)
//    {
//        count++;
//        break;
//    }
//}
//if (count == 0 && n >= 1)
//{
//    Console.WriteLine("Eded 2-nin quvvetidir");
//}
//else
//{
//    Console.WriteLine("Eded 2-nin quvveti deyil");
//}



