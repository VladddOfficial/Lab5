using System;

class MainClass {
  public static void Main (string[] args) {
    


    Employee employee1 = new Employee();
    employee1.Intro();
    Console.WriteLine ("");

    Employee employee2 = new Employee();
    employee2.FirstName = "Robert";
    employee2.LastName = "Downey";
    employee2.ID = "12321";
    employee2.Age = 12;
    employee2.YearlySalary = 100;
    employee2.Intro();
    Console.WriteLine ("");

    Employee employee3 = new Employee();
    employee3.FirstName = "John";
    employee3.LastName = "Smith";
    employee3.ID = "S0089";
    employee3.Age = 38;
    employee3.YearlySalary = 50000;
    employee3.Intro();
    employee3.IncreaseSalary(-2);
    employee3.RemoveEmployee();
    Console.WriteLine ("");

    Employee employee4 = new Employee();
    employee4.FirstName = "Maria";
    employee4.LastName = "Lambert";
    employee4.ID = "S0010";
    employee4.Age = 26;
    employee4.YearlySalary = 80000;
    employee4.Intro();
    employee4.IncreaseSalary(7);
    employee4.RemoveEmployee();
    employee4.RemoveEmployee();


  

  }

}