//// 1.1 Uzdevums
//Console.WriteLine("Ievadiet simbola rindu");
//string input = Console.ReadLine();
//int sum = 0;

//for (int i = 0; i < input.Length; i++)
//{
//    Console.WriteLine($"{input[i]} = {(int)input[i]}");
//    sum += (int)input[i];
//}

//Console.WriteLine($"Kodu summa: {sum}");

//Console.Write("Ievadiet simbolu:");
//char symbol = Convert.ToChar(Console.ReadLine());
//int count = 0;

//for (int i = 0; i < input.Length; i++)
//{
//    if (input[i] == symbol)
//    {
//        count++;
//    }
//}

//Console.WriteLine($"Simbols ir sastopams {count} reizes");


//// 1.2 Uzdevums 6fee0a4a68f2  feefee

//Console.WriteLine("Ievadiet pirmo simbolu rindu:");
//string firstRow = Console.ReadLine();

//Console.WriteLine("Ievadiet otro simbolu rindu:");
//string secondRow = Console.ReadLine();

//string newFirstRow = "";

//for  (int i = 0; i < firstRow.Length; i++)
//{
//    if ((int)firstRow[i] >= 48 && (int)firstRow[i] <= 57)
//    {
//        newFirstRow += "*";
//    }
//    else
//    {
//        newFirstRow += firstRow[i];
//    }
//}

//string newSecondRow = "";

//for (int i = 0; i < secondRow.Length; i++)
//{
//    if ((int)secondRow[i] >= 97 && (int)secondRow[i] <= 122)
//    {
//        newSecondRow += (char)((int)secondRow[i]-32);
//    }
//    else
//    {
//        newSecondRow += secondRow[i];
//    }
//}

//Console.WriteLine($"Pirmās simbolu rindas garums ir {firstRow.Length} un tās rezultāts: {newFirstRow}");
//Console.WriteLine($"Otrās simbolu rindas garums ir {secondRow.Length} un tās rezultāts: {newSecondRow}");

//string combined = secondRow.Substring(0, secondRow.Length / 2) + firstRow + secondRow.Substring(secondRow.Length / 2);
//Console.WriteLine($"Simbolu rindas apvienošana {combined}");

//Console.WriteLine("Ievadiet trešo simbolu rindu:");
//string thirdRow = Console.ReadLine();

//int count = 0;
//for (int i = 0; i <= combined.Length - thirdRow.Length; i++)
//{
//    bool found = true;
//    for (int j = 0; j < thirdRow.Length; j++)
//    {
//        if (combined[i + j] != thirdRow[j])
//        {
//            found = false;
//            break;
//        }
//    }
//    if (found)
//    {
//        count++;
//    }
//}

//Console.WriteLine($"{thirdRow} atkārtojas simbolu virknē {combined} - {count} reizes");

//// 2.1 Uzdevums
//int[] ints = new int[10];

//for (int i = 1; i <= 10; i++)
//{
//    Console.Write($"Ievadiet {i} masīva elementa vērtību: ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    ints[i - 1] = num;
//}

//Console.WriteLine();

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"mas[{i + 1}] = {ints[i]}");
//}

//Console.WriteLine();

//var reiz = 1;
//for (int i = 0; i < 10; i++)
//{
//    reiz *= ints[i];
//    Console.WriteLine($"reiz_{i+1} = {reiz}");
//}




//// 2.2 Uzdevums

//char[] chars = new char[20];

//for (int i = 0; i < 20; i++)
//{
//    Console.Write($"mas[{i + 1}] = ");
//    char input = Convert.ToChar(Console.ReadLine());

//    chars[i] = input;
//}

//Console.Write("Ievadiet simbolu: ");
//char symbol = Convert.ToChar(Console.ReadLine());
//int count = 0;

//for (int i = 0; i < chars.Length; i++)
//{
//    if (chars[i] == symbol)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Simbols {symbol} atrodas masīvā {count} reizes");

//for (int i = 0; i < chars.Length; i++)
//{
//    if (chars[i] != symbol)
//    {
//        Console.WriteLine($"mas[{i+1}] = {chars[i]}");
//    }
//}



//// 2.3 Uzdevums

