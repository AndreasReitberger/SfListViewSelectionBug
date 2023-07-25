using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp_SfListViewBug.ViewModels
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public partial class MainPageViewModel : ObservableObject
    {
        #region Propertiess

        [ObservableProperty]
        ObservableCollection<object> selection = new();
        partial void OnSelectionChanged(ObservableCollection<object> value)
        {
            Debug.WriteLine($"Selection changed: {value?.Count} items selected");
        }

        [ObservableProperty]
        ObservableCollection<Item> items = new();


        #endregion

        #region Ctor
        public MainPageViewModel()
        {
            Items = new()
            {
                new Item() { Id = 1, Name = "First item"},
                new Item() { Id = 2, Name = "Second item"},
                new Item() { Id = 3, Name = "Third item"}
            };
        }
        #endregion
    }
}
