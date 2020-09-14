using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bobuk
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class foor : ContentPage
    {
        public foor()
        {
            InitializeComponent();
        }
        bool vkl;
        private object rnd;

        private async void on_Clicked(object sender, EventArgs e)
        {
            vkl = true;
            while (vkl != false)
            {
                pun.BackgroundColor = Color.Red;
                kol.BackgroundColor = Color.Gray;
                roh.BackgroundColor = Color.Gray;
                await Task.Run(() => Thread.Sleep(3000));
                for (int i = 0; i < 3; i++)
                {
                    pun.BackgroundColor = Color.Gray;
                    pun.BackgroundColor = Color.Gray;
                    roh.BackgroundColor = Color.Gray;
                    await Task.Run(() => Thread.Sleep(500));
                    kol.BackgroundColor = Color.Yellow;
                }
                roh.BackgroundColor = Color.Green;
                pun.BackgroundColor = Color.Gray;
                kol.BackgroundColor = Color.Gray;
                await Task.Run(() => Thread.Sleep(3000));
            }

        }

        private void off_Clicked(object sender, EventArgs e)
        {
            {
                roh.BackgroundColor = Color.Green;
                pun.BackgroundColor = Color.Gray;
                kol.BackgroundColor = Color.Gray;
                vkl = false;
            }
        }

        private void Oma_Clicked(object sender, EventArgs e)
        {

        }

        private void Random_Clicked(object sender, EventArgs e)
        {
            int r = rnd.Next(0, 255)

        }
    }
}