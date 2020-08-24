namespace AdapterPattern.ThreeAdapterIntro.Action
{
    class DbAction
    {
        public string GetDataFromDb()
        {
            return new DatabaseService().GetFromDb();
        }
    }
}
