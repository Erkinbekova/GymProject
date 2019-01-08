namespace Gym
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.абонементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абонементыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видАбонементаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.штатноеРасписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.штатноеРаспиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоАбонементуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSchedule = new System.Windows.Forms.Button();
            this.editSchedule = new System.Windows.Forms.Button();
            this.delSchedule = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Group = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.Employee = new System.Windows.Forms.Label();
            this.Staff = new System.Windows.Forms.Label();
            this.textBoxEmployee = new System.Windows.Forms.TextBox();
            this.textBoxStaff = new System.Windows.Forms.TextBox();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.вРЕМЯDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCHEDULEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGym = new Gym.DataGym();
            this.txtId = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sCHEDULEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGymBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCHEDULETableAdapter = new Gym.DataGymTableAdapters.SCHEDULETableAdapter();
            this.sCHEDULEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распечататьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCHEDULEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCHEDULEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGymBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCHEDULEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.абонементToolStripMenuItem,
            this.группаToolStripMenuItem,
            this.штатноеРасписаниеToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.отчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // абонементToolStripMenuItem
            // 
            this.абонементToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.абонементыToolStripMenuItem,
            this.видАбонементаToolStripMenuItem});
            this.абонементToolStripMenuItem.Name = "абонементToolStripMenuItem";
            this.абонементToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.абонементToolStripMenuItem.Text = "Абонемент";
            // 
            // абонементыToolStripMenuItem
            // 
            this.абонементыToolStripMenuItem.Name = "абонементыToolStripMenuItem";
            this.абонементыToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.абонементыToolStripMenuItem.Text = "Абонементы";
            this.абонементыToolStripMenuItem.Click += new System.EventHandler(this.абонементыToolStripMenuItem_Click);
            // 
            // видАбонементаToolStripMenuItem
            // 
            this.видАбонементаToolStripMenuItem.Name = "видАбонементаToolStripMenuItem";
            this.видАбонементаToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.видАбонементаToolStripMenuItem.Text = "Вид абонемента";
            this.видАбонементаToolStripMenuItem.Click += new System.EventHandler(this.видАбонементаToolStripMenuItem_Click);
            // 
            // группаToolStripMenuItem
            // 
            this.группаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.группыToolStripMenuItem});
            this.группаToolStripMenuItem.Name = "группаToolStripMenuItem";
            this.группаToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.группаToolStripMenuItem.Text = "Группа";
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.группыToolStripMenuItem.Text = "Группы";
            this.группыToolStripMenuItem.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // штатноеРасписаниеToolStripMenuItem
            // 
            this.штатноеРасписаниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.штатноеРаспиеToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.штатноеРасписаниеToolStripMenuItem.Name = "штатноеРасписаниеToolStripMenuItem";
            this.штатноеРасписаниеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.штатноеРасписаниеToolStripMenuItem.Text = "Штатное расписание";
            // 
            // штатноеРаспиеToolStripMenuItem
            // 
            this.штатноеРаспиеToolStripMenuItem.Name = "штатноеРаспиеToolStripMenuItem";
            this.штатноеРаспиеToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.штатноеРаспиеToolStripMenuItem.Text = "Штатное расп-ие";
            this.штатноеРаспиеToolStripMenuItem.Click += new System.EventHandler(this.штатноеРаспиеToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоАбонементуToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поискПоАбонементуToolStripMenuItem
            // 
            this.поискПоАбонементуToolStripMenuItem.Name = "поискПоАбонементуToolStripMenuItem";
            this.поискПоАбонементуToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.поискПоАбонементуToolStripMenuItem.Text = "Поиск по абонементу";
            this.поискПоАбонементуToolStripMenuItem.Click += new System.EventHandler(this.поискПоАбонементуToolStripMenuItem_Click);
            // 
            // addSchedule
            // 
            this.addSchedule.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSchedule.Location = new System.Drawing.Point(666, 128);
            this.addSchedule.Name = "addSchedule";
            this.addSchedule.Size = new System.Drawing.Size(75, 40);
            this.addSchedule.TabIndex = 2;
            this.addSchedule.Text = "Добавить";
            this.addSchedule.UseVisualStyleBackColor = true;
            this.addSchedule.Click += new System.EventHandler(this.addSchedule_Click);
            // 
            // editSchedule
            // 
            this.editSchedule.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editSchedule.Location = new System.Drawing.Point(666, 228);
            this.editSchedule.Name = "editSchedule";
            this.editSchedule.Size = new System.Drawing.Size(75, 40);
            this.editSchedule.TabIndex = 3;
            this.editSchedule.Text = "Изменить";
            this.editSchedule.UseVisualStyleBackColor = true;
            this.editSchedule.Click += new System.EventHandler(this.editSchedule_Click);
            // 
            // delSchedule
            // 
            this.delSchedule.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delSchedule.Location = new System.Drawing.Point(666, 328);
            this.delSchedule.Name = "delSchedule";
            this.delSchedule.Size = new System.Drawing.Size(75, 40);
            this.delSchedule.TabIndex = 4;
            this.delSchedule.Text = "Удалить";
            this.delSchedule.UseVisualStyleBackColor = true;
            this.delSchedule.Click += new System.EventHandler(this.delSchedule_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(25, 453);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(71, 23);
            this.Time.TabIndex = 6;
            this.Time.Text = "Время";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 455);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Group
            // 
            this.Group.AutoSize = true;
            this.Group.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group.Location = new System.Drawing.Point(25, 530);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(78, 23);
            this.Group.TabIndex = 8;
            this.Group.Text = "Группа";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(129, 533);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(200, 20);
            this.textBoxGroup.TabIndex = 9;
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employee.Location = new System.Drawing.Point(435, 453);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(115, 23);
            this.Employee.TabIndex = 10;
            this.Employee.Text = "Сотрудник";
            // 
            // Staff
            // 
            this.Staff.AutoSize = true;
            this.Staff.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Staff.Location = new System.Drawing.Point(435, 533);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(117, 23);
            this.Staff.TabIndex = 11;
            this.Staff.Text = "Должность";
            // 
            // textBoxEmployee
            // 
            this.textBoxEmployee.Location = new System.Drawing.Point(578, 455);
            this.textBoxEmployee.Name = "textBoxEmployee";
            this.textBoxEmployee.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmployee.TabIndex = 12;
            // 
            // textBoxStaff
            // 
            this.textBoxStaff.Location = new System.Drawing.Point(578, 533);
            this.textBoxStaff.Name = "textBoxStaff";
            this.textBoxStaff.Size = new System.Drawing.Size(200, 20);
            this.textBoxStaff.TabIndex = 13;
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AutoGenerateColumns = false;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.вРЕМЯDataGridViewTextBoxColumn,
            this.iDGDataGridViewTextBoxColumn,
            this.iDSDataGridViewTextBoxColumn,
            this.iDDDataGridViewTextBoxColumn});
            this.dataGridViewSchedule.DataSource = this.sCHEDULEBindingSource2;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(85, 86);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.Size = new System.Drawing.Size(445, 326);
            this.dataGridViewSchedule.TabIndex = 14;
            this.dataGridViewSchedule.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewSchedule_MouseClick);
            // 
            // вРЕМЯDataGridViewTextBoxColumn
            // 
            this.вРЕМЯDataGridViewTextBoxColumn.DataPropertyName = "ВРЕМЯ";
            this.вРЕМЯDataGridViewTextBoxColumn.HeaderText = "ВРЕМЯ";
            this.вРЕМЯDataGridViewTextBoxColumn.Name = "вРЕМЯDataGridViewTextBoxColumn";
            // 
            // iDGDataGridViewTextBoxColumn
            // 
            this.iDGDataGridViewTextBoxColumn.DataPropertyName = "ID_G";
            this.iDGDataGridViewTextBoxColumn.HeaderText = "ID_G";
            this.iDGDataGridViewTextBoxColumn.Name = "iDGDataGridViewTextBoxColumn";
            // 
            // iDSDataGridViewTextBoxColumn
            // 
            this.iDSDataGridViewTextBoxColumn.DataPropertyName = "ID_S";
            this.iDSDataGridViewTextBoxColumn.HeaderText = "ID_S";
            this.iDSDataGridViewTextBoxColumn.Name = "iDSDataGridViewTextBoxColumn";
            // 
            // iDDDataGridViewTextBoxColumn
            // 
            this.iDDDataGridViewTextBoxColumn.DataPropertyName = "ID_D";
            this.iDDDataGridViewTextBoxColumn.HeaderText = "ID_D";
            this.iDDDataGridViewTextBoxColumn.Name = "iDDDataGridViewTextBoxColumn";
            // 
            // sCHEDULEBindingSource2
            // 
            this.sCHEDULEBindingSource2.DataMember = "SCHEDULE";
            this.sCHEDULEBindingSource2.DataSource = this.dataGym;
            // 
            // dataGym
            // 
            this.dataGym.DataSetName = "DataGym";
            this.dataGym.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(606, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 15;
            this.txtId.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "crossfit01.jpg");
            // 
            // sCHEDULEBindingSource
            // 
            this.sCHEDULEBindingSource.DataMember = "SCHEDULE";
            this.sCHEDULEBindingSource.DataSource = this.dataGym;
            // 
            // dataGymBindingSource
            // 
            this.dataGymBindingSource.DataSource = this.dataGym;
            this.dataGymBindingSource.Position = 0;
            // 
            // sCHEDULETableAdapter
            // 
            this.sCHEDULETableAdapter.ClearBeforeFill = true;
            // 
            // sCHEDULEBindingSource1
            // 
            this.sCHEDULEBindingSource1.DataMember = "SCHEDULE";
            this.sCHEDULEBindingSource1.DataSource = this.dataGym;
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.распечататьОтчетToolStripMenuItem});
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            // 
            // распечататьОтчетToolStripMenuItem
            // 
            this.распечататьОтчетToolStripMenuItem.Name = "распечататьОтчетToolStripMenuItem";
            this.распечататьОтчетToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.распечататьОтчетToolStripMenuItem.Text = "Распечатать отчет";
            this.распечататьОтчетToolStripMenuItem.Click += new System.EventHandler(this.распечататьОтчетToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.textBoxStaff);
            this.Controls.Add(this.textBoxEmployee);
            this.Controls.Add(this.Staff);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.delSchedule);
            this.Controls.Add(this.editSchedule);
            this.Controls.Add(this.addSchedule);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCHEDULEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCHEDULEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGymBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCHEDULEBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem абонементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонементыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видАбонементаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem штатноеРасписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem штатноеРаспиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.BindingSource dataGymBindingSource;
        private DataGym dataGym;
        private System.Windows.Forms.Button addSchedule;
        private System.Windows.Forms.Button editSchedule;
        private System.Windows.Forms.Button delSchedule;
        private System.Windows.Forms.BindingSource sCHEDULEBindingSource;
        private DataGymTableAdapters.SCHEDULETableAdapter sCHEDULETableAdapter;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Group;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.Label Staff;
        private System.Windows.Forms.TextBox textBoxEmployee;
        private System.Windows.Forms.TextBox textBoxStaff;
        private System.Windows.Forms.BindingSource sCHEDULEBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn вРЕМЯDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sCHEDULEBindingSource2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоАбонементуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem распечататьОтчетToolStripMenuItem;
    }
}