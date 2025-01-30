// Written by Aaron Paatela
// 1/27/2025


namespace QuizCalculatorSpring2025
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QuizCalculatorA aQuizCalculator = new QuizCalculatorA();

            aQuizCalculator.Quiz1 = 85.0;
            aQuizCalculator.Quiz2 = 75.0;
            aQuizCalculator.Quiz3 = 95.0;
            aQuizCalculator.Quiz4 = 85.0;


            Console.WriteLine("Total: " + aQuizCalculator.CalcTotal());
            Console.WriteLine("Total: " + aQuizCalculator.CalcTotal());

        }
    }
}
