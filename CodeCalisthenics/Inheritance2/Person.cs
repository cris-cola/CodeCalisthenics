using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCalisthenics.Inheritance2
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    public class Student : Person
    {
        public string firstName;
        public string lastName;
        public int idNumber;
        public int[] testScores;

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        public Student(string firstName, string lastName, int idNumber, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNumber = idNumber;
            this.testScores = scores;
        }

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        public char Calculate()
        {
            return CalculateGrade(CalculateAverage());
        }

        public int CalculateAverage()
        {
            var sum = testScores.Sum();

            return sum / testScores.Length;
        }

        public char CalculateGrade(int averageGrade)
        {
            if (averageGrade >= 90 && averageGrade <= 100)
                return 'O';
            if (averageGrade >= 80 && averageGrade < 90)
                return 'E';
            if (averageGrade >= 70 && averageGrade < 80)
                return 'A';
            if (averageGrade >= 55 && averageGrade < 70)
                return 'P';
            if (averageGrade >= 40 && averageGrade < 55)
                return 'D';

            return 'T';
        }

        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
            Console.WriteLine("ID: " + idNumber);
        }
    }
}
