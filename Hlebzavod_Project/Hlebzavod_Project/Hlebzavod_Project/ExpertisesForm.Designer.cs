
namespace Hlebzavod_Project
{
    partial class ExpertisesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpertisesForm));
            this.DGExpertises = new System.Windows.Forms.DataGridView();
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
            this.доходыИРасходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.dataExpertise = new System.Windows.Forms.DateTimePicker();
            this.btDelete = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGExpertises)).BeginInit();
            this.FLP1.SuspendLayout();
            this.ms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGExpertises
            // 
            this.DGExpertises.AllowUserToAddRows = false;
            this.DGExpertises.AllowUserToDeleteRows = false;
            this.DGExpertises.AllowUserToResizeRows = false;
            this.DGExpertises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGExpertises.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGExpertises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGExpertises.Location = new System.Drawing.Point(207, 24);
            this.DGExpertises.MultiSelect = false;
            this.DGExpertises.Name = "DGExpertises";
            this.DGExpertises.ReadOnly = true;
            this.DGExpertises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGExpertises.Size = new System.Drawing.Size(669, 343);
            this.DGExpertises.TabIndex = 17;
            this.DGExpertises.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGExpertises_CellClick);
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
            this.FLP1.TabIndex = 16;
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
            this.bt4.BackColor = System.Drawing.Color.Azure;
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
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.Gainsboro;
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
            this.bt5.UseVisualStyleBackColor = false;
            // 
            // ms1
            // 
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(883, 24);
            this.ms1.TabIndex = 18;
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
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
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
            this.доходыИРасходыToolStripMenuItem,
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
            // доходыИРасходыToolStripMenuItem
            // 
            this.доходыИРасходыToolStripMenuItem.Name = "доходыИРасходыToolStripMenuItem";
            this.доходыИРасходыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.доходыИРасходыToolStripMenuItem.Text = "Доходы и расходы";
            this.доходыИРасходыToolStripMenuItem.Click += new System.EventHandler(this.доходыИРасходыToolStripMenuItem_Click);
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(284, 389);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(196, 21);
            this.cbItems.TabIndex = 20;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.Location = new System.Drawing.Point(206, 388);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(49, 18);
            this.lb1.TabIndex = 21;
            this.lb1.Text = "Товар";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2.Location = new System.Drawing.Point(206, 430);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(72, 18);
            this.lb2.TabIndex = 22;
            this.lb2.Text = "Причина";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(284, 431);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(196, 20);
            this.txtReason.TabIndex = 23;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4.Location = new System.Drawing.Point(486, 430);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(43, 18);
            this.lb4.TabIndex = 24;
            this.lb4.Text = "Дата";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3.Location = new System.Drawing.Point(486, 388);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(79, 18);
            this.lb3.TabIndex = 25;
            this.lb3.Text = "Результат";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(571, 390);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(175, 20);
            this.txtResult.TabIndex = 26;
            // 
            // dataExpertise
            // 
            this.dataExpertise.Location = new System.Drawing.Point(571, 431);
            this.dataExpertise.Name = "dataExpertise";
            this.dataExpertise.Size = new System.Drawing.Size(175, 20);
            this.dataExpertise.TabIndex = 27;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(752, 429);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(124, 22);
            this.btDelete.TabIndex = 28;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(752, 401);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(124, 22);
            this.btRefresh.TabIndex = 29;
            this.btRefresh.Text = "Обновить";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(752, 373);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(124, 22);
            this.btAdd.TabIndex = 30;
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
            // ExpertisesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(883, 470);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dataExpertise);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.DGExpertises);
            this.Controls.Add(this.FLP1);
            this.Controls.Add(this.ms1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExpertisesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт данных на ООО «Северный хлебозавод»";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpertisesForm_FormClosing);
            this.Shown += new System.EventHandler(this.ExpertisesForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGExpertises)).EndInit();
            this.FLP1.ResumeLayout(false);
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGExpertises;
        private System.Windows.Forms.FlowLayoutPanel FLP1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.DateTimePicker dataExpertise;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остаткиНаСкладеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доходыИРасходыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
    }
}