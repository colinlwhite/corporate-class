using System;
using System.Collections.Generic;

namespace corporate_class
{
  public class Company
{
    /*
        Some readonly properties
    */
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a property for holding a list of current employees
    private List<Employees> TeamMembers = new List<Employees>();

    // Create a method that allows external code to add an employee
    public void AddATeamMember(Employees employeeName)
    {
      TeamMembers.Add(employeeName);
    }

    // Create a method that allows external code to remove an employee
    public void RemoveATeamMember(Employees employeeName)
    {
      TeamMembers.Remove(employeeName);
    }

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */

    public Company(string name, DateTime createdon)
    {
      Name = name;
      CreatedOn = createdon;
    }

    public void ListEmployees()
    {
      foreach(var member in TeamMembers)
      {
        Console.WriteLine($"{member.EmployeeName} joined Kairos' on {member.StartDate} and serves as {member.JobTitle}");
      }
    }
}
}