namespace adminka
{
    partial class set_man
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sumname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pasport = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.issued_by = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.phone_number = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.year_of_birth = new System.Windows.Forms.MaskedTextBox();
            this.When_issued = new System.Windows.Forms.MaskedTextBox();
            this.error_invent = new System.Windows.Forms.Label();
            this.report_card_number = new System.Windows.Forms.TextBox();
            this.komnata = new System.Windows.Forms.NumericUpDown();
            this.set_invent_bd = new System.Windows.Forms.Button();
            this.set_invent = new System.Windows.Forms.TextBox();
            this.invent = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.set_full = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.organization = new System.Windows.Forms.TextBox();
            this.specialty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.database1DataSet = new adminka.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_invent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.komnata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invent)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sumname
            // 
            this.sumname.Location = new System.Drawing.Point(356, 63);
            this.sumname.MaxLength = 128;
            this.sumname.Name = "sumname";
            this.sumname.Size = new System.Drawing.Size(170, 20);
            this.sumname.TabIndex = 2;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(555, 63);
            this.name.MaxLength = 128;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(138, 20);
            this.name.TabIndex = 3;
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(727, 63);
            this.patronymic.MaxLength = 128;
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(214, 20);
            this.patronymic.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "№ комнаты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(393, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(594, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(781, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отчество ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1107, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(38, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Номер паспорта";
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(55, 158);
            this.pasport.Mask = "00_00_000000";
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(100, 20);
            this.pasport.TabIndex = 6;
            this.pasport.Leave += new System.EventHandler(this.pasport_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(252, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дата выдачи";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(63, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Выдан";
            // 
            // issued_by
            // 
            this.issued_by.Location = new System.Drawing.Point(55, 244);
            this.issued_by.Name = "issued_by";
            this.issued_by.Size = new System.Drawing.Size(1258, 47);
            this.issued_by.TabIndex = 8;
            this.issued_by.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(984, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "№ Табеля";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1140, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "№ Телефона";
            // 
            // phone_number
            // 
            this.phone_number.Location = new System.Drawing.Point(1144, 158);
            this.phone_number.Mask = "+7000_000_00_00";
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(100, 20);
            this.phone_number.TabIndex = 10;
            this.phone_number.Leave += new System.EventHandler(this.phone_number_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.year_of_birth);
            this.panel1.Controls.Add(this.When_issued);
            this.panel1.Controls.Add(this.error_invent);
            this.panel1.Controls.Add(this.report_card_number);
            this.panel1.Controls.Add(this.komnata);
            this.panel1.Controls.Add(this.set_invent_bd);
            this.panel1.Controls.Add(this.set_invent);
            this.panel1.Controls.Add(this.invent);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.organization);
            this.panel1.Controls.Add(this.specialty);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.phone_number);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.issued_by);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pasport);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.patronymic);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.sumname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 739);
            this.panel1.TabIndex = 0;
            // 
            // year_of_birth
            // 
            this.year_of_birth.Location = new System.Drawing.Point(1111, 63);
            this.year_of_birth.Mask = "00/00/0000";
            this.year_of_birth.Name = "year_of_birth";
            this.year_of_birth.Size = new System.Drawing.Size(100, 20);
            this.year_of_birth.TabIndex = 5;
            this.year_of_birth.ValidatingType = typeof(System.DateTime);
            this.year_of_birth.Leave += new System.EventHandler(this.date_check);
            // 
            // When_issued
            // 
            this.When_issued.Location = new System.Drawing.Point(256, 158);
            this.When_issued.Mask = "00/00/0000";
            this.When_issued.Name = "When_issued";
            this.When_issued.Size = new System.Drawing.Size(100, 20);
            this.When_issued.TabIndex = 7;
            this.When_issued.ValidatingType = typeof(System.DateTime);
            this.When_issued.Leave += new System.EventHandler(this.date_check);
            // 
            // error_invent
            // 
            this.error_invent.AutoSize = true;
            this.error_invent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_invent.ForeColor = System.Drawing.Color.Red;
            this.error_invent.Location = new System.Drawing.Point(929, 605);
            this.error_invent.Name = "error_invent";
            this.error_invent.Size = new System.Drawing.Size(0, 20);
            this.error_invent.TabIndex = 47;
            this.error_invent.Visible = false;
            // 
            // report_card_number
            // 
            this.report_card_number.Location = new System.Drawing.Point(977, 158);
            this.report_card_number.MaxLength = 128;
            this.report_card_number.Name = "report_card_number";
            this.report_card_number.Size = new System.Drawing.Size(102, 20);
            this.report_card_number.TabIndex = 9;
            this.report_card_number.Leave += new System.EventHandler(this.report_card_number_Leave);
            // 
            // komnata
            // 
            this.komnata.CausesValidation = false;
            this.komnata.InterceptArrowKeys = false;
            this.komnata.Location = new System.Drawing.Point(52, 60);
            this.komnata.Name = "komnata";
            this.komnata.Size = new System.Drawing.Size(120, 20);
            this.komnata.TabIndex = 1;
            // 
            // set_invent_bd
            // 
            this.set_invent_bd.Location = new System.Drawing.Point(1144, 569);
            this.set_invent_bd.Name = "set_invent_bd";
            this.set_invent_bd.Size = new System.Drawing.Size(91, 23);
            this.set_invent_bd.TabIndex = 46;
            this.set_invent_bd.TabStop = false;
            this.set_invent_bd.Text = "Создать ";
            this.set_invent_bd.UseVisualStyleBackColor = true;
            this.set_invent_bd.Click += new System.EventHandler(this.set_invent_bd_Click);
            // 
            // set_invent
            // 
            this.set_invent.Location = new System.Drawing.Point(933, 573);
            this.set_invent.MaxLength = 11;
            this.set_invent.Name = "set_invent";
            this.set_invent.Size = new System.Drawing.Size(163, 20);
            this.set_invent.TabIndex = 45;
            this.set_invent.TabStop = false;
            // 
            // invent
            // 
            this.invent.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.invent.AllowUserToAddRows = false;
            this.invent.AllowUserToDeleteRows = false;
            this.invent.BackgroundColor = System.Drawing.Color.White;
            this.invent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invent.CausesValidation = false;
            this.invent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name_invent,
            this.kolvo});
            this.invent.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.invent.Location = new System.Drawing.Point(900, 306);
            this.invent.Name = "invent";
            this.invent.Size = new System.Drawing.Size(367, 158);
            this.invent.TabIndex = 13;
            this.invent.TabStop = false;
            this.invent.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.invent_CellBeginEdit);
            this.invent.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.invent_CellEndEdit);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.set_full);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 672);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1299, 67);
            this.panel3.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(822, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 38);
            this.button3.TabIndex = 15;
            this.button3.TabStop = false;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // set_full
            // 
            this.set_full.Location = new System.Drawing.Point(542, 21);
            this.set_full.Name = "set_full";
            this.set_full.Size = new System.Drawing.Size(200, 38);
            this.set_full.TabIndex = 14;
            this.set_full.Text = "Создать";
            this.set_full.UseVisualStyleBackColor = true;
            this.set_full.Click += new System.EventHandler(this.set_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(67, 545);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(60, 20);
            this.error.TabIndex = 34;
            this.error.Text = "label14";
            this.error.Visible = false;
            // 
            // organization
            // 
            this.organization.Location = new System.Drawing.Point(55, 400);
            this.organization.MaxLength = 64;
            this.organization.Name = "organization";
            this.organization.Size = new System.Drawing.Size(206, 20);
            this.organization.TabIndex = 11;
            // 
            // specialty
            // 
            this.specialty.Location = new System.Drawing.Point(370, 400);
            this.specialty.MaxLength = 64;
            this.specialty.Name = "specialty";
            this.specialty.Size = new System.Drawing.Size(206, 20);
            this.specialty.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(51, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = " Организация";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(366, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Специальность";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // id
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.Frozen = true;
            this.id.HeaderText = "номер";
            this.id.MaxInputLength = 11;
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Visible = false;
            // 
            // name_invent
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.name_invent.DefaultCellStyle = dataGridViewCellStyle2;
            this.name_invent.Frozen = true;
            this.name_invent.HeaderText = "название";
            this.name_invent.MaxInputLength = 128;
            this.name_invent.Name = "name_invent";
            this.name_invent.ReadOnly = true;
            // 
            // kolvo
            // 
            this.kolvo.HeaderText = "кол-во";
            this.kolvo.MaxInputLength = 11;
            this.kolvo.Name = "kolvo";
            this.kolvo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // set_man
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 759);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1280, 680);
            this.Name = "set_man";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Text = "Создание";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.set_man_FormClosed);
            this.Load += new System.EventHandler(this.set_man_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.komnata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invent)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox sumname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox pasport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox issued_by;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox phone_number;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button set_full;
        private System.Windows.Forms.TextBox organization;
        private System.Windows.Forms.TextBox specialty;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView invent;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.Button set_invent_bd;
        private System.Windows.Forms.TextBox set_invent;
        private System.Windows.Forms.NumericUpDown komnata;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox report_card_number;
        private System.Windows.Forms.Label error_invent;
        private System.Windows.Forms.MaskedTextBox year_of_birth;
        private System.Windows.Forms.MaskedTextBox When_issued;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_invent;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvo;
    }
}

