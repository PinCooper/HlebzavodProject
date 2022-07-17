
namespace Hlebzavod_Project
{
    partial class PlaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceForm));
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остаткиНаСкладеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прибыльToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FLP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.DGPlaces = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms1.SuspendLayout();
            this.FLP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // ms1
            // 
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(883, 24);
            this.ms1.TabIndex = 0;
            this.ms1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.остаткиНаСкладеToolStripMenuItem,
            this.прибыльToolStripMenuItem,
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
            // прибыльToolStripMenuItem
            // 
            this.прибыльToolStripMenuItem.Name = "прибыльToolStripMenuItem";
            this.прибыльToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.прибыльToolStripMenuItem.Text = "Доходы и расходы";
            this.прибыльToolStripMenuItem.Click += new System.EventHandler(this.прибыльToolStripMenuItem_Click);
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
            this.FLP1.Size = new System.Drawing.Size(200, 444);
            this.FLP1.TabIndex = 1;
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Gainsboro;
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
            // 
            // bt2
            // 
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
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
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
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
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
            // DGPlaces
            // 
            this.DGPlaces.AllowUserToAddRows = false;
            this.DGPlaces.AllowUserToDeleteRows = false;
            this.DGPlaces.AllowUserToResizeRows = false;
            this.DGPlaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGPlaces.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPlaces.Location = new System.Drawing.Point(206, 24);
            this.DGPlaces.MultiSelect = false;
            this.DGPlaces.Name = "DGPlaces";
            this.DGPlaces.ReadOnly = true;
            this.DGPlaces.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGPlaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGPlaces.Size = new System.Drawing.Size(669, 343);
            this.DGPlaces.TabIndex = 2;
            this.DGPlaces.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPlaces_CellClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(288, 378);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 20);
            this.txtName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(206, 377);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(76, 18);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Название";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(751, 429);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(124, 22);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(751, 401);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(124, 22);
            this.btRefresh.TabIndex = 13;
            this.btRefresh.Text = "Обновить";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(751, 373);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(124, 22);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddress.Location = new System.Drawing.Point(206, 405);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(49, 18);
            this.lbAddress.TabIndex = 4;
            this.lbAddress.Text = "Адрес";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(288, 406);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(278, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // PlaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(883, 468);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.DGPlaces);
            this.Controls.Add(this.FLP1);
            this.Controls.Add(this.ms1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms1;
            this.Name = "PlaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт данных на ООО «Северный хлебозавод»";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlaceForm_FormClosing);
            this.Shown += new System.EventHandler(this.PlaceForm_Shown);
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.FLP1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel FLP1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.DataGridView DGPlaces;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem остаткиНаСкладеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прибыльToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
    }
}

