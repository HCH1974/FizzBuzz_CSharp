// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");

// // for (var i = 1; i < 101; i++) {
// //     // when we use "===", we got an error that types don't match
// //     if ((i % 3)== 0 && (i % 5) == 0)
// //     {
// //         Console.WriteLine("FizzBuzz");
// //     } else if ((i % 3)==0) 
// //     {
// //         Console.WriteLine("Fizz");
// //     } else if ((i % 5)==0)
// //     {
// //         Console.WriteLine("Buzz");
// //     }
// //     else 
// //     {
// //     Console.WriteLine(i);
// //     }
// // }

// // for (var i = 1; i < 300; i++) {
// //     string output = "";
// //    
// //     if ((i % 3)== 0) 
// //     {
// //         if ((i % 13)==0)
// //         {
// //             output="Fezz";
// //         }
// //         output = "Fizz"+output;
// //     }
// //     if ((i % 5)==0) 
// //     {
// //         if ((i % 13)==0 && !output.Contains("Fezz"))
// //         {
// //             output="Fezz";
// //         }
// //         output = output + "Buzz";    
// //     } 
// //     if ((i % 7)==0)
// //     {
// //         if ((i % 13)==0 && !output.Contains("Fezz"))
// //         {
// //             output="Fezz";
// //         }
// //         output = output + "Bang";
// //     }
// //     if ((i % 11)==0) 
// //         {
// //             if ((i % 13)==0 && !output.Contains("Fezz"))
// //         {
// //             output="FezzBong";
// //         } else 
// //         {
// //             output = "Bong";
// //         }
// //     }
// //     if ((i % 13)==0 && output == ""){
// //         output="Fezz";
// //     }
// //     if (output != "") {
// //     Console.WriteLine(output);
// //     }
// //     else {
// //         Console.WriteLine(i);
// //     }
// // }


// Console.WriteLine("Please enter a number: ");
// int number = int.Parse(Console.ReadLine());

// // Solution 1:
// // Console.WriteLine("Would you like rule 3? Y/N");
// // string rule3 = Console.ReadLine();

// // Console.WriteLine("Would you like rule 5? Y/N");
// // string rule5 = Console.ReadLine();

// // Console.WriteLine("Would you like rule 7? Y/N");
// // string rule7 = Console.ReadLine();

// // Console.WriteLine("Would you like rule 11? Y/N");
// // string rule11 = Console.ReadLine();

// // Console.WriteLine("Would you like rule 13? Y/N");
// // string rule13 = Console.ReadLine();

// // Console.WriteLine("Would you like rule 17? Y/N");
// // string rule17 = Console.ReadLine();

// Console.WriteLine("What rules would you like, separate with a space?");
// // Add a "!" at the end of ReadLine so that it will never be a null
// string rules = Console.ReadLine()!;
// string[] rulesArray = rules.Split(" ");

// for (var i = 1; i <= number; i++) {
// List<String>message=new List<string>{""};

// // Solution 2:
// if (rulesArray.Contains("3") &&((i % 3)== 0)) message.Add("Fizz");
// if (rulesArray.Contains("5") &&((i % 5)== 0)) message.Add("Buzz");
// if (rulesArray.Contains("7") &&((i % 7)== 0)) message.Add("Bang");
// if (rulesArray.Contains("11") &&((i % 11)== 0)) message.Add("Bong");
// if (rulesArray.Contains("13") &&((i % 13)== 0)) message.Add("Fezz");

// // Solution 1:
// // if (rule3=="Y" &&((i % 3)== 0)) message.Add("Fizz");
// // if ((rule5=="Y" &&((i % 5)== 0))) message.Add("Buzz");
// // if ((rule7=="Y" &&((i % 7)== 0))) message.Add("Bang");
// // if((rule11=="Y" &&((i % 11)== 0))) message.Add("Bong");
// // if ((rule13=="Y" &&((i % 13)== 0))) message.Add("Fezz");

// //adjust the sequence order:
// if (message.Contains("Fezz")){

//     message.Remove("Fezz");
    
//     if (message.Contains("Fizz"))
//     {
//         message.Insert(1,"Fezz");
//     }
//     else 
//     { 
//         message.Insert(0,"Fezz");
//     }
// } 

// if (rulesArray.Contains("17") &&((i % 17)== 0)) 
// {
//     message.Reverse();
// } 

// if (String.Join("",message) != "") 
// {
//     Console.WriteLine(String.Join("",message));
// }
// else 
// {
//     Console.WriteLine(i);
// }

// }

// one liner:
// for(var i = 1; i < 101; i++) Console.Read((i % 3? "" : "Fizz") + (i % 5? "" : "Buzz") || i) 

//Solution 3:
// Enumerable.Range(1,100).Select(
//     n => 
//     (n % 3 == 0) ? "Fizz" : 
//     (n % 5 == 0) ? "Buzz" : 
//     (n % 7 == 0) ? "Bang" : 
//     (n % 5 != 0)&& (n % 5 != 0) && (n % 7 != 0)? n : 
//     n.ToString())
//     .ToList()
//     .ForEach(Console.WriteLine);

// Enumerable.Range(1, 20).ToList().ForEach(
//     c => Console.WriteLine((c%15==0)?"FizzBuzz":((c%3==0)?"Fizz":(c%5==0)?"Buzz":c.ToString())));


// Extenstion: Dictionary:
Console.WriteLine("Please enter a number: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("What rules would you like, separate with a space?");
// Add a "!" at the end of ReadLine so that it will never be a null
string rules = Console.ReadLine()!;
string[] rulesArray = rules.Split(" ");

Dictionary<string,string> rulesDictionary = new Dictionary<string, string>();
rulesDictionary.Add("3","Fizz");
rulesDictionary.Add("5","Buzz");
rulesDictionary.Add("7","Bang");
rulesDictionary.Add("11","Bong");
rulesDictionary.Add("13","Fezz");

List<string> keyList = new List<string>(rulesDictionary.Keys);

for (var i=1; i<=number;i++){

List<String>message=new List<string>{""};

    for (var j =0; j<rulesArray.Length;j++) {
        if (rulesDictionary.ContainsKey(rulesArray[j]) && i % int.Parse(rulesArray[j])==0)
    {
        message.Add(rulesDictionary[rulesArray[j]]);
    }
}
     if (String.Join("",message) != "") 
        {
            Console.WriteLine(String.Join("",message));
        }
        else 
        {
            Console.WriteLine(i);
        }
}


