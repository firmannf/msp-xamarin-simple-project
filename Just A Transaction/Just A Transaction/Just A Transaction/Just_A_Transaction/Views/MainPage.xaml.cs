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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var transactions = App.DBUtils.GetAllTransactions();
            listViewTransaction.ItemsSource = transactions;
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var selectedTransaction = (Transaction) e.SelectedItem;
            Navigation.PushAsync(new ShowTransactionPage(selectedTransaction));
        }

        public void OnNewClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AddTransactionPage());
        }
    }
}
