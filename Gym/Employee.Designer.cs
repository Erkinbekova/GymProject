namespace Gym
{
    partial class Employee
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
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGym = new Gym.DataGym();
            this.eMPLOYEETableAdapter = new Gym.DataGymTableAdapters.EMPLOYEETableAdapter();
            this.name = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.Surname = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.id_d = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxId_d = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btnDelEmp = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dataGridEmp = new System.Windows.Forms.DataGridView();
            this.иМЯDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фАМИЛИЯDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тЕЛЕФОНDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рОЛЬDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Gym.DataSet1();
            this.eMPLOYEEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter1 = new Gym.DataSet1TableAdapters.EMPLOYEETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.dataGym;
            // 
            // dataGym
            // 
            this.dataGym.DataSetName = "DataGym";
            this.dataGym.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(32, 446);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(48, 23);
            this.name.TabIndex = 1;
            this.name.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(132, 451);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(149, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEmp.Location = new System.Drawing.Point(748, 96);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(75, 40);
            this.btnAddEmp.TabIndex = 3;
            this.btnAddEmp.Text = "Добавить";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(32, 541);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(94, 23);
            this.Surname.TabIndex = 4;
            this.Surname.Text = "Фамилия";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(313, 446);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(94, 23);
            this.Number.TabIndex = 5;
            this.Number.Text = "Телефон";
            // 
            // id_d
            // 
            this.id_d.AutoSize = true;
            this.id_d.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_d.Location = new System.Drawing.Point(313, 541);
            this.id_d.Name = "id_d";
            this.id_d.Size = new System.Drawing.Size(146, 23);
            this.id_d.TabIndex = 6;
            this.id_d.Text = "ID_Должности";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.role.Location = new System.Drawing.Point(654, 490);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(53, 23);
            this.role.TabIndex = 7;
            this.role.Text = "Роль";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(132, 546);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(149, 20);
            this.textBoxSurname.TabIndex = 8;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(473, 446);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(149, 20);
            this.textBoxNumber.TabIndex = 9;
            // 
            // textBoxId_d
            // 
            this.textBoxId_d.Location = new System.Drawing.Point(473, 541);
            this.textBoxId_d.Name = "textBoxId_d";
            this.textBoxId_d.Size = new System.Drawing.Size(149, 20);
            this.textBoxId_d.TabIndex = 10;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(723, 490);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(149, 20);
            this.textBoxRole.TabIndex = 11;
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditEmp.Location = new System.Drawing.Point(748, 183);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(75, 40);
            this.btnEditEmp.TabIndex = 12;
            this.btnEditEmp.Text = "Изменить";
            this.btnEditEmp.UseVisualStyleBackColor = true;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // btnDelEmp
            // 
            this.btnDelEmp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelEmp.Location = new System.Drawing.Point(748, 273);
            this.btnDelEmp.Name = "btnDelEmp";
            this.btnDelEmp.Size = new System.Drawing.Size(75, 40);
            this.btnDelEmp.TabIndex = 13;
            this.btnDelEmp.Text = "Удалить";
            this.btnDelEmp.UseVisualStyleBackColor = true;
            this.btnDelEmp.Click += new System.EventHandler(this.btnDelEmp_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(748, 34);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 14;
            this.textBoxId.Visible = false;
            // 
            // dataGridEmp
            // 
            this.dataGridEmp.AutoGenerateColumns = false;
            this.dataGridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иМЯDataGridViewTextBoxColumn,
            this.фАМИЛИЯDataGridViewTextBoxColumn,
            this.тЕЛЕФОНDataGridViewTextBoxColumn,
            this.iDDDataGridViewTextBoxColumn,
            this.рОЛЬDataGridViewTextBoxColumn});
            this.dataGridEmp.DataSource = this.eMPLOYEEBindingSource3;
            this.dataGridEmp.Location = new System.Drawing.Point(41, 44);
            this.dataGridEmp.Name = "dataGridEmp";
            this.dataGridEmp.Size = new System.Drawing.Size(644, 367);
            this.dataGridEmp.TabIndex = 15;
            this.dataGridEmp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridEmp_MouseClick);
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
            // тЕЛЕФОНDataGridViewTextBoxColumn
            // 
            this.тЕЛЕФОНDataGridViewTextBoxColumn.DataPropertyName = "ТЕЛЕФОН";
            this.тЕЛЕФОНDataGridViewTextBoxColumn.HeaderText = "ТЕЛЕФОН";
            this.тЕЛЕФОНDataGridViewTextBoxColumn.Name = "тЕЛЕФОНDataGridViewTextBoxColumn";
            // 
            // iDDDataGridViewTextBoxColumn
            // 
            this.iDDDataGridViewTextBoxColumn.DataPropertyName = "ID_D";
            this.iDDDataGridViewTextBoxColumn.HeaderText = "ID_D";
            this.iDDDataGridViewTextBoxColumn.Name = "iDDDataGridViewTextBoxColumn";
            // 
            // рОЛЬDataGridViewTextBoxColumn
            // 
            this.рОЛЬDataGridViewTextBoxColumn.DataPropertyName = "РОЛЬ";
            this.рОЛЬDataGridViewTextBoxColumn.HeaderText = "РОЛЬ";
            this.рОЛЬDataGridViewTextBoxColumn.Name = "рОЛЬDataGridViewTextBoxColumn";
            // 
            // eMPLOYEEBindingSource3
            // 
            this.eMPLOYEEBindingSource3.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource3.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEEBindingSource1
            // 
            this.eMPLOYEEBindingSource1.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource1.DataSource = this.dataGym;
            // 
            // eMPLOYEEBindingSource2
            // 
            this.eMPLOYEEBindingSource2.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource2.DataSource = this.dataSet1;
            // 
            // eMPLOYEETableAdapter1
            // 
            this.eMPLOYEETableAdapter1.ClearBeforeFill = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.dataGridEmp);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.btnDelEmp);
            this.Controls.Add(this.btnEditEmp);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxId_d);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.role);
            this.Controls.Add(this.id_d);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.name);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGym dataGym;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private DataGymTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCОТРУДНИКАDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label id_d;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxId_d;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btnDelEmp;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridView dataGridEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn иМЯDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фАМИЛИЯDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тЕЛЕФОНDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рОЛЬDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource2;
        private DataSet1TableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter1;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource3;
    }
}