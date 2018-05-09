﻿using ProyectoDAM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoDAM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}

        private void CloseButton_Clicked(object sender, EventArgs e)
        {
            //Debería ir a nativo pero como solo vamos a desarollar para Android lo dejo aquí
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }

        private void ExplorarButton_Clicked(object sender, EventArgs e)
        {

            //Debería ir a nativo pero como solo vamos a desarollar para Android lo dejo aquí
            if (App.Current.Properties.ContainsKey("nombre"))
            {
                App.Current.Properties.Remove("nombre");
                App.Current.SavePropertiesAsync();
            }

        }

        private void ProximaButton_Clicked(object sender, EventArgs e)
        {
            OnLoadPageAsync(1);
        }
        private void ParadasButton_Clicked(object sender, EventArgs e)
        {
            //StationList StationList = new View.StationList();
            OnLoadPageAsync(0);

        }


        private async void OnLoadPageAsync(int page)
        {
            switch(page)
            {
                case 0:
                    await Navigation.PushModalAsync(new StationList());                    
                    break;
                case 1:
                    await Navigation.PushModalAsync(new MapPage());
                    break;
                case 2:
                    break;
                case 3:
                    break;
                    
            }
           
        }


    }
}