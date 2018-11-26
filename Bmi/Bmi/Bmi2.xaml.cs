using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bmi
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Bmi2 : ContentPage
	{
        private float bmi;
		public Bmi2 ()
		{
			InitializeComponent ();
            buttonBack.Clicked += buttonBackClicked;
		}

        public Bmi2(float bmi)
        {
            InitializeComponent();
            this.bmi = bmi;
            labelBMI.Text = "BMI=" + bmi;
            buttonBack.Clicked += buttonBackClicked;
        }

        private void buttonBackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}