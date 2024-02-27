using System;

class Robot
{
    string RobotName;
    int RobotAge;

    public Robot(string RobotName, int RobotAge)
    {
        this.RobotName = RobotName;
        this.RobotAge = RobotAge;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("The name of the Robot is " + RobotName);
        Console.WriteLine("The age of the Robot is " + RobotAge);
    }
    static void Main()
    {
        Robot Robot1 = new Robot("BumbleBee", 100);
        Robot Robot2 = new Robot("Optimus Prime", 1000);

        Console.WriteLine("The information of the Robot1 is: ");
        Robot1.DisplayInfo();

        Console.WriteLine("The information of the Robot2 is: ");
        Robot2.DisplayInfo();

        Console.ReadLine();
    }
}

    // We can modify it's Driver program by another way. i.e by adding return and creating an object class of getInfo
//since we'll use string in that class the Driver program will get change as well.

    /*
     public string GetInfo()
    {
    return $"Robot name: {RobotName}\n Robot age: {RobotAge}";
    }

    static void Main()
    {
    Robot Robot1 = new Robot("BumbleBee" , 100);
    Robot Robot2 = new Robot("OptimusPrime" , 1000);

    Console.WriteLine("Info of Robot 1 is:");
    Console.WriteLine(Robot1.GetInfo());
    
    Console.WriteLine("Info of Robot 2 is: ");
    Console.WritgeLine(Robot2.GetInfo());

    Console.ReadLine();

    }

     */