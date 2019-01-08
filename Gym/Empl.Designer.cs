namespace Gym
{
    partial class Empl
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
            this.dataGridEmp = new System.Windows.Forms.DataGridView();
            this.iDCОТРDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иМЯDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фАМИЛИЯDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тЕЛЕФОНDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рОЛЬDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGym = new Gym.DataGym();
            this.eMPLOYEETableAdapter = new Gym.DataGymTableAdapters.EMPLOYEETableAdapter();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxId_d = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.role = new System.Windows.Forms.Label();
            this.id_d = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btnDelEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmp
            // 
            this.dataGridEmp.AutoGenerateColumns = false;
            this.dataGridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCОТРDataGridViewTextBoxColumn,
            this.иМЯDataGridViewTextBoxColumn,
            this.фАМИЛИЯDataGridViewTextBoxColumn,
            this.тЕЛЕФОНDataGridViewTextBoxColumn,
            this.iDDDataGridViewTextBoxColumn,
            this.рОЛЬDataGridViewTextBoxColumn});
            this.dataGridEmp.DataSource = this.eMPLOYEEBindingSource;
            this.dataGridEmp.Location = new System.Drawing.Point(50, 44);
            this.dataGridEmp.Name = "dataGridEmp";
            this.dataGridEmp.Size = new System.Drawing.Size(645, 344);
            this.dataGridEmp.TabIndex = 0;
            this.dataGridEmp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridEmp_MouseClick);
            // 
            // iDCОТРDataGridViewTextBoxColumn
            // 
            this.iDCОТРDataGridViewTextBoxColumn.DataPropertyName = "ID_CОТР";
            this.iDCОТРDataGridViewTextBoxColumn.HeaderText = "ID_CОТР";
            this.iDCОТРDataGridViewTextBoxColumn.Name = "iDCОТРDataGridViewTextBoxColumn";
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
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(699, 514);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(149, 20);
            this.textBoxRole.TabIndex = 21;
            // 
            // textBoxId_d
            // 
            this.textBoxId_d.Location = new System.Drawing.Point(463, 581);
            this.textBoxId_d.Name = "textBoxId_d";
            this.textBoxId_d.Size = new System.Drawing.Size(149, 20);
            this.textBoxId_d.TabIndex = 20;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(463, 452);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(149, 20);
            this.textBoxNumber.TabIndex = 19;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(122, 576);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(149, 20);
            this.textBoxSurname.TabIndex = 18;
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.role.Location = new System.Drawing.Point(628, 514);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(53, 23);
            this.role.TabIndex = 17;
            this.role.Text = "Роль";
            // 
            // id_d
            // 
            this.id_d.AutoSize = true;
            this.id_d.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_d.Location = new System.Drawing.Point(303, 576);
            this.id_d.Name = "id_d";
            this.id_d.Size = new System.Drawing.Size(146, 23);
            this.id_d.TabIndex = 16;
            this.id_d.Text = "ID_Должности";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(327, 452);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(94, 23);
            this.Number.TabIndex = 15;
            this.Number.Text = "Телефон";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(12, 573);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(94, 23);
            this.Surname.TabIndex = 14;
            this.Surname.Text = "Фамилия";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(122, 452);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(149, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(12, 452);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(48, 23);
            this.name.TabIndex = 12;
            this.name.Text = "Имя";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(748, 44);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(52, 20);
            this.textBoxId.TabIndex = 22;
            this.textBoxId.Visible = false;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEmp.Location = new System.Drawing.Point(748, 90);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(75, 40);
            this.btnAddEmp.TabIndex = 23;
            this.btnAddEmp.Text = "Добавить";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditEmp.Location = new System.Drawing.Point(748, 201);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(75, 40);
            this.btnEditEmp.TabIndex = 24;
            this.btnEditEmp.Text = "Изменить";
            this.btnEditEmp.UseVisualStyleBackColor = true;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // btnDelEmp
            // 
            this.btnDelEmp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelEmp.Location = new System.Drawing.Point(748, 310);
            this.btnDelEmp.Name = "btnDelEmp";
            this.btnDelEmp.Size = new System.Drawing.Size(75, 40);
            this.btnDelEmp.TabIndex = 25;
            this.btnDelEmp.Text = "Удалить";
            this.btnDelEmp.UseVisualStyleBackColor = true;
            this.btnDelEmp.Click += new System.EventHandler(this.btnDelEmp_Click);
            // 
            // Empl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnDelEmp);
            this.Controls.Add(this.btnEditEmp);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxId_d);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.role);
            this.Controls.Add(this.id_d);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dataGridEmp);
            this.Name = "Empl";
            this.Text = "Empl";
            this.Load += new System.EventHandler(this.Empl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEmp;
        private DataGym dataGym;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private DataGymTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCОТРDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иМЯDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фАМИЛИЯDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тЕЛЕФОНDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рОЛЬDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.TextBox textBoxId_d;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label id_d;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btnDelEmp;
    }
}