using System;

namespace StudentExample
{


    class Student { // class Student 
        // fields
        private string name; // private field for the student's Name
        private int age;     // private field for the student's Age
    
        // Constructors
        public Student() {   // constructor, sets values by default of the fields
            name = "Unknown";
            age = 0;
        }
    
        public Student(string name, int age) { // Constructor that takes Name   
                                               // and Age as arguments
            this.name = name; // We use the keyword THIS 'this' to adress the  
                              // field 'name' of the current object
            this.age = age;   // We use the keyword THIS 'this' to adress the  
                              // field 'age' of the current object
        }
    
        // Properties
        public string Name {      // property to acess the field Name 
            get { return name; }  // Getter method, that returns the value  
                                  // of the field 'name'
            set { name = value; } // Setter method to set the value of the
                                  //  field 'name'
        }
    
        public int Age { // public - property to get acess to the field 'age'
            get { return age; }   // Getter - method, that returns the value  
                                  //of the field 'age'
            set { 
                if (value >= 16)
                    age = value;
                else
                    Console.WriteLine("Age must be 16 or greater");
            } // Setter -method to set the value of the field 'age' 
                                             
        }
    
        // Methods
        public void PrintInfo() { // public method, that prints to  
                                  // the screen the name and age of the student
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }
        

    class Program
    {
        static void Main(string[] args)
        {
            // creation of new object Student, 'name' - "John Doe"
            Student myStudent = new Student("John Doe", 15);
            
            // output to the screen information about the student John Doe:
            myStudent.PrintInfo();
            
            myStudent.Age = 13; // calling the setter method, to set a wrong value

            // setting a 'right' value about the student's age ( >= 16 ) throught setter
            myStudent.Age = 18;
            
            myStudent.PrintInfo();
            
            
        }
    } 
}