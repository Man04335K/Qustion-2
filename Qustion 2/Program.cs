using System;

class User
{
    // Properties of the User class
    public string Name { get; set; }
    public string Country { get; set; }
    public string Employment { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }

    // Constructor to initialize a new User object
    public User(string name, string country, string employment, int age, decimal salary)
    {
        Name = name;
        Country = country;
        Employment = employment;
        Age = age;
        Salary = salary;
    }

    // Method to display user details
    public void DisplayUserDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Country: {Country}");
        Console.WriteLine($"Employment: {Employment}");
    }

    // Method to display user's age
    public void DisplayAge()
    {
        Console.WriteLine($"Age: {Age}");
    }

    // Method to display user's salary
    public void DisplaySalary()
    {
        Console.WriteLine($"Salary: ${Salary}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the User class
        User user = new User("John Doe", "USA", "Software Engineer", 25, 75000);

        // Display user details regardless
        Console.WriteLine("User Details:");
        user.DisplayUserDetails();

        // Ask if the user is above 18
        Console.Write("Are you above 18 years old? (yes/no): ");
        string ageResponse = Console.ReadLine().ToLower();

        if (ageResponse == "yes")
        {
            // Display user's age if they are above 18
            user.DisplayAge();
        }
        else
        {
            Console.WriteLine("You must be above 18 to proceed.");
        }

        // Ask if the user is willing to share salary info
        Console.Write("Are you willing to share your salary information? (yes/no): ");
        string salaryResponse = Console.ReadLine().ToLower();

        if (salaryResponse == "yes")
        {
            // Display salary if the user agrees
            user.DisplaySalary();
        }
        else
        {
            Console.WriteLine("You chose not to share your salary information.");
        }
    }
}