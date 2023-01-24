// See https://aka.ms/new-console-template for more information
using System;
public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter a numeric argument.");
            return;
        }
        double start1 = double.Parse(args[0]);
        double start2 = double.Parse(args[1]);
        double start3 = double.Parse(args[2]);
        double final1 = double.Parse(args[3]);
        double final2 = double.Parse(args[4]);
        double final3 = double.Parse(args[5]);
        double time = double.Parse(args[6]);

        Console.WriteLine("start position: " + start1 + " " + start2 + " " + start3 + " ");
        Console.WriteLine("final position: " + final1 + " " + final2 + " " + final3 + " ");
        Console.WriteLine("time: " + time);

        double distance1 = Math.Pow((final1-start1),2);
        double distance2 = Math.Pow((final2-start2),2);
        double distance3 = Math.Pow((final3-start3),2);

        double totalDistance = Math.Sqrt(distance1 + distance2 + distance3);
        Console.WriteLine("total Distance is " + totalDistance);
        double speed = totalDistance / time;
        Console.WriteLine("the rate of speed " + speed);
        
        
        for (int i = 1; i <= 10; i++){
            time = i * 0.5;
            Console.WriteLine("iteration " + i + ":");
            double distance = speed * time;
            Console.WriteLine("distance traveled " + distance);

            double diff1 = (final1 - start1) / 10;
            double diff2 = (final2 - start2) / 10;
            double diff3 = (final3 - start3) / 10;

            double new1 = start1 + diff1 * i;
            double new2 = start2 + diff2 * i;
            double new3 = start3 + diff3 * i;
            Console.WriteLine("current position: [" + new1 + "," + new2 + "," + new3 + "]");

            Console.WriteLine("time: " + time);
            

        }
    }

}
    

