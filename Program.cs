using ConsoleApp2;

Employee user1 = new Employee("Sam","Serious",30);
Employee user2 = new Employee("John");
Employee user3 = new Employee();
List<Employee> employees = new List<Employee>() { user1,user2,user3};
var random = new Random();

foreach (Employee employee in employees)
    for (int i = 0; i < 5; i++)
        employee.AddScore(random.Next(1,11));

int maxIndex = 0;

for (int i = 1;i < 3; i++)
    if (employees[maxIndex].Score < employees[i].Score)
        maxIndex = i;

if (maxIndex != 0)
    Console.WriteLine("Are You serious?");
Console.WriteLine("The best employee is:");
Console.WriteLine("imię: " + employees[maxIndex].FirstName
                  +" nazwisko: " + employees[maxIndex].LastName 
                  +" wiek: " + employees[maxIndex].Age+" punkty: "
                  + employees[maxIndex].Score);