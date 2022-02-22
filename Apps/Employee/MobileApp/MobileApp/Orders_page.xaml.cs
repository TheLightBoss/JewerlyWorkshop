using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Models;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Orders_page : ContentPage
    {
        public static Orders selected_order = null;
        public Orders_page()
        {
            InitializeComponent();
            if (MainPage.orders.Count > 0)
                foreach (Orders i in MainPage.orders) picker_zak.Items.Add(i.id_production.ToString());
        }

        protected async override void OnAppearing()
        {
            Title = MainPage.empl.fio;
            if (MainPage.orders.Count == 0) // если заказов больше нет, то очищаем приложение от сохранённых строк json и отправляем пользователя в MainPage для авторизации
            { await DisplayAlert("Заказов нет", "На данный аккаунт нет заказов!", "OK"); MainPage.DeleteAppCurrProp(); await Navigation.PopAsync(); }

        }
        private async void ButtonHello_Click(object sender, EventArgs e)
        {
            if (selected_order != null) await Navigation.PushAsync(new Product_page());
            else await DisplayAlert("Ошибка", "Не выбран заказ!", "OK");

        }
        private void ButtonLoad_Image(object sender, EventArgs e)
        {
            foreach (Orders i in MainPage.orders)
                if (i.id_production.ToString() == picker_zak.SelectedItem.ToString())
                    selected_order = i;
            image.Source = selected_order.url_pic;
            label.Text = selected_order.name_prod + "\nДата начала: " + selected_order.date_start;

        }
        private async void ButtonExit_Click(object sender, EventArgs e)
        {
            MainPage.DeleteAppCurrProp();
            await Navigation.PopAsync();
        }
        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Employee_page());
        }
    }
}