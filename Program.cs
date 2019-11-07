using System;
using System.Collections.Generic;
using System.Linq;

namespace example_code
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a few instances of cohorts

            Cohort CohortOne = new Cohort("Cohort One");

            Cohort CohortTwo = new Cohort("Cohort Two");

            CohortOne.StudentList.Add(new Student()
            {
                FirstName = "Sable",
                LastName = "Bowen",
                FavoriteLanguage = "C#",
                monthsToHire = 4,
                startingSalary = 47000
            });

            CohortOne.StudentList.Add(new Student()
            {
                FirstName = "Matt",
                LastName = "Rowe",
                FavoriteLanguage = "JavaScript",
                monthsToHire = 3,
                startingSalary = 49000

            });

            CohortOne.StudentList.Add(new Student()
            {
                FirstName = "Sydney",
                LastName = "Wait",
                FavoriteLanguage = "JavaScript",
                monthsToHire = 3,
                startingSalary = 49000
            });

            CohortOne.StudentList.Add(new Student()
            {
                FirstName = "Joey",
                LastName = "Wellman",
                FavoriteLanguage = "C#",
                startingSalary = 45000,
                monthsToHire = 1
            });

            CohortOne.StudentList.Add(new Student()
            {
                FirstName = "Josh",
                LastName = "Havey",
                FavoriteLanguage = "C#",
                startingSalary = 43000,
                monthsToHire = 3
            });

            CohortOne.StudentList.Add(new Student()
            {
                FirstName = "Connor",
                LastName = "Fitzgerald",
                FavoriteLanguage = "C#",
                startingSalary = 41000,
                monthsToHire = 3
            });




            CohortTwo.StudentList.Add(new Student()
            {
                FirstName = "Luke",
                LastName = "Miller",
                FavoriteLanguage = "JavaScript"
            });

            Cohort CohortThree = new Cohort("Cohort Three")
            {
                StudentList = new List<Student>(){
                    new Student(){
                        FirstName = "Dan",
                        LastName = "McGee",
                        FavoriteLanguage = "JavaScript"
                    },
                     new Student(){
                        FirstName = "Frank",
                        LastName = "McGee",
                        FavoriteLanguage = "JavaScript"
                    },
                     new Student(){
                        FirstName = "Janice",
                        LastName = "McGee",
                        FavoriteLanguage = "C#"
                    },
                     new Student(){
                        FirstName = "Lila",
                        LastName = "McGee",
                        FavoriteLanguage = "JavaScript"
                    },
                     new Student(){
                        FirstName = "Chris",
                        LastName = "McGee",
                        FavoriteLanguage = "C#"
                    },
                }
            };

            Cohort CohortFour = new Cohort("Cohort Four")
            {
                StudentList = new List<Student>(){
                    new Student(){
                        FirstName = "Mary",
                        LastName = "Franklin",
                        FavoriteLanguage = "JavaScript"
                    },
                     new Student(){
                        FirstName = "Sarah",
                        LastName = "Franklin",
                        FavoriteLanguage = "JavaScript"
                    },
                     new Student(){
                        FirstName = "Jake",
                        LastName = "Franklin",
                        FavoriteLanguage = "C#"
                    }
                }
            };

            Cohort CohortFive = new Cohort("Cohort Five")
            {
                StudentList = new List<Student>(){
                    new Student(){
                        FirstName = "Michael",
                        LastName = "Delores",
                        FavoriteLanguage = "C#"
                    },
                     new Student(){
                        FirstName = "Janelle",
                        LastName = "Delores",
                        FavoriteLanguage = "C#"
                    },
                     new Student(){
                        FirstName = "Lisa",
                        LastName = "Delores",
                        FavoriteLanguage = "JavaScript"
                    },
                     new Student(){
                        FirstName = "Mark",
                        LastName = "Delores",
                        FavoriteLanguage = "C#"
                    },
                }
            };






            // ----- Math -------//

            List<Cohort> allCohorts = new List<Cohort>(){
                CohortOne, CohortTwo, CohortThree, CohortFour, CohortFive
            };

            // .length --> .Count()

            // .map() -- > .Select()

            List<int> cohortCounts = allCohorts.Select(singleCohort => singleCohort.StudentList.Count()).ToList();

            Console.WriteLine();


            // Find the average cohort size
            // .Average()

            double average = cohortCounts.Average();

            // Find the total number of students in all the cohorts

            int totalNumberOfStudents = cohortCounts.Sum();

            // Which cohort is the largest?
            int largestClassSize = cohortCounts.Max();

            // Find the largest three cohorts
            List<Cohort> topThreeCohorts = allCohorts.OrderByDescending(singleCohort => singleCohort.StudentList.Count()).Take(3).ToList();



            // Find the cohorts that have fewer than 5 people
            // .filter()
            List<Cohort> tinyCohorts = allCohorts.Where(singleCohort => singleCohort.StudentList.Count() < 5).ToList();

            Console.WriteLine();


            // -------- LIGHTNING EXERCISE ----------//
            //         1. Copy and paste the following list of grades into `Program.cs`.
            List<int> studentGrades = new List<int>() { 57, 99, 87, 83, 85, 90, 86, 78, 79, 61, 93, 88, 82, 78 };
            // - What was the average grade in this class?
            double avgGrade = studentGrades.Average();
            // - What was the highest grade?
            int largestGrade = studentGrades.Max();
            // - What was the lowest grade?
            int smallestGrade = studentGrades.Min();
            // - To pass the class, you have to make above a 65. Use linq to figure out how many students passed.

            // make a list
            // compare to 65 with .Where()
            // Count how many people are in the list

            // int numberOfPassingStudents = studentGrades.Where(singleGrade => singleGrade >= 65).Count();

            var passingGrades = from singleGrade in studentGrades where singleGrade >= 65 select singleGrade;

            int numberOfPassingGrades = passingGrades.Count();

            List<int> topFiveGrades = studentGrades.OrderByDescending(grade => grade).Take(5).ToList();

            // IEnumerable<int> topFiveGrades = from singleGrade in studentGrades orderby descending select singleGrade;


            

            // ---- Data questions (we haven't been over these yet) ----///

            // Which students in Cohort One like C# best?
            List<Student> CSharpStudents = CohortOne.StudentList.Where(student => student.FavoriteLanguage == "C#").ToList();

            var cstudnets = from student in CohortOne.StudentList where student.FavoriteLanguage == "C#" select student;


            // Let's look at a report of how many students in cohort one favor different languages in cohort one
            // JavaScript - 2
            // C# - 1

            var studentReport = from student in CohortOne.StudentList
                                group student by student.FavoriteLanguage into
                                // languageGroup is an IGrouping<string, Student>
                                languageGroup
                                select new Dictionary<string, int>(){
                {languageGroup.Key, languageGroup.Count()}
            };




            // Build a report for each cohort in the allCohorts List
            // Use the ReportItem class

            IEnumerable<ReportItem> cohortReport = from cohort in allCohorts
                                                   select new ReportItem()
                                                   {
                                                       CohortName = cohort.CohortName,
                                                       numberOfStudents = cohort.StudentList.Count(),
                                                       averageMonthsToHire = cohort.StudentList.Select(s => s.monthsToHire).Average(),
                                                       averageStartingSalary = cohort.StudentList.Select(s => s.startingSalary).Average()
                                                   };


            Console.WriteLine();




















        }
    }
}
