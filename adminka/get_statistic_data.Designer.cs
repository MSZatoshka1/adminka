namespace adminka
{
    partial class get_statistic_data
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
            this.statick = new System.Windows.Forms.DataGridView();
            this.subname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_card_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.списокКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.statick)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statick
            // 
            this.statick.AllowUserToAddRows = false;
            this.statick.AllowUserToDeleteRows = false;
            this.statick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statick.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subname,
            this.name,
            this.patronymic,
            this.organization,
            this.specialty,
            this.passport,
            this.report_card_number,
            this.data_p,
            this.data_y,
            this.kom});
            this.statick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statick.Location = new System.Drawing.Point(0, 24);
            this.statick.Name = "statick";
            this.statick.ReadOnly = true;
            this.statick.Size = new System.Drawing.Size(1464, 768);
            this.statick.TabIndex = 59;
            // 
            // subname
            // 
            this.subname.HeaderText = "Фамилия";
            this.subname.Name = "subname";
            this.subname.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // patronymic
            // 
            this.patronymic.HeaderText = "Отчетство";
            this.patronymic.Name = "patronymic";
            this.patronymic.ReadOnly = true;
            // 
            // organization
            // 
            this.organization.HeaderText = "Организация";
            this.organization.Name = "organization";
            this.organization.ReadOnly = true;
            // 
            // specialty
            // 
            this.specialty.HeaderText = "Специальность";
            this.specialty.Name = "specialty";
            this.specialty.ReadOnly = true;
            // 
            // passport
            // 
            this.passport.HeaderText = "Паспорт";
            this.passport.Name = "passport";
            this.passport.ReadOnly = true;
            // 
            // report_card_number
            // 
            this.report_card_number.HeaderText = "Табель";
            this.report_card_number.Name = "report_card_number";
            this.report_card_number.ReadOnly = true;
            // 
            // data_p
            // 
            this.data_p.HeaderText = "дата приезда";
            this.data_p.Name = "data_p";
            this.data_p.ReadOnly = true;
            // 
            // data_y
            // 
            this.data_y.HeaderText = "дата уезда";
            this.data_y.Name = "data_y";
            this.data_y.ReadOnly = true;
            // 
            // kom
            // 
            this.kom.HeaderText = "комната";
            this.kom.Name = "kom";
            this.kom.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКлиентовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1464, 24);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // списокКлиентовToolStripMenuItem
            // 
            this.списокКлиентовToolStripMenuItem.Name = "списокКлиентовToolStripMenuItem";
            this.списокКлиентовToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.списокКлиентовToolStripMenuItem.Text = "Назад";
            this.списокКлиентовToolStripMenuItem.Click += new System.EventHandler(this.списокКлиентовToolStripMenuItem_Click);
            // 
            // get_statistic_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 792);
            this.Controls.Add(this.statick);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "get_statistic_data";
            this.Text = "Статистика";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.get_statistic_data_FormClosed);
            this.Load += new System.EventHandler(this.get_statistic_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statick)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView statick;
        private System.Windows.Forms.DataGridViewTextBoxColumn subname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn organization;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_card_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_y;
        private System.Windows.Forms.DataGridViewTextBoxColumn kom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem списокКлиентовToolStripMenuItem;
    }
}