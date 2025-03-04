using System.Collections;
using System.ComponentModel;

namespace zadaniamaui04032025
{
    public partial class MainPage : ContentPage
    {
     
        List<string> textData = new List<string>();

        public MainPage()
        {
            InitializeComponent();
            var StackLayout = new StackLayout();
            
            var Slider = new Slider
            {
                Minimum = 0,
                Maximum = 100,
            };
            var FontSlider = new Slider
            {
                Minimum = 24,
                Maximum = 48,
            };
            var ResetSlider = new Button
            {
                Text = "Zresetuj Slider"
            };
            ResetSlider.Clicked += (s, e) =>
            {
                Slider.Value = 50;
            };
            var Label = new Label
            {
                Text = "Zmiana rozmiaru",
                FontSize = 24
            };

            StackLayout.Children.Add(Slider);
            StackLayout.Children.Add(ResetSlider);
            Content = StackLayout;





        }

        
    }

}
