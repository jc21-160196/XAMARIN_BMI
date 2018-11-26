using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bmi
{
    public partial class MainPage : ContentPage
    {
        float bmi;

        public MainPage()
        {
            InitializeComponent();
            ButtonBMI.Clicked += ButtonBmiClickEvent;
            ButtonBMI2.Clicked += ButtonBmi2ClickEvent;
        }

        private void ButtonBmi2ClickEvent(object sender, EventArgs e)
        {
            float height = float.Parse(EntryHeight.Text);
            if (height <= 3.0)
            {
                height = height * height;
            }
            else
            {
                height = (height / 100) * (height / 100);
            }
            float weight = int.Parse(EntryWeight.Text);
            bmi = weight / height;
            Navigation.PushModalAsync(new NavigationPage(new Bmi2(bmi)));
        }

        private void ButtonBmiClickEvent(object sender, EventArgs e)
        {
            float height = float.Parse(EntryHeight.Text);
            if (height <= 3.0)
            {
                height = height * height;
            }
            else
            {
                height = (height / 100) * (height / 100);
            }
            float weight = int.Parse(EntryWeight.Text);
            bmi = weight / height;
            LabelResult.Text = "BMI="+ bmi;
        }
    }
}
