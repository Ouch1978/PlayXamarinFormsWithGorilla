using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlayXamarinFormsWithGorilla
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemSelected( object sender , SelectedItemChangedEventArgs e )
        {
            if( e.SelectedItem != null )
            {
                var detailPage = new DetailPage( e.SelectedItem as Book );

                Navigation.PushAsync( detailPage );

            }
        }

    }
}
