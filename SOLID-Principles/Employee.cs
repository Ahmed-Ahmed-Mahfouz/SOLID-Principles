using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{

    // The Employee class is responsible for storing employee information.
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }

    // The ISalaryCalculator interface defines a method for calculating salary.
    public interface ISalaryCalculator
    {
        decimal CalculateYearlySalary(Employee emp);
    }

    // The SalaryCalculator class is responsible for calculating the yearly salary of an employee.
    public class SalaryCalculator : ISalaryCalculator
    {
        public decimal CalculateYearlySalary(Employee emp)
        {
            return emp.Salary * 12;
        }
    }

    // The IReportGenerator interface defines a method for generating reports.
    public interface IReportGenerator
    {
        void GenerateReport(Employee emp, string reportType);
    }

    // The ReportGenerator class is responsible for generating a report for an employee.
    public class ReportGenerator : IReportGenerator
    {
        public void GenerateReport(Employee emp, string reportType)
        {
            //Code to generate report based on reportType
        }
    }

    // The INotification interface defines a method for sending notifications.
    public interface INotification
    {
        void SendNotification(Employee emp, string message);
    }

    // The Notification class is responsible for sending notifications.
    public class Notification : INotification
    {
        public void SendNotification(Employee emp, string message)
        {
            //Code to send email notification
        }
    }
}

// Responsibilities of the Employee class:
//  - Store employee information
//  - Calculate yearly salary
//  - Generate report
//  - Send notification