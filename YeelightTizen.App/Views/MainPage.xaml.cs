using System;

using Xamarin.Forms;
using YeelightTizen.App.Services;
using YeelightTizen.Interfaces;

namespace YeelightTizen.App.Views
{
    public partial class MainPage : ContentPage
    {
        protected ILampadaServico Servico;
        public MainPage()
        {
            InitializeComponent();
            Teste();
   
        }

        public async void Teste()
        {
            Servico = new LampadaServico();
            try
            {
                var devices = await Servico.ObterDispositivos();
            }
            catch(Exception e)
            {

            }
            
        }
    }
}
