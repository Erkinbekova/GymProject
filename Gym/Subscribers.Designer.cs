namespace Gym
{
    partial class Subscribers
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
            this.dataGridViewSub = new System.Windows.Forms.DataGridView();
            this.iDАБОНЕМЕНТАDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иМЯDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фАМИЛИЯDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дАТАРОЖДЕНИЯDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тЕЛЕФОНDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пОЛDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дАТАВЫДАЧИDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGym = new Gym.DataGym();
            this.sUBTableAdapter = new Gym.DataGymTableAdapters.SUBTableAdapter();
            this.btnAddSub = new System.Windows.Forms.Button();
            this.btnEditSub = new System.Windows.Forms.Button();
            this.btnDelSub = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNam = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.Birth = new System.Windows.Forms.Label();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.Number = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSub
            // 
            this.dataGridViewSub.AutoGenerateColumns = false;
            this.dataGridViewSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDАБОНЕМЕНТАDataGridViewTextBoxColumn,
            this.иМЯDataGridViewTextBoxColumn,
            this.фАМИЛИЯDataGridViewTextBoxColumn,
            this.дАТАРОЖДЕНИЯDataGridViewTextBoxColumn,
            this.тЕЛЕФОНDataGridViewTextBoxColumn,
            this.пОЛDataGridViewTextBoxColumn,
            this.дАТАВЫДАЧИDataGridViewTextBoxColumn});
            this.dataGridViewSub.DataSource = this.sUBBindingSource;
            this.dataGridViewSub.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSub.Name = "dataGridViewSub";
            this.dataGridViewSub.Size = new System.Drawing.Size(743, 335);
            this.dataGridViewSub.TabIndex = 0;
            this.dataGridViewSub.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewSub_MouseClick);
            // 
            // iDАБОНЕМЕНТАDataGridViewTextBoxColumn
            // 
            this.iDАБОНЕМЕНТАDataGridViewTextBoxColumn.DataPropertyName = "ID_АБОНЕМЕНТА";
            this.iDАБОНЕМЕНТАDataGridViewTextBoxColumn.HeaderText = "ID_АБОНЕМЕНТА";
            this.iDАБОНЕМЕНТАDataGridViewTextBoxColumn.Name = "iDАБОНЕМЕНТАDataGridViewTextBoxColumn";
            // 
            // иМЯDataGridViewTextBoxColumn
            // 
            this.иМЯDataGridViewTextBoxColumn.DataPropertyName = "ИМЯ";
            this.иМЯDataGridViewTextBoxColumn.HeaderText = "ИМЯ";
            this.иМЯDataGridViewTextBoxColumn.Name = "иМЯDataGridViewTextBoxColumn";
            // 
            // фАМИЛИЯDataGridViewTextBoxColumn
            // 
            this.фАМИЛИЯDataGridViewTextBoxColumn.DataPropertyName = "ФАМИЛИЯ";
            this.фАМИЛИЯDataGridViewTextBoxColumn.HeaderText = "ФАМИЛИЯ";
            this.фАМИЛИЯDataGridViewTextBoxColumn.Name = "фАМИЛИЯDataGridViewTextBoxColumn";
            // 
            // дАТАРОЖДЕНИЯDataGridViewTextBoxColumn
            // 
            this.дАТАРОЖДЕНИЯDataGridViewTextBoxColumn.DataPropertyName = "ДАТА_РОЖДЕНИЯ";
            this.дАТАРОЖДЕНИЯDataGridViewTextBoxColumn.HeaderText = "ДАТА_РОЖДЕНИЯ";
            this.дАТАРОЖДЕНИЯDataGridViewTextBoxColumn.Name = "дАТАРОЖДЕНИЯDataGridViewTextBoxColumn";
            // 
            // тЕЛЕФОНDataGridViewTextBoxColumn
            // 
            this.тЕЛЕФОНDataGridViewTextBoxColumn.DataPropertyName = "ТЕЛЕФОН";
            this.тЕЛЕФОНDataGridViewTextBoxColumn.HeaderText = "ТЕЛЕФОН";
            this.тЕЛЕФОНDataGridViewTextBoxColumn.Name = "тЕЛЕФОНDataGridViewTextBoxColumn";
            // 
            // пОЛDataGridViewTextBoxColumn
            // 
            this.пОЛDataGridViewTextBoxColumn.DataPropertyName = "ПОЛ";
            this.пОЛDataGridViewTextBoxColumn.HeaderText = "ПОЛ";
            this.пОЛDataGridViewTextBoxColumn.Name = "пОЛDataGridViewTextBoxColumn";
            // 
            // дАТАВЫДАЧИDataGridViewTextBoxColumn
            // 
            this.дАТАВЫДАЧИDataGridViewTextBoxColumn.DataPropertyName = "ДАТА_ВЫДАЧИ";
            this.дАТАВЫДАЧИDataGridViewTextBoxColumn.HeaderText = "ДАТА_ВЫДАЧИ";
            this.дАТАВЫДАЧИDataGridViewTextBoxColumn.Name = "дАТАВЫДАЧИDataGridViewTextBoxColumn";
            // 
            // sUBBindingSource
            // 
            this.sUBBindingSource.DataMember = "SUB";
            this.sUBBindingSource.DataSource = this.dataGym;
            // 
            // dataGym
            // 
            this.dataGym.DataSetName = "DataGym";
            this.dataGym.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUBTableAdapter
            // 
            this.sUBTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddSub
            // 
            this.btnAddSub.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSub.Location = new System.Drawing.Point(784, 85);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(75, 40);
            this.btnAddSub.TabIndex = 1;
            this.btnAddSub.Text = "Добавить";
            this.btnAddSub.UseVisualStyleBackColor = true;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            // 
            // btnEditSub
            // 
            this.btnEditSub.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSub.Location = new System.Drawing.Point(784, 170);
            this.btnEditSub.Name = "btnEditSub";
            this.btnEditSub.Size = new System.Drawing.Size(75, 40);
            this.btnEditSub.TabIndex = 2;
            this.btnEditSub.Text = "Изменить";
            this.btnEditSub.UseVisualStyleBackColor = true;
            this.btnEditSub.Click += new System.EventHandler(this.btnEditSub_Click);
            // 
            // btnDelSub
            // 
            this.btnDelSub.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelSub.Location = new System.Drawing.Point(784, 257);
            this.btnDelSub.Name = "btnDelSub";
            this.btnDelSub.Size = new System.Drawing.Size(75, 40);
            this.btnDelSub.TabIndex = 3;
            this.btnDelSub.Text = "Удалить";
            this.btnDelSub.UseVisualStyleBackColor = true;
            this.btnDelSub.Click += new System.EventHandler(this.btnDelSub_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(31, 404);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(48, 23);
            this.Name.TabIndex = 4;
            this.Name.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(135, 409);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(0, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxNam
            // 
            this.textBoxNam.Location = new System.Drawing.Point(210, 402);
            this.textBoxNam.Name = "textBoxNam";
            this.textBoxNam.Size = new System.Drawing.Size(160, 20);
            this.textBoxNam.TabIndex = 6;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(31, 476);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(94, 23);
            this.Surname.TabIndex = 7;
            this.Surname.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(210, 476);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(160, 20);
            this.textBoxSurname.TabIndex = 8;
            // 
            // Birth
            // 
            this.Birth.AutoSize = true;
            this.Birth.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birth.Location = new System.Drawing.Point(31, 549);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(173, 23);
            this.Birth.TabIndex = 9;
            this.Birth.Text = "Дата рожденния";
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(210, 552);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerBirth.TabIndex = 10;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(437, 397);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(94, 23);
            this.Number.TabIndex = 11;
            this.Number.Text = "Телефон";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender.Location = new System.Drawing.Point(437, 476);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(45, 23);
            this.Gender.TabIndex = 12;
            this.Gender.Text = "Пол";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(437, 549);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(138, 23);
            this.Date.TabIndex = 13;
            this.Date.Text = "Дата выдачи";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(581, 400);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(160, 20);
            this.textBoxNumber.TabIndex = 14;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(581, 551);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerDate.TabIndex = 15;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(581, 476);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(160, 20);
            this.textBoxGender.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(795, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(28, 20);
            this.txtId.TabIndex = 17;
            this.txtId.Visible = false;
            // 
            // Subscribers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.textBoxNam);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.btnDelSub);
            this.Controls.Add(this.btnEditSub);
            this.Controls.Add(this.btnAddSub);
            this.Controls.Add(this.dataGridViewSub);
         //   this.Name = "Subscribers";
            this.Text = "Subscribers";
            this.Load += new System.EventHandler(this.Subscribers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSub;
        private DataGym dataGym;
        private System.Windows.Forms.BindingSource sUBBindingSource;
        private DataGymTableAdapters.SUBTableAdapter sUBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАБОНЕМЕНТАDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иМЯDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фАМИЛИЯDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дАТАРОЖДЕНИЯDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тЕЛЕФОНDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пОЛDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дАТАВЫДАЧИDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddSub;
        private System.Windows.Forms.Button btnEditSub;
        private System.Windows.Forms.Button btnDelSub;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNam;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label Birth;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox txtId;
    }
}