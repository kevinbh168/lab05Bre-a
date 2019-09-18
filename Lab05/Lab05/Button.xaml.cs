using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Button : ContentPage
    {
        public Button()
        {
            InitializeComponent();
        }

        public string Text { get; internal set; }
        public LayoutOptions VerticalOptions { get; internal set; }
        public LayoutOptions HorizontalOptions { get; internal set; }
        public Func<object, object, Task<bool>> Clicked { get; internal set; }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await label.RelRotateTo(360, 1000);
        }
    }
}