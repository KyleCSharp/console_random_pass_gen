using console_random_pass;
using System.Diagnostics;
using System.Text;

while (true)
{
    Console.WriteLine("hello, welcome to my random password generator!");
    Console.WriteLine("please type special for special character password or simple for non special character");
    //-------------------------------------------------------------------------------------------------------------
    var userReso = Console.ReadLine();
    if (userReso.ToLower() == "simple")
    {
        Console.WriteLine("now how manys characters do you need?");
        var numberRepo = int.Parse(Console.ReadLine());
        
        Console.WriteLine(rando.RandomString(numberRepo));

        Console.WriteLine("now please high light and press CTRL>C to copy and paste where needed");
    }
    if (userReso.ToLower() == "special")
    {

        Console.WriteLine("now how many characters do you need?");
        var numberRepo = int.Parse(Console.ReadLine());

        Console.WriteLine(rando.RandomTwo(numberRepo));

        Console.WriteLine("now please high light and press CTRL>C to copy and paste where needed");
        


       
    }
    Console.WriteLine("if you would like to exit type exit or program will continue to loop");

    if (userReso.ToLower() == "exit")
    {
        Environment.Exit(0);
    }




}
