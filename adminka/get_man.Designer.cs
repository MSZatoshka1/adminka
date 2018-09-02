namespace adminka
{
    partial class get_man
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
            this.year_of_birth = new System.Windows.Forms.MaskedTextBox();
            this.when_issued = new System.Windows.Forms.MaskedTextBox();
            this.kom = new System.Windows.Forms.NumericUpDown();
            this.problit = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.issued_by = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.passport = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.report_card_number = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.specialty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.organization = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.check_invent = new System.Windows.Forms.Label();
            this.check_man = new System.Windows.Forms.Label();
            this.phone_number = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.year_of_birth);
            this.panel1.Controls.Add(this.when_issued);
            this.panel1.Controls.Add(this.kom);
            this.panel1.Controls.Add(this.problit);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.issued_by);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.passport);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.report_card_number);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.specialty);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.organization);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.check_invent);
            this.panel1.Controls.Add(this.check_man);
            this.panel1.Controls.Add(this.phone_number);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.patronymic);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.subname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 738);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // year_of_birth
            // 
            this.year_of_birth.Location = new System.Drawing.Point(178, 140);
            this.year_of_birth.Mask = "00/00/0000";
            this.year_of_birth.Name = "year_of_birth";
            this.year_of_birth.Size = new System.Drawing.Size(100, 20);
            this.year_of_birth.TabIndex = 4;
            this.year_of_birth.ValidatingType = typeof(System.DateTime);
            this.year_of_birth.Enter += new System.EventHandler(this.focus_on);
            this.year_of_birth.Leave += new System.EventHandler(this.focus_off);
            this.year_of_birth.Leave += new System.EventHandler(this.date_check);
            // 
            // when_issued
            // 
            this.when_issued.Location = new System.Drawing.Point(476, 359);
            this.when_issued.Mask = "00/00/0000";
            this.when_issued.Name = "when_issued";
            this.when_issued.Size = new System.Drawing.Size(100, 20);
            this.when_issued.TabIndex = 10;
            this.when_issued.ValidatingType = typeof(System.DateTime);
            this.when_issued.Enter += new System.EventHandler(this.focus_on);
            this.when_issued.Leave += new System.EventHandler(this.focus_off);
            this.when_issued.Leave += new System.EventHandler(this.date_check);
            // 
            // kom
            // 
            this.kom.CausesValidation = false;
            this.kom.InterceptArrowKeys = false;
            this.kom.Location = new System.Drawing.Point(728, 632);
            this.kom.Name = "kom";
            this.kom.Size = new System.Drawing.Size(120, 20);
            this.kom.TabIndex = 13;
            // 
            // problit
            // 
            this.problit.Location = new System.Drawing.Point(737, 671);
            this.problit.Name = "problit";
            this.problit.Size = new System.Drawing.Size(97, 47);
            this.problit.TabIndex = 14;
            this.problit.Text = "Продлить";
            this.problit.UseVisualStyleBackColor = true;
            this.problit.Click += new System.EventHandler(this.problit_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1082, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 41);
            this.button6.TabIndex = 16;
            this.button6.Text = "Инвентарь";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1082, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 41);
            this.button5.TabIndex = 56;
            this.button5.TabStop = false;
            this.button5.Text = "время присутствия";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1174, 671);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 47);
            this.button3.TabIndex = 15;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // issued_by
            // 
            this.issued_by.Location = new System.Drawing.Point(46, 449);
            this.issued_by.Name = "issued_by";
            this.issued_by.Size = new System.Drawing.Size(926, 69);
            this.issued_by.TabIndex = 11;
            this.issued_by.Text = "";
            this.issued_by.Enter += new System.EventHandler(this.focus_on);
            this.issued_by.Leave += new System.EventHandler(this.focus_off);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(42, 404);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "Выдан";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(334, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 48;
            this.label14.Text = "Дата выдачи";
            // 
            // passport
            // 
            this.passport.Location = new System.Drawing.Point(204, 357);
            this.passport.Mask = "00_00_000000";
            this.passport.Name = "passport";
            this.passport.Size = new System.Drawing.Size(100, 20);
            this.passport.TabIndex = 9;
            this.passport.Leave += new System.EventHandler(this.passport_Leave);
            this.passport.Enter += new System.EventHandler(this.focus_on);
            this.passport.Leave += new System.EventHandler(this.focus_off);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(42, 357);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 20);
            this.label15.TabIndex = 46;
            this.label15.Text = "Номер паспорта";
            // 
            // report_card_number
            // 
            this.report_card_number.Location = new System.Drawing.Point(389, 186);
            this.report_card_number.Name = "report_card_number";
            this.report_card_number.Size = new System.Drawing.Size(99, 20);
            this.report_card_number.TabIndex = 6;
            this.report_card_number.Leave += new System.EventHandler(this.report_card_number_Leave);
            this.report_card_number.Enter += new System.EventHandler(this.focus_on);
            this.report_card_number.Leave += new System.EventHandler(this.focus_off);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(290, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "№ Табеля";
            // 
            // specialty
            // 
            this.specialty.Location = new System.Drawing.Point(178, 281);
            this.specialty.Name = "specialty";
            this.specialty.Size = new System.Drawing.Size(310, 20);
            this.specialty.TabIndex = 8;
            this.specialty.Enter += new System.EventHandler(this.focus_on);
            this.specialty.Leave += new System.EventHandler(this.focus_off);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(44, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Специальность";
            // 
            // organization
            // 
            this.organization.Location = new System.Drawing.Point(178, 240);
            this.organization.Name = "organization";
            this.organization.Size = new System.Drawing.Size(310, 20);
            this.organization.TabIndex = 7;
            this.organization.Enter += new System.EventHandler(this.focus_on);
            this.organization.Leave += new System.EventHandler(this.focus_off);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(44, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Организация";
            // 
            // check_invent
            // 
            this.check_invent.AutoSize = true;
            this.check_invent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_invent.ForeColor = System.Drawing.Color.Black;
            this.check_invent.Location = new System.Drawing.Point(610, 68);
            this.check_invent.Name = "check_invent";
            this.check_invent.Size = new System.Drawing.Size(0, 25);
            this.check_invent.TabIndex = 24;
            this.check_invent.Visible = false;
            // 
            // check_man
            // 
            this.check_man.AutoSize = true;
            this.check_man.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_man.ForeColor = System.Drawing.Color.Black;
            this.check_man.Location = new System.Drawing.Point(605, 31);
            this.check_man.Name = "check_man";
            this.check_man.Size = new System.Drawing.Size(0, 25);
            this.check_man.TabIndex = 23;
            this.check_man.Visible = false;
            // 
            // phone_number
            // 
            this.phone_number.Location = new System.Drawing.Point(156, 188);
            this.phone_number.Mask = "+7000_000_00_00";
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(100, 20);
            this.phone_number.TabIndex = 5;
            this.phone_number.Enter += new System.EventHandler(this.focus_on);
            this.phone_number.Enter += new System.EventHandler(this.focus_off);
            this.phone_number.Leave += new System.EventHandler(this.phone_number_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(44, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "№ Телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(42, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Год рождения";
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(131, 103);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(242, 20);
            this.patronymic.TabIndex = 3;
            this.patronymic.Enter += new System.EventHandler(this.focus_on);
            this.patronymic.Leave += new System.EventHandler(this.focus_off);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(131, 68);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(242, 20);
            this.name.TabIndex = 2;
            this.name.Enter += new System.EventHandler(this.focus_on);
            this.name.Leave += new System.EventHandler(this.focus_off);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // subname
            // 
            this.subname.Location = new System.Drawing.Point(131, 31);
            this.subname.Name = "subname";
            this.subname.Size = new System.Drawing.Size(242, 20);
            this.subname.TabIndex = 1;
            this.subname.Enter += new System.EventHandler(this.focus_on);
            this.subname.Leave += new System.EventHandler(this.focus_off);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // get_man
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 814);
            this.Controls.Add(this.panel1);
            this.Name = "get_man";
            this.Text = "Клиент";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.get_man_FormClosed);
            this.Load += new System.EventHandler(this.get_man_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox subname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox phone_number;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label check_man;
        private System.Windows.Forms.Label check_invent;
        private System.Windows.Forms.TextBox organization;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox specialty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox report_card_number;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox issued_by;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox passport;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button problit;
        private System.Windows.Forms.NumericUpDown kom;
        private System.Windows.Forms.MaskedTextBox year_of_birth;
        private System.Windows.Forms.MaskedTextBox when_issued;
    }
}