using System;
using System.Collections.Generic;

namespace example_code {

    class Cohort {

        public Cohort(string name){
            CohortName = name;
        }
        public string CohortName {get; set; }

        public List<Student> StudentList {get; set;} = new List<Student>();
    }

}