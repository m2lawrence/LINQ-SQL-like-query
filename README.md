# LINQ-Standard-Query-Operators

Select, From, Where, OrderBy, Join, GroupBy.

There are 2 ways to write LINQ queries using the Standard Query Operators:
1. Lambda Expressions
2. SQL like query expressions

Note: Behind the scene, LINQ queries written using SQL like query expressions are translated into their Lambda expressions before they are compiled. 

The Standard Query Operators are implemented as extension methods on IEnumerable T Interface. 
