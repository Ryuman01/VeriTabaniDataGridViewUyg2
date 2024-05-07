namespace VeriTabaniDataGridViewUyg2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphane206DataSet = new VeriTabaniDataGridViewUyg2.Kutuphane206DataSet();
            this.kitaplarTableAdapter = new VeriTabaniDataGridViewUyg2.Kutuphane206DataSetTableAdapters.KitaplarTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphane206DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.kitapYazariDataGridViewTextBoxColumn,
            this.KitapTuru});
            this.dataGridView1.DataSource = this.kitaplarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 137);
            this.dataGridView1.TabIndex = 0;
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "Kitaplar";
            this.kitaplarBindingSource.DataSource = this.kutuphane206DataSet;
            // 
            // kutuphane206DataSet
            // 
            this.kutuphane206DataSet.DataSetName = "Kutuphane206DataSet";
            this.kutuphane206DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            // 
            // kitapYazariDataGridViewTextBoxColumn
            // 
            this.kitapYazariDataGridViewTextBoxColumn.DataPropertyName = "KitapYazari";
            this.kitapYazariDataGridViewTextBoxColumn.HeaderText = "Kitap Yazarı";
            this.kitapYazariDataGridViewTextBoxColumn.Name = "kitapYazariDataGridViewTextBoxColumn";
            // 
            // KitapTuru
            // 
            this.KitapTuru.DataPropertyName = "KitapTuru";
            this.KitapTuru.HeaderText = "Kitap Türü";
            this.KitapTuru.Name = "KitapTuru";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphane206DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Kutuphane206DataSet kutuphane206DataSet;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private Kutuphane206DataSetTableAdapters.KitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapTuru;
    }
}

