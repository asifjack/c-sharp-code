
using System;  
 public class Employee  
    {  
        public int id;   
        public String name;  
        public float salary;  
        public Employee(int i, String n,float s)  
        {  
            id = i;  
            name = n;  
            salary = s;  
        }  
        public void display()  
        {  
            Console.WriteLine(id + " " + name+" "+salary);  
        }  
   }  
   public class TestConExample  
    {  
        
        public TestConExample()  
        {  
            Console.WriteLine("Default Constructor Invoked");  
        }  
        public static void Main(string[] args)  
        {  
            TestConExample e1 = new TestConExample();
            Employee emp = new Employee(100, "Asif", 890000f);  
              
            emp.display();  
            

        }  
    }  