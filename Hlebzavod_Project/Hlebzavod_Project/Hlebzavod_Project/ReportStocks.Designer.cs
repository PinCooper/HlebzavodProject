
namespace Hlebzavod_Project
{
    partial class ReportStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportStocks));
            this.DGAll = new System.Windows.Forms.DataGridView();
            this.btReport = new System.Windows.Forms.Button();
            this.DGResult = new System.Windows.Forms.DataGridView();
            this.lbTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.checkTime = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGAll
            // 
            this.DGAll.AllowUserToAddRows = false;
            this.DGAll.AllowUserToDeleteRows = false;
            this.DGAll.AllowUserToResizeColumns = false;
            this.DGAll.AllowUserToResizeRows = false;
            this.DGAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGAll.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGAll.Location = new System.Drawing.Point(12, 113);
            this.DGAll.MultiSelect = false;
            this.DGAll.Name = "DGAll";
            this.DGAll.ReadOnly = true;
            this.DGAll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGAll.Size = new System.Drawing.Size(332, 343);
            this.DGAll.TabIndex = 3;
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(537, 61);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(144, 36);
            this.btReport.TabIndex = 15;
            this.btReport.Text = "Сформировать отчёт";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // DGResult
            // 
            this.DGResult.AllowUserToAddRows = false;
            this.DGResult.AllowUserToDeleteRows = false;
            this.DGResult.AllowUserToResizeRows = false;
            this.DGResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResult.Location = new System.Drawing.Point(350, 113);
            this.DGResult.MultiSelect = false;
            this.DGResult.Name = "DGResult";
            this.DGResult.ReadOnly = true;
            this.DGResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGResult.Size = new System.Drawing.Size(332, 343);
            this.DGResult.TabIndex = 16;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(12, 24);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(96, 18);
            this.lbTime.TabIndex = 17;
            this.lbTime.Text = "За всё время";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 18;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Начиная";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Заканчивая";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(122, 49);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(161, 20);
            this.dateStart.TabIndex = 31;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(122, 77);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(161, 20);
            this.dateEnd.TabIndex = 31;
            // 
            // checkTime
            // 
            this.checkTime.AutoSize = true;
            this.checkTime.Location = new System.Drawing.Point(122, 29);
            this.checkTime.Name = "checkTime";
            this.checkTime.Size = new System.Drawing.Size(15, 14);
            this.checkTime.TabIndex = 32;
            this.checkTime.UseVisualStyleBackColor = true;
            this.checkTime.CheckedChanged += new System.EventHandler(this.checkTime_CheckedChanged);
            // 
            // ReportStocks
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
            this.Controls.Add(this.DGResult);
            this.Controls.Add(this.btReport);
            this.Controls.Add(this.DGAll);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReportStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт об остатках на складе";
            this.Shown += new System.EventHandler(this.ReportStocks_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGResult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGAll;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.DataGridView DGResult;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.CheckBox checkTime;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}