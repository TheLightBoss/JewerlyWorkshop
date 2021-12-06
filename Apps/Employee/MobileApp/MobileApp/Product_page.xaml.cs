using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Models;
using MobileApp.Views;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Product_page : ContentPage
    {
        readonly HttpClient client = new HttpClient();
        bool lol = false; //при подгрузке данных выскакивает окно, с bool уберём это
        public Product_page()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            Title = Orders_page.selected_order.name_prod;
            image.Source = Orders_page.selected_order.url_pic;
            label_raz.Text = "Размер" + Orders_page.selected_order.size.ToString();

            label1.Text = Orders_page.selected_order.list_jobs[0];
            label2.Text = Orders_page.selected_order.list_jobs[1];
            label3.Text = Orders_page.selected_order.list_jobs[2];

            if (Orders_page.selected_order.list_jobs[0] == Orders_page.selected_order.list_done_job[0]) chbox1.IsChecked = true;
            else chbox1.IsChecked = false;

            if (Orders_page.selected_order.list_jobs[1] == Orders_page.selected_order.list_done_job[1]) chbox2.IsChecked = true;
            else chbox2.IsChecked = false;

            if (Orders_page.selected_order.list_jobs[2] == Orders_page.selected_order.list_done_job[2]) chbox3.IsChecked = true;
            else chbox3.IsChecked = false;

            if (Orders_page.selected_order.list_jobs.Count == 4)
            {
                label4.Text = Orders_page.selected_order.list_jobs[3];
                if (Orders_page.selected_order.list_jobs[3] == Orders_page.selected_order.list_done_job[3]) chbox4.IsChecked = true;
                else chbox4.IsChecked = false;
            }
            else { chbox4.IsEnabled = false; chbox4.IsVisible = false; label4.IsVisible = false; }//скрываем лишний chechbox,
                                                                                                  //так как у некоторых изделий нет 4 пункта   
            lol = true;
        }
        void UpdateItem(int i, bool ch)
        {
            if (ch)
            {
                Orders_page.selected_order.list_done_job[i] = Orders_page.selected_order.list_jobs[i];
            }
            else
            {
                Orders_page.selected_order.list_done_job[i] = "";
            }
            Orders tmp = new Orders();
            foreach (Orders j in MainPage.orders)
                if (j.id_production == Orders_page.selected_order.id_production)
                    tmp = j; // ищем нужный заказ, сохраняем
            MainPage.orders.Remove(tmp); //удаляем старый
            MainPage.orders.Add(Orders_page.selected_order); //добавляем новый
            MainPage.UpdateAppCurrProp(); //сохраняем изменения в строках json 
        }
        private async void chbox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (lol)
            {
                UpdateItem(0, chbox1.IsChecked);
                await DisplayAlert("Выполнено", "", "OK");
            }
        }

        private async void chbox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (lol)
            {
                UpdateItem(1, chbox2.IsChecked);
                await DisplayAlert("Выполнено", "", "OK");
            }
        }

        private async void chbox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (lol)
            {
                UpdateItem(2, chbox3.IsChecked);
                await DisplayAlert("Выполнено", "", "OK");
            }
        }

        private async void chbox4_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (lol)
            {
                UpdateItem(3, chbox4.IsChecked);
                await DisplayAlert("Выполнено", "", "OK");
            }
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (chbox1.IsChecked && chbox2.IsChecked && chbox3.IsChecked)
            {
                Orders_View orders_View = new Orders_View();
                orders_View.id_production = Orders_page.selected_order.id_production;
                orders_View.list_done = Orders_page.selected_order.list_done_job;
                orders_View.status = true;
                orders_View.half_status = true;
                var content = new StringContent(JsonConvert.SerializeObject(orders_View), Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage = await client.PutAsync(MainPage.url + "proc/production", content);
                string result = await responseMessage.Content.ReadAsStringAsync();
                if (result == "0")
                {
                    Orders tmp = new Orders();
                    foreach (Orders j in MainPage.orders)
                        if (j.id_production == Orders_page.selected_order.id_production)
                            tmp = j; // ищем нужный заказ, сохраняем
                    MainPage.orders.Remove(tmp); // удаляем выполненный заказ из списка заказовы
                    MainPage.UpdateAppCurrProp(); //сохраняем изменения в строках json 

                    await DisplayAlert("Выполнено", "Заказ завершён!", "OK");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Ошибка", "", "OK");
                }
            }
            else
            {
                await DisplayAlert("Ошибка", "Не все задачи выполнены!", "OK");
            }
        } // заказ выполнен полностью

        private async void Button_ClickedUpdItem(object sender, EventArgs e)
        {
            Orders_View orders_View = new Orders_View();
            orders_View.id_production = Orders_page.selected_order.id_production;
            orders_View.list_done = Orders_page.selected_order.list_done_job;
            orders_View.status = false;
            orders_View.half_status = true;
            var content = new StringContent(JsonConvert.SerializeObject(orders_View), Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PutAsync(MainPage.url + "proc/production", content);
            string result = await responseMessage.Content.ReadAsStringAsync();
            if (result == "0")
            {
                Orders tmp = new Orders();
                foreach (Orders j in MainPage.orders)
                    if (j.id_production == Orders_page.selected_order.id_production)
                        tmp = j; // ищем нужный заказ, сохраняем
                MainPage.orders.Remove(tmp); // обновляем выполненный заказ из списка заказовы
                MainPage.orders.Add(Orders_page.selected_order);
                MainPage.UpdateAppCurrProp(); //сохраняем изменения в строках json 

                await DisplayAlert("Выполнено", "Изменения отправлены!", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Ошибка", "", "OK");
            }
        } // отправляем изменения (то что уже выполнил)
    }
}