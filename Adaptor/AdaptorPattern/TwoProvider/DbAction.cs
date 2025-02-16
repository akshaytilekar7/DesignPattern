namespace AdapterPattern.TwoProvider
{
    class DbAction
    {
        public string GetDataFromDb()
        {
            return new DatabaseService().GetFromDb();
        }
    }
}
