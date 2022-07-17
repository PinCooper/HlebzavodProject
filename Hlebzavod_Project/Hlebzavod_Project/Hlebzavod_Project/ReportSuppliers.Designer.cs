
namespace Hlebzavod_Project
{
    partial class ReportSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportSuppliers));
            this.DGSuppliers = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btReport = new System.Windows.Forms.Button();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.checkTime = new System.Windows.Forms.CheckBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGSuppliers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGSuppliers
            // 
            this.DGSuppliers.AllowUserToAddRows = false;
            this.DGSuppliers.AllowUserToDeleteRows = false;
            this.DGSuppliers.AllowUserToResizeColumns = false;
            this.DGSuppliers.AllowUserToResizeRows = false;
            this.DGSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGSuppliers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSuppliers.Location = new System.Drawing.Point(12, 128);
            this.DGSuppliers.MultiSelect = false;
            this.DGSuppliers.Name = "DGSuppliers";
            this.DGSuppliers.ReadOnly = true;
            this.DGSuppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGSuppliers.Size = new System.Drawing.Size(669, 328);
            this.DGSuppliers.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
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
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(537, 86);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(144, 36);
            this.btReport.TabIndex = 20;
            this.btReport.Text = "Сформировать отчёт";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(122, 25);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(161, 21);
            this.cbSuppliers.TabIndex = 21;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.Location = new System.Drawing.Point(12, 24);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(109, 18);
            this.lb1.TabIndex = 22;
            this.lb1.Text = "Поставщик(и)";
            // 
            // checkTime
            // 
            this.checkTime.AutoSize = true;
            this.checkTime.Location = new System.Drawing.Point(122, 54);
            this.checkTime.Name = "checkTime";
            this.checkTime.Size = new System.Drawing.Size(15, 14);
            this.checkTime.TabIndex = 38;
            this.checkTime.UseVisualStyleBackColor = true;
            this.checkTime.CheckedChanged += new System.EventHandler(this.checkTime_CheckedChanged);
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(122, 102);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(161, 20);
            this.dateEnd.TabIndex = 36;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(122, 74);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(161, 20);
            this.dateStart.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Заканчивая";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Начиная";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(12, 50);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(96, 18);
            this.lbTime.TabIndex = 33;
            this.lbTime.Text = "За всё время";
            // 
            // ReportSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(693, 468);
            this.Controls.Add(this.checkTime);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.btReport);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DGSuppliers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт о поставщиках";
            this.Shown += new System.EventHandler(this.ReportSuppliers_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGSuppliers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGSuppliers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.CheckBox checkTime;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}