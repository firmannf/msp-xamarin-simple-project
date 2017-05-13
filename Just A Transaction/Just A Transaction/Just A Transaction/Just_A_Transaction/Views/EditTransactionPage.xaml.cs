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
    public partial class EditTransactionPage : ContentPage
    {
        Transaction selectedTransaction;
        public EditTransactionPage(Transaction selectedTransaction)
        {
            InitializeComponent();
            this.selectedTransaction = selectedTransaction;
            BindingContext = this.selectedTransaction;
        }

        public void OnEditClicked(object sender, EventArgs args)
        {
            try
            {
                selectedTransaction.TransactionName = entryTransactionName.Text;
                selectedTransaction.TransactionAmount = entryTransactionAmount.Text;
                if (datePickerTransactionDate.Date == null)
                    selectedTransaction.TransactionDate = DateTime.Now;
                else
                    selectedTransaction.TransactionDate = datePickerTransactionDate.Date;
                selectedTransaction.TransactionInfo = entryTransactionInfo.Text;
                App.DBUtils.EditTransaction(selectedTransaction);
                Navigation.PushAsync(new MainPage());
            }
            catch (Exception exception)
            {
                DisplayAlert("Error", exception.Message, "Close");
            }
        }
    }
}
