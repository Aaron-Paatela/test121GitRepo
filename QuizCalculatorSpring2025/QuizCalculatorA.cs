// Written By Aaron Paatela
// 1/25/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QuizCalculatorSpring2025
{
    public class QuizCalculatorA
    {
        private double quiz1 = -999.99;
        private double quiz2 = -999.99;
        private double quiz3 = -999.99;
        private double quiz4 = -999.99;
        private double total = -4000.00;
        private double average = -899.99;
        private string letterGrade = "n/a";

        // Refactor with a list



        public double Quiz1
        {
            get { return this.quiz1; }
            set {
                if (value > 100.00 || value < 0.0)
                {
                    this.quiz1 = -999.99;
                }
                else
                {
                    this.quiz1 = value;
                }
            }
        }
        public double Quiz2
        {
            get { return this.quiz2; }
            set
            {
                if (value > 100.00 || value < 0.0)
                {
                    this.quiz1 = -999.99;
                }
                else
                {
                    this.quiz2 = value;
                }
            }
        }
        public double Quiz3
        {
            get { return this.quiz3; }
            set
            {
                if (value > 100.00 || value < 0.0)
                {
                    this.quiz3 = -999.99;
                }
                else
                {
                    this.quiz3 = value;
                }
            }
        }
        public double Quiz4
        {
            get { return this.quiz4; }
            set
            {
                if (value > 100.00 || value < 0.0)
                {
                    this.quiz4 = -999.99;
                }
                else
                {
                    this.quiz4 = value;
                }

                
            }
        }

        // methods

        public double CalcTotal()
        {
            double aTotal = 0.0;

            aTotal = Quiz1 + Quiz2 + Quiz3 + Quiz4;
            return aTotal;
        }

        public double CalcAverage()
        {
            double aAverage = 0.0;
            
            // The 4 is a classic "Magic Number", meaning we arbitrarily decided there are 4 quizzes.  
            aAverage = (Quiz1 + Quiz2 + Quiz3 + Quiz4) / 4;

            return aAverage;

        }
        public string CalcLetterGrade()
        {
            double aAverage = 0.0;
            string aLetterGrade = "n/a";
            aAverage = (Quiz1 + Quiz2 + Quiz3 + Quiz4) / 4;

            if(aAverage >= 0.0 && aAverage < 60.0)
            {
                aLetterGrade = "F";
            }
            if(aAverage >= 60.0 && aAverage < 70.0)
            {
                aLetterGrade = "D";
            }    
            if(aAverage >= 70.0 && aAverage < 80.0)
            {
                aLetterGrade = "C";
            }
            if(aAverage >= 80.0 && aAverage < 90.0)
            {
                aLetterGrade = "B";
            }
            if(aAverage >= 90.0)
            {
                aLetterGrade = "A";
            }
            return aLetterGrade;
        }
        
        

    }
}
