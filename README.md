# LINQ: SQL like query.

Select, From, Where, OrderBy, Join, GroupBy.

Note: Behind the scene, LINQ queries written using SQL like query expressions are translated into their Lambda expressions before they are compiled. 

The Standard Query Operators are implemented as extension methods on IEnumerable T Interface. 


Note the range operator is: student.

1. IEnumerable Student QueryResult = from student in Student.GetAllStudents()
2. where student.Gender == "Male"
3. select student;
