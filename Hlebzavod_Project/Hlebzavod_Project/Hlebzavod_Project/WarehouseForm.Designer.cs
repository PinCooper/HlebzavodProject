
namespace Hlebzavod_Project
{
    partial class WarehouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseForm));
            this.FLP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.DGItems = new System.Windows.Forms.DataGridView();
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остаткиНаСкладеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доходрасходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FLP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGItems)).BeginInit();
            this.ms1.SuspendLayout();
            this.SuspendLayout();
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
            this.FLP1.Size = new System.Drawing.Size(200, 443);
            this.FLP1.TabIndex = 2;
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
            this.bt2.BackColor = System.Drawing.Color.Gainsboro;
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
            // DGItems
            // 
            this.DGItems.AllowUserToAddRows = false;
            this.DGItems.AllowUserToDeleteRows = false;
            this.DGItems.AllowUserToResizeRows = false;
            this.DGItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGItems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGItems.Location = new System.Drawing.Point(207, 24);
            this.DGItems.MultiSelect = false;
            this.DGItems.Name = "DGItems";
            this.DGItems.ReadOnly = true;
            this.DGItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGItems.Size = new System.Drawing.Size(669, 343);
            this.DGItems.TabIndex = 3;
            this.DGItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGItems_CellClick);
            // 
            // ms1
            // 
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(882, 24);
            this.ms1.TabIndex = 4;
            this.ms1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem,
            this.cjToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.закрытьToolStripMenuItem.Text = "Сохранить";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // cjToolStripMenuItem
            // 
            this.cjToolStripMenuItem.Name = "cjToolStripMenuItem";
            this.cjToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cjToolStripMenuItem.Text = "Закрыть";
            this.cjToolStripMenuItem.Click += new System.EventHandler(this.cjToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.остаткиНаСкладеToolStripMenuItem,
            this.доходрасходToolStripMenuItem,
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
            // доходрасходToolStripMenuItem
            // 
            this.доходрасходToolStripMenuItem.Name = "доходрасходToolStripMenuItem";
            this.доходрасходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.доходрасходToolStripMenuItem.Text = "Доходы и расходы";
            this.доходрасходToolStripMenuItem.Click += new System.EventHandler(this.доходрасходToolStripMenuItem_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.Location = new System.Drawing.Point(204, 387);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(76, 18);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "Название";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(286, 388);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 6;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2.Location = new System.Drawing.Point(204, 426);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(44, 18);
            this.lb2.TabIndex = 7;
            this.lb2.Text = "Цена";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(286, 427);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(752, 373);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(124, 22);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(752, 401);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(124, 22);
            this.btRefresh.TabIndex = 11;
            this.btRefresh.Text = "Обновить";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(752, 429);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(124, 22);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(882, 467);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.DGItems);
            this.Controls.Add(this.FLP1);
            this.Controls.Add(this.ms1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms1;
            this.Name = "WarehouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт данных на ООО «Северный хлебозавод»";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WarehouseForm_FormClosing);
            this.Shown += new System.EventHandler(this.WarehouseForm_Shown);
            this.FLP1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGItems)).EndInit();
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLP1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.DataGridView DGItems;
        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ToolStripMenuItem cjToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остаткиНаСкладеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доходрасходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
    }
}