//int[] ints = new int[10];

//for (int i = 0; i < ints.Length; i++)
//{
//    Console.Write($"mas[{i+1}] = ");
//    int input = Convert.ToInt32( Console.ReadLine() );

//    ints[i] = input;
//}

//int max = 0;
//int min = 20;
//for (int i = 0;i < ints.Length;i++)
//{
//    if (ints[i] > max)
//    {
//        max = ints[i];
//    } 

//    if (ints[i] < min)
//    {
//        min = ints[i];
//    }
//}

//Console.WriteLine("max vērtība = " + max);
//Console.WriteLine("min vērtība = " + min);




//// 2.4 Uzdevums

//int[] ints = new int[10];

//for (int i = 0; i < ints.Length; i++)
//{
//    Console.Write($"mas[{i + 1}] = ");
//    int input = Convert.ToInt32(Console.ReadLine());

//    ints[i] = input;
//}

//for (int i = 0; i < ints.Length / 2; i++)
//{
//    int temp = ints[i];
//    ints[i] = ints[ints.Length - 1 - i];
//    ints[ints.Length - 1 - i] = temp;
//}

//for (int i = 0; i < ints.Length; i++)
//{
//    Console.WriteLine($"mas[{i + 1}] = {ints[i]}");
//}




//// 3.1 Uzdevums
//string[] strings = new string[10];

//for (int i = 0; i < strings.Length; i++)
//{
//    Console.Write($"Ievadiet {i + 1} masīva vērtību: ");
//    string input = Console.ReadLine();

//    strings[i] = input;
//}

//for (int i = 0; i < strings.Length; i++)
//{
//    Console.WriteLine($"masīva {i+1} vēŗtīa ir: {strings[i]}");
//}

//string bigString = "";

//for (int i = 0;i < strings.Length; i++)
//{
//    bigString += strings[i];
//}

//Console.WriteLine("Apvienotais masīvs: " + bigString);





////3.2 Uzdevums
//Console.Write("Ievadiet pirmā masīva izmēru: ");
//int firstArrLength = Convert.ToInt32(Console.ReadLine());
//Console.Write("Ievadiet otrā masīva izmēru: ");
//int secondArrLength = Convert.ToInt32(Console.ReadLine());

//string[] firstArr = new string[firstArrLength];
//string[] secondArr = new string[secondArrLength];

//for (int i = 0; i < firstArr.Length; i++)
//{
//    Console.Write($"Ievadiet 1. {i + 1} masīva vērtību: ");
//    string input = Console.ReadLine();

//    firstArr[i] = input;
//}
//for (int i = 0; i < secondArr.Length; i++)
//{
//    Console.Write($"Ievadiet 2. {i + 1} masīva vērtību: ");
//    string input = Console.ReadLine();

//    secondArr[i] = input;
//}

//for (int i = 0; i < firstArr.Length; i++)
//{
//    Console.WriteLine($"1. masīva {i + 1} vērtība ir: {firstArr[i]}");
//}

//for (int i = 0; i < secondArr.Length; i++)
//{
//    Console.WriteLine($"2. masīva {i + 1} vērtība ir: {secondArr[i]}");
//}

//int longest = firstArr.Length > secondArr.Length ? firstArrLength : secondArrLength;

//string fullString = "";

//for (int i = 0; i < longest; i++)
//{
//    if (i < firstArr.Length)
//    {
//        fullString += firstArr[i]; 
//    }

//    if (i < secondArr.Length)
//    {
//        fullString += secondArr[i];
//    }
//}

//Console.WriteLine("1. un 2. masīa apvienotā simbolu virkne: " + fullString);




////3.3 Uzdevums
//Console.Write("Ievadiet pirmā masīva izmēru: ");
//int firstArrLength = Convert.ToInt32(Console.ReadLine());
//Console.Write("Ievadiet otrā masīva izmēru: ");
//int secondArrLength = Convert.ToInt32(Console.ReadLine());

//string[] firstArr = new string[firstArrLength];
//string[] secondArr = new string[secondArrLength];

//for (int i = 0; i < firstArr.Length; i++)
//{
//    Console.Write($"Ievadiet 1. {i + 1} masīva vērtību: ");
//    string input = Console.ReadLine();

