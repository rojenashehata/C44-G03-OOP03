using AssignmentOOP03.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03
{

    //Notes: 
    //● Employee is identified by an ID, Name, security level, salary, hire
    //date and Gender.
    //● We need to restrict the Gender field to be only M or F[Male or
    //Female]  
    //● Assign the following security privileges to the employee(guest,
    //Developer, secretary and DBA) in a form of Enum.
    //● We want to provide the Employee Class to represent Employee
    //data in a string Form(override ToString()), display employee
    //salary in a currency format. [Use String.Format() Function]
    public class Employee
    {
        public Employee(int id)
        {
            ID = id;

        }

        public Employee(int iD, string name, Gender gender, SecurityLevel securityLevel, HiringDate hireDate, double salary)
        {
            ID = iD;
            Name = name;
            _gender = gender;
            SecurityLevel = securityLevel;
            HireDate = hireDate;
            Salary = salary;
        }

        public Employee( int iD,string name, SecurityLevel securityLevel)
        {
            _name = name;
            ID = iD;
            _securityLevel = securityLevel;
        }

        public Employee(string name, int iD)
        {
            _name = name;
            ID = iD;
        }

        
        public string Name
        {
            get { return _name; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value.Trim()))
                {
                    StringBuilder formattedName = new StringBuilder();
                  string[]splittedName=  value.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                  foreach (string name in splittedName)
                    {
                        formattedName .Append(char.ToUpper(name[0]) + name.Substring(1).ToLower() + " ");
                    };
                    _name = formattedName .ToString().TrimEnd();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                    
            }
        }


        private int _id;

        public int ID
        {
            get { 
                return _id;
            }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Invalid negative id");
                }
                else
                    _id = value;
                
            }
        }
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set {
                if (Salary < 0)
                    Console.WriteLine("Invalid! negative salary");
                else
                    _salary = value;

            }
        }

        private string _name;


        private SecurityLevel _securityLevel;

        private Gender _gender;

        public Gender Gender
        {
            get 
            { 
                return _gender; 
            }
            set 
            {
                if (value==Gender.M||value==Gender.F)
                {
                    _gender = value;
                }
                else
                    Console.WriteLine("InValid Input");
            }
        }


        public SecurityLevel SecurityLevel
        {
            get { return _securityLevel; }
            set { 
              

                _securityLevel = value; 
            }
        }

        public HiringDate HireDate { get; set; }

        

        //public bool IsgenderANumber(string gender)
        //{
        //    bool isValid = true;
        //    if(int.TryParse(gender.ToString(),out _))
        //    return isValid;

        //}



        public bool isValidGenderByString(string enteredGender,out Gender ValidatedGender )//Constraints: string parameter not a number
        {
            ValidatedGender = 0;
            bool isValid=true;
            //do
            //{
                //Console.WriteLine("Enter Gender M or F only");
                if (int.TryParse(enteredGender, out _))
                {
                    Console.WriteLine("Invalid Input");
                
                    return false;
                    //continue;
                }

                isValid = Enum.TryParse<Gender>(enteredGender, true, out ValidatedGender);
            if (!isValid)
            {
                    Console.WriteLine("Invalid Security Level");

            }

            // Console.WriteLine(enteredGender);

            //} while (!isValid);

            return isValid;

        }

       public void getSecurityLevelPermissionByEnteredLevels(params SecurityLevel[] securitylevels)
        {
            SecurityLevel resultSecurityLevel = 0;
            foreach (var level in securitylevels)
            {
                resultSecurityLevel|=level;
            }

            _securityLevel= (SecurityLevel)resultSecurityLevel;
        }
        public void securityLevelPermissionByNumber(byte number)
        {

            if (number > 1 && number <= 15)
            {
                SecurityLevel resultSecurityLevel = (SecurityLevel)number;
                SecurityLevel = resultSecurityLevel;
                 
            }
            else
            {
                Console.WriteLine("invalid Security Level");
            }
            // Enum.TryParse<SecurityLevel>(number,out resultSecurityLevel);


        }

        public override string ToString()
        {
            //if (ID != 0 && Name != null && Gender != 0 && SecurityLevel != 0 && HireDate != null && Salary != 0)
                return $"ID:{ID}, Name:{Name}, Gender:{_gender}, Security Level:{SecurityLevel}, hire date:{HireDate.getDate()}, salary:{string.Format("{0:c}",Salary)}";
        }



    }
}
