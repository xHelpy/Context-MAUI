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
            var StackLayout = new StackLayout { 
                BindingContext = this,
            };
            
            var Slider = new Slider
            {
                Minimum = 0,
                Maximum = 100,
            };
            var FontSlider = new Slider
            {
                Minimum = 10,
                Maximum = 40,
            };
            var ResetSlider = new Button
            {
                Text = "Zresetuj Slider"
            };
            var ColorSlider = new Slider
            {
                Minimum = 0,
                Maximum = 1,
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

            var Stepper = new Stepper
            {
                Minimum = 10,
                Maximum = 40
            };
            var ProgressBar = new ProgressBar
            {
                ProgressColor = Color.FromRgb(255, 185, 125)
            };
            var BoxView = new BoxView
            {
                HeightRequest = 50,
                WidthRequest = 100,
            };
            var HeightSlider = new Slider
            {
                Minimum = 50,
                Maximum = 200,
            };
            var RedSlider = new Slider
            {
                Minimum = 0,
                Maximum = 1,
            };

            StackLayout.Children.Add(Slider);
            StackLayout.Children.Add(FontSlider);
            StackLayout.Children.Add(ResetSlider);
            StackLayout.Children.Add(ColorSlider);
            StackLayout.Children.Add(Label);
            StackLayout.Children.Add(Stepper);
            StackLayout.Children.Add(ProgressBar);
            StackLayout.Children.Add(HeightSlider);
            StackLayout.Children.Add(RedSlider);
            StackLayout.Children.Add(BoxView);
            

            Content = StackLayout;

            ColorSlider.ValueChanged += (s, e) =>
            {
                if (ColorSlider.Value == 0)
                {
                    Content.BackgroundColor = Color.FromRgb(255,255,255);
                }
                if (ColorSlider.Value == 1)
                {
                    Content.BackgroundColor = Color.FromRgb(0, 0, 0);
                }
            };
            FontSlider.ValueChanged += (s, e) =>
            {
                Label.FontSize = FontSlider.Value;

            };
            ResetSlider.Clicked += (s, e) =>
            {
              Slider.Value = 50;
            };

            Stepper.ValueChanged += (s, e) =>
            {
                Label.FontSize = Stepper.Value;
            };

            Slider.ValueChanged += (s, e) =>
            {
                ProgressBar.Progress = Slider.Value;
            };

            HeightSlider.ValueChanged += (s, e) =>
            {
                BoxView.HeightRequest = HeightSlider.Value;
            };

            RedSlider.ValueChanged += (s, e) =>
            {
                BoxView.BackgroundColor = Color.FromRgb(RedSlider.Value,0,0);
            };

        }

        
    }

}
