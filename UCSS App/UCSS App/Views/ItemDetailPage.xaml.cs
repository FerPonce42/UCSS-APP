using System.ComponentModel;
using UCSS_App.ViewModels;
using Xamarin.Forms;

namespace UCSS_App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}