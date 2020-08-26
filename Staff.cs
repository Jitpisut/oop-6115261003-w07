using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261003_w07
{
    class Staff : Person
    {
        private double performanceLevel;
        public double PerformanceLaval
        {
            get { return performanceLevel; }
            set { performanceLevel = value; }
        }
        public Staff(string n, string ln, int s, int w, int i, double a, double p)
        {
            this.Name = n;
            this.Lastname = ln;
            this.Salary = s;
            this.WorkedYear = w;
            this.IntentYearlyActivity = i;
            this.AssessedFromAdmin = a;
            this.performanceLevel = p;
        }

        public double calculateSalaryRaise()
        {
            double score = this.AssessedFromAdmin + this.IntentYearlyActivity + this.PerformanceLaval;
            double salaryRaise = 0;

            if (score < 70)
            {
                return Salary;
            }
            else if (score <= 80)
            {
                salaryRaise = Salary * 0.01 + Salary;
            }
            else if (score <= 85)
            {
                salaryRaise = Salary * 0.015 + Salary;
            }
            else if (score <= 90)
            {
                salaryRaise = Salary * 0.02 + Salary;
            }
            else if (score <= 95)
            {
                salaryRaise = Salary * 0.025 + Salary;
            }
            else if (score > 95)
            {
                salaryRaise = Salary * 0.03 + Salary;
            }
            return salaryRaise;
        }

        public override string ToString()
        {
            return base.ToString() + " " + "Salary Raise : : " +
                this.calculateSalaryRaise();
        }
    }
}
