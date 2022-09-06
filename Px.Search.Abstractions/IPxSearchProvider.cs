namespace Px.Search.Abstractions
{
    public interface IPxSearchProvider
    {
        ISearcher GetSearcher();
        IIndexer GetIndexer();
    }

}
