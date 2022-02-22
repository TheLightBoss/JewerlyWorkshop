using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net.Http;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using ExamplePG_Manager.Models;
using ExamplePG_Manager.View;
using Newtonsoft.Json;

namespace ExamplePG_Manager
{
    
    public partial class Form1 : Form
    {
        //String url = "https://c9192a0a689d.ngrok.io/Home/";

        DataRow[] dataRow; // (работаем через это) 
        DataTable dataTable; // данные таблицы Izdeli_Spr
        DataTable dataTable_rabota; 
        DataTable dataTable_tip_izd;
        DataTable dataTable_mats;
        int numSelectedIzd = 0;
        int numSelectedSotr = 0;
        List<int> id_izd = new List<int>();

        //List<ZakazNew> zakazs_sNew = new List<ZakazNew>();// новые, которые нужно распределить
        List<ZakazGotov> zakazs_sGotov = new List<ZakazGotov>();// готовые заказы
        List<ZakazInProc> zakazs_sInProc = new List<ZakazInProc>();//заказы, которые выполняются

        public static List<Empls> masters1 = new List<Empls>();
        List<Mats> mats = new List<Mats>();
        List<Bank> banks = new List<Bank>();


        List<OrdersAPI> orders_new = new List<OrdersAPI>();
        List<OrdersRun> orders_run = new List<OrdersRun>();
        public Form1()
        {
            InitializeComponent();
        }
        public static readonly HttpClient client = new HttpClient();
        public static String URL = "http://localhost:50/api/";
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jewerlyDataSet.izdelie_spr". При необходимости она может быть перемещена или удалена.
            //this.izdelie_sprTableAdapter.Fill(this.jewerlyDataSet.izdelie_spr);
            
