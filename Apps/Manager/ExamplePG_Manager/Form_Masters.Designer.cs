
namespace ExamplePG_Manager
{
    partial class Form_Masters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton_Mast1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Mast2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Mast3 = new System.Windows.Forms.RadioButton();
            this.dgv_mast1 = new System.Windows.Forms.DataGridView();
            this.Column_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Izd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_mast2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_mast3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Choice = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mast1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mast2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mast3)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_Mast1
            // 
            this.radioButton_Mast1.AutoSize = true;
            this.radioButton_Mast1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Mast1.Location = new System.Drawing.Point(20, 16);
            this.radioButton_Mast1.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_Mast1.Name = "radioButton_Mast1";
            this.radioButton_Mast1.Size = new System.Drawing.Size(167, 28);
            this.radioButton_Mast1.TabIndex = 0;
            this.radioButton_Mast1.TabStop = true;
            this.radioButton_Mast1.Text = "_имя_мастера1";
            this.radioButton_Mast1.UseVisualStyleBackColor = true;
            this.radioButton_Mast1.CheckedChanged += new System.EventHandler(this.radioButton_Mast1_CheckedChanged);
            // 
            // radioButton_Mast2
            // 
            this.radioButton_Mast2.AutoSize = true;
            this.radioButton_Mast2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Mast2.Location = new System.Drawing.Point(15, 208);
            this.radioButton_Mast2.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_Mast2.Name = "radioButton_Mast2";
            this.radioButton_Mast2.Size = new System.Drawing.Size(167, 28);
            this.radioButton_Mast2.TabIndex = 1;
            this.radioButton_Mast2.TabStop = true;
            this.radioButton_Mast2.Text = "_имя_мастера2";
            this.radioButton_Mast2.UseVisualStyleBackColor = true;
            this.radioButton_Mast2.CheckedChanged += new System.EventHandler(this.radioButton_Mast2_CheckedChanged);
            // 
            // radioButton_Mast3
            // 
            this.radioButton_Mast3.AutoSize = true;
            this.radioButton_Mast3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Mast3.Location = new System.Drawing.Point(17, 395);
            this.radioButton_Mast3.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_Mast3.Name = "radioButton_Mast3";
            this.radioButton_Mast3.Size = new System.Drawing.Size(167, 28);
            this.radioButton_Mast3.TabIndex = 2;
            this.radioButton_Mast3.TabStop = true;
            this.radioButton_Mast3.Text = "_имя_мастера3";
            this.radioButton_Mast3.UseVisualStyleBackColor = true;
            this.radioButton_Mast3.CheckedChanged += new System.EventHandler(this.radioButton_Mast3_CheckedChanged);
            // 
            // dgv_mast1
            // 
            this.dgv_mast1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mast1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mast1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Date,
            this.Column_Izd,
            this.Column_Status});
            this.dgv_mast1.Location = new System.Drawing.Point(15, 56);
            this.dgv_mast1.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_mast1.Name = "dgv_mast1";
            this.dgv_mast1.Size = new System.Drawing.Size(531, 135);
            this.dgv_mast1.TabIndex = 3;
            // 
            // Column_Date
            // 
            this.Column_Date.HeaderText = "Дата";
            this.Column_Date.Name = "Column_Date";
            // 
            // Column_Izd
            // 
            this.Column_Izd.HeaderText = "Изделие";
            this.Column_Izd.Name = "Column_Izd";
            // 
            // Column_Status
            // 
            this.Column_Status.HeaderText = "Статус";
            this.Column_Status.Name = "Column_Status";
            // 
            // dgv_mast2
            // 
            this.dgv_mast2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mast2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mast2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_mast2.Location = new System.Drawing.Point(15, 248);
            this.dgv_mast2.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_mast2.Name = "dgv_mast2";
            this.dgv_mast2.Size = new System.Drawing.Size(531, 130);
            this.dgv_mast2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Изделие";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dgv_mast3
            // 
            this.dgv_mast3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mast3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mast3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgv_mast3.Location = new System.Drawing.Point(15, 435);
            this.dgv_mast3.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_mast3.Name = "dgv_mast3";
            this.dgv_mast3.Size = new System.Drawing.Size(531, 146);
            this.dgv_mast3.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Изделие";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btn_Choice
            // 
            this.btn_Choice.Location = new System.Drawing.Point(595, 531);
            this.btn_Choice.Name = "btn_Choice";
            this.btn_Choice.Size = new System.Drawing.Size(170, 50);
            this.btn_Choice.TabIndex = 6;
            this.btn_Choice.Text = "Выбрать";
            this.btn_Choice.UseVisualStyleBackColor = true;
            this.btn_Choice.Click += new System.EventHandler(this.btn_Choice_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(595, 373);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(170, 50);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Закрыть";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Form_Masters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 602);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.btn_Choice);
            this.Controls.Add(this.dgv_mast3);
            this.Controls.Add(this.dgv_mast2);
            this.Controls.Add(this.dgv_mast1);
            this.Controls.Add(this.radioButton_Mast3);
            this.Controls.Add(this.radioButton_Mast2);
            this.Controls.Add(this.radioButton_Mast1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_Masters";
            this.Text = "Загруженность мастеров";
            this.Load += new System.EventHandler(this.Form_Masters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mast1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mast2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mast3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Mast1;
        private System.Windows.Forms.RadioButton radioButton_Mast2;
        private System.Windows.Forms.RadioButton radioButton_Mast3;
        private System.Windows.Forms.DataGridView dgv_mast1;
        private System.Windows.Forms.DataGridView dgv_mast2;
        private System.Windows.Forms.DataGridView dgv_mast3;
        private System.Windows.Forms.Button btn_Choice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Izd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button_close;
    }
}