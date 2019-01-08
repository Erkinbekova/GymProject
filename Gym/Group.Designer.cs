namespace Gym
{
    partial class Group
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
            this.dataGridGroup = new System.Windows.Forms.DataGridView();
            this.iDГРУППЫDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нАЗВАНИЕDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тИПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGym = new Gym.DataGym();
            this.gRPTableAdapter = new Gym.DataGymTableAdapters.GRPTableAdapter();
            this.type = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.buttonEditGroup = new System.Windows.Forms.Button();
            this.buttonDelGroup = new System.Windows.Forms.Button();
            this.deleteID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGroup
            // 
            this.dataGridGroup.AutoGenerateColumns = false;
            this.dataGridGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDГРУППЫDataGridViewTextBoxColumn,
            this.нАЗВАНИЕDataGridViewTextBoxColumn,
            this.тИПDataGridViewTextBoxColumn});
            this.dataGridGroup.DataSource = this.gRPBindingSource;
            this.dataGridGroup.Location = new System.Drawing.Point(37, 54);
            this.dataGridGroup.Name = "dataGridGroup";
            this.dataGridGroup.Size = new System.Drawing.Size(451, 211);
            this.dataGridGroup.TabIndex = 0;
            this.dataGridGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridGroup_MouseClick);
            // 
            // iDГРУППЫDataGridViewTextBoxColumn
            // 
            this.iDГРУППЫDataGridViewTextBoxColumn.DataPropertyName = "ID_ГРУППЫ";
            this.iDГРУППЫDataGridViewTextBoxColumn.HeaderText = "ID_ГРУППЫ";
            this.iDГРУППЫDataGridViewTextBoxColumn.Name = "iDГРУППЫDataGridViewTextBoxColumn";
            // 
            // нАЗВАНИЕDataGridViewTextBoxColumn
            // 
            this.нАЗВАНИЕDataGridViewTextBoxColumn.DataPropertyName = "НАЗВАНИЕ";
            this.нАЗВАНИЕDataGridViewTextBoxColumn.HeaderText = "НАЗВАНИЕ";
            this.нАЗВАНИЕDataGridViewTextBoxColumn.Name = "нАЗВАНИЕDataGridViewTextBoxColumn";
            // 
            // тИПDataGridViewTextBoxColumn
            // 
            this.тИПDataGridViewTextBoxColumn.DataPropertyName = "ТИП";
            this.тИПDataGridViewTextBoxColumn.HeaderText = "ТИП";
            this.тИПDataGridViewTextBoxColumn.Name = "тИПDataGridViewTextBoxColumn";
            // 
            // gRPBindingSource
            // 
            this.gRPBindingSource.DataMember = "GRP";
            this.gRPBindingSource.DataSource = this.dataGym;
            // 
            // dataGym
            // 
            this.dataGym.DataSetName = "DataGym";
            this.dataGym.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gRPTableAdapter
            // 
            this.gRPTableAdapter.ClearBeforeFill = true;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.Location = new System.Drawing.Point(48, 497);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(40, 23);
            this.type.TabIndex = 2;
            this.type.Text = "Тип";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(48, 400);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(102, 23);
            this.title.TabIndex = 3;
            this.title.Text = "Название";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(216, 497);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(183, 20);
            this.textBoxType.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(216, 400);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(183, 20);
            this.textBoxTitle.TabIndex = 6;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddGroup.Location = new System.Drawing.Point(656, 54);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(75, 40);
            this.buttonAddGroup.TabIndex = 7;
            this.buttonAddGroup.Text = "Добавить";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // buttonEditGroup
            // 
            this.buttonEditGroup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditGroup.Location = new System.Drawing.Point(656, 136);
            this.buttonEditGroup.Name = "buttonEditGroup";
            this.buttonEditGroup.Size = new System.Drawing.Size(75, 40);
            this.buttonEditGroup.TabIndex = 8;
            this.buttonEditGroup.Text = "Изменить";
            this.buttonEditGroup.UseVisualStyleBackColor = true;
            this.buttonEditGroup.Click += new System.EventHandler(this.buttonEditGroup_Click);
            // 
            // buttonDelGroup
            // 
            this.buttonDelGroup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelGroup.Location = new System.Drawing.Point(656, 225);
            this.buttonDelGroup.Name = "buttonDelGroup";
            this.buttonDelGroup.Size = new System.Drawing.Size(75, 40);
            this.buttonDelGroup.TabIndex = 9;
            this.buttonDelGroup.Text = "Удалить";
            this.buttonDelGroup.UseVisualStyleBackColor = true;
            this.buttonDelGroup.Click += new System.EventHandler(this.buttonDelGroup_Click);
            // 
            // deleteID
            // 
            this.deleteID.Location = new System.Drawing.Point(448, 336);
            this.deleteID.Name = "deleteID";
            this.deleteID.Size = new System.Drawing.Size(100, 20);
            this.deleteID.TabIndex = 10;
            this.deleteID.Visible = false;
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.deleteID);
            this.Controls.Add(this.buttonDelGroup);
            this.Controls.Add(this.buttonEditGroup);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.title);
            this.Controls.Add(this.type);
            this.Controls.Add(this.dataGridGroup);
            this.Name = "Group";
            this.Text = "Group";
            this.Load += new System.EventHandler(this.Group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGroup;
        private DataGym dataGym;
        private System.Windows.Forms.BindingSource gRPBindingSource;
        private DataGymTableAdapters.GRPTableAdapter gRPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГРУППЫDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn нАЗВАНИЕDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тИПDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonEditGroup;
        private System.Windows.Forms.Button buttonDelGroup;
        private System.Windows.Forms.TextBox deleteID;
    }
}