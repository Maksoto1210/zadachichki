namespace zadachkazaplati
{
    internal class Program
    {


        public static void Main()
        {
            Company company = new Company();
            company.Employees.Add(new Employee("Даниел", 6969));
            company.Employees.Add(new Employee("Мартин", 5000));
            company.Employees.Add(new Employee("Анастас", 3000));
            company.Employees.Add(new Employee("Максим", 7000));

            string result = company.FindEmployeeBySalary(7000);
            Console.WriteLine(result);
        }

    }
}
    

