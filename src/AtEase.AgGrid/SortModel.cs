using System;
using System.Linq;
using AtEase.ValidationExtensions;

namespace AtEase.AgGrid
{
    [Serializable]
    public class SortModel
    {
        private string _colId;
        private string _sort;

        private string[] _sortRange = {"asc", "desc"};

        public SortModel()
        {
        }

        public SortModel(string colId, string sort)
        {
            ColId = colId;
            Sort = sort;
        }

        public string Sort
        {
            get => _sort;
            set
            {
                var sort = value?.ToLower();
                Assert.IsTrue(_sortRange.Contains(sort), () => throw new ArgumentOutOfRangeException(nameof(Sort)));
                _sort = sort;
            }
        }

        public string ColId
        {
            get => _colId;
            set => _colId = value;
        }
    }
}