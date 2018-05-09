public class Company
{
    public Company(string companyName, string department, decimal salary)
    {
        CompanyName = companyName;
        Department = department;
        Salary = salary;
    }

    public string CompanyName { get; set; }

    public string Department { get; set; }

    public decimal Salary { get; set; }
}