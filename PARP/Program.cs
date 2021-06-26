using System;
using System.Collections.Generic;

namespace ParCalculation
{
    class Program
    { 
        static void Main(string[] args)
        {
            List<Double> inputIQ = new List<Double>
            {
                11,
                22,
                33,
                44,
                55
            };
            _ = ParCalculation(inputIQ);
        }
        // Function that Calculate
        // Root Mean Square
        static Double RmsVoltage(List<double> inputIQ)
        {
            int square = 0;
            double mean;
            double root;
            double n = inputIQ.Count;

            // Calculate square.
            for (int i = 0; i < n; i++)
            {
                square += (int)Math.Pow(inputIQ[index: i], 2);
            }

            // Calculate Mean.
            mean = (square /  (n));


            // Calculate Root.
            root = Math.Sqrt(mean);

            Console.WriteLine(root);
            return root;
        }


        static Double AverageVoltage(List<double> inputIQ)
        {
            double mean;
            double sum = 0;
            int loop;

            for (loop = 0; loop < inputIQ.Count; loop++)
            {
                sum += inputIQ[loop];
            }

            mean = sum / (inputIQ.Count - 0);
            
            return mean;
        }


        static double ParCalculation(List<Double> inputIQ)
        {
            var rmsVoltage = RmsVoltage(inputIQ);
            var averageVoltage = AverageVoltage(inputIQ);
            var peakVoltage = rmsVoltage * Math.Sqrt(2);

            //The  peak to average power ratio(PAR) is peak power divided by average voltage power
            var parValue = peakVoltage / averageVoltage;
       
            return parValue;
        }

    }
}

