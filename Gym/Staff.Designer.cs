namespace Gym
{
    partial class Staff
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
            this.dataGym = new Gym.DataGym();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFTableAdapter = new Gym.DataGymTableAdapters.STAFFTableAdapter();
            this.sTAFFBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.title = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.education = new System.Windows.Forms.Label();
            this.experience = new System.Windows.Forms.Label();
            this.textBoxEducation = new System.Windows.Forms.TextBox();
            this.textBoxExperience = new System.Windows.Forms.TextBox();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnDelStaff = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dataGridStaff = new System.Windows.Forms.DataGridView();
            this.iDДОЛЖНОСТИDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нАИМЕНОВАНИЕDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оКЛАДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оБРАЗОВАНИЕDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оПЫТDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGym
            // 
            this.dataGym.DataSetName = "DataGym";
            this.dataGym.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.dataGym;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // sTAFFBindingSource1
            // 
            this.sTAFFBindingSource1.DataMember = "STAFF";
            this.sTAFFBindingSource1.DataSource = this.dataGym;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(42, 401);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(154, 23);
            this.title.TabIndex = 1;
            this.title.Text = "Наименование";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddStaff.Location = new System.Drawing.Point(697, 79);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 40);
            this.btnAddStaff.TabIndex = 2;
            this.btnAddStaff.Text = "Добавить";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(233, 406);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(144, 20);
            this.textBoxTitle.TabIndex = 3;
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salary.Location = new System.Drawing.Point(42, 530);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(71, 23);
            this.salary.TabIndex = 4;
            this.salary.Text = "Оклад";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(233, 535);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(144, 20);
            this.textBoxSalary.TabIndex = 5;
            // 
            // education
            // 
            this.education.AutoSize = true;
            this.education.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.education.Location = new System.Drawing.Point(435, 401);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(142, 23);
            this.education.TabIndex = 6;
            this.education.Text = "Образование";
            // 
            // experience
            // 
            this.experience.AutoSize = true;
            this.experience.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.experience.Location = new System.Drawing.Point(435, 530);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(62, 23);
            this.experience.TabIndex = 7;
            this.experience.Text = "Опыт";
            // 
            // textBoxEducation
            // 
            this.textBoxEducation.Location = new System.Drawing.Point(628, 406);
            this.textBoxEducation.Name = "textBoxEducation";
            this.textBoxEducation.Size = new System.Drawing.Size(144, 20);
            this.textBoxEducation.TabIndex = 8;
            // 
            // textBoxExperience
            // 
            this.textBoxExperience.Location = new System.Drawing.Point(628, 535);
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.Size = new System.Drawing.Size(144, 20);
            this.textBoxExperience.TabIndex = 9;
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditStaff.Location = new System.Drawing.Point(697, 172);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(75, 40);
            this.btnEditStaff.TabIndex = 10;
            this.btnEditStaff.Text = "Изменить";
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnDelStaff
            // 
            this.btnDelStaff.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelStaff.Location = new System.Drawing.Point(697, 275);
            this.btnDelStaff.Name = "btnDelStaff";
            this.btnDelStaff.Size = new System.Drawing.Size(75, 40);
            this.btnDelStaff.TabIndex = 11;
            this.btnDelStaff.Text = "Удалить";
            this.btnDelStaff.UseVisualStyleBackColor = true;
            this.btnDelStaff.Click += new System.EventHandler(this.btnDelStaff_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(681, 37);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 12;
            this.textBoxId.Visible = false;
            // 
            // dataGridStaff
            // 
            this.dataGridStaff.AutoGenerateColumns = false;
            this.dataGridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDДОЛЖНОСТИDataGridViewTextBoxColumn,
            this.нАИМЕНОВАНИЕDataGridViewTextBoxColumn,
            this.оКЛАДDataGridViewTextBoxColumn,
            this.оБРАЗОВАНИЕDataGridViewTextBoxColumn,
            this.оПЫТDataGridViewTextBoxColumn});
            this.dataGridStaff.DataSource = this.sTAFFBindingSource2;
            this.dataGridStaff.Location = new System.Drawing.Point(71, 37);
            this.dataGridStaff.Name = "dataGridStaff";
            this.dataGridStaff.Size = new System.Drawing.Size(544, 313);
            this.dataGridStaff.TabIndex = 13;
            this.dataGridStaff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridStaff_MouseClick_1);
            // 
            // iDДОЛЖНОСТИDataGridViewTextBoxColumn
            // 
            this.iDДОЛЖНОСТИDataGridViewTextBoxColumn.DataPropertyName = "ID_ДОЛЖНОСТИ";
            this.iDДОЛЖНОСТИDataGridViewTextBoxColumn.HeaderText = "ID_ДОЛЖНОСТИ";
            this.iDДОЛЖНОСТИDataGridViewTextBoxColumn.Name = "iDДОЛЖНОСТИDataGridViewTextBoxColumn";
            // 
            // нАИМЕНОВАНИЕDataGridViewTextBoxColumn
            // 
            this.нАИМЕНОВАНИЕDataGridViewTextBoxColumn.DataPropertyName = "НАИМЕНОВАНИЕ";
            this.нАИМЕНОВАНИЕDataGridViewTextBoxColumn.HeaderText = "НАИМЕНОВАНИЕ";
            this.нАИМЕНОВАНИЕDataGridViewTextBoxColumn.Name = "нАИМЕНОВАНИЕDataGridViewTextBoxColumn";
            // 
            // оКЛАДDataGridViewTextBoxColumn
            // 
            this.оКЛАДDataGridViewTextBoxColumn.DataPropertyName = "ОКЛАД";
            this.оКЛАДDataGridViewTextBoxColumn.HeaderText = "ОКЛАД";
            this.оКЛАДDataGridViewTextBoxColumn.Name = "оКЛАДDataGridViewTextBoxColumn";
            // 
            // оБРАЗОВАНИЕDataGridViewTextBoxColumn
            // 
            this.оБРАЗОВАНИЕDataGridViewTextBoxColumn.DataPropertyName = "ОБРАЗОВАНИЕ";
            this.оБРАЗОВАНИЕDataGridViewTextBoxColumn.HeaderText = "ОБРАЗОВАНИЕ";
            this.оБРАЗОВАНИЕDataGridViewTextBoxColumn.Name = "оБРАЗОВАНИЕDataGridViewTextBoxColumn";
            // 
            // оПЫТDataGridViewTextBoxColumn
            // 
            this.оПЫТDataGridViewTextBoxColumn.DataPropertyName = "ОПЫТ";
            this.оПЫТDataGridViewTextBoxColumn.HeaderText = "ОПЫТ";
            this.оПЫТDataGridViewTextBoxColumn.Name = "оПЫТDataGridViewTextBoxColumn";
            // 
            // sTAFFBindingSource2
            // 
            this.sTAFFBindingSource2.DataMember = "STAFF";
            this.sTAFFBindingSource2.DataSource = this.dataGym;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.dataGridStaff);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.btnDelStaff);
            this.Controls.Add(this.btnEditStaff);
            this.Controls.Add(this.textBoxExperience);
            this.Controls.Add(this.textBoxEducation);
            this.Controls.Add(this.experience);
            this.Controls.Add(this.education);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.title);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGym dataGym;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private DataGymTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.BindingSource sTAFFBindingSource1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label education;
        private System.Windows.Forms.Label experience;
        private System.Windows.Forms.TextBox textBoxEducation;
        private System.Windows.Forms.TextBox textBoxExperience;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnDelStaff;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridView dataGridStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDДОЛЖНОСТИDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn нАИМЕНОВАНИЕDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оКЛАДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оБРАЗОВАНИЕDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оПЫТDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sTAFFBindingSource2;
    }
}