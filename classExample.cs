using System;  
   public class Student  
    {  
        public int StudentId;   
        public String StudentName;  
   }  
   class TestStudent{  
       public static void Main(string[] args)  
        {  
            Student student = new Student();    
            student.StudentId = 100;  
            student.StudentName = "Md Asif";  
            Console.WriteLine(student.StudentId);  
            Console.WriteLine(student.StudentName);  
  
        }  
    } 