            Fill_ZakazNew();
            Fill_ZakazInProc();
            masters();
            dgv_ZakazMain.Rows.Clear();
            string pubIp = new System.Net.WebClient().DownloadString("https://api.ipify.org");
            MessageBox.Show("Внешний IP для проверки: "+pubIp);
            radioButton_newZakaz.Checked = true;
        }
        async void masters()
        {
            var content = new StringContent("", Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync(URL + "view/list", content);
            string result = await responseMessage.Content.ReadAsStringAsync();
            masters1 = JsonConvert.DeserializeObject<List<Empls>>(result);
        }
        async void Fill_ZakazNew()
        {
            string ss = "{\"argument\": \"new\"}";
            var content = new StringContent(ss, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync(URL + "view/orders", content);
            string result = await responseMessage.Content.ReadAsStringAsync();
            orders_new = JsonConvert.DeserializeObject<List<OrdersAPI>>(result);
            
        }// {"argument" : "new"} новые, которые нужно распределить
        async void Fill_ZakazInProc()
        {
            string ss = "{\"argument\": \"run\"}";
            var content = new StringContent(ss, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync(URL + "view/orders", content);
            string result = await responseMessage.Content.ReadAsStringAsync();
            orders_run = JsonConvert.DeserializeObject<List<OrdersRun>>(result);
        } //{"argument" : "run"} заказы, которые выполняются

        private void radioButton_newZakaz_CheckedChanged(object sender, EventArgs e)
        {
            dgv_ZakazMain.Rows.Clear();
            foreach (var i in orders_new)
            {
                int k = dgv_ZakazMain.Rows.Add();
                dgv_ZakazMain.Rows[k].Cells[0].Value = i.id_prod;
                dgv_ZakazMain.Rows[k].Cells[1].Value = i.date_order.ToShortDateString();
                dgv_ZakazMain.Rows[k].Cells[2].Value = i.name_prod;
                dgv_ZakazMain.Rows[k].Cells[3].Value = i.fio;
                dgv_ZakazMain.Rows[k].Cells[4].Value = i.contact_face;
                dgv_ZakazMain.Rows[k].Cells[5].Value = i.price_prod;
            }
        } //подгружает новые заказы

        private void radioButton_loadZakaz_CheckedChanged(object sender, EventArgs e)
        {
            dgv_ZakazMain.Rows.Clear();
            foreach (var i in orders_run)
            {
                int k = dgv_ZakazMain.Rows.Add(); 
                dgv_ZakazMain.Rows[k].Cells[0].Value = i.id_order;
                dgv_ZakazMain.Rows[k].Cells[1].Value = i.date_order.ToShortDateString();
                dgv_ZakazMain.Rows[k].Cells[2].Value = i.name_prod;
                dgv_ZakazMain.Rows[k].Cells[3].Value = i.fio;
                dgv_ZakazMain.Rows[k].Cells[4].Value = i.contact_face;
                dgv_ZakazMain.Rows[k].Cells[5].Value = i.price_prod;
            }
        } //подгружает выполняющиеся заказы

        private void radioButton_readyZakaz_CheckedChanged(object sender, EventArgs e)
        {
            dgv_ZakazMain.Rows.Clear();
            foreach (var i in orders_run)
            {
                if (i.status)
                {
                    int k = dgv_ZakazMain.Rows.Add();
                    dgv_ZakazMain.Rows[k].Cells[0].Value = i.id_order;
                    dgv_ZakazMain.Rows[k].Cells[1].Value = i.date_order.ToShortDateString();
                    dgv_ZakazMain.Rows[k].Cells[2].Value = i.name_prod;
                    dgv_ZakazMain.Rows[k].Cells[3].Value = i.fio;
                    dgv_ZakazMain.Rows[k].Cells[4].Value = i.contact_face;
                    dgv_ZakazMain.Rows[k].Cells[5].Value = i.price_prod;
                }
            }
        } //подгружает выполненные заказы, которые нужно подготовить к доставке


        private void textBox_urlIzd_Click(object sender, EventArgs e)
        {
        } //работа с url 

        private void dqv_ZakazMain_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (radioButton_newZakaz.Checked)
            {
                string index = dgv_ZakazMain.SelectedRows[0].Cells[0].Value.ToString();// с помощью этого свойства получаем id_izd в выбранной строке 
                Form_Masters masters = new Form_Masters(index, orders_run);
                Hide();
                masters.ShowDialog();
                radioButton_newZakaz_CheckedChanged(sender, e);
                Form1_Load(sender, e);
                Show();
            }

        } // выбираем нужный заказ и переходим на форму выбора мастера


        private async void button1_Click(object sender, EventArgs e)
        {
            AddEmpl empl = new AddEmpl();
            empl.address_new = textBox_adress.Text;
            empl.exp = Convert.ToInt32(numericUpDown_exp.Value);
            empl.fio_new = textBox_name.Text;
            empl.log = textBox_login.Text;
            empl.passp = textBox_passport.Text;
            empl.passw = textBox_password.Text;
            string ss = JsonConvert.SerializeObject(empl);
            var content = new StringContent(ss, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync(URL + "proc/employee", content);
            string result = await responseMessage.Content.ReadAsStringAsync();
            try
            {
                int i = JsonConvert.DeserializeObject<int>(result);
                if (i == 0)
                {
                    MessageBox.Show("Сотрудник добавлен.", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_adress.Text = "";
                    numericUpDown_exp.Value = 0;
                    textBox_name.Text = "";
                    textBox_login.Text = "";
                    textBox_passport.Text = "";
                    textBox_password.Text = "";
                }
                else
                {
                    throw new Exception("Логин и пароль неуникальные!");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_adress.Text = "";
                numericUpDown_exp.Value = 0;
                textBox_name.Text = "";
                textBox_login.Text = "";
                textBox_passport.Text = "";
                textBox_password.Text = "";
            }
        }



        // с помщью методов ниже изменяем размеры окна для удобной работы
        private void tabPage_izdSpr_Enter(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(1021, 679);
            
            tabControl_Main.Size = new System.Drawing.Size(981, 616);
            
        }  // страница с изделиями

        private void tabPage_sotrudnik_Enter(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(495, 610);
            tabControl_Main.Size = new System.Drawing.Size(462, 549);
        } //страница с сотрудниками

        private void tabPage_Zakazs_Enter(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(1021, 679);
            tabControl_Main.Size = new System.Drawing.Size(981, 616);
        }// главная форма для заказов

        private void tabPage2_Enter_1(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(743, 503);
            //tabControl1.Size = new System.Drawing.Size(682, 380);
            tabControl_Main.Size = new System.Drawing.Size(706, 441);
        }// страница с материалами

        private void tabPage_DataMain_Enter(object sender, EventArgs e)
        {
            tabPage2_Enter_1(sender, e);
        } // для страницы с материалами

        private void dgv_ZakazMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    
    }
}
