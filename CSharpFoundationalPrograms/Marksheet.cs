using System;
using System.Collections.Generic;

namespace CSharpFoundational
{
	internal class Marksheet
	{
		public static void Main()
		{
		    Console.Write("Enter the total number of Students: ");
		    int noOfStudents = Convert.ToInt32(Console.ReadLine());
		    
		    Console.Write("Enter the total number of Subjects: ");
		    int noOfSubjects = Convert.ToInt32(Console.ReadLine());
		    
		    string[] students = new string[noOfStudents];
		    int[] sumScores = new int[noOfStudents];
		    int[] sumAssignments = new int[noOfStudents];
		    double[] avgExtraAssignment = new double[noOfStudents];
		    double[] avgScores = new double[noOfStudents];
		    double[] finalAvgScores = new double[noOfStudents];
			string[] gradeScores = new string[noOfSubjects];
		    
		    Console.WriteLine("Enter the name of the Students: ");
		    for(int i = 0; i < noOfStudents; i++)
		    {
		        students[i] = Console.ReadLine();
		    }
		    
		    string[] subjects = new string[noOfSubjects];
		    Console.WriteLine("Enter the name of the Subjects: ");
		    for(int i = 0; i < noOfSubjects; i++)
		    {
		        subjects[i] = Console.ReadLine();
		    }
		    
		    Console.WriteLine("Enter the extra assignments marks;");
		    int[,] extraAssignments = new int[noOfStudents,noOfSubjects];
		    
		    for(int i = 0; i < noOfStudents; i++)
		    {
		        Console.WriteLine($"Enter number of extra assignments submitted by {students[i]}:" );
		        int noOfAssignments = Convert.ToInt32(Console.ReadLine());
		      for(int j = 0; j < noOfAssignments; j++)
		      {
		          Console.WriteLine("Marks: ");
		          extraAssignments[i,j] = Convert.ToInt32(Console.ReadLine());
		      }
		    }
		    
		    int[,] studentScores = new int[noOfStudents,noOfSubjects];
		    
		    Console.WriteLine("Enter the marks of students according to subjects: ");
		    for(int i = 0; i < noOfStudents; i++)
		    {
		            Console.WriteLine($"For {students[i]}: ");
		            
		        for(int j = 0; j < noOfSubjects; j++)
		        {
		            Console.Write($"In {subjects[j]}: ");
		            studentScores[i,j] = Convert.ToInt32(Console.ReadLine());
		            sumScores[i] += studentScores[i,j];
		            sumAssignments[i] += extraAssignments[i,j];
		        }
		            avgScores[i] = sumScores[i] / noOfSubjects;
		            avgExtraAssignment[i] = sumAssignments[i] / extraAssignments.GetLength(1);
		            finalAvgScores[i] = (sumScores[i]  / noOfSubjects + (avgExtraAssignment[i] * 0.1));
			    gradeScores[i] = GetGradeScores(finalAvgScores[i]);
		    }
		    
		   /* Console.WriteLine("\nComplete Marksheet of Students\n");
		    for(int i = 0; i < noOfStudents; i++)
		    {
		            Console.WriteLine($"For {students[i]}: {avgScores[i]}");
		            
		        for(int j = 0; j < noOfSubjects; j++)
		        {
		            Console.WriteLine($"{subjects[j]}: {studentScores[i,j]}");
		        }
		    }*/
		    
		    Console.WriteLine("\n\n----Student Marksheet-----\n\n");
            Console.WriteLine("Student\t\tExam Score\t\tOverall Grade\t\tExtra Credit");
			for(int i = 0; i < noOfStudents; i++)
			{
				Console.WriteLine($"{students[i]}\t\t{avgScores[i]}\t\t{finalAvgScores[i]}\t\t{gradeScores[i]}\t\t{avgExtraAssignment[i]}\t({avgScores[i] - finalAvgScores[i]} pts)");			    
			}
		}

		public static string GetGradeScores(double score)
		{
			string grade;

			if(score >= 97.0 && score <= 100.0)
				grade = "A+";
			else if(score >= 93.0 && score < 97.0)
				grade = "A";
			else if(score >= 90.0 && score < 93.0)
				grade = "A-";
			else if(score >= 87.0 && score < 90.0)
				grade = "B+";
			else if(score >= 83.0 && score < 87.0)
				grade = "B";
			else if(score >= 80.0 && score < 83.0)
				grade = "B";
			else if(score >= 77.0 && score < 80.0)
				grade = "C+";
			else if(score >= 73.0 && score < 77.0)
				grade = "C";
			else if(score >= 70.0 && score < 73.0)
				grade = "C-";
			else if(score >= 67.0 && score < 70.0)
				grade = "D+";
			else if(score >= 63.0 && score < 67.0)
				grade = "D";
			else if(score >= 60.0 && score < 63.0)
				grade = "D-";
			else if(score >= 0.0 && score < 60.0)
				grade = "F";
			else
				grade = "Error";

			return grade;
	    }
	}
}