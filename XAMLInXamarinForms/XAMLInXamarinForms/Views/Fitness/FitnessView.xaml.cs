using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XAMLInXamarinForms.Views.Fitness
{
    public partial class FitnessView : CarouselPage
    {
        public FitnessView()
        {
            InitializeComponent();

        }


        private async void FitnessButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FitnessView());
        }

    }
}
