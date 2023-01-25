//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learning
//{

    
//class @switch
//    {
//        Console.WriteLine("Enter the Number to Check the Switch Statements");
//        int Num = int.Parse(Console.ReadLine());

//    switch(Num)
//    {
//        case 1:  
//        case 2:   
//        case 3: 
//        case 4:
//            Console.WriteLine("Entered Number is {0}", Num);
//            break;
//        default:
//            Console.WriteLine("Entered Number is not 1, 2, 3, & 4");
//            break;
//    }
//    Console.ReadLine();

////Coffee Swtich Example
//    int PriceofCup = 0;
//    start:
//Console.WriteLine("Select the Size of Cup \n 1 - Small \n 2 - Medium \n 3 - Large");
//int SizeofCup = int.Parse(Console.ReadLine());

//switch (SizeofCup)
//{
//    case 1:
//        PriceofCup += 10;
//        break;
//    case 2:
//        PriceofCup += 20;
//        break;
//    case 3:
//        PriceofCup += 30;
//        break;
//    default:
//        Console.WriteLine("Your Cup Size {0} is Invalid", SizeofCup);
//        goto start;
//}

//UserChoiceOption:
//Console.WriteLine("Do you want to buy another Coffee \n Yes \n No");
//string UserChoice = Console.ReadLine();

//switch (UserChoice.ToUpper())
//{

//    case "YES":
//        goto start;
//    case "NO":
//        break;
//    default:
//        Console.WriteLine("Your Choice {0} is invalid, Please try agian", UserChoice);
//        goto UserChoiceOption;

//}

//Console.WriteLine("Thank you For buying Coffee");
//Console.WriteLine("Your Bill is {0}", PriceofCup);
//Console.ReadLine();
//    }
//}
