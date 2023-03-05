using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1, num2, result = 0;
            // Outer Try
            try
            {
                // Inner Try
                try
                {
                    Console.Write("Enter First Number : ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Second Number : ");
                    num2 = int.Parse(Console.ReadLine());
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                // Inner Catch
                catch (Exception ex)
                {
                    string filePath = @"D:\logs\log.txt";
                    if (File.Exists(filePath))
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append($"Message: {ex.Message}");
                        stringBuilder.Append($"\nSource: {ex.Source}");
                        stringBuilder.Append($"\nGet Type: {ex.GetType()}");
                        stringBuilder.Append($"\nGet Type and Name: {ex.GetType().Name}");
                        StreamWriter streamWriter = new StreamWriter(filePath);
                        streamWriter.Write(stringBuilder.ToString());
                        streamWriter.Close();
                        Console.WriteLine("Exception Occurred and Logged Successfully.");
                    }
                    else
                    {
                        throw new FileNotFoundException("File doesn't Exists.", ex);
                    }
                }
            }
            // Outer Catch
            catch (Exception ex)
            {
                // Current Exception Details:
                Console.WriteLine("Current Exception Message: " + ex.Message);
                Console.WriteLine("Current Exception Resource: " + ex.Source);

                // InnerException to get Inner Exception Details:
                Console.WriteLine("Inner Exception Message: " + ex.InnerException.Message);
                Console.WriteLine("Inner Exception Resource: " + ex.InnerException.Source);
            }

            Console.ReadKey();
        }
    }
}
