using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Worker : Human
{
    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
    {
        WeekSalary = weekSalary;
        WorkHoursPerDay = workHoursPerDay;
    }

    private decimal weekSalary;

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value < 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }

    private decimal workHoursPerDay;

    public decimal WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            workHoursPerDay = value;
        }
    }

    public override string ToString()
    {
        return $"First Name: {FirstName}{Environment.NewLine}" +
               $"Last Name: {LastName}{Environment.NewLine}" +
               $"Week Salary: {WeekSalary:f2}{Environment.NewLine}" +
               $"Hours per day: {WorkHoursPerDay:f2}{Environment.NewLine}" +
               $"Salary per hour: {WeekSalary / 5 / WorkHoursPerDay:f2}";
    }

}

