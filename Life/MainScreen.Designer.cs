namespace Life
{
    partial class MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metal = new System.Windows.Forms.Label();
            this.carbon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fule = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbonCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuleCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ddfs = new System.Windows.Forms.TabControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buildingLevelViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planetViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarbonCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuleCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ddfs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildingLevelViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Life";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metal";
            // 
            // metal
            // 
            this.metal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metal.AutoSize = true;
            this.metal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metal.Location = new System.Drawing.Point(68, 44);
            this.metal.Name = "metal";
            this.metal.Size = new System.Drawing.Size(13, 13);
            this.metal.TabIndex = 3;
            this.metal.Text = "0";
            // 
            // carbon
            // 
            this.carbon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.carbon.AutoSize = true;
            this.carbon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.carbon.Location = new System.Drawing.Point(159, 44);
            this.carbon.Name = "carbon";
            this.carbon.Size = new System.Drawing.Size(13, 13);
            this.carbon.TabIndex = 5;
            this.carbon.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Carbon";
            // 
            // fule
            // 
            this.fule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fule.AutoSize = true;
            this.fule.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fule.Location = new System.Drawing.Point(248, 44);
            this.fule.Name = "fule";
            this.fule.Size = new System.Drawing.Size(13, 13);
            this.fule.TabIndex = 7;
            this.fule.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fule";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 372);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Buildings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.levelDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.MetalCost,
            this.CarbonCost,
            this.FuleCost,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            this.dataGridView3.DataSource = this.buildingLevelViewModelBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(697, 372);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Galaxy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn,
            this.zDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.planetViewModelBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(697, 372);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.Duration,
            this.metalCostDataGridViewTextBoxColumn,
            this.carbonCostDataGridViewTextBoxColumn,
            this.fuleCostDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Cancle});
            this.dataGridView1.DataSource = this.buildingLevelViewModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(697, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            this.levelDataGridViewTextBoxColumn.Width = 35;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 50;
            // 
            // metalCostDataGridViewTextBoxColumn
            // 
            this.metalCostDataGridViewTextBoxColumn.DataPropertyName = "MetalCost";
            this.metalCostDataGridViewTextBoxColumn.HeaderText = "Metal";
            this.metalCostDataGridViewTextBoxColumn.Name = "metalCostDataGridViewTextBoxColumn";
            this.metalCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.metalCostDataGridViewTextBoxColumn.Width = 45;
            // 
            // carbonCostDataGridViewTextBoxColumn
            // 
            this.carbonCostDataGridViewTextBoxColumn.DataPropertyName = "CarbonCost";
            this.carbonCostDataGridViewTextBoxColumn.HeaderText = "Carbon";
            this.carbonCostDataGridViewTextBoxColumn.Name = "carbonCostDataGridViewTextBoxColumn";
            this.carbonCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.carbonCostDataGridViewTextBoxColumn.Width = 45;
            // 
            // fuleCostDataGridViewTextBoxColumn
            // 
            this.fuleCostDataGridViewTextBoxColumn.DataPropertyName = "FuleCost";
            this.fuleCostDataGridViewTextBoxColumn.HeaderText = "Fule";
            this.fuleCostDataGridViewTextBoxColumn.Name = "fuleCostDataGridViewTextBoxColumn";
            this.fuleCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.fuleCostDataGridViewTextBoxColumn.Width = 45;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Build";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Start building";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Details";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Details";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CurrentlyBuilding";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 50;
            // 
            // Cancle
            // 
            this.Cancle.HeaderText = "Cancle";
            this.Cancle.Name = "Cancle";
            this.Cancle.ReadOnly = true;
            this.Cancle.Text = "Cancle";
            this.Cancle.UseColumnTextForButtonValue = true;
            this.Cancle.Visible = false;
            // 
            // ddfs
            // 
            this.ddfs.Controls.Add(this.tabPage1);
            this.ddfs.Controls.Add(this.tabPage2);
            this.ddfs.Location = new System.Drawing.Point(12, 72);
            this.ddfs.Name = "ddfs";
            this.ddfs.SelectedIndex = 0;
            this.ddfs.Size = new System.Drawing.Size(705, 398);
            this.ddfs.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(663, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buildingLevelViewModelBindingSource
            // 
            this.buildingLevelViewModelBindingSource.DataSource = typeof(Life.ViewModels.BuildingLevelViewModel);
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            this.xDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            this.yDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zDataGridViewTextBoxColumn
            // 
            this.zDataGridViewTextBoxColumn.DataPropertyName = "Z";
            this.zDataGridViewTextBoxColumn.HeaderText = "Z";
            this.zDataGridViewTextBoxColumn.Name = "zDataGridViewTextBoxColumn";
            this.zDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 50;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.ReadOnly = true;
            this.temperatureDataGridViewTextBoxColumn.Width = 50;
            // 
            // planetViewModelBindingSource
            // 
            this.planetViewModelBindingSource.DataSource = typeof(Life.ViewModels.PlanetViewModel);
            // 
            // buildingLevelBindingSource
            // 
            this.buildingLevelBindingSource.DataSource = typeof(Life.Models.BuildingLevel);
            // 
            // userViewModelBindingSource
            // 
            this.userViewModelBindingSource.DataSource = typeof(Life.ViewModels.UserViewModel);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn1
            // 
            this.levelDataGridViewTextBoxColumn1.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn1.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn1.Name = "levelDataGridViewTextBoxColumn1";
            this.levelDataGridViewTextBoxColumn1.ReadOnly = true;
            this.levelDataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn2.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // MetalCost
            // 
            this.MetalCost.DataPropertyName = "MetalCost";
            this.MetalCost.HeaderText = "Metal";
            this.MetalCost.Name = "MetalCost";
            this.MetalCost.ReadOnly = true;
            this.MetalCost.Width = 50;
            // 
            // CarbonCost
            // 
            this.CarbonCost.DataPropertyName = "CarbonCost";
            this.CarbonCost.HeaderText = "Carbon";
            this.CarbonCost.Name = "CarbonCost";
            this.CarbonCost.ReadOnly = true;
            this.CarbonCost.Width = 50;
            // 
            // FuleCost
            // 
            this.FuleCost.DataPropertyName = "FuleCost";
            this.FuleCost.HeaderText = "Fule";
            this.FuleCost.Name = "FuleCost";
            this.FuleCost.ReadOnly = true;
            this.FuleCost.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Start";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Text = "Start building";
            this.Column4.UseColumnTextForButtonValue = true;
            this.Column4.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Name";
            this.Column7.HeaderText = "Details";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Details";
            this.Column7.UseColumnTextForButtonValue = true;
            this.Column7.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Building";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cancle";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Text = "Cancle";
            this.Column6.UseColumnTextForButtonValue = true;
            this.Column6.Visible = false;
            this.Column6.Width = 50;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 482);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.fule);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.carbon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.metal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddfs);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.Text = "Life";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ddfs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buildingLevelViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label metal;
        private System.Windows.Forms.Label carbon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource buildingLevelBindingSource;
        private System.Windows.Forms.BindingSource userViewModelBindingSource;
        private System.Windows.Forms.BindingSource buildingLevelViewModelBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn metalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbonCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuleCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Cancle;
        private System.Windows.Forms.TabControl ddfs;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource planetViewModelBindingSource;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarbonCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuleCost;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}