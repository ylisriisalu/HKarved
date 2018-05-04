namespace HKarved
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_avahinnakiri = new System.Windows.Forms.Button();
            this.dataGView_hkhinnakiri = new System.Windows.Forms.DataGridView();
            this.kOODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hINDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aKPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lKPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HKhinnakiriBS = new System.Windows.Forms.BindingSource(this.components);
            this.dsHK = new HKarved.DataSetHK();
            this.openFileHK = new System.Windows.Forms.OpenFileDialog();
            this.btn_avaarved = new System.Windows.Forms.Button();
            this.btn_avalehed = new System.Windows.Forms.Button();
            this.openFile_arved = new System.Windows.Forms.OpenFileDialog();
            this.openFile_lehed = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lEHTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jRKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eRIALAKOODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hKKOODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kOGUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kOEFITSENT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hINDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kOEFITSENT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARVEDBS = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LEHEDBS = new System.Windows.Forms.BindingSource(this.components);
            this.btnTootle = new System.Windows.Forms.Button();
            this.splitContainer_failid = new System.Windows.Forms.SplitContainer();
            this.btn_kirjutafailid = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lEHTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNFODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUMMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNFO2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView_hkhinnakiri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HKhinnakiriBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARVEDBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEHEDBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_failid)).BeginInit();
            this.splitContainer_failid.Panel1.SuspendLayout();
            this.splitContainer_failid.Panel2.SuspendLayout();
            this.splitContainer_failid.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_avahinnakiri
            // 
            resources.ApplyResources(this.btn_avahinnakiri, "btn_avahinnakiri");
            this.btn_avahinnakiri.Name = "btn_avahinnakiri";
            this.btn_avahinnakiri.UseVisualStyleBackColor = true;
            this.btn_avahinnakiri.Click += new System.EventHandler(this.btn_avahinnakiri_Click);
            // 
            // dataGView_hkhinnakiri
            // 
            this.dataGView_hkhinnakiri.AutoGenerateColumns = false;
            this.dataGView_hkhinnakiri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView_hkhinnakiri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kOODDataGridViewTextBoxColumn,
            this.hINDDataGridViewTextBoxColumn,
            this.aKPVDataGridViewTextBoxColumn,
            this.lKPVDataGridViewTextBoxColumn,
            this.NIMI});
            this.dataGView_hkhinnakiri.DataSource = this.HKhinnakiriBS;
            resources.ApplyResources(this.dataGView_hkhinnakiri, "dataGView_hkhinnakiri");
            this.dataGView_hkhinnakiri.Name = "dataGView_hkhinnakiri";
            this.dataGView_hkhinnakiri.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            // 
            // kOODDataGridViewTextBoxColumn
            // 
            this.kOODDataGridViewTextBoxColumn.DataPropertyName = "KOOD";
            resources.ApplyResources(this.kOODDataGridViewTextBoxColumn, "kOODDataGridViewTextBoxColumn");
            this.kOODDataGridViewTextBoxColumn.Name = "kOODDataGridViewTextBoxColumn";
            // 
            // hINDDataGridViewTextBoxColumn
            // 
            this.hINDDataGridViewTextBoxColumn.DataPropertyName = "HIND";
            resources.ApplyResources(this.hINDDataGridViewTextBoxColumn, "hINDDataGridViewTextBoxColumn");
            this.hINDDataGridViewTextBoxColumn.Name = "hINDDataGridViewTextBoxColumn";
            // 
            // aKPVDataGridViewTextBoxColumn
            // 
            this.aKPVDataGridViewTextBoxColumn.DataPropertyName = "AKPV";
            resources.ApplyResources(this.aKPVDataGridViewTextBoxColumn, "aKPVDataGridViewTextBoxColumn");
            this.aKPVDataGridViewTextBoxColumn.Name = "aKPVDataGridViewTextBoxColumn";
            // 
            // lKPVDataGridViewTextBoxColumn
            // 
            this.lKPVDataGridViewTextBoxColumn.DataPropertyName = "LKPV";
            resources.ApplyResources(this.lKPVDataGridViewTextBoxColumn, "lKPVDataGridViewTextBoxColumn");
            this.lKPVDataGridViewTextBoxColumn.Name = "lKPVDataGridViewTextBoxColumn";
            // 
            // NIMI
            // 
            this.NIMI.DataPropertyName = "NIMI";
            resources.ApplyResources(this.NIMI, "NIMI");
            this.NIMI.Name = "NIMI";
            // 
            // HKhinnakiriBS
            // 
            this.HKhinnakiriBS.DataMember = "HKhinnakiri";
            this.HKhinnakiriBS.DataSource = this.dsHK;
            // 
            // dsHK
            // 
            this.dsHK.DataSetName = "DataSetHK";
            this.dsHK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileHK
            // 
            this.openFileHK.FileName = "hinnakiri.csv";
            // 
            // btn_avaarved
            // 
            resources.ApplyResources(this.btn_avaarved, "btn_avaarved");
            this.btn_avaarved.Name = "btn_avaarved";
            this.btn_avaarved.UseVisualStyleBackColor = true;
            this.btn_avaarved.Click += new System.EventHandler(this.btn_avaarved_Click);
            // 
            // btn_avalehed
            // 
            resources.ApplyResources(this.btn_avalehed, "btn_avalehed");
            this.btn_avalehed.Name = "btn_avalehed";
            this.btn_avalehed.UseVisualStyleBackColor = true;
            this.btn_avalehed.Click += new System.EventHandler(this.btn_avalehed_Click);
            // 
            // openFile_arved
            // 
            this.openFile_arved.FileName = "arved.dat";
            // 
            // openFile_lehed
            // 
            this.openFile_lehed.FileName = "lehed.dat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lEHTIDDataGridViewTextBoxColumn,
            this.jRKDataGridViewTextBoxColumn,
            this.eRIALAKOODDataGridViewTextBoxColumn,
            this.hKKOODDataGridViewTextBoxColumn,
            this.kOGUSDataGridViewTextBoxColumn,
            this.kOEFITSENT1DataGridViewTextBoxColumn,
            this.hINDDataGridViewTextBoxColumn1,
            this.kPVDataGridViewTextBoxColumn,
            this.tYHIDataGridViewTextBoxColumn,
            this.kOEFITSENT2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ARVEDBS;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // lEHTIDDataGridViewTextBoxColumn
            // 
            this.lEHTIDDataGridViewTextBoxColumn.DataPropertyName = "LEHTID";
            resources.ApplyResources(this.lEHTIDDataGridViewTextBoxColumn, "lEHTIDDataGridViewTextBoxColumn");
            this.lEHTIDDataGridViewTextBoxColumn.Name = "lEHTIDDataGridViewTextBoxColumn";
            // 
            // jRKDataGridViewTextBoxColumn
            // 
            this.jRKDataGridViewTextBoxColumn.DataPropertyName = "JRK";
            resources.ApplyResources(this.jRKDataGridViewTextBoxColumn, "jRKDataGridViewTextBoxColumn");
            this.jRKDataGridViewTextBoxColumn.Name = "jRKDataGridViewTextBoxColumn";
            // 
            // eRIALAKOODDataGridViewTextBoxColumn
            // 
            this.eRIALAKOODDataGridViewTextBoxColumn.DataPropertyName = "ERIALAKOOD";
            resources.ApplyResources(this.eRIALAKOODDataGridViewTextBoxColumn, "eRIALAKOODDataGridViewTextBoxColumn");
            this.eRIALAKOODDataGridViewTextBoxColumn.Name = "eRIALAKOODDataGridViewTextBoxColumn";
            // 
            // hKKOODDataGridViewTextBoxColumn
            // 
            this.hKKOODDataGridViewTextBoxColumn.DataPropertyName = "HKKOOD";
            resources.ApplyResources(this.hKKOODDataGridViewTextBoxColumn, "hKKOODDataGridViewTextBoxColumn");
            this.hKKOODDataGridViewTextBoxColumn.Name = "hKKOODDataGridViewTextBoxColumn";
            // 
            // kOGUSDataGridViewTextBoxColumn
            // 
            this.kOGUSDataGridViewTextBoxColumn.DataPropertyName = "KOGUS";
            resources.ApplyResources(this.kOGUSDataGridViewTextBoxColumn, "kOGUSDataGridViewTextBoxColumn");
            this.kOGUSDataGridViewTextBoxColumn.Name = "kOGUSDataGridViewTextBoxColumn";
            // 
            // kOEFITSENT1DataGridViewTextBoxColumn
            // 
            this.kOEFITSENT1DataGridViewTextBoxColumn.DataPropertyName = "KOEFITSENT1";
            resources.ApplyResources(this.kOEFITSENT1DataGridViewTextBoxColumn, "kOEFITSENT1DataGridViewTextBoxColumn");
            this.kOEFITSENT1DataGridViewTextBoxColumn.Name = "kOEFITSENT1DataGridViewTextBoxColumn";
            // 
            // hINDDataGridViewTextBoxColumn1
            // 
            this.hINDDataGridViewTextBoxColumn1.DataPropertyName = "HIND";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.hINDDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.hINDDataGridViewTextBoxColumn1, "hINDDataGridViewTextBoxColumn1");
            this.hINDDataGridViewTextBoxColumn1.Name = "hINDDataGridViewTextBoxColumn1";
            // 
            // kPVDataGridViewTextBoxColumn
            // 
            this.kPVDataGridViewTextBoxColumn.DataPropertyName = "KPV";
            resources.ApplyResources(this.kPVDataGridViewTextBoxColumn, "kPVDataGridViewTextBoxColumn");
            this.kPVDataGridViewTextBoxColumn.Name = "kPVDataGridViewTextBoxColumn";
            // 
            // tYHIDataGridViewTextBoxColumn
            // 
            this.tYHIDataGridViewTextBoxColumn.DataPropertyName = "TYHI";
            resources.ApplyResources(this.tYHIDataGridViewTextBoxColumn, "tYHIDataGridViewTextBoxColumn");
            this.tYHIDataGridViewTextBoxColumn.Name = "tYHIDataGridViewTextBoxColumn";
            // 
            // kOEFITSENT2DataGridViewTextBoxColumn
            // 
            this.kOEFITSENT2DataGridViewTextBoxColumn.DataPropertyName = "KOEFITSENT2";
            resources.ApplyResources(this.kOEFITSENT2DataGridViewTextBoxColumn, "kOEFITSENT2DataGridViewTextBoxColumn");
            this.kOEFITSENT2DataGridViewTextBoxColumn.Name = "kOEFITSENT2DataGridViewTextBoxColumn";
            // 
            // ARVEDBS
            // 
            this.ARVEDBS.DataMember = "ARVED";
            this.ARVEDBS.DataSource = this.dsHK;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lEHTIDDataGridViewTextBoxColumn1,
            this.iNFODataGridViewTextBoxColumn,
            this.sUMMADataGridViewTextBoxColumn,
            this.iNFO2DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.LEHEDBS;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            // 
            // LEHEDBS
            // 
            this.LEHEDBS.DataMember = "LEHED";
            this.LEHEDBS.DataSource = this.dsHK;
            // 
            // btnTootle
            // 
            resources.ApplyResources(this.btnTootle, "btnTootle");
            this.btnTootle.Name = "btnTootle";
            this.btnTootle.UseVisualStyleBackColor = true;
            this.btnTootle.Click += new System.EventHandler(this.btnTootle_Click);
            // 
            // splitContainer_failid
            // 
            resources.ApplyResources(this.splitContainer_failid, "splitContainer_failid");
            this.splitContainer_failid.Name = "splitContainer_failid";
            // 
            // splitContainer_failid.Panel1
            // 
            this.splitContainer_failid.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer_failid.Panel2
            // 
            this.splitContainer_failid.Panel2.Controls.Add(this.dataGridView2);
            // 
            // btn_kirjutafailid
            // 
            this.btn_kirjutafailid.ForeColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.btn_kirjutafailid, "btn_kirjutafailid");
            this.btn_kirjutafailid.Name = "btn_kirjutafailid";
            this.btn_kirjutafailid.UseVisualStyleBackColor = true;
            this.btn_kirjutafailid.Click += new System.EventHandler(this.btn_kirjutafailid_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::HKarved.Properties.Resources.logo1;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lEHTIDDataGridViewTextBoxColumn1
            // 
            this.lEHTIDDataGridViewTextBoxColumn1.DataPropertyName = "LEHTID";
            resources.ApplyResources(this.lEHTIDDataGridViewTextBoxColumn1, "lEHTIDDataGridViewTextBoxColumn1");
            this.lEHTIDDataGridViewTextBoxColumn1.Name = "lEHTIDDataGridViewTextBoxColumn1";
            // 
            // iNFODataGridViewTextBoxColumn
            // 
            this.iNFODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iNFODataGridViewTextBoxColumn.DataPropertyName = "INFO";
            resources.ApplyResources(this.iNFODataGridViewTextBoxColumn, "iNFODataGridViewTextBoxColumn");
            this.iNFODataGridViewTextBoxColumn.Name = "iNFODataGridViewTextBoxColumn";
            // 
            // sUMMADataGridViewTextBoxColumn
            // 
            this.sUMMADataGridViewTextBoxColumn.DataPropertyName = "SUMMA";
            resources.ApplyResources(this.sUMMADataGridViewTextBoxColumn, "sUMMADataGridViewTextBoxColumn");
            this.sUMMADataGridViewTextBoxColumn.Name = "sUMMADataGridViewTextBoxColumn";
            // 
            // iNFO2DataGridViewTextBoxColumn
            // 
            this.iNFO2DataGridViewTextBoxColumn.DataPropertyName = "INFO2";
            resources.ApplyResources(this.iNFO2DataGridViewTextBoxColumn, "iNFO2DataGridViewTextBoxColumn");
            this.iNFO2DataGridViewTextBoxColumn.Name = "iNFO2DataGridViewTextBoxColumn";
            // 
            // Form_main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_kirjutafailid);
            this.Controls.Add(this.splitContainer_failid);
            this.Controls.Add(this.btnTootle);
            this.Controls.Add(this.btn_avalehed);
            this.Controls.Add(this.btn_avaarved);
            this.Controls.Add(this.dataGView_hkhinnakiri);
            this.Controls.Add(this.btn_avahinnakiri);
            this.Name = "Form_main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGView_hkhinnakiri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HKhinnakiriBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARVEDBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEHEDBS)).EndInit();
            this.splitContainer_failid.Panel1.ResumeLayout(false);
            this.splitContainer_failid.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_failid)).EndInit();
            this.splitContainer_failid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_avahinnakiri;
        private System.Windows.Forms.DataGridView dataGView_hkhinnakiri;
        private System.Windows.Forms.DataGridViewTextBoxColumn kOODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hINDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aKPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lKPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource HKhinnakiriBS;
        private System.Windows.Forms.OpenFileDialog openFileHK;
        private DataSetHK dsHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIMI;
        private System.Windows.Forms.Button btn_avaarved;
        private System.Windows.Forms.Button btn_avalehed;
        private System.Windows.Forms.OpenFileDialog openFile_arved;
        private System.Windows.Forms.OpenFileDialog openFile_lehed;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ARVEDBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEHTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jRKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eRIALAKOODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hKKOODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kOGUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kOEFITSENT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hINDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kPVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kOEFITSENT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource LEHEDBS;
        private System.Windows.Forms.Button btnTootle;
        private System.Windows.Forms.SplitContainer splitContainer_failid;
        private System.Windows.Forms.Button btn_kirjutafailid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEHTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUMMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNFO2DataGridViewTextBoxColumn;
    }
}

