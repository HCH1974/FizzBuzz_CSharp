// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// for (var i = 1; i < 101; i++) {
//     // when we use "===", we got an error that types don't match
//     if ((i % 3)== 0 && (i % 5) == 0)
//     {
//         Console.WriteLine("FizzBuzz");
//     } else if ((i % 3)==0) 
//     {
//         Console.WriteLine("Fizz");
//     } else if ((i % 5)==0)
//     {
//         Console.WriteLine("Buzz");
//     }
//     else 
//     {
//     Console.WriteLine(i);
//     }
// }

// for (var i = 1; i < 300; i++) {
//     string output = "";
//    
//     if ((i % 3)== 0) 
//     {
//         if ((i % 13)==0)
//         {
//             output="Fezz";
//         }
//         output = "Fizz"+output;
//     }
//     if ((i % 5)==0) 
//     {
//         if ((i % 13)==0 && !output.Contains("Fezz"))
//         {
//             output="Fezz";
//         }
//         output = output + "Buzz";    
//     } 
//     if ((i % 7)==0)
//     {
//         if ((i % 13)==0 && !output.Contains("Fezz"))
//         {
//             output="Fezz";
//         }
//         output = output + "Bang";
//     }
//     if ((i % 11)==0) 
//         {
//             if ((i % 13)==0 && !output.Contains("Fezz"))
//         {
//             output="FezzBong";
//         } else 
//         {
//             output = "Bong";
//         }
//     }
//     if ((i % 13)==0 && output == ""){
//         output="Fezz";
//     }
//     if (output != "") {
//     Console.WriteLine(output);
//     }
//     else {
//         Console.WriteLine(i);
//     }

// }
for (var i = 1; i < 300; i++) {
List<String>message=new List<string>{""};
if ((i % 3)== 0) message.Add("Fizz");
if ((i % 5)== 0) message.Add("Buzz");
if ((i % 7)== 0) message.Add("Bang");
if ((i % 11)== 0) message.Add("Bong");
if ((i % 13)== 0) message.Add("Fezz");

//adjust the order
if (message.Contains("Fezz")){

    message.Remove("Fezz");
    
    if (message.Contains("Fizz"))
    {
        message.Insert(1,"Fezz");
    }
    else 
    { 
        message.Insert(0,"Fezz");
    }
} 

if ((i % 17)== 0) {
    message.Reverse();
} 
if (String.Join("",message) != "") 

{
    Console.WriteLine(String.Join("",message));
}
else {
    Console.WriteLine(i);
}

}