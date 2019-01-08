namespace BEAProjectManagement
{
    partial class frmActivityTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivityTeam));
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.tblActivityTeamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblActivityTeamTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.tblActivityTeamTableAdapter();
            this.tableAdapterManager = new BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager();
            this.tblActivityTeamBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblActivityTeamBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblActivityTeamDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vProjectTeamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actteamBudget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblRemainingBudget = new System.Windows.Forms.Label();
            this.vProjectTeamTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.vProjectTeamTableAdapter();
            this.lblCurrentActivity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityTeamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityTeamBindingNavigator)).BeginInit();
            this.tblActivityTeamBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityTeamDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProjectTeamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblActivityTeamBindingSource
            // 
            this.tblActivityTeamBindingSource.DataMember = "tblActivityTeam";
            this.tblActivityTeamBindingSource.DataSource = this.beaDBDataSet;
            // 
            // tblActivityTeamTableAdapter
            // 
            this.tblActivityTeamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblActivityTeamTableAdapter = this.tblActivityTeamTableAdapter;
            this.tableAdapterManager.tblActivityWorkByIDTableAdapter = null;
            this.tableAdapterManager.tblActivityWorksTableAdapter = null;
            this.tableAdapterManager.tblAvailabilityTableAdapter = null;
            this.tableAdapterManager.tblDepartmentsTableAdapter = null;
            this.tableAdapterManager.tblMonthsTableAdapter = null;
            this.tableAdapterManager.tblOccupationsTableAdapter = null;
            this.tableAdapterManager.tblPersonAvailabilityTableAdapter = null;
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
            // tblActivityTeamBindingNavigator
            // 
            this.tblActivityTeamBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblActivityTeamBindingNavigator.BindingSource = this.tblActivityTeamBindingSource;
            this.tblActivityTeamBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblActivityTeamBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblActivityTeamBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblActivityTeamBindingNavigatorSaveItem});
            this.tblActivityTeamBindingNavigator.Location = new System.Drawing.Point(0, 90);
            this.tblActivityTeamBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblActivityTeamBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblActivityTeamBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblActivityTeamBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblActivityTeamBindingNavigator.Name = "tblActivityTeamBindingNavigator";
            this.tblActivityTeamBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblActivityTeamBindingNavigator.Size = new System.Drawing.Size(1008, 25);
            this.tblActivityTeamBindingNavigator.TabIndex = 3;
            this.tblActivityTeamBindingNavigator.Text = "bindingNavigator1";
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
            // tblActivityTeamBindingNavigatorSaveItem
            // 
            this.tblActivityTeamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblActivityTeamBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblActivityTeamBindingNavigatorSaveItem.Image")));
            this.tblActivityTeamBindingNavigatorSaveItem.Name = "tblActivityTeamBindingNavigatorSaveItem";
            this.tblActivityTeamBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblActivityTeamBindingNavigatorSaveItem.Text = "Save Data";
            this.tblActivityTeamBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblActivityTeamBindingNavigatorSaveItem_Click);
            // 
            // tblActivityTeamDataGridView
            // 
            this.tblActivityTeamDataGridView.AutoGenerateColumns = false;
            this.tblActivityTeamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblActivityTeamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.actteamBudget,
            this.availabilityIcon,
            this.availability});
            this.tblActivityTeamDataGridView.DataSource = this.tblActivityTeamBindingSource;
            this.tblActivityTeamDataGridView.Location = new System.Drawing.Point(120, 180);
            this.tblActivityTeamDataGridView.Name = "tblActivityTeamDataGridView";
            this.tblActivityTeamDataGridView.Size = new System.Drawing.Size(599, 220);
            this.tblActivityTeamDataGridView.TabIndex = 5;
            this.tblActivityTeamDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblActivityTeamDataGridView_CellContentClick);
            this.tblActivityTeamDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblActivityTeamDataGridView_RowValidated);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "actteamID";
            this.dataGridViewTextBoxColumn1.HeaderText = "actteamID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "personID";
            this.dataGridViewTextBoxColumn2.DataSource = this.vProjectTeamBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "personName";
            this.dataGridViewTextBoxColumn2.HeaderText = "personID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "personID";
            // 
            // vProjectTeamBindingSource
            // 
            this.vProjectTeamBindingSource.DataMember = "vProjectTeam";
            this.vProjectTeamBindingSource.DataSource = this.beaDBDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "actteamWorkBudget";
            this.dataGridViewTextBoxColumn3.HeaderText = "actteamWorkBudget";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "practID";
            this.dataGridViewTextBoxColumn4.HeaderText = "practID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // actteamBudget
            // 
            this.actteamBudget.HeaderText = "actteamBudget";
            this.actteamBudget.Name = "actteamBudget";
            // 
            // availabilityIcon
            // 
            this.availabilityIcon.HeaderText = "availabilityIcon";
            this.availabilityIcon.Image = global::BEAProjectManagement.Properties.Resources.availability;
            this.availabilityIcon.Name = "availabilityIcon";
            this.availabilityIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.availabilityIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // availability
            // 
            this.availability.HeaderText = "availability";
            this.availability.Name = "availability";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(830, 101);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(35, 13);
            this.lblBudget.TabIndex = 6;
            this.lblBudget.Text = "label2";
            // 
            // lblRemainingBudget
            // 
            this.lblRemainingBudget.AutoSize = true;
            this.lblRemainingBudget.Location = new System.Drawing.Point(831, 126);
            this.lblRemainingBudget.Name = "lblRemainingBudget";
            this.lblRemainingBudget.Size = new System.Drawing.Size(35, 13);
            this.lblRemainingBudget.TabIndex = 7;
            this.lblRemainingBudget.Text = "label2";
            // 
            // vProjectTeamTableAdapter
            // 
            this.vProjectTeamTableAdapter.ClearBeforeFill = true;
            // 
            // lblCurrentActivity
            // 
            this.lblCurrentActivity.AutoSize = true;
            this.lblCurrentActivity.Location = new System.Drawing.Point(474, 101);
            this.lblCurrentActivity.Name = "lblCurrentActivity";
            this.lblCurrentActivity.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentActivity.TabIndex = 8;
            this.lblCurrentActivity.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(702, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(702, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label3";
            // 
            // frmActivityTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 573);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrentActivity);
            this.Controls.Add(this.lblRemainingBudget);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.tblActivityTeamDataGridView);
            this.Controls.Add(this.tblActivityTeamBindingNavigator);
            this.Name = "frmActivityTeam";
            this.Load += new System.EventHandler(this.frmActivityTeam2_Load);
            this.Controls.SetChildIndex(this.tblActivityTeamBindingNavigator, 0);
            this.Controls.SetChildIndex(this.tblActivityTeamDataGridView, 0);
            this.Controls.SetChildIndex(this.lblBudget, 0);
            this.Controls.SetChildIndex(this.lblRemainingBudget, 0);
            this.Controls.SetChildIndex(this.lblCurrentActivity, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityTeamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityTeamBindingNavigator)).EndInit();
            this.tblActivityTeamBindingNavigator.ResumeLayout(false);
            this.tblActivityTeamBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityTeamDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProjectTeamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private beaDBDataSet beaDBDataSet;
        private System.Windows.Forms.BindingSource tblActivityTeamBindingSource;
        private beaDBDataSetTableAdapters.tblActivityTeamTableAdapter tblActivityTeamTableAdapter;
        private beaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblActivityTeamBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblActivityTeamBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblActivityTeamDataGridView;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblRemainingBudget;
        private System.Windows.Forms.BindingSource vProjectTeamBindingSource;
        private beaDBDataSetTableAdapters.vProjectTeamTableAdapter vProjectTeamTableAdapter;
        private System.Windows.Forms.Label lblCurrentActivity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn actteamBudget;
        private System.Windows.Forms.DataGridViewImageColumn availabilityIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn availability;
    }
}
