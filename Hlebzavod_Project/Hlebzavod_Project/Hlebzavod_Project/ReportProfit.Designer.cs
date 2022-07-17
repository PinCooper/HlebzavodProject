
namespace Hlebzavod_Project
{
    partial class ReportProfit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportProfit));
            this.DGResult = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTime = new System.Windows.Forms.CheckBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.btReport = new System.Windows.Forms.Button();
            this.lbProfit = new System.Windows.Forms.Label();
            this.lbMinus = new System.Windows.Forms.Label();
            this.lbAll = new System.Windows.Forms.Label();
            this.txtAll = new System.Windows.Forms.TextBox();
            this.txtMinus = new System.Windows.Forms.TextBox();
            this.txtProfit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGResult
            // 
            this.DGResult.AllowUserToAddRows = false;
            this.DGResult.AllowUserToDeleteRows = false;
            this.DGResult.AllowUserToResizeColumns = false;
            this.DGResult.AllowUserToResizeRows = false;
            this.DGResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResult.Location = new System.Drawing.Point(12, 113);
            this.DGResult.MultiSelect = false;
            this.DGResult.Name = "DGResult";
            this.DGResult.ReadOnly = true;
            this.DGResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGResult.Size = new System.Drawing.Size(669, 343);
            this.DGResult.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 5;
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
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // checkTime
            // 
            this.checkTime.AutoSize = true;
            this.checkTime.Location = new System.Drawing.Point(122, 29);
            this.checkTime.Name = "checkTime";
            this.checkTime.Size = new System.Drawing.Size(15, 14);
            this.checkTime.TabIndex = 38;
            this.checkTime.UseVisualStyleBackColor = true;
            this.checkTime.CheckedChanged += new System.EventHandler(this.checkTime_CheckedChanged);
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(122, 77);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(161, 20);
            this.dateEnd.TabIndex = 36;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(122, 49);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(161, 20);
            this.dateStart.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Заканчивая";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Начиная";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(12, 24);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(96, 18);
            this.lbTime.TabIndex = 33;
            this.lbTime.Text = "За всё время";
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(537, 61);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(144, 36);
            this.btReport.TabIndex = 39;
            this.btReport.Text = "Сформировать отчёт";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // lbProfit
            // 
            this.lbProfit.AutoSize = true;
            this.lbProfit.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProfit.Location = new System.Drawing.Point(309, 24);
            this.lbProfit.Name = "lbProfit";
            this.lbProfit.Size = new System.Drawing.Size(52, 18);
            this.lbProfit.TabIndex = 40;
            this.lbProfit.Text = "Доход";
            // 
            // lbMinus
            // 
            this.lbMinus.AutoSize = true;
            this.lbMinus.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMinus.Location = new System.Drawing.Point(309, 51);
            this.lbMinus.Name = "lbMinus";
            this.lbMinus.Size = new System.Drawing.Size(57, 18);
            this.lbMinus.TabIndex = 40;
            this.lbMinus.Text = "Расход";
            // 
            // lbAll
            // 
            this.lbAll.AutoSize = true;
            this.lbAll.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAll.Location = new System.Drawing.Point(309, 79);
            this.lbAll.Name = "lbAll";
            this.lbAll.Size = new System.Drawing.Size(72, 18);
            this.lbAll.TabIndex = 40;
            this.lbAll.Text = "Прибыль";
            // 
            // txtAll
            // 
            this.txtAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAll.Location = new System.Drawing.Point(387, 77);
            this.txtAll.Name = "txtAll";
            this.txtAll.ReadOnly = true;
            this.txtAll.Size = new System.Drawing.Size(144, 20);
            this.txtAll.TabIndex = 41;
            // 
            // txtMinus
            // 
            this.txtMinus.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMinus.Location = new System.Drawing.Point(387, 49);
            this.txtMinus.Name = "txtMinus";
            this.txtMinus.ReadOnly = true;
            this.txtMinus.Size = new System.Drawing.Size(144, 20);
            this.txtMinus.TabIndex = 41;
            // 
            // txtProfit
            // 
            this.txtProfit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtProfit.Location = new System.Drawing.Point(387, 22);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.ReadOnly = true;
            this.txtProfit.Size = new System.Drawing.Size(144, 20);
            this.txtProfit.TabIndex = 41;
            // 
            // ReportProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(693, 468);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.txtMinus);
            this.Controls.Add(this.txtAll);
            this.Controls.Add(this.lbAll);
            this.Controls.Add(this.lbMinus);
            this.Controls.Add(this.lbProfit);
            this.Controls.Add(this.btReport);
            this.Controls.Add(this.checkTime);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.DGResult);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReportProfit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт о прибыли и расходах";
            this.Shown += new System.EventHandler(this.ReportProfit_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGResult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGResult;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkTime;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Label lbProfit;
        private System.Windows.Forms.Label lbMinus;
        private System.Windows.Forms.Label lbAll;
        private System.Windows.Forms.TextBox txtAll;
        private System.Windows.Forms.TextBox txtMinus;
        private System.Windows.Forms.TextBox txtProfit;
    }
}