// SQL like Expressions.
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSqlLikeWebApp1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //write a LINQ query using SQL like Expressions.
            //use IEnumerable and store it in "QueryResult"
            //bind to GridView.

            // range operator is: student.
            IEnumerable<Student> QueryResult = from student in Student.GetAllStudents()
                                               where student.Gender == "Male"
                                               select student;
            
            //display the data in a GridView.
            GridView1.DataSource = QueryResult;

            //invoke the data bind method to the GridView.
            GridView1.DataBind();
        }
    }
}