//    firstArr[i] = input;
//}
//for (int i = 0; i < secondArr.Length; i++)
//{
//    Console.Write($"Ievadiet 2. {i + 1} masīva vērtību: ");
//    string input = Console.ReadLine();

//    secondArr[i] = input;
//}

//for (int i = 0; i < firstArr.Length; i++)
//{
//    Console.WriteLine($"1. masīva {i + 1} vērtība ir: {firstArr[i]}");
//}

//for (int i = 0; i < secondArr.Length; i++)
//{
//    Console.WriteLine($"2. masīva {i + 1} vērtība ir: {secondArr[i]}");
//}

//string fullString = "";

//for (int i = 0;i < firstArr.Length / 2; i++)
//{
//    fullString += firstArr[i];
//}

//for (int i = 0; i < secondArr.Length; i++)
//{
//    fullString += secondArr[i];
//}

//for (int i = firstArr.Length / 2; i < firstArr.Length; i++)
//{
//    fullString += firstArr[i];
//}

//Console.WriteLine("1. un 2. masīa apvienotā simbolu virkne: " + fullString);








//// 3.4 UZDEVUMS

//Console.Write("Ievadiet pirmā masīva izmēru: ");
//int firstArrLength = Convert.ToInt32(Console.ReadLine());
//Console.Write("Ievadiet otrā masīva izmēru: ");
//int secondArrLength = Convert.ToInt32(Console.ReadLine());

//int[] firstArr = new int[firstArrLength];
//int[] secondArr = new int[secondArrLength];

//for (int i = 0; i < firstArr.Length; i++)
//{
//    Console.Write($"Ievadiet 1. {i + 1} masīva vērtību: ");
//    int input = Convert.ToInt32(Console.ReadLine());

//    firstArr[i] = input;
//}
//for (int i = 0; i < secondArr.Length; i++)
//{
//    Console.Write($"Ievadiet 2. {i + 1} masīva vērtību: ");
//    int input = Convert.ToInt32(Console.ReadLine());

//    secondArr[i] = input;
//}

//int longest = firstArrLength > secondArrLength ? firstArrLength : secondArrLength;

//int firstSmallest = 100;
//int secondSmallest = 100;

//int firstLargest = 0;
//int secondLargest = 0;

//Console.WriteLine("pirmais otrais");
//for (int i = 0; i < longest; i++)
//{
//    if (firstArrLength > i)
//    {
//        Console.Write(firstArr[i]);
//        if (firstSmallest > firstArr[i])
//        {
//            firstSmallest = firstArr[i];
//        }
//        if (firstLargest < firstArr[i])
//        {
//            firstLargest = firstArr[i];
//        }
//    }
//    Console.Write("\t");
//    if (secondArrLength > i)
//    {
//        Console.Write(secondArr[i]);
//        if (secondSmallest > secondArr[i])
//        {
//            secondSmallest = secondArr[i];
//        }
//        if (secondLargest < secondArr[i])
//        {
//            secondLargest = secondArr[i];
//        }
//    }
//    Console.WriteLine();
//}

//if (firstSmallest == secondSmallest)
//{
//    Console.WriteLine("Mazakais skaitlis ir gan pirma, gan otra masiva un ir vienads ar " + firstSmallest);
//}
//else if (firstSmallest > secondSmallest)
//{
//    Console.WriteLine("Mazakais skaitlis it pirma masiva un ir vienads ar " + firstSmallest);
//}
//else
//{
//    Console.WriteLine("Mazakais skaitlis it otra masiva un ir vienads ar " + secondSmallest);
//}

//if (firstLargest == secondLargest)
//{
//    Console.WriteLine("Lielakais skaitlis ir gan pirma, gan otra masiva un ir vienads ar " + firstLargest);
//}
//else if (firstLargest > secondLargest)
//{
//    Console.WriteLine("Lielakais skaitlis it pirma masiva un ir vienads ar " + firstLargest);
//}
//else
//{
//    Console.WriteLine("Lielakais skaitlis it otra masiva un ir vienads ar " + secondLargest);
//}
