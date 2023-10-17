using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GridView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ListPageModel();
        }

        // Creo el Modelo que tendra mi lista
        public class ListModel
        {
            public string id {  get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        // Creo la clase que crea la lista con los items  
        public class ListPageModel 
        {            
            public ObservableCollection<ListModel> SomeItems {  get; set; }
            public ListPageModel()
            {
                SomeItems = new ObservableCollection<ListModel>();
                SomeItems.Add(new ListModel
                {
                    id=""
                    Name = "Hammer", 
                    Description="I am a hammer"
                });
                SomeItems.Add(new ListModel
                {
                    Name = "Fork",
                    Description = "Pick me up, wachin"
                });
            }
        }
    }
}
