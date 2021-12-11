using System;

using System.Collections.Generic;
namespace Student
{
    public class student
    {
      
        public string name
        {
            get;
            set;
        }

        public int age
        {
            get;
            set;
        }
    
        public string subject
            {
               get;
               set;
    }
        public string subject1
        {
            get;
            set;
        }
        public string subject2
        {
            get;
            set;
        }
        public string subject3
        {
            get;
            set;
        }
        public string subject4
        {
            get;
            set;
        }
    
        public string grade
        {
            get;
            set;
        }
        public string grade1
        {
            get;
            set;
        }
        public string grade2
        {
            get;
            set;
        }
        public string grade3
        {
            get;
            set;
        }
        public string grade4
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student stu1 = new student()
            {

                name = " Jose",
                age =54,
                subject =" Math",
                subject1 =" CSS",
                subject2 =" Cook",
                subject3 =" HTML",
                subject4 =" Java",
                grade =" D",
                grade1 =" C",
                grade2 =" A",
                grade3 =" B",
                grade4 =" B",

            };
            student stu2 = new student()
            {

                name = " Ray",
                age = 23,
                subject = " Math",
                subject1 = " CSS",
                subject2 = " Cook",
                subject3 = " HTML",
                subject4 = " Java",
                grade = " D",
                grade1 = " C",
                grade2 = " A",
                grade3 = " B",
                grade4 = " B",
                

            };
            student stu3 = new student()
            {

                name = " Rita",
                age = 26,
                subject = " Math",
                subject1 = " CSS",
                subject2 = " Cook",
                subject3 = " HTML",
                subject4 = " Java",
                grade =  " D",
                grade1 = " D",
                grade2 = " D",
                grade3 = " B",
                grade4 = " B",

            };
            student stu4 = new student()
            {

                name = " Jay",
                age = 25,
                subject = " Math",
                subject1 = " CSS",
                subject2 = " Cook",
                subject3 = " HTML",
                subject4 = " Java",
                grade = " C",
                grade1 = " C",
                grade2 = " C",
                grade3 = " B",
                grade4 = " C",

            };
            student stu5= new student()
            {

                name = " Jackson",
                age = 21,
                subject = " Math",
                subject1 =  " CSS",
                subject2 = " Cook",
                subject3 = " HTML",
                subject4 = " Java",
                grade = " A",
                grade1 = " B",
                grade2 = " C",
                grade3 = " B",
                grade4 = " B",

            };




            List<student> students = new List<student>();
            students.Add(stu1);
            students.Add(stu2);
            students.Add(stu3);
            students.Add(stu4);
            students.Add(stu5);


            
            Console.WriteLine("\nname={0},\nage={1}, \nsubject={2},grade={7},\nsubject1={3},grade1={8},\nsubject2={4},grade2={9},\nsubject3={5},grade3={10},\nsubject4={6},grade4={11}\n", stu1.name, stu1.age, stu1.subject, stu1.subject1, stu1.subject2, stu1.subject3, stu1.subject4, stu1.grade, stu1.grade1, stu1.grade2, stu1.grade3, stu1.grade4);
            Console.WriteLine("\nname={0},\nage={1}, \nsubject={2},grade={7},\nsubject1={3},grade1={8},\nsubject2={4},grade2={9},\nsubject3={5},grade3={10},\nsubject4={6},grade4={11}\n", stu2.name, stu2.age, stu2.subject, stu2.subject1, stu2.subject2, stu2.subject3, stu2.subject4, stu2.grade, stu2.grade1, stu2.grade2, stu2.grade3, stu2.grade4);
            Console.WriteLine("\nname={0},\nage={1}, \nsubject={2},grade={7},\nsubject1={3},grade1={8},\nsubject2={4},grade2={9},\nsubject3={5},grade3={10},\nsubject4={6},grade4={11}\n", stu3.name, stu3.age, stu3.subject, stu3.subject1, stu3.subject2, stu3.subject3, stu3.subject4, stu3.grade, stu3.grade1, stu3.grade2, stu3.grade3, stu3.grade4);
            Console.WriteLine("\nname={0},\nage={1}, \nsubject={2},grade={7},\nsubject1={3},grade1={8},\nsubject2={4},grade2={9},\nsubject3={5},grade3={10},\nsubject4={6},grade4={11}\n", stu4.name, stu4.age, stu4.subject, stu4.subject1, stu4.subject2, stu4.subject3, stu4.subject4, stu4.grade, stu4.grade1, stu4.grade2, stu4.grade3, stu4.grade4);
            Console.WriteLine("\nname={0},\nage={1}, \nsubject={2},grade={7},\nsubject1={3},grade1={8},\nsubject2={4},grade2={9},\nsubject3={5},grade3={10},\nsubject4={6},grade4={11}\n", stu5.name, stu5.age, stu5.subject, stu5.subject1, stu5.subject2, stu5.subject3, stu5.subject4, stu5.grade, stu5.grade1, stu5.grade2, stu5.grade3, stu5.grade4);

        }
    }
}
