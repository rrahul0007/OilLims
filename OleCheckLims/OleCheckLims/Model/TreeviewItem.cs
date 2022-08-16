using System.Collections.ObjectModel;
using System.Collections;

namespace OelCheckLims
{
   public class TreeviewItem : NotifyProperty, IEnumerable
    {
        private bool isSelected;
        public TreeviewItem(string name)
        {
            Name = name;
            Items = new ObservableCollection<TreeviewItem>();
        }

        private string name { get; set; }
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public void Add(TreeviewItem item)
        {
            Items.Add(item);
        }
        public ObservableCollection<TreeviewItem> Items { get; private set; }
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                if (isSelected != value)
                {
                    isSelected = value;
                    OnPropertyChanged();
                }

            }
        }
        public IEnumerator GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
