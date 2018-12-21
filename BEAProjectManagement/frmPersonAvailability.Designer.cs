namespace BEAProjectManagement
{
    partial class frmPersonAvailability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonAvailability));
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.tblPersonAvailabilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPersonAvailabilityTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.tblPersonAvailabilityTableAdapter();
            this.tableAdapterManager = new BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager();
            this.tblPersonAvailabilityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblPersonAvailabilityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblPersonAvailabilityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vAvailabilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fromDate = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDate = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vAvailabilityTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.vAvailabilityTableAdapter();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonAvailabilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonAvailabilityBindingNavigator)).BeginInit();
            this.tblPersonAvailabilityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonAvailabilityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAvailabilityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonAvailabilityBindingSource
            // 
            this.tblPersonAvailabilityBindingSource.DataMember = "tblPersonAvailability";
            this.tblPersonAvailabilityBindingSource.DataSource = this.beaDBDataSet;
            // 
            // tblPersonAvailabilityTableAdapter
            // 
            this.tblPersonAvailabilityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblActivityTeamTableAdapter = null;
            this.tableAdapterManager.tblActivityWorkByIDTableAdapter = null;
            this.tableAdapterManager.tblActivityWorksTableAdapter = null;
            this.tableAdapterManager.tblAvailabilityTableAdapter = null;
            this.tableAdapterManager.tblDepartmentsTableAdapter = null;
            this.tableAdapterManager.tblMonthsTableAdapter = null;
            this.tableAdapterManager.tblOccupationsTableAdapter = null;
            this.tableAdapterManager.tblPersonAvailabilityTableAdapter = this.tblPersonAvailabilityTableAdapter;
            this.tableAdapterManager.tblPersonCostTableAdapter = null;
            this.tableAdapterManager.tblPersonHourAvailabilityTableAdapter = null;
            this.tableAdapterManager.tblPersonsTableAdapter = null;
            this.tableAdapterManager.tblProjectActivitiesTableAdapter = null;
            this.tableAdapterManager.tblProjectRolesTableAdapter = null;
            this.tableAdapterManager.tblProjectsTableAdapter = null;
            this.tableAdapterManager.tblProjectTeamTableAdapter = null;
            this.tableAdapterManager.tblUserRolesTableAdapter = null;
            this.tableAdapterManager.tblUsers1TableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblWorkActionsTableAdapter = null;
            this.tableAdapterManager.tblYearsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblPersonAvailabilityBindingNavigator
            // 
            this.tblPersonAvailabilityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblPersonAvailabilityBindingNavigator.BindingSource = this.tblPersonAvailabilityBindingSource;
            this.tblPersonAvailabilityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblPersonAvailabilityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblPersonAvailabilityBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tblPersonAvailabilityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblPersonAvailabilityBindingNavigatorSaveItem});
            this.tblPersonAvailabilityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblPersonAvailabilityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblPersonAvailabilityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblPersonAvailabilityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblPersonAvailabilityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblPersonAvailabilityBindingNavigator.Name = "tblPersonAvailabilityBindingNavigator";
            this.tblPersonAvailabilityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblPersonAvailabilityBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.tblPersonAvailabilityBindingNavigator.TabIndex = 8;
            this.tblPersonAvailabilityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblPersonAvailabilityBindingNavigatorSaveItem
            // 
            this.tblPersonAvailabilityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblPersonAvailabilityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblPersonAvailabilityBindingNavigatorSaveItem.Image")));
            this.tblPersonAvailabilityBindingNavigatorSaveItem.Name = "tblPersonAvailabilityBindingNavigatorSaveItem";
            this.tblPersonAvailabilityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblPersonAvailabilityBindingNavigatorSaveItem.Text = "Save Data";
            this.tblPersonAvailabilityBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblPersonAvailabilityBindingNavigatorSaveItem_Click_2);
            // 
            // tblPersonAvailabilityDataGridView
            // 
            this.tblPersonAvailabilityDataGridView.AutoGenerateColumns = false;
            this.tblPersonAvailabilityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPersonAvailabilityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.fromDate,
            this.dataGridViewTextBoxColumn3,
            this.toDate,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tblPersonAvailabilityDataGridView.DataSource = this.tblPersonAvailabilityBindingSource;
            this.tblPersonAvailabilityDataGridView.Location = new System.Drawing.Point(12, 122);
            this.tblPersonAvailabilityDataGridView.MultiSelect = false;
            this.tblPersonAvailabilityDataGridView.Name = "tblPersonAvailabilityDataGridView";
            this.tblPersonAvailabilityDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tblPersonAvailabilityDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tblPersonAvailabilityDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPersonAvailabilityDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tblPersonAvailabilityDataGridView.TabIndex = 9;
            this.tblPersonAvailabilityDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPersonAvailabilityDataGridView_CellContentClick);
            this.tblPersonAvailabilityDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPersonAvailabilityDataGridView_RowValidated);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "persavailID";
            this.dataGridViewTextBoxColumn1.HeaderText = "persavailID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "personID";
            this.dataGridViewTextBoxColumn2.HeaderText = "personID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "availabilityID";
            this.dataGridViewTextBoxColumn6.DataSource = this.vAvailabilityBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "availabilityDesc";
            this.dataGridViewTextBoxColumn6.HeaderText = "availabilityID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "availabilityID";
            // 
            // vAvailabilityBindingSource
            // 
            this.vAvailabilityBindingSource.DataMember = "vAvailability";
            this.vAvailabilityBindingSource.DataSource = this.beaDBDataSet;
            // 
            // fromDate
            // 
            this.fromDate.HeaderText = "Column1";
            this.fromDate.Image = global::BEAProjectManagement.Properties.Resources.calendar4;
            this.fromDate.Name = "fromDate";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "persavailDateFrom";
            this.dataGridViewTextBoxColumn3.HeaderText = "persavailDateFrom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // toDate
            // 
            this.toDate.HeaderText = "Column1";
            this.toDate.Image = global::BEAProjectManagement.Properties.Resources.calendar4;
            this.toDate.Name = "toDate";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "persavailDateTo";
            this.dataGridViewTextBoxColumn4.HeaderText = "persavailDateTo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "persavailWeekhours";
            this.dataGridViewTextBoxColumn5.HeaderText = "persavailWeekhours";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // vAvailabilityTableAdapter
            // 
            this.vAvailabilityTableAdapter.ClearBeforeFill = true;
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPersonel.Location = new System.Drawing.Point(371, 108);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(52, 19);
            this.lblPersonel.TabIndex = 10;
            this.lblPersonel.Text = "label2";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(404, 128);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 12;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(156, 128);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // frmPersonAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblPersonel);
            this.Controls.Add(this.tblPersonAvailabilityDataGridView);
            this.Controls.Add(this.tblPersonAvailabilityBindingNavigator);
            this.Name = "frmPersonAvailability";
            this.Load += new System.EventHandler(this.frmPersonAvailability_Load);
            this.Controls.SetChildIndex(this.tblPersonAvailabilityBindingNavigator, 0);
            this.Controls.SetChildIndex(this.tblPersonAvailabilityDataGridView, 0);
            this.Controls.SetChildIndex(this.lblPersonel, 0);
            this.Controls.SetChildIndex(this.monthCalendar1, 0);
            this.Controls.SetChildIndex(this.monthCalendar2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonAvailabilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonAvailabilityBindingNavigator)).EndInit();
            this.tblPersonAvailabilityBindingNavigator.ResumeLayout(false);
            this.tblPersonAvailabilityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonAvailabilityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAvailabilityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private beaDBDataSet beaDBDataSet;
        private System.Windows.Forms.BindingSource tblPersonAvailabilityBindingSource;
        private beaDBDataSetTableAdapters.tblPersonAvailabilityTableAdapter tblPersonAvailabilityTableAdapter;
        private beaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblPersonAvailabilityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblPersonAvailabilityBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblPersonAvailabilityDataGridView;
        private System.Windows.Forms.BindingSource vAvailabilityBindingSource;
        private beaDBDataSetTableAdapters.vAvailabilityTableAdapter vAvailabilityTableAdapter;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn fromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn toDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}
