using Just_A_Transaction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Just_A_Transaction.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowTransactionPage : ContentPage
    {
        Transaction selectedTransaction;
        public ShowTransactionPage(Transaction selectedTransaction)
        {
            InitializeComponent();
            this.selectedTransaction = selectedTransaction;
            BindingContext = this.selectedTransaction;
        }

        public void OnEditClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new EditTransactionPage(selectedTransaction));
        }

        public async void OnDeleteClicked(object sender, EventArgs args)
        {
            bool accepted = await DisplayAlert("Konfirmasi", "Apakah anda yakin untuk mendelete data ?", "Yes", "No");
            if (accepted)
            {
                App.DBUtils.DeleteTransaction(selectedTransaction);
            }
            await Navigation.PushAsync(new MainPage());
        }
    }
}
