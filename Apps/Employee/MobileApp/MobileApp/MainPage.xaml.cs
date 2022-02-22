using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Xamarin.Forms;
using MobileApp.Models;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        public static List<Orders> orders = new List<Orders>();
        public static Employee empl = new Employee();
        public static readonly HttpClient client = new HttpClient();
        public static String url = "https://37fb-94-181-204-149.ngrok.io/api/";
        public MainPage()
        {
            InitializeComponent();
            this.Title = "Авторизация";
        }
        protected override void OnAppearing()
        {
            object m = "";
            if (Application.Current.Properties.TryGetValue("empl", out m) && Application.Current.Properties.TryGetValue("orders", out m))
            {
#pragma warning disable CS0252 // Возможно, использовано непреднамеренное сравнение ссылок: для левой стороны требуется приведение
                if (Application.Current.Properties["empl"] != "")
#pragma warning restore CS0252 // Возможно, использовано непреднамеренное сравнение ссылок: для левой стороны требуется приведение
                {
                    empl = JsonConvert.DeserializeObject<Employee>((string)Application.Current.Properties["empl"]);//получаем строку мастера и возвращаем к Employee
                    orders = JsonConvert.DeserializeObject<List<Orders>>((string)Application.Current.Properties["orders"]);
                    EntryLogin.Text = empl.login;
                    //await Navigation.PushAsync(new Orders_page()); // отправляем к заказам 

                }
            }

        } //при подзрузке проверяем, если есть данные, берём их и отправляем на Orders_page для дальнейшей работы

        async void Load_Employee()
        {
            string ss = JsonConvert.SerializeObject(empl);
            var content = new StringContent(ss, Encoding.UTF8, "application/json");
            
            try
            {
                HttpResponseMessage responseMessage = await client.PostAsync(url + "view/employee", content);
                string result = await responseMessage.Content.ReadAsStringAsync();
                empl = JsonConvert.DeserializeObject<Employee>(result);
                if (empl.id_empl == -1) throw new Exception("Неверно введён логин или пароль!");
                else Load_Data();//если вернул мастера, то загружаем его заказы 
            }
            catch
            {
                EntryLogin.Text = "";
                EntryPassword.Text = "";
                await DisplayAlert("Ошибка", "Неверно введён логин или пароль!", "OK");
            }
        } //подгрузка данных через http-запрос

        async void Load_Data()
        {
            string ss = JsonConvert.SerializeObject(empl);
            var content = new StringContent(ss, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage responseMessage = await client.PostAsync(url + "view/empl", content);
                
                string result = await responseMessage.Content.ReadAsStringAsync();
                
                //string res = "{" + result.Substring(1, result.Length - 1) + "}";
                //EntryLogin.Text = res;
                orders = JsonConvert.DeserializeObject<List<Orders>>(result);
                if (orders.Count == 0) throw new Exception(); //если кол-во заказов 0, то ошибка, и далее работа пойдёт в catch
                
                object m = "";
                if (Application.Current.Properties.TryGetValue("empl", out m) && Application.Current.Properties.TryGetValue("orders", out m))
                    UpdateAppCurrProp(); //если есть то меняем
                else AddAppCurrProp(); //сохраняем строки json, если у мастера есть заказы на выполнение
                await Navigation.PushAsync(new Orders_page());
            }
            catch(Exception ex)
            {
                orders = null;
                EntryLogin.Text = ex.Message;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                EntryPassword.Text = "";
                await DisplayAlert("Заказов нет", "На данный аккаунт нет заказов!", "OK");
                //await Navigation.PushAsync(new Employee_page()); //отправляем на форму сотрудника (его данные для редактирования)
            }

        } //подгрузка данных через http-запрос

        private async void Button_Click(object sender, EventArgs e)
        {
            if (EntryLogin.Text == null || EntryLogin.Text == "") await DisplayAlert("Ошибка", "Введите логин!", "OK");
            else if (EntryPassword.Text == null || EntryPassword.Text == "") await DisplayAlert("Ошибка", "Введите пароль!", "OK");
            else
            {
                empl.login = EntryLogin.Text;
                empl.password = EntryPassword.Text;
                Load_Employee();
            }
        } //при нажатии на кнопку Войти

        public static void DeleteAppCurrProp()
        {
            Application.Current.Properties["empl"] = "";
            Application.Current.Properties["orders"] = "";
        } // удаляем строки json, так как пользователь вышел (нажал кнопку выйти)
          // то есть возможно он хочет зайти на другой аккаунт (другой сотрудник)
        void AddAppCurrProp()
        {
            Application.Current.Properties.Add("empl", JsonConvert.SerializeObject(empl));// сохраняем строку мастера по ключу empl на устройстве
            Application.Current.Properties.Add("orders", JsonConvert.SerializeObject(orders));// сохраняем заказы мастера по ключу orders на устройстве
        } // сохраняем строки json
        public static void UpdateAppCurrProp()
        {
            Application.Current.Properties["empl"] = JsonConvert.SerializeObject(empl);
            Application.Current.Properties["orders"] = JsonConvert.SerializeObject(orders);
        } //при любом изменение данных в empl или zakaz_s сохраняем эти изменения в App.Current.Properties
    }
}
