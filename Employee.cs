using System;

 class Employee{

    private string firstname; 
    private string lastname;  
    private string id;  
    private int age; 
    private string address; 
    private string phonenumber; 
    private string title; 
    private double yearlysalary;
    private string employmentstatus; 

  
  
  
  public string FirstName{set;get;}

  public string LastName{set;get;}

  public int Age{
    get{return age;}
    set{if(value < 18) age=18; }
  }

  public double YearlySalary{
    set{
      if(value<1000){ yearlysalary=1000;}
      else yearlysalary = value;
      }
    get{return yearlysalary;}
  } 

  public string ID{get;set;}

  public string EmploymentStatus{get;set;}

  public Employee(){
    FirstName = "Unknown";
    LastName ="Unknown";
    ID = "Unknown";
    Age = 0;
    EmploymentStatus = "Active";
  }

  public void Intro(){
    
    Console.WriteLine ("First Name: " + FirstName);
    Console.WriteLine ("Last Name: " + LastName);
    Console.WriteLine ("Age: " + Age);
    Console.WriteLine ("ID: " + ID);
    Console.WriteLine ("Yearly Salary: " + YearlySalary);
  }

  

  public void IncreaseSalary(double percent){
    if( percent > 0 ){
      yearlysalary *= (0.01*percent+1);
      Console.WriteLine("Yearly salary updated to " + yearlysalary);
      }

    else {Console.WriteLine("Invalid input. Yearly Salary not updated.");}
    
  }

  public void RemoveEmployee(){
    if (EmploymentStatus == "Inactive") Console.WriteLine("Employee already inactive");
    else if (EmploymentStatus == "Active") {
      EmploymentStatus = "Inactive";
      Console.WriteLine("Employee removed");
    }
  }
}