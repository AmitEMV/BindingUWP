using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BindingUWP
{
    public class MainPageViewModel : ObservableObject
    {
        public IAsyncRelayCommand LoadInitialDataCommand { get; }

        public MainPageViewModel()
        {
            LoadInitialDataCommand = new AsyncRelayCommand(LoadInitialDataAsync);
        }

        private List<Data> namesList;
        public List<Data> NamesList
        {
            get => namesList;
            set => SetProperty(ref namesList, value);
        }

        private async Task LoadInitialDataAsync()
        {
            await Task.Delay(1000);

            Data data1 = new Data
            {
                Group = "A",
                Name = "Name1"
            };

            Data data2 = new Data
            {
                Group = "A",
                Name = "Name2"
            };

            Data data3 = new Data
            {
                Group = "B",
                Name = "Name3"
            };

            NamesList = new List<Data>(new Data[] { data1, data2, data3 });

        }
    }

    public class Data
    {
        public string Name { get; set; }
        public string Group { get; set; }
    }
}

