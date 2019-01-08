namespace Gym
{
    partial class SearchSub
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDАБDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иМЯDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фАМИЛИЯDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вИДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нАЗВАНИЕDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEARCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Gym.DataSet2();
            this.gRPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGym = new Gym.DataGym();
            this.sUBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUBTableAdapter = new Gym.DataGymTableAdapters.SUBTableAdapter();
            this.gRPTableAdapter = new Gym.DataGymTableAdapters.GRPTableAdapter();
            this.dataSet1 = new Gym.DataSet1();
            this.sEARCHFORSUBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEARCHFORSUBTableAdapter = new Gym.DataSet1TableAdapters.SEARCHFORSUBTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sEARCHTableAdapter = new Gym.DataSet2TableAdapters.SEARCHTableAdapter();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHFORSUBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDАБDataGridViewTextBoxColumn,
            this.иМЯDataGridViewTextBoxColumn,
            this.фАМИЛИЯDataGridViewTextBoxColumn,
            this.вИДDataGridViewTextBoxColumn,
            this.нАЗВАНИЕDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sEARCHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(83, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDАБDataGridViewTextBoxColumn
            // 
            this.iDАБDataGridViewTextBoxColumn.DataPropertyName = "ID_АБ";
            this.iDАБDataGridViewTextBoxColumn.HeaderText = "ID_АБ";
            this.iDАБDataGridViewTextBoxColumn.Name = "iDАБDataGridViewTextBoxColumn";
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
            // вИДDataGridViewTextBoxColumn
            // 
            this.вИДDataGridViewTextBoxColumn.DataPropertyName = "ВИД";
            this.вИДDataGridViewTextBoxColumn.HeaderText = "ВИД";
            this.вИДDataGridViewTextBoxColumn.Name = "вИДDataGridViewTextBoxColumn";
            // 
            // нАЗВАНИЕDataGridViewTextBoxColumn
            // 
            this.нАЗВАНИЕDataGridViewTextBoxColumn.DataPropertyName = "НАЗВАНИЕ";
            this.нАЗВАНИЕDataGridViewTextBoxColumn.HeaderText = "НАЗВАНИЕ";
            this.нАЗВАНИЕDataGridViewTextBoxColumn.Name = "нАЗВАНИЕDataGridViewTextBoxColumn";
            // 
            // sEARCHBindingSource
            // 
            this.sEARCHBindingSource.DataMember = "SEARCH";
            this.sEARCHBindingSource.DataSource = this.dataSet2BindingSource;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sUBBindingSource
            // 
            this.sUBBindingSource.DataMember = "SUB";
            this.sUBBindingSource.DataSource = this.dataGym;
            // 
            // sUBTableAdapter
            // 
            this.sUBTableAdapter.ClearBeforeFill = true;
            // 
            // gRPTableAdapter
            // 
            this.gRPTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEARCHFORSUBBindingSource
            // 
            this.sEARCHFORSUBBindingSource.DataMember = "SEARCHFORSUB";
            this.sEARCHFORSUBBindingSource.DataSource = this.dataSet1;
            // 
            // sEARCHFORSUBTableAdapter
            // 
            this.sEARCHFORSUBTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(634, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 39);
            this.textBox1.TabIndex = 2;
            // 
            // sEARCHTableAdapter
            // 
            this.sEARCHTableAdapter.ClearBeforeFill = true;
            // 
            // SearchSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchSub";
            this.Text = "SearchSub";
            this.Load += new System.EventHandler(this.SearchSub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGym)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHFORSUBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGym dataGym;
        private System.Windows.Forms.BindingSource sUBBindingSource;
        private DataGymTableAdapters.SUBTableAdapter sUBTableAdapter;
        private System.Windows.Forms.BindingSource gRPBindingSource;
        private DataGymTableAdapters.GRPTableAdapter gRPTableAdapter;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sEARCHFORSUBBindingSource;
        private DataSet1TableAdapters.SEARCHFORSUBTableAdapter sEARCHFORSUBTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource sEARCHBindingSource;
        private DataSet2TableAdapters.SEARCHTableAdapter sEARCHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАБDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иМЯDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фАМИЛИЯDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вИДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn нАЗВАНИЕDataGridViewTextBoxColumn;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}