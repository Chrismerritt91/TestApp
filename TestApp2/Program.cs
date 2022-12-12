class Sample
{
    static void Main()
    {
        //    String name = "Scott";
        //    int age = 23;

        //    System.Console.Write("hey ");
        //    System.Console.Write(name);
        //    System.Console.Write(" your age is ");
        //    System.Console.Write(age);

        //    System.Console.ReadKey();

        //area of a circle assignment
        //int radius = 3;

        //System.Console.Write(3.14 * radius * radius);

        //height in inches to centimeters
        //double feet = 6;
        //double inches = 2;
        //double oneInch = 2.54;
        //double oneFoot = 12;

        //double feetInInches = (feet * oneFoot) + inches;

        //System.Console.Write(feetInInches * oneInch);

        //how to round to the nearest thousandth without using commands
        //int input = 417;
        //decimal decimalInput = input;

        //int prevThousand = (input / 1000) * 1000;

        //decimal lastThree1 = decimalInput / 1000;
        //decimal lastThree2 = input /1000;
        //decimal getLastThree = (lastThree1 - lastThree2) * 1000;

        //int round = (getLastThree >= 500) ? 1000 : 0;
        //int lessThanfiveHundred = (input < 500) ? 1000 : 0;

        //int nearestThousand = prevThousand + round + lessThanfiveHundred;

        //System.Console.WriteLine(nearestThousand);

        int seconds = 288970;
        int minutes = seconds / 60;
        int hours = seconds / 60 / 60;
        int days = seconds / 60 / 60 / 24;

        int secondsLeft = seconds - (minutes * 60);
        int minutesLeft = minutes - (hours * 60);
        int hoursLeft = hours - (days * 24);


        System.Console.WriteLine(days + " days, " + hoursLeft + " hours, " + minutesLeft + " minutes, " + secondsLeft + " seconds");
   
        System.Console.ReadKey();

    }

}