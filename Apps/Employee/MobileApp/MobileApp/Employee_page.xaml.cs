using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Models;
using MobileApp.Views;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Employee_page : ContentPage
    {
        public Employee_page()
        {
            InitializeComponent();
            Title = "Ваши данные";
            EntryFio.Text = MainPage.empl.fio;
            EntryPassport.Text = MainPage.empl.passport;
            EntryPassword.Text = MainPage.empl.password;
            EntryLogin.Text = MainPage.empl.login;
            EntryAddress.Text = MainPage.empl.address;
        }

        //TODO: добавить изменения в строки ключ-значение
        private async void Button_ClickUpdate(object sender, EventArgs e)
        {
            if (EntryLogin.Text == null || EntryLogin.Text == "") await DisplayAlert("Ошибка", "Введите логин!", "OK");
            else if (EntryPassword.Text == null || EntryPassword.Text == "") await DisplayAlert("Ошибка", "Введите пароль!", "OK");
            else if (EntryPassport.Text == null || EntryPassport.Text == "") await DisplayAlert("Ошибка", "Введите номер и серию паспорта!", "OK");
            else if (EntryAddress.Text == null || EntryAddress.Text == "") await DisplayAlert("Ошибка", "Введите адрес!", "OK");
            else if (EntryFio.Text == null || EntryFio.Text == "") await DisplayAlert("Ошибка", "Введите ФИО!", "OK");
            else
            {
                HttpClient client = new HttpClient();
                Empl_View empl_View = new Empl_View();
                empl_View.address_new = EntryAddress.Text;
                empl_View.fio_new = EntryFio.Text;
                empl_View.log = EntryLogin.Text;
                empl_View.passp = EntryPassport.Text;
                empl_View.passw = EntryPassword.Text;
                empl_View.exp = MainPage.empl.exp;
                empl_View.is_deleted = false;
                empl_View.idd = MainPage.empl.id_empl;
                string ss = JsonConvert.SerializeObject(empl_View);
                var content = new StringContent(ss, Encoding.UTF8, "application/json");
                try
                {
                    HttpResponseMessage responseMessage = await client.PutAsync(MainPage.url + "proc/employee", content);
                    string result = await responseMessage.Content.ReadAsStringAsync();
                    if (result == "0")
                    {
                        MainPage.empl.address = empl_View.address_new;
                        MainPage.empl.fio = empl_View.fio_new;
                        MainPage.empl.login = empl_View.log;
                        MainPage.empl.passport = empl_View.passp;
                        MainPage.empl.password = empl_View.passw;

                        await DisplayAlert("Выполнено", "Данные успешно обновлены!", "OK");
                        await Navigation.PopAsync();
                    }
                    else throw new Exception("Не удалось обновить!");
                    
                }
                catch
                {
                    await DisplayAlert("Ошибка", "", "OK");
                }
            }
        }
    }
}