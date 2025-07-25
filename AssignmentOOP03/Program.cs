using AssignmentOOP03.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentOOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Question 01
            // 1.Design and implement a Class for the employees in a
            //company: 
            //Notes: 
            //● Employee is identified by an ID, Name, security level, salary, hire
            //date and Gender.
            //● We need to restrict the Gender field to be only M or F[Male or
            //Female]  
            //● Assign the following security privileges to the employee(guest,
            //Developer, secretary and DBA) in a form of Enum.
            //● We want to provide the Employee Class to represent Employee
            //data in a string Form(override ToString()), display employee
            //salary in a currency format. [Use String.Format() Function]. 

            //HiringDate date = new HiringDate(-1, 2, 2020);
            //Console.WriteLine(date.Day);
            //Console.WriteLine(date.Month);
            //Console.WriteLine(date.Year);
            

          //  Console.WriteLine();

          //  Employee employee = new Employee(iD:1,name:"ali");
          //  //employee.Gender 
            
          //  Gender gender=0;
          //     // Enum.TryParse<Gender>("M",true,out gender);
          //// Console.WriteLine("is valid? " +employee.isValidGenderByString("male",out gender));
          //  //.CompareTo(1 / 2 / 2024)
            #endregion
          //  Console.WriteLine(gender);

          //  // employee.securityLevelPermissionByNumber(15);
          // // employee.SecurityLevel = employee.getSecurityLevelPermissionByEnteredLevels(SecurityLevel.DBA, SecurityLevel.guest);
           
          //      Console.WriteLine(employee.SecurityLevel);
          //  employee.Name = "";
          //  Console.WriteLine(employee.Name);
          //  // employee.SecurityLevel = 



            #region ArrayOFEmployees
            //            0.
            //Create an array of Employees with size three a DBA, Guest
            //and the third one is security officer who have full permissions. 
            //(Employee[] EmpArr;) 
            Employee[] employees = new Employee[3];
            HiringDate hiringDate;
            employees[0] = new Employee(0,"Ali ahmed",SecurityLevel.guest);
            employees[0].HireDate = new HiringDate(1,2,2024);
            employees[1] = new Employee(1,"Amr ali",SecurityLevel.DBA);
            employees[1].HireDate = new HiringDate(1, 5, 2025);

            employees[2] = new Employee(iD:2,name:"Security Officer");
            employees[2].securityLevelPermissionByNumber(15);
            employees[2].HireDate = new HiringDate(1,5,2025);
            Console.WriteLine("Employees Data");
            foreach(var emp in employees)
            {
               Console.WriteLine( emp.ToString());
            }

            #endregion

        }
    }
}
