using System;
using System.Collections.Generic;

namespace Px.Search.Abstractions
{
    public interface ISearcher
    {
        DateTime CreationTime { get; }
        List<SearchResultItem> Search(string text, string filter, int resultListLength, out SearchStatusType status);
        void SetDefaultOperator(DefaultOperator defaultOperator);
    }
}
