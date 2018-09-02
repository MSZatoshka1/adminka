namespace adminka
{
    partial class get_times
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
            this.spicok = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_man = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Паспорт = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Табель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.zacrit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spicok)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spicok
            // 
            this.spicok.AllowUserToAddRows = false;
            this.spicok.AllowUserToDeleteRows = false;
            this.spicok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spicok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_time,
            this.id_man,
            this.subname,
            this.name,
            this.Column1,
            this.Паспорт,
            this.Табель,
            this.data1,
            this.date2,
            this.kom,
            this.problit,
            this.zacrit});
            this.spicok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spicok.Location = new System.Drawing.Point(0, 24);
            this.spicok.Name = "spicok";
            this.spicok.ReadOnly = true;
            this.spicok.Size = new System.Drawing.Size(1434, 603);
            this.spicok.TabIndex = 0;
            this.spicok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spicok_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1434, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // id_time
            // 
            this.id_time.HeaderText = "id_time";
            this.id_time.Name = "id_time";
            this.id_time.ReadOnly = true;
            // 
            // id_man
            // 
            this.id_man.HeaderText = "id_man";
            this.id_man.Name = "id_man";
            this.id_man.ReadOnly = true;
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
            // Column1
            // 
            this.Column1.HeaderText = "Отчество";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Паспорт
            // 
            this.Паспорт.HeaderText = "Паспорт";
            this.Паспорт.Name = "Паспорт";
            this.Паспорт.ReadOnly = true;
            // 
            // Табель
            // 
            this.Табель.HeaderText = "Табель";
            this.Табель.Name = "Табель";
            this.Табель.ReadOnly = true;
            // 
            // data1
            // 
            this.data1.HeaderText = "приехал";
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            // 
            // date2
            // 
            this.date2.HeaderText = "Дата уезда";
            this.date2.Name = "date2";
            this.date2.ReadOnly = true;
            // 
            // kom
            // 
            this.kom.HeaderText = "комната";
            this.kom.Name = "kom";
            this.kom.ReadOnly = true;
            // 
            // problit
            // 
            this.problit.HeaderText = " ";
            this.problit.Name = "problit";
            this.problit.ReadOnly = true;
            this.problit.Text = "Продлить";
            this.problit.UseColumnTextForButtonValue = true;
            // 
            // zacrit
            // 
            this.zacrit.HeaderText = " ";
            this.zacrit.Name = "zacrit";
            this.zacrit.ReadOnly = true;
            this.zacrit.Text = "Закрыть";
            this.zacrit.UseColumnTextForButtonValue = true;
            // 
            // get_times
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 627);
            this.Controls.Add(this.spicok);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "get_times";
            this.Text = "get_times";
            this.Load += new System.EventHandler(this.get_times_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spicok)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView spicok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_man;
        private System.Windows.Forms.DataGridViewTextBoxColumn subname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Паспорт;
        private System.Windows.Forms.DataGridViewTextBoxColumn Табель;
        private System.Windows.Forms.DataGridViewTextBoxColumn data1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kom;
        private System.Windows.Forms.DataGridViewButtonColumn problit;
        private System.Windows.Forms.DataGridViewButtonColumn zacrit;
    }
}