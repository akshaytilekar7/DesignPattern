#region Table Value Parameter

/*

Table value parameter :

    -  can pass list<T> to SP
    -  must be passed as READONLY, cant do DML on tableValue parameter

Examples :

        CREATE TYPE udEmpTable as Table 
        (
        Id int,
        Name varchar(250),
        )

    - created in programibility  in system data type


    Create SP InsertEmployee
    @emp udEmpTable READONLY 
    AS
    BEGIN
        INSERT INT tblEmp 
        SELECT * from emp
    END


- can pass DataTable from C#

*/

#endregion Table Value Parameter

#region  Temp Table

/*
 LOCAL TEMP TABLE

    -    tables are useful for storing the immediate result sets
        that are accessed multiple times.
    -    temporary tables are only accessible within the session that created them. 
         (not in new tab)
    -    temp tables are store tempDB
    -    sql server create table with tableName____randomNUmber

        CREATE TABLE #tblProducts (
            product_name VARCHAR(MAX),
            list_price DEC(10,2)
        );

GLOBAL TEMPORARY 
    -   table starts with a double hash symbol (##).

    CREATE TABLE #tempTable(id int, name varchar(250));
    SELECT * FROM #tempTable


 
 */

#endregion Temp Table

#region Delete truncate drop
/*

   DROP         DDL Command.
                Tables' rows, indexes, and privileges will also be removed.
                Cannot be rolled back.



   TRUNCATE     DDL Command.
                Deletes the data of the tables
                cant use WHERE clause 


   delete       DML 
                use WHERE clause 
                can be roll back



*/

#endregion

#region Transaction

/*
    ACID
    BEGIN TRANSACTION, COMMIT TRANSACTION, COMMIT WORK, ROLLBACK TRANSACTION, ROLLBACK WORK, and SET IMPLICIT_TRANSACTIONS

    Autocommit Transactions
        default transaction management mode of SQL Server.
        committed or rolled back when it is completed.
    
        implicit transaction mode 
            using SET IMPLICIT TRANSACTIONS ON|OFF.
             COMMIT or ROLLBACK has to be executed by us


        SELECT TOP 1 salary FROM 
            (SELECT DISTINCT TOP 6 salary 
            FROM employee 
            ORDER BY salary DESC) a
        ORDER BY salary


        The function must return a value but in Stored Procedure it is optional. Even a procedure can return zero or n values.
        Functions can have only input parameters for it whereas Procedures can have input or output parameters.
        Functions can be called from Procedure whereas Procedures cannot be called from a Function.
        The procedure allows all DML statement whereas Function allows only SELECT 
        exception can be handled by try-catch block in a Procedure whereas try-catch block cannot be used in a Function
        Can use Transactions in Procedure whereas we can't use Transactions in Function.


        NVL function is used to convert Null value to actual value.
                NVL: NVL(val1, val2), it converts source value to the target value and if source value contains null, 
                                        target remains the same data type as of val1.
                NVL2: NVL2(val1, val2, val3), this function checks for null in the first value, if it is not null 
                                        then second value val2 is returned and if it is null then the third value val3 is returned


        Nullif function is used to compare to expressions and if they are equal, 
                then it returns Null or else it returns the first expression

        

*/

#endregion


// HAVING clause was added to SQL because the
// WHERE keyword could not be used with aggregate functions.

//SELECT ID, NAME, AGE, ADDRESS, SALARY
//FROM CUSTOMERS
//GROUP BY age
//HAVING COUNT(age) >= 2;


//one to one →an author can write only one book, and a book only have one author.
//one to many →an author can write multiple books, but book can only have one author.
//many to many →an author can write multiple books, and also a book can be written by multiple authors.