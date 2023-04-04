namespace TCsorgu.Models
{
    public static class Repository
    {

        private static List<SearchModel> _searchModels=new List<SearchModel>();
        public static List<SearchModel> SearchModels { get {  return _searchModels; } }
        public static void addList(SearchModel searchModel) 
        {
        _searchModels.Add(searchModel);
        }


    }
}
