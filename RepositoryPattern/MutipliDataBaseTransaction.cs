
/*
public class Demo
{
    public void Test()
    {
        try
        {
            using (TransactionScope scope = new TransactionScope())
            {
                // DB 1
                using (connection = new SqlConnection(""))
                {
                    connection.Open();
                    // Your first operation
                    // Your second operation 
                }

                // DB 2
                using (connection = new SqlConnection(connectionStringB))
                {
                    connection.Open();
                    // Your first operation
                    // Your second operation
                }
                // if success so far, commit the transaction
                scope.Complete();
            }
        }
        catch (Exception ex)
        {
            // transaction will be rolled back if exception occurs
        }
    }
}

*/
