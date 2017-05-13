using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ideal_Weight
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            buttonCalculateManIdealWeight.Clicked += buttonCalculateManIdealWeight_Clicked;
            buttonCalculateWomanIdealWeight.Clicked += buttonCalculateWomanIdealWeight_Clicked;
        }
        
        private void buttonCalculateManIdealWeight_Clicked(object sender, EventArgs e)
        {
            try
            {
                double height = entryHeight.Text.Equals("") || entryHeight.Text.Equals(null) ? 0 : Convert.ToDouble(entryHeight.Text);
                double weight = entryWeight.Text.Equals("") || entryWeight.Text.Equals(null) ? 0 : Convert.ToDouble(entryWeight.Text);
                double brocha = Math.Ceiling((height - 100) - (0.10d * (height - 100)));
                double BMI = Math.Ceiling(weight / ((height * 0.01d) * (height * 0.01d)));

                labelBMI.Text = BMI.ToString();
                labelBrocha.Text = brocha.ToString();

                if (BMI < 17)
                {
                    labelConclusion.Text = "Under Weight ( < 17 )";
                }
                else if (BMI <= 23)
                {
                    labelConclusion.Text = "Normal Weight ( 17 - 23 )";
                }
                else if (BMI <= 27)
                {
                    labelConclusion.Text = "Over Weight ( 23 - 27 )";
                }
                else
                {
                    labelConclusion.Text = "Obesity ( > 27 )";
                }
            }
            catch (Exception exception)
            {
                DisplayAlert("Error", exception.Message, "Close");
            }
        }

        private void buttonCalculateWomanIdealWeight_Clicked(object sender, EventArgs e)
        {
            try
            {
                double height = entryHeight.Text.Equals("") || entryHeight.Text.Equals(null) ? 0 : Convert.ToDouble(entryHeight.Text);
                double weight = entryWeight.Text.Equals("") || entryWeight.Text.Equals(null) ? 0 : Convert.ToDouble(entryWeight.Text);
                double brocha = Math.Ceiling((height - 100) - (0.15d * (height - 100)));
                double BMI = Math.Ceiling(weight / ((height * 0.01d) * (height * 0.01d)));

                labelBMI.Text = BMI.ToString();
                labelBrocha.Text = brocha.ToString();

                if (BMI < 18)
                {
                    labelConclusion.Text = "Under Weight ( < 18 )";
                }
                else if (BMI <= 25)
                {
                    labelConclusion.Text = "Normal Weight ( 18 - 25 )";
                }
                else if (BMI <= 27)
                {
                    labelConclusion.Text = "Over Weight ( 25 - 27 )";
                }
                else
                {
                    labelConclusion.Text = "Obesity ( > 27 )";
                }
            }
            catch (Exception exception)
            {
                DisplayAlert("Error", exception.Message, "Close");
            }
        }
    }
}