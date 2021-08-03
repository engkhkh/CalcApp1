using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalcApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Page1();
            MainPage = new ContentPage
            {
                BackgroundImage = "background.png",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    Spacing = 50,
                    Children = {

                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome, Please Sign in!",
                            FontSize=50,
                            TextColor=Color.Gray,
                        },


                         new Entry
                        {
                             Placeholder="Username",
                            VerticalOptions = LayoutOptions.Center,
                            Keyboard = Keyboard.Text,
                            HorizontalOptions = LayoutOptions.Center,
                             WidthRequest = 350,
                             HeightRequest = 50,
                             FontSize=20,
                             TextColor=Color.Gray,
                             PlaceholderColor=Color.Gray,
                        },

                          new Entry
                        {
                             Placeholder="Password",
                            VerticalOptions = LayoutOptions.Center,

                            Keyboard = Keyboard.Text,
                            HorizontalOptions = LayoutOptions.Center,
                             WidthRequest = 350,
                             HeightRequest = 50,
                             FontSize=25,
                             TextColor=Color.Gray,
                             IsPassword=true,
                              PlaceholderColor =Color.Gray,
                        },
                        new Button
                        {
                            Text="Login",
                            FontSize=Device.GetNamedSize(NamedSize.Large,typeof(Button)),
                            HorizontalOptions=LayoutOptions.Center,
                            VerticalOptions=LayoutOptions.Fill,
                            WidthRequest=350,
                            TextColor=Color.Silver,
                            BackgroundColor=Color.Red,
                            BorderColor=Color.Red,
                        },
                       new Label //for this label I want to create click event to open new page
                        {
                            Text="Forgot Password?",
                            FontSize=20,
                            TextColor=Color.Blue,
                            HorizontalOptions=LayoutOptions.Center,

                        },
                    }
                }
            };

            var forgetPasswordLabel = new Label   // Your Forget Password Label
            {
                Text = "Forgot Password?",
                FontSize = 20,
                TextColor = Color.Blue,
                HorizontalOptions = LayoutOptions.Center,
            };


            // Your label tap event
            var forgetPassword_tap = new TapGestureRecognizer();
            forgetPassword_tap.Tapped += (s, e) =>
            {
                //
                //  Do your work here.
                //
            };
            forgetPasswordLabel.GestureRecognizers.Add(forgetPassword_tap);
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
