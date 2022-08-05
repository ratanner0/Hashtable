using System;
using System.Collections;

namespace Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable= new Hashtable();

            Student s1 = new Student(1, "Maria", 98);
            Student s2 = new Student(2, "Jason", 76);
            Student s3 = new Student(3, "Clara", 43);
            Student s4 = new Student(4, "Steve", 55);

            studentsTable.Add(s1.ID, s1);
            studentsTable.Add(s2.ID, s2);
            studentsTable.Add(s3.ID, s3);
            studentsTable.Add(s4.ID, s4);

            Student storedStudent1 = (Student)studentsTable[1];

            //retrieve all values from Hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID: {0}",temp.ID);
                Console.WriteLine("Student Name: {0}",temp.Name);
                Console.WriteLine("Student GPA: {0}",temp.GPA);
                Console.WriteLine(" ");
            }

            Console.WriteLine("Student ID: {0}, Name: {1}, GPA {2}",storedStudent1.ID,storedStudent1.Name,storedStudent1.GPA);
            Console.Read();

        }
    }

    class Student
    {
        //property called ID
        public int ID { get; set; }
        //property Name
        public string Name { get; set; }
        //property GPA
        public float GPA { get; set; }
        //simple constructor
        public Student(int ID, string Name, float GPA)
        {
            this.ID = ID;
            this.Name = Name;
            this.GPA = GPA;
        }
        

    }
}
