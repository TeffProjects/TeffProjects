using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system
{
    class Student
    {

        // student properties
        
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public  string Course { get; set; }
        public string Contact { get; set; }
        public string ResidentialAddress { get; set; }
        public string EmailAddress  { get; set; }


        public string FullInfo
        {
            get
            {
                return "{StudentID} {StudentName} {Course} {Contact} {ResidentialAddress}"; 
            }
            
        }

    }
}
