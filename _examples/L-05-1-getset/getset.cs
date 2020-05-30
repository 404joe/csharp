using System;

namespace StudentExample
{


    class Student { // клас Student 
        // полета
        private string name; // private поле за името на студента
        private int age; // private поле за възрастта на студента
    
        // Constructors
        public Student() { // constructor, който установява 
                           // стойности по подразбиране на полетата
            name = "Unknown";
            age = 0;
        }
    
        public Student(string name, int age) { // Конструктор, който приема name /име/ и  
                                                                    // age /възраст/ като аргументи /параметри/
            this.name = name; // Използваме ключова дума "this" за сда се обърнем 
                                          // към полето name на текущия обект
            this.age = age; // Използваме ключова дума "this" за сда се обърнем 
                                    // към полето age на текущия обект
        }
    
        // Properties
        public string Name { // свойство /property/ за достъп до полето Name - Име
            get { return name; } // Getter метод, който втъща стойността на 
                                            //полето name /име/
            set { name = value; } // Setter метод за установяване на 
                                            //  стойносттта на полето name /име/
        }
    
        public int Age { // public - свойство /property/ за достъп до полето age - възраст
            get { return age; }   // Getter -метод, който втъща стойността на 
                                            //полето age /възраст/
            set { 
                if (value >= 16)
                    age = value;
                else
                    Console.WriteLine("Age must be 16 or greater");
            } // Setter -метод за установяване на 
                                            //  стойносттта на полето age /възраст/ 
        }
    
        // Методи
        public void PrintInfo() { // public метод, който извежда на екрана 
                                                // име и възраст на студента
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }
        

    class Program
    {
        static void Main(string[] args)
        {
            // създаване на нов обект Student, име - "John Doe"
            Student myStudent = new Student("John Doe", 15);
            
            // извеждаме информация за студента на екрана
            myStudent.PrintInfo();
            
            myStudent.Age = 13; // извикване на setter метода, за установяване на неправилна стойност

            // установяване на 'правилна' стойност за възрастта на студентa ( >= 16 ) чрез setter
            myStudent.Age = 18;
            
            myStudent.PrintInfo();
            
            
        }
    } 
}