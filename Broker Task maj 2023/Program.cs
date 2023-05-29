using System;
using System.Security.Cryptography.X509Certificates;

namespace Broker_Task_maj_2023
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(5, 3);
            Console.WriteLine("Wynik dodawania: " + result);
                }        
        
    }
}