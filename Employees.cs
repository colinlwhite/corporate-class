using System;

namespace corporate_class
{
  public class Employees
  {
    // Propeties that are describing the employees
    public string EmployeeName {get; set;}
    public string JobTitle {get; set;}
    public DateTime StartDate {get; set;}

    // Per the instruction: define methods to get/set employee name, job title, and start date
    // Access modifier has to be public with constructor methods
    // Constructors don't return anything so that's why we don't need VOID
    public Employees(string employeename, string jobtitle, DateTime startdate)
    {
      EmployeeName = employeename;
      JobTitle = jobtitle;
      StartDate = startdate;
    }


  }
}