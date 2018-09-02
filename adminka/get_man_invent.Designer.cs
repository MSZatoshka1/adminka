namespace adminka
{
    partial class get_man_invent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.name_invent = new System.Windows.Forms.ComboBox();
            this.kol = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id_rent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_invent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bernyl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rabn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.table);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 703);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(882, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.name_invent);
            this.panel2.Controls.Add(this.kol);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(882, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 229);
            this.panel2.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "инвентарь";
            // 
            // name_invent
            // 
            this.name_invent.FormattingEnabled = true;
            this.name_invent.Location = new System.Drawing.Point(216, 54);
            this.name_invent.Name = "name_invent";
            this.name_invent.Size = new System.Drawing.Size(112, 21);
            this.name_invent.TabIndex = 62;
            // 
            // kol
            // 
            this.kol.CausesValidation = false;
            this.kol.InterceptArrowKeys = false;
            this.kol.Location = new System.Drawing.Point(216, 94);
            this.kol.Name = "kol";
            this.kol.Size = new System.Drawing.Size(112, 20);
            this.kol.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(33, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "количество";
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_rent,
            this.id_invent,
            this.Название,
            this.Column1,
            this.bernyl,
            this.date,
            this.rabn});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.table.ImeMode = System.Windows.Forms.ImeMode.On;
            this.table.Location = new System.Drawing.Point(0, 24);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(1252, 679);
            this.table.TabIndex = 60;
            this.table.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.table_CellBeginEdit);
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
            this.table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellEndEdit);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 24);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // id_rent
            // 
            this.id_rent.HeaderText = "id_rent";
            this.id_rent.Name = "id_rent";
            this.id_rent.ReadOnly = true;
            this.id_rent.Visible = false;
            // 
            // id_invent
            // 
            this.id_invent.HeaderText = "id_invent";
            this.id_invent.Name = "id_invent";
            this.id_invent.ReadOnly = true;
            this.id_invent.Visible = false;
            // 
            // Название
            // 
            this.Название.HeaderText = "Название";
            this.Название.Name = "Название";
            this.Название.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "взял";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // bernyl
            // 
            this.bernyl.HeaderText = "вернул";
            this.bernyl.Name = "bernyl";
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // rabn
            // 
            this.rabn.HeaderText = "";
            this.rabn.Name = "rabn";
            this.rabn.Text = "приравнить";
            this.rabn.UseColumnTextForButtonValue = true;
            // 
            // get_man_invent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 703);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "get_man_invent";
            this.Text = "Инвентарь";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.get_man_invent_FormClosed);
            this.Load += new System.EventHandler(this.get_man_invent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown kol;
        private System.Windows.Forms.ComboBox name_invent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rent;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_invent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bernyl;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewButtonColumn rabn;
    }
}