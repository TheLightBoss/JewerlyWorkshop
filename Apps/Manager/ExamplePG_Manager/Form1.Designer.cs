
namespace ExamplePG_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.jewerlyDataSet = new ExamplePG_Manager.jewerlyDataSet();
            this.izdeliesprBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izdelie_sprTableAdapter = new ExamplePG_Manager.jewerlyDataSetTableAdapters.izdelie_sprTableAdapter();
            this.tabPage_Zakazs = new System.Windows.Forms.TabPage();
            this.dgv_ZakazMain = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Izdel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ContactInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton_readyZakaz = new System.Windows.Forms.RadioButton();
            this.radioButton_loadZakaz = new System.Windows.Forms.RadioButton();
            this.radioButton_newZakaz = new System.Windows.Forms.RadioButton();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown_exp = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.textBox_passport = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.jewerlyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdeliesprBindingSource)).BeginInit();
            this.tabPage_Zakazs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ZakazMain)).BeginInit();
            this.tabControl_Main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_exp)).BeginInit();
            this.SuspendLayout();
            // 
            // jewerlyDataSet
            // 
            this.jewerlyDataSet.DataSetName = "jewerlyDataSet";
            this.jewerlyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izdeliesprBindingSource
            // 
            this.izdeliesprBindingSource.DataMember = "izdelie_spr";
            this.izdeliesprBindingSource.DataSource = this.jewerlyDataSet;
            // 
            // izdelie_sprTableAdapter
            // 
            this.izdelie_sprTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage_Zakazs
            // 
            this.tabPage_Zakazs.Controls.Add(this.dgv_ZakazMain);
            this.tabPage_Zakazs.Controls.Add(this.radioButton_readyZakaz);
            this.tabPage_Zakazs.Controls.Add(this.radioButton_loadZakaz);
            this.tabPage_Zakazs.Controls.Add(this.radioButton_newZakaz);
            this.tabPage_Zakazs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage_Zakazs.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Zakazs.Name = "tabPage_Zakazs";
            this.tabPage_Zakazs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Zakazs.Size = new System.Drawing.Size(973, 583);
            this.tabPage_Zakazs.TabIndex = 0;
            this.tabPage_Zakazs.Text = "Заказы";
            this.tabPage_Zakazs.UseVisualStyleBackColor = true;
            this.tabPage_Zakazs.Enter += new System.EventHandler(this.tabPage_Zakazs_Enter);
            // 
            // dgv_ZakazMain
            // 
            this.dgv_ZakazMain.AllowUserToAddRows = false;
            this.dgv_ZakazMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ZakazMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ZakazMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ZakazMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column_Date,
            this.Column_Izdel,
            this.Column_Client,
            this.Column_ContactInfo,
            this.Column_Price});
            this.dgv_ZakazMain.Location = new System.Drawing.Point(19, 221);
            this.dgv_ZakazMain.Name = "dgv_ZakazMain";
            this.dgv_ZakazMain.ReadOnly = true;
            this.dgv_ZakazMain.Size = new System.Drawing.Size(931, 348);
            this.dgv_ZakazMain.TabIndex = 3;
            this.dgv_ZakazMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ZakazMain_CellContentClick);
            this.dgv_ZakazMain.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dqv_ZakazMain_RowHeaderMouseDoubleClick);
            // 
            // id
            // 
            this.id.FillWeight = 15.22843F;
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Column_Date
            // 
            this.Column_Date.FillWeight = 116.9543F;
            this.Column_Date.HeaderText = "Дата";
            this.Column_Date.Name = "Column_Date";
            this.Column_Date.ReadOnly = true;
            // 
            // Column_Izdel
            // 
            this.Column_Izdel.FillWeight = 116.9543F;
            this.Column_Izdel.HeaderText = "Изделие";
            this.Column_Izdel.Name = "Column_Izdel";
            this.Column_Izdel.ReadOnly = true;
            // 
            // Column_Client
            // 
            this.Column_Client.FillWeight = 116.9543F;
            this.Column_Client.HeaderText = "Клиент";
            this.Column_Client.Name = "Column_Client";
            this.Column_Client.ReadOnly = true;
            // 
            // Column_ContactInfo
            // 
            this.Column_ContactInfo.FillWeight = 116.9543F;
            this.Column_ContactInfo.HeaderText = "Контактная инфо.";
            this.Column_ContactInfo.Name = "Column_ContactInfo";
            this.Column_ContactInfo.ReadOnly = true;
            // 
            // Column_Price
            // 
            this.Column_Price.FillWeight = 116.9543F;
            this.Column_Price.HeaderText = "Цена, P";
            this.Column_Price.Name = "Column_Price";
            this.Column_Price.ReadOnly = true;
            // 
            // radioButton_readyZakaz
            // 
            this.radioButton_readyZakaz.AutoSize = true;
            this.radioButton_readyZakaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_readyZakaz.Location = new System.Drawing.Point(35, 124);
            this.radioButton_readyZakaz.Name = "radioButton_readyZakaz";
            this.radioButton_readyZakaz.Size = new System.Drawing.Size(149, 24);
            this.radioButton_readyZakaz.TabIndex = 2;
            this.radioButton_readyZakaz.Text = "Готовые заказы";
            this.radioButton_readyZakaz.UseVisualStyleBackColor = true;
            this.radioButton_readyZakaz.CheckedChanged += new System.EventHandler(this.radioButton_readyZakaz_CheckedChanged);
            // 
            // radioButton_loadZakaz
            // 
            this.radioButton_loadZakaz.AutoSize = true;
            this.radioButton_loadZakaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_loadZakaz.Location = new System.Drawing.Point(35, 83);
            this.radioButton_loadZakaz.Name = "radioButton_loadZakaz";
            this.radioButton_loadZakaz.Size = new System.Drawing.Size(212, 24);
            this.radioButton_loadZakaz.TabIndex = 1;
            this.radioButton_loadZakaz.Text = "Выполняющиеся заказы";
            this.radioButton_loadZakaz.UseVisualStyleBackColor = true;
            this.radioButton_loadZakaz.CheckedChanged += new System.EventHandler(this.radioButton_loadZakaz_CheckedChanged);
            // 
            // radioButton_newZakaz
            // 
            this.radioButton_newZakaz.AutoSize = true;
            this.radioButton_newZakaz.Checked = true;
            this.radioButton_newZakaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_newZakaz.Location = new System.Drawing.Point(35, 37);
            this.radioButton_newZakaz.Name = "radioButton_newZakaz";
            this.radioButton_newZakaz.Size = new System.Drawing.Size(134, 24);
            this.radioButton_newZakaz.TabIndex = 0;
            this.radioButton_newZakaz.TabStop = true;
            this.radioButton_newZakaz.Text = "Новые заказы";
            this.radioButton_newZakaz.UseVisualStyleBackColor = true;
            this.radioButton_newZakaz.CheckedChanged += new System.EventHandler(this.radioButton_newZakaz_CheckedChanged);
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Zakazs);
            this.tabControl_Main.Controls.Add(this.tabPage1);
            this.tabControl_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl_Main.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(981, 616);
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.numericUpDown_exp);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_password);
            this.tabPage1.Controls.Add(this.textBox_login);
            this.tabPage1.Controls.Add(this.textBox_adress);
            this.tabPage1.Controls.Add(this.textBox_passport);
            this.tabPage1.Controls.Add(this.textBox_name);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 583);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Регистрация сотрудников";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown_exp
            // 
            this.numericUpDown_exp.Location = new System.Drawing.Point(320, 272);
            this.numericUpDown_exp.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_exp.Name = "numericUpDown_exp";
            this.numericUpDown_exp.Size = new System.Drawing.Size(191, 26);
            this.numericUpDown_exp.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Пароль";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Опыт работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Серия и номер паспорта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(320, 403);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(191, 26);
            this.textBox_password.TabIndex = 5;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(320, 334);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(191, 26);
            this.textBox_login.TabIndex = 4;
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(320, 206);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(191, 26);
            this.textBox_adress.TabIndex = 2;
            // 
            // textBox_passport
            // 
            this.textBox_passport.Location = new System.Drawing.Point(320, 140);
            this.textBox_passport.Name = "textBox_passport";
            this.textBox_passport.Size = new System.Drawing.Size(191, 26);
            this.textBox_passport.TabIndex = 1;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(320, 75);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(191, 26);
            this.textBox_name.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 640);
            this.Controls.Add(this.tabControl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jewerlyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdeliesprBindingSource)).EndInit();
            this.tabPage_Zakazs.ResumeLayout(false);
            this.tabPage_Zakazs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ZakazMain)).EndInit();
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_exp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private jewerlyDataSet jewerlyDataSet;
        private System.Windows.Forms.BindingSource izdeliesprBindingSource;
        private jewerlyDataSetTableAdapters.izdelie_sprTableAdapter izdelie_sprTableAdapter;
        private System.Windows.Forms.TabPage tabPage_Zakazs;
        private System.Windows.Forms.DataGridView dgv_ZakazMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Izdel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ContactInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Price;
        private System.Windows.Forms.RadioButton radioButton_readyZakaz;
        private System.Windows.Forms.RadioButton radioButton_loadZakaz;
        private System.Windows.Forms.RadioButton radioButton_newZakaz;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_passport;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_exp;
        private System.Windows.Forms.Button button1;
    }
}

