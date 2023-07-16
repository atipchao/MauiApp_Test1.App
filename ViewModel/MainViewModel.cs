
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiApp_Test1.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text_add_item;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text_add_item))
                return;

            Items.Add(Text_add_item);
            // Add our Item
            Text_add_item = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
            //Items.Remove(Text);
        }

        [RelayCommand]
        async Task Tap(string s)
        {
            // Add navigation code to navigate to Detail-Page
            // await Shell.Current.GoToAsync("DetailPage");
            // Passing Information is also by either: 
            // 1: Query Property - via URL
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Passing_Text_From_Main_Page={s}");
            // You can also pass info as complex Object type as well
            // 2: 
            //await Shell.Current.GoToAsync(nameof(DetailPage));
        }

    }
}
