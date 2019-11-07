```c#

   IEnumerable<int> idealSizes = from count in cohortStudentCount
                                          where count < 15 && count > 20
                                          orderby count ascending
                                          select count;

```

```
 IEnumerable<Student> cSharpStudents2 = from student in one.Students where student.FavoriteLanguage == "C#" select student;
 ```

 ```
     var studentReport = from student in one.Students
                                group student by student.FavoriteLanguage into
                                // languageGroup is an IGrouping<string, Student>
                                languageGroup
                                select new Dictionary<string, int>(){
                {languageGroup.Key, languageGroup.Count()}
            };
```

```
  IEnumerable<ReportItem> cohortReport = from cohort in allCohorts
                                                   select new ReportItem()
                                                   {
                                                       CohortName = cohort.Name,
                                                       numberOfStudents = cohort.Students.Count(),
                                                       averageMonthsToHire = cohort.Students.Select(s => s.monthsToHire).Average(),
                                                       averageStartingSalary = cohort.Students.Select(s => s.startingSalary).Average()
                                                   };
```