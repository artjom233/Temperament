using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Temperament
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {

            ImageButton mert;
            ImageButton torm;
            ImageButton inq;
            ImageButton sold;


            mert = new ImageButton
            {
                Source = "mert.jpg"
            };
            mert.Clicked += Vvv_Clicked;
            var fleg = new ContentPage
            {

                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Флегматик",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Red
                    },
                    }
                }
            };



            torm = new ImageButton
            {
                Source = "torm.jpg"


            };
            torm.Clicked += Ppp_Clicked;
            var mela = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Меланхолик",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Blue
                    },

                    }
                }
            };
            inq = new ImageButton
            {
                Source = "inq.jpg"


            };
            inq.Clicked += Pulll_Clicked;

            var hol = new ContentPage
            {

                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Холерик",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Black
                    },

                }
                }
            };

            sold = new ImageButton
            {
                Source = "sold.jpg"


            };
            sold.Clicked += Lilit_Clicked;


            var sang = new ContentPage
            {

                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Сангвиник",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Orange
                    },

                }
                }
            };

          
            

            
                    

                
              

            Children.Add(fleg);
            Children.Add(mela);
            Children.Add(hol);            
            Children.Add(sang);

        }

        private async void Lilit_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/", BrowserLaunchMode.SystemPreferred);
        }

       

        private async void Vvv_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/", BrowserLaunchMode.SystemPreferred);
        }

        private async void Ppp_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/", BrowserLaunchMode.SystemPreferred);
        }

        private async void Pulll_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/", BrowserLaunchMode.SystemPreferred);
        }
    }
};
