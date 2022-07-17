
namespace Hlebzavod_Project
{
    partial class OperationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationsForm));
            this.lb4 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.DGOperations = new System.Windows.Forms.DataGridView();
            this.FLP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остаткиНаСкладеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доходыРасходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbWhere = new System.Windows.Forms.ComboBox();
            this.cbOperation_Types = new System.Windows.Forms.ComboBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.dateOperation = new System.Windows.Forms.DateTimePicker();
            this.btDelete = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGOperations)).BeginInit();
            this.FLP1.SuspendLayout();
            this.ms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4.Location = new System.Drawing.Point(473, 403);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(106, 18);
            this.lb4.TabIndex = 19;
            this.lb4.Text = "Тип операции";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2.Location = new System.Drawing.Point(206, 402);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(43, 18);
            this.lb2.TabIndex = 17;
            this.lb2.Text = "Куда";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.Location = new System.Drawing.Point(206, 373);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(61, 18);
            this.lb1.TabIndex = 15;
            this.lb1.Text = "Откуда";
            // 
            // DGOperations
            // 
            this.DGOperations.AllowUserToAddRows = false;
            this.DGOperations.AllowUserToDeleteRows = false;
            this.DGOperations.AllowUserToResizeRows = false;
            this.DGOperations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGOperations.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGOperations.Location = new System.Drawing.Point(207, 24);
            this.DGOperations.MultiSelect = false;
            this.DGOperations.Name = "DGOperations";
            this.DGOperations.ReadOnly = true;
            this.DGOperations.Size = new System.Drawing.Size(669, 343);
            this.DGOperations.TabIndex = 13;
            this.DGOperations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGOperations_CellClick);
            // 
            // FLP1
            // 
            this.FLP1.BackColor = System.Drawing.Color.Azure;
            this.FLP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLP1.Controls.Add(this.bt1);
            this.FLP1.Controls.Add(this.bt2);
            this.FLP1.Controls.Add(this.bt3);
            this.FLP1.Controls.Add(this.bt4);
            this.FLP1.Controls.Add(this.bt5);
            this.FLP1.Dock = System.Windows.Forms.DockStyle.Left;
            this.FLP1.Location = new System.Drawing.Point(0, 24);
            this.FLP1.Name = "FLP1";
            this.FLP1.Size = new System.Drawing.Size(200, 446);
            this.FLP1.TabIndex = 12;
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Azure;
            this.bt1.FlatAppearance.BorderSize = 0;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt1.Image = ((System.Drawing.Image)(resources.GetObject("bt1.Image")));
            this.bt1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt1.Location = new System.Drawing.Point(3, 3);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(197, 38);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "Места";
            this.bt1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.Azure;
            this.bt2.FlatAppearance.BorderSize = 0;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt2.Image = ((System.Drawing.Image)(resources.GetObject("bt2.Image")));
            this.bt2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt2.Location = new System.Drawing.Point(3, 47);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(197, 38);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "Склад";
            this.bt2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.Gainsboro;
            this.bt3.FlatAppearance.BorderSize = 0;
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt3.Image = ((System.Drawing.Image)(resources.GetObject("bt3.Image")));
            this.bt3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt3.Location = new System.Drawing.Point(3, 91);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(197, 38);
            this.bt3.TabIndex = 3;
            this.bt3.Text = "Операции";
            this.bt3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt3.UseVisualStyleBackColor = false;
            // 
            // bt4
            // 
            this.bt4.FlatAppearance.BorderSize = 0;
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt4.Image = ((System.Drawing.Image)(resources.GetObject("bt4.Image")));
            this.bt4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt4.Location = new System.Drawing.Point(3, 135);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(197, 38);
            this.bt4.TabIndex = 4;
            this.bt4.Text = "Тип операции";
            this.bt4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.FlatAppearance.BorderSize = 0;
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt5.Image = ((System.Drawing.Image)(resources.GetObject("bt5.Image")));
            this.bt5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt5.Location = new System.Drawing.Point(3, 179);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(197, 38);
            this.bt5.TabIndex = 5;
            this.bt5.Text = "Экспертизы";
            this.bt5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // ms1
            // 
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(883, 24);
            this.ms1.TabIndex = 14;
            this.ms1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem,
            this.закрытьToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.закрытьToolStripMenuItem.Text = "Сохранить";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem1
            // 
            this.закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
            this.закрытьToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.закрытьToolStripMenuItem1.Text = "Закрыть";
            this.закрытьToolStripMenuItem1.Click += new System.EventHandler(this.закрытьToolStripMenuItem1_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.остаткиНаСкладеToolStripMenuItem,
            this.доходыРасходыToolStripMenuItem,
            this.поставщикиToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // остаткиНаСкладеToolStripMenuItem
            // 
            this.остаткиНаСкладеToolStripMenuItem.Name = "остаткиНаСкладеToolStripMenuItem";
            this.остаткиНаСкладеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.остаткиНаСкладеToolStripMenuItem.Text = "Остатки на складе";
            this.остаткиНаСкладеToolStripMenuItem.Click += new System.EventHandler(this.остаткиНаСкладеToolStripMenuItem_Click);
            // 
            // доходыРасходыToolStripMenuItem
            // 
            this.доходыРасходыToolStripMenuItem.Name = "доходыРасходыToolStripMenuItem";
            this.доходыРасходыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.доходыРасходыToolStripMenuItem.Text = "Доходы и расходы";
            this.доходыРасходыToolStripMenuItem.Click += new System.EventHandler(this.доходыРасходыToolStripMenuItem_Click);
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(282, 373);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(173, 21);
            this.cbFrom.TabIndex = 22;
            // 
            // cbWhere
            // 
            this.cbWhere.FormattingEnabled = true;
            this.cbWhere.Location = new System.Drawing.Point(282, 403);
            this.cbWhere.Name = "cbWhere";
            this.cbWhere.Size = new System.Drawing.Size(173, 21);
            this.cbWhere.TabIndex = 23;
            // 
            // cbOperation_Types
            // 
            this.cbOperation_Types.FormattingEnabled = true;
            this.cbOperation_Types.Location = new System.Drawing.Point(585, 402);
            this.cbOperation_Types.Name = "cbOperation_Types";
            this.cbOperation_Types.Size = new System.Drawing.Size(161, 21);
            this.cbOperation_Types.TabIndex = 24;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3.Location = new System.Drawing.Point(473, 374);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(49, 18);
            this.lb3.TabIndex = 25;
            this.lb3.Text = "Товар";
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(585, 374);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(161, 21);
            this.cbItems.TabIndex = 26;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb5.Location = new System.Drawing.Point(206, 430);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(57, 18);
            this.lb5.TabIndex = 27;
            this.lb5.Text = "Кол-во";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb6.Location = new System.Drawing.Point(473, 430);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(43, 18);
            this.lb6.TabIndex = 28;
            this.lb6.Text = "Дата";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(282, 431);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(173, 20);
            this.txtNumber.TabIndex = 29;
            // 
            // dateOperation
            // 
            this.dateOperation.Location = new System.Drawing.Point(585, 431);
            this.dateOperation.Name = "dateOperation";
            this.dateOperation.Size = new System.Drawing.Size(161, 20);
            this.dateOperation.TabIndex = 30;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(752, 429);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(124, 22);
            this.btDelete.TabIndex = 31;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(752, 401);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(124, 22);
            this.btRefresh.TabIndex = 32;
            this.btRefresh.Text = "Обновить";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(752, 373);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(124, 22);
            this.btAdd.TabIndex = 33;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(883, 470);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dateOperation);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.cbOperation_Types);
            this.Controls.Add(this.cbWhere);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.DGOperations);
            this.Controls.Add(this.FLP1);
            this.Controls.Add(this.ms1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OperationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт данных на ООО «Северный хлебозавод»";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OperationsForm_FormClosing);
            this.Shown += new System.EventHandler(this.OperationsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGOperations)).EndInit();
            this.FLP1.ResumeLayout(false);
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView DGOperations;
        private System.Windows.Forms.FlowLayoutPanel FLP1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbWhere;
        private System.Windows.Forms.ComboBox cbOperation_Types;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.DateTimePicker dateOperation;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остаткиНаСкладеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доходыРасходыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
    }
}