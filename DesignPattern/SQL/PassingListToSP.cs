#region Table Value Parameter

/*

Table value parameter :

    -  can pass list<T> to SP
    -   must be passed as READONLY, cant do DML on tableValue parameter


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

    -    tables are useful for storing the immediate result sets that are accessed multiple times.
    -    temporary tables are only accessible within the session that created them. (not in new tab)
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