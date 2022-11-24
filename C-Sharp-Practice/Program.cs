using C_Sharp_Practice.Exceptions;
using C_Sharp_Practice.Models;

//User user2 = new("Rasul", "password123");
////Console.WriteLine(user1.Id);
////Console.WriteLine(user2.Id);
//Console.WriteLine(user1.GetInfo());
//Console.WriteLine(user2.GetInfo());

//using C_Sharp_Practice.Utils;

//int month = int.Parse(Console.ReadLine());

////string monthStr = month switch
////{
////    1 => MonthEnum.Yanvar.ToString(),
////    2 => MonthEnum.Fevral.ToString(),
////    3 => MonthEnum.Mart.ToString(),
////    _ => String.Empty
////};

//string monthStr = month switch
//{
//    (int)MonthEnum.Yanvar => "Yanvar",
//    (int)MonthEnum.Fevral => "Fevral",
//    (int)MonthEnum.Mart => "Mart",
//};

//foreach (var item in Enum.GetValues(typeof(MonthEnum)))
//{
//    Console.WriteLine(item.ToString());
//}
//int[] numbers = new int[2];
//numbers[3] = 0;
//try
//{
//    int[] numbers = new int[2];
//    numbers[3] = 0;
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}

try
{
    User user1 = new("Humay", "password123");
}
catch (IncorrectPasswordException ex)
{
    Console.WriteLine(ex.Message);
}