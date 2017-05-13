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
    public partial class AddTransactionPage : ContentPage
    {
        public AddTransactionPage()
        {
            InitializeComponent();
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            try
            {
                var transaction = new Transaction();
                transaction.TransactionName = entryTransactionName.Text;
                transaction.TransactionAmount = entryTransactionAmount.Text;
                if (datePickerTransactionDate.Date == null)
                    transaction.TransactionDate = DateTime.Now;
                else
                    transaction.TransactionDate = datePickerTransactionDate.Date;
                transaction.TransactionInfo = entryTransactionInfo.Text;
                App.DBUtils.SaveTransaction(transaction);
                Navigation.PushAsync(new MainPage());
            }
            catch (Exception exception)
            {
                DisplayAlert("Error", exception.Message, "Close");
            }
        }
    }
}
