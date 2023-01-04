namespace YurtKayitSistemi
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.pctrBoxAdd = new System.Windows.Forms.PictureBox();
            this.pctrBoxDelete = new System.Windows.Forms.PictureBox();
            this.pctrBoxEdit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolumId = new System.Windows.Forms.TextBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet1 = new YurtKayitSistemi.YurtOtomasyonDataSet1();
            this.bolumlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonDataSet1TableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrBoxAdd
            // 
            this.pctrBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pctrBoxAdd.Image")));
            this.pctrBoxAdd.Location = new System.Drawing.Point(353, 12);
            this.pctrBoxAdd.Name = "pctrBoxAdd";
            this.pctrBoxAdd.Size = new System.Drawing.Size(76, 71);
            this.pctrBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBoxAdd.TabIndex = 0;
            this.pctrBoxAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.pctrBoxAdd, "Bölüm Ekle");
            this.pctrBoxAdd.Click += new System.EventHandler(this.pctrBoxAdd_Click);
            // 
            // pctrBoxDelete
            // 
            this.pctrBoxDelete.Image = ((System.Drawing.Image)(resources.GetObject("pctrBoxDelete.Image")));
            this.pctrBoxDelete.Location = new System.Drawing.Point(435, 12);
            this.pctrBoxDelete.Name = "pctrBoxDelete";
            this.pctrBoxDelete.Size = new System.Drawing.Size(74, 71);
            this.pctrBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBoxDelete.TabIndex = 1;
            this.pctrBoxDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.pctrBoxDelete, "Bölüm Sil");
            this.pctrBoxDelete.Click += new System.EventHandler(this.pctrBoxDelete_Click);
            // 
            // pctrBoxEdit
            // 
            this.pctrBoxEdit.Image = ((System.Drawing.Image)(resources.GetObject("pctrBoxEdit.Image")));
            this.pctrBoxEdit.Location = new System.Drawing.Point(515, 12);
            this.pctrBoxEdit.Name = "pctrBoxEdit";
            this.pctrBoxEdit.Size = new System.Drawing.Size(76, 71);
            this.pctrBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBoxEdit.TabIndex = 2;
            this.pctrBoxEdit.TabStop = false;
            this.toolTip1.SetToolTip(this.pctrBoxEdit, "Bölüm Düzenle");
            this.pctrBoxEdit.Click += new System.EventHandler(this.pctrBoxEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm ID:";
            // 
            // txtBolumId
            // 
            this.txtBolumId.Enabled = false;
            this.txtBolumId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumId.Location = new System.Drawing.Point(117, 12);
            this.txtBolumId.Name = "txtBolumId";
            this.txtBolumId.Size = new System.Drawing.Size(225, 30);
            this.txtBolumId.TabIndex = 4;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumAd.Location = new System.Drawing.Point(117, 57);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(225, 30);
            this.txtBolumAd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(10, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(589, 265);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumidDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonDataSet1;
            // 
            // yurtOtomasyonDataSet1
            // 
            this.yurtOtomasyonDataSet1.DataSetName = "YurtOtomasyonDataSet1";
            this.yurtOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 374);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBolumId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctrBoxEdit);
            this.Controls.Add(this.pctrBoxDelete);
            this.Controls.Add(this.pctrBoxAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrBoxAdd;
        private System.Windows.Forms.PictureBox pctrBoxDelete;
        private System.Windows.Forms.PictureBox pctrBoxEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolumId;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonDataSet1 yurtOtomasyonDataSet1;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtOtomasyonDataSet1TableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}