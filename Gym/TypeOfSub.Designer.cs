namespace Gym
{
    partial class TypeOfSub
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
            this.вИДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сТОИМОСТЬDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сКИДКАDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вРЕМЯСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вРЕМЯДОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDАБDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPESUBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGym = new Gym.DataGym();
            this.tYPE_SUBTableAdapter = new Gym.DataGymTableAdapters.TYPE_SUBTableAdapter();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnEditType = new System.Windows.Forms.Button();
            this.btnDelType = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.timeFrom = new System.Windows.Forms.Label();
            this.timeTo = new System.Windows.Forms.Label();
            this.id_sub = new System.Windows.Forms.Label();
            this.id_group = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.textBoxTimeFrom = new System.Windows.Forms.TextBox();
            this.textBoxTimeTo = new System.Windows.Forms.TextBox();
            this.textBoxIdSub = new System.Windows.Forms.TextBox();
            this.textBoxIdGroup = new System.Windows.Forms.TextBox();
            this.dataGridTypeOfSub = new System.Windows.Forms.DataGridView();
            this.вИДDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сТОИМОСТЬDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сКИДКАDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вРЕМЯСDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вРЕМЯДОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDАБDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPESUBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tYPESUBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypeOfSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPESUBBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // вИДDataGridViewTextBoxColumn
            // 
            this.вИДDataGridViewTextBoxColumn.DataPropertyName = "ВИД";
            this.вИДDataGridViewTextBoxColumn.HeaderText = "ВИД";
            this.вИДDataGridViewTextBoxColumn.Name = "вИДDataGridViewTextBoxColumn";
            // 
            // сТОИМОСТЬDataGridViewTextBoxColumn
            // 
            this.сТОИМОСТЬDataGridViewTextBoxColumn.DataPropertyName = "СТОИМОСТЬ";
            this.сТОИМОСТЬDataGridViewTextBoxColumn.HeaderText = "СТОИМОСТЬ";
            this.сТОИМОСТЬDataGridViewTextBoxColumn.Name = "сТОИМОСТЬDataGridViewTextBoxColumn";
            // 
            // сКИДКАDataGridViewTextBoxColumn
            // 
            this.сКИДКАDataGridViewTextBoxColumn.DataPropertyName = "СКИДКА";
            this.сКИДКАDataGridViewTextBoxColumn.HeaderText = "СКИДКА";
            this.сКИДКАDataGridViewTextBoxColumn.Name = "сКИДКАDataGridViewTextBoxColumn";
            // 
            // вРЕМЯСDataGridViewTextBoxColumn
            // 
            this.вРЕМЯСDataGridViewTextBoxColumn.DataPropertyName = "ВРЕМЯ_С";
            this.вРЕМЯСDataGridViewTextBoxColumn.HeaderText = "ВРЕМЯ_С";
            this.вРЕМЯСDataGridViewTextBoxColumn.Name = "вРЕМЯСDataGridViewTextBoxColumn";
            // 
            // вРЕМЯДОDataGridViewTextBoxColumn
            // 
            this.вРЕМЯДОDataGridViewTextBoxColumn.DataPropertyName = "ВРЕМЯ_ДО";
            this.вРЕМЯДОDataGridViewTextBoxColumn.HeaderText = "ВРЕМЯ_ДО";
            this.вРЕМЯДОDataGridViewTextBoxColumn.Name = "вРЕМЯДОDataGridViewTextBoxColumn";
            // 
            // iDАБDataGridViewTextBoxColumn
            // 
            this.iDАБDataGridViewTextBoxColumn.DataPropertyName = "ID_АБ";
            this.iDАБDataGridViewTextBoxColumn.HeaderText = "ID_АБ";
            this.iDАБDataGridViewTextBoxColumn.Name = "iDАБDataGridViewTextBoxColumn";
            // 
            // iDGDataGridViewTextBoxColumn
            // 
            this.iDGDataGridViewTextBoxColumn.DataPropertyName = "ID_G";
            this.iDGDataGridViewTextBoxColumn.HeaderText = "ID_G";
            this.iDGDataGridViewTextBoxColumn.Name = "iDGDataGridViewTextBoxColumn";
            // 
            // tYPESUBBindingSource
            // 
            this.tYPESUBBindingSource.DataMember = "TYPE_SUB";
            this.tYPESUBBindingSource.DataSource = this.dataGym;
            // 
            // dataGym
            // 
            this.dataGym.DataSetName = "DataGym";
            this.dataGym.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tYPE_SUBTableAdapter
            // 
            this.tYPE_SUBTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddType
            // 
            this.btnAddType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddType.Location = new System.Drawing.Point(781, 64);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(75, 40);
            this.btnAddType.TabIndex = 1;
            this.btnAddType.Text = "Добавить";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // btnEditType
            // 
            this.btnEditType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditType.Location = new System.Drawing.Point(781, 164);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Size = new System.Drawing.Size(75, 40);
            this.btnEditType.TabIndex = 4;
            this.btnEditType.Text = "Изменить";
            this.btnEditType.UseVisualStyleBackColor = true;
            this.btnEditType.Click += new System.EventHandler(this.btnEditType_Click);
            // 
            // btnDelType
            // 
            this.btnDelType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelType.Location = new System.Drawing.Point(781, 259);
            this.btnDelType.Name = "btnDelType";
            this.btnDelType.Size = new System.Drawing.Size(75, 40);
            this.btnDelType.TabIndex = 5;
            this.btnDelType.Text = "Удалить";
            this.btnDelType.UseVisualStyleBackColor = true;
            this.btnDelType.Click += new System.EventHandler(this.btnDelType_Click);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.Location = new System.Drawing.Point(12, 375);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(44, 23);
            this.type.TabIndex = 6;
            this.type.Text = "Вид";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(12, 461);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(117, 23);
            this.price.TabIndex = 7;
            this.price.Text = "Стоимость";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discount.Location = new System.Drawing.Point(12, 559);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(81, 23);
            this.discount.TabIndex = 8;
            this.discount.Text = "Скидка";
            // 
            // timeFrom
            // 
            this.timeFrom.AutoSize = true;
            this.timeFrom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeFrom.Location = new System.Drawing.Point(309, 418);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.Size = new System.Drawing.Size(88, 23);
            this.timeFrom.TabIndex = 9;
            this.timeFrom.Text = "Время с";
            // 
            // timeTo
            // 
            this.timeTo.AutoSize = true;
            this.timeTo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTo.Location = new System.Drawing.Point(309, 525);
            this.timeTo.Name = "timeTo";
            this.timeTo.Size = new System.Drawing.Size(100, 23);
            this.timeTo.TabIndex = 10;
            this.timeTo.Text = "Время до";
            // 
            // id_sub
            // 
            this.id_sub.AutoSize = true;
            this.id_sub.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_sub.Location = new System.Drawing.Point(552, 418);
            this.id_sub.Name = "id_sub";
            this.id_sub.Size = new System.Drawing.Size(160, 23);
            this.id_sub.TabIndex = 11;
            this.id_sub.Text = "ID_Абонемента";
            // 
            // id_group
            // 
            this.id_group.AutoSize = true;
            this.id_group.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_group.Location = new System.Drawing.Point(552, 525);
            this.id_group.Name = "id_group";
            this.id_group.Size = new System.Drawing.Size(108, 23);
            this.id_group.TabIndex = 12;
            this.id_group.Text = "ID_Группы";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(147, 461);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(134, 20);
            this.textBoxPrice.TabIndex = 13;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(147, 380);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(134, 20);
            this.textBoxType.TabIndex = 14;
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(147, 559);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(134, 20);
            this.textBoxDiscount.TabIndex = 15;
            // 
            // textBoxTimeFrom
            // 
            this.textBoxTimeFrom.Location = new System.Drawing.Point(412, 423);
            this.textBoxTimeFrom.Name = "textBoxTimeFrom";
            this.textBoxTimeFrom.Size = new System.Drawing.Size(134, 20);
            this.textBoxTimeFrom.TabIndex = 16;
            // 
            // textBoxTimeTo
            // 
            this.textBoxTimeTo.Location = new System.Drawing.Point(412, 530);
            this.textBoxTimeTo.Name = "textBoxTimeTo";
            this.textBoxTimeTo.Size = new System.Drawing.Size(134, 20);
            this.textBoxTimeTo.TabIndex = 17;
            // 
            // textBoxIdSub
            // 
            this.textBoxIdSub.Location = new System.Drawing.Point(718, 423);
            this.textBoxIdSub.Name = "textBoxIdSub";
            this.textBoxIdSub.Size = new System.Drawing.Size(92, 20);
            this.textBoxIdSub.TabIndex = 18;
            // 
            // textBoxIdGroup
            // 
            this.textBoxIdGroup.Location = new System.Drawing.Point(718, 530);
            this.textBoxIdGroup.Name = "textBoxIdGroup";
            this.textBoxIdGroup.Size = new System.Drawing.Size(92, 20);
            this.textBoxIdGroup.TabIndex = 19;
            // 
            // dataGridTypeOfSub
            // 
            this.dataGridTypeOfSub.AutoGenerateColumns = false;
            this.dataGridTypeOfSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTypeOfSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.вИДDataGridViewTextBoxColumn1,
            this.сТОИМОСТЬDataGridViewTextBoxColumn1,
            this.сКИДКАDataGridViewTextBoxColumn1,
            this.вРЕМЯСDataGridViewTextBoxColumn1,
            this.вРЕМЯДОDataGridViewTextBoxColumn1,
            this.iDАБDataGridViewTextBoxColumn1,
            this.iDGDataGridViewTextBoxColumn1});
            this.dataGridTypeOfSub.DataSource = this.tYPESUBBindingSource1;
            this.dataGridTypeOfSub.Location = new System.Drawing.Point(12, 12);
            this.dataGridTypeOfSub.Name = "dataGridTypeOfSub";
            this.dataGridTypeOfSub.Size = new System.Drawing.Size(748, 327);
            this.dataGridTypeOfSub.TabIndex = 20;
            this.dataGridTypeOfSub.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridTypeOfSub_MouseClick);
            // 
            // вИДDataGridViewTextBoxColumn1
            // 
            this.вИДDataGridViewTextBoxColumn1.DataPropertyName = "ВИД";
            this.вИДDataGridViewTextBoxColumn1.HeaderText = "ВИД";
            this.вИДDataGridViewTextBoxColumn1.Name = "вИДDataGridViewTextBoxColumn1";
            // 
            // сТОИМОСТЬDataGridViewTextBoxColumn1
            // 
            this.сТОИМОСТЬDataGridViewTextBoxColumn1.DataPropertyName = "СТОИМОСТЬ";
            this.сТОИМОСТЬDataGridViewTextBoxColumn1.HeaderText = "СТОИМОСТЬ";
            this.сТОИМОСТЬDataGridViewTextBoxColumn1.Name = "сТОИМОСТЬDataGridViewTextBoxColumn1";
            // 
            // сКИДКАDataGridViewTextBoxColumn1
            // 
            this.сКИДКАDataGridViewTextBoxColumn1.DataPropertyName = "СКИДКА";
            this.сКИДКАDataGridViewTextBoxColumn1.HeaderText = "СКИДКА";
            this.сКИДКАDataGridViewTextBoxColumn1.Name = "сКИДКАDataGridViewTextBoxColumn1";
            // 
            // вРЕМЯСDataGridViewTextBoxColumn1
            // 
            this.вРЕМЯСDataGridViewTextBoxColumn1.DataPropertyName = "ВРЕМЯ_С";
            this.вРЕМЯСDataGridViewTextBoxColumn1.HeaderText = "ВРЕМЯ_С";
            this.вРЕМЯСDataGridViewTextBoxColumn1.Name = "вРЕМЯСDataGridViewTextBoxColumn1";
            // 
            // вРЕМЯДОDataGridViewTextBoxColumn1
            // 
            this.вРЕМЯДОDataGridViewTextBoxColumn1.DataPropertyName = "ВРЕМЯ_ДО";
            this.вРЕМЯДОDataGridViewTextBoxColumn1.HeaderText = "ВРЕМЯ_ДО";
            this.вРЕМЯДОDataGridViewTextBoxColumn1.Name = "вРЕМЯДОDataGridViewTextBoxColumn1";
            // 
            // iDАБDataGridViewTextBoxColumn1
            // 
            this.iDАБDataGridViewTextBoxColumn1.DataPropertyName = "ID_АБ";
            this.iDАБDataGridViewTextBoxColumn1.HeaderText = "ID_АБ";
            this.iDАБDataGridViewTextBoxColumn1.Name = "iDАБDataGridViewTextBoxColumn1";
            // 
            // iDGDataGridViewTextBoxColumn1
            // 
            this.iDGDataGridViewTextBoxColumn1.DataPropertyName = "ID_G";
            this.iDGDataGridViewTextBoxColumn1.HeaderText = "ID_G";
            this.iDGDataGridViewTextBoxColumn1.Name = "iDGDataGridViewTextBoxColumn1";
            // 
            // tYPESUBBindingSource1
            // 
            this.tYPESUBBindingSource1.DataMember = "TYPE_SUB";
            this.tYPESUBBindingSource1.DataSource = this.dataGym;
            // 
            // TypeOfSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.dataGridTypeOfSub);
            this.Controls.Add(this.textBoxIdGroup);
            this.Controls.Add(this.textBoxIdSub);
            this.Controls.Add(this.textBoxTimeTo);
            this.Controls.Add(this.textBoxTimeFrom);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.id_group);
            this.Controls.Add(this.id_sub);
            this.Controls.Add(this.timeTo);
            this.Controls.Add(this.timeFrom);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.price);
            this.Controls.Add(this.type);
            this.Controls.Add(this.btnDelType);
            this.Controls.Add(this.btnEditType);
            this.Controls.Add(this.btnAddType);
            this.Name = "TypeOfSub";
            this.Text = "TypeOfSub";
            this.Load += new System.EventHandler(this.TypeOfSub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tYPESUBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypeOfSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPESUBBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTypeSub;
        private DataGym dataGym;
        private System.Windows.Forms.BindingSource tYPESUBBindingSource;
        private DataGymTableAdapters.TYPE_SUBTableAdapter tYPE_SUBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn вИДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сТОИМОСТЬDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сКИДКАDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вРЕМЯСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вРЕМЯДОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАБDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Button btnEditType;
        private System.Windows.Forms.Button btnDelType;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label timeFrom;
        private System.Windows.Forms.Label timeTo;
        private System.Windows.Forms.Label id_sub;
        private System.Windows.Forms.Label id_group;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.TextBox textBoxTimeFrom;
        private System.Windows.Forms.TextBox textBoxTimeTo;
        private System.Windows.Forms.TextBox textBoxIdSub;
        private System.Windows.Forms.TextBox textBoxIdGroup;
        private System.Windows.Forms.DataGridView dataGridTypeOfSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn вИДDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn сТОИМОСТЬDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn сКИДКАDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn вРЕМЯСDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn вРЕМЯДОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАБDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tYPESUBBindingSource1;
    }
}