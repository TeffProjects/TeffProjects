using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Student_management_system
{

    class DataAccess
    {
        public void Insert(string StudentID, string StudentName, string Course, string Contact, string ResidentialAddress, string EmailAddress)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnString("SMSDb")))
            {
                List<Student> insert = new List<Student>();
                insert.Add(new Student { StudentID = StudentID, StudentName = StudentName, Course = Course, Contact = Contact, ResidentialAddress = ResidentialAddress, EmailAddress= EmailAddress });
                connection.Execute("dbo.Student_Insert @StudentID,@StudentName,@Course,@Contact,@ResidentialAddress,@EmailAddress", insert);
            }

        }
        public void delete(string StudentID)
        {

            using (IDbConnection connection = new SqlConnection(Helper.CnnString("SMSDb")))
            {
                connection.Execute("dbo.StdDelete @StudentID", new { StudentID = StudentID });

            }

        }
       
    }
}

