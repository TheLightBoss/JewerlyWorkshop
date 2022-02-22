using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using Npgsql;
using ExamplePG_Manager.Models;
using ExamplePG_Manager.View;
using Newtonsoft.Json;

namespace ExamplePG_Manager
{
    public partial class Form_Masters : Form
    {
        
        int selected_Index_Master = -1;
        List<OrdersRun> orders_run;
        List<Zakazs_Master> zakazs_s = new List<Zakazs_Master>();
        public static readonly HttpClient client = new HttpClient();
        public static String URL = "http://localhost:50/api/";
        string id_izd;

        //создадим переменную в которую получим заказ, который присвоим выбранному мастеру

        public Form_Masters(string id, List<OrdersRun> orders_run)
        {
            InitializeComponent();
            this.id_izd = id;
            this.orders_run = orders_run;
        }

        private void Form_Masters_Load(object sender, EventArgs e)
        {
        
            selected_Index_Master = 0;

            radioButton_Mast1.Text = Form1.masters1[0].fio;
            radioButton_Mast2.Text = Form1.masters1[1].fio;
            radioButton_Mast3.Text = Form1.masters1[2].fio;
            radioButton_Mast1.Checked = true;
        }

        void Load_dataGrid()
        {
            List<OrdersRun> zz = new List<OrdersRun>();
            foreach (var i in orders_run) if (i.id_empl == selected_Index_Master) zz.Add(i);
            dgv_mast3.Rows.Clear();
            dgv_mast2.Rows.Clear();
            dgv_mast1.Rows.Clear();

            if(selected_Index_Master == 1)
            {
                foreach (var j in zz)
                {
                    if (!j.status)
                    {
                        int i = dgv_mast1.Rows.Add();
                    dgv_mast1.Rows[i].Cells[0].Value = j.date_start;
                    dgv_mast1.Rows[i].Cells[1].Value = j.name_prod;
                   
                        if (!j.half_status) { dgv_mast1.Rows[i].Cells[2].Value = "Работа не начата"; dgv_mast1.Rows[i].Cells[2].Style.BackColor = Color.OrangeRed; }
                        else { dgv_mast1.Rows[i].Cells[2].Value = "Выполняется"; dgv_mast1.Rows[i].Cells[2].Style.BackColor = Color.Yellow; }
                    }
                }
            }
            if (selected_Index_Master == 2)
            {
                foreach (var j in zz)
                {
                    if (!j.status)
                    {
                        int i = dgv_mast2.Rows.Add();
                    dgv_mast2.Rows[i].Cells[0].Value = j.date_start;
                    dgv_mast2.Rows[i].Cells[1].Value = j.name_prod;
                    
                        if (!j.half_status) { dgv_mast2.Rows[i].Cells[2].Value = "Работа не начата"; dgv_mast2.Rows[i].Cells[2].Style.BackColor = Color.OrangeRed; }
                        else { dgv_mast2.Rows[i].Cells[2].Value = "Выполняется"; dgv_mast2.Rows[i].Cells[2].Style.BackColor = Color.Yellow; }
                    }
                }
            }
            if (selected_Index_Master == 3)
            {
                foreach (var j in zz)
                {
                    if (!j.status)
                    {
                        int i = dgv_mast3.Rows.Add();
                    dgv_mast3.Rows[i].Cells[0].Value = j.date_start;
                    dgv_mast3.Rows[i].Cells[1].Value = j.name_prod;
                    
                        if (!j.half_status) { dgv_mast3.Rows[i].Cells[2].Value = "Работа не начата"; dgv_mast3.Rows[i].Cells[2].Style.BackColor = Color.OrangeRed; }
                        else { dgv_mast3.Rows[i].Cells[2].Value = "Выполняется"; dgv_mast3.Rows[i].Cells[2].Style.BackColor = Color.Yellow; }
                    }
                }
            }

        }


        private async void btn_Choice_Click(object sender, EventArgs e)
        {
            if (selected_Index_Master == -1)
            {
                MessageBox.Show("Не выбран мастер.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Dictionary<string, int> openWith = new Dictionary<string, int>();
                openWith.Add("id_empl", selected_Index_Master);
                openWith.Add("id_prod", Convert.ToInt32(id_izd));
                string ss = JsonConvert.SerializeObject(openWith);
                var content = new StringContent(ss, Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage = await client.PostAsync(URL + "proc/production", content);
                string result = await responseMessage.Content.ReadAsStringAsync();
                try
                {
                    int i = JsonConvert.DeserializeObject<int>(result);
                    if (i == 0)
                    {
                        MessageBox.Show("Заказ успешно отправлен сотруднику.", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //http запрос на добавление сотруднику нового заказа (создание строки в изготовлении и отправка её)
            }
            
        } //выбран сотрудник для нового заказа 

        private void radioButton_Mast1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Mast1.Checked)
            {
    
                selected_Index_Master = Form1.masters1[0].id_empl;
                Load_dataGrid();
            }
        }

        private void radioButton_Mast2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Mast2.Checked)
            {
  
                selected_Index_Master = Form1.masters1[1].id_empl;
                Load_dataGrid();
            }
        }

        private void radioButton_Mast3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Mast3.Checked)
            {
             
                selected_Index_Master = Form1.masters1[2].id_empl;
                Load_dataGrid();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
