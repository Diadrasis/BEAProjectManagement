namespace BEAProjectManagement
{
    partial class frmProjectTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectTeam));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblProjectTeamBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tblProjectTeamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
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
            this.tblProjectTeamBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblProjectTeamDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prteamRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prteamBudget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRemainingBudget = new System.Windows.Forms.Label();
            this.lblCurrentProject = new System.Windows.Forms.Label();
            this.tblProjectTeamTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.tblProjectTeamTableAdapter();
            this.tableAdapterManager = new BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager();
            this.vPersonsTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.vPersonsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectTeamBindingNavigator)).BeginInit();
            this.tblProjectTeamBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectTeamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectTeamDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPersonsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblProjectTeamBindingNavigator
            // 
            this.tblProjectTeamBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblProjectTeamBindingNavigator.BindingSource = this.tblProjectTeamBindingSource;
            this.tblProjectTeamBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblProjectTeamBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblProjectTeamBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblProjectTeamBindingNavigatorSaveItem});
            this.tblProjectTeamBindingNavigator.Location = new System.Drawing.Point(0, 90);
            this.tblProjectTeamBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblProjectTeamBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblProjectTeamBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblProjectTeamBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblProjectTeamBindingNavigator.Name = "tblProjectTeamBindingNavigator";
            this.tblProjectTeamBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblProjectTeamBindingNavigator.Size = new System.Drawing.Size(1444, 25);
            this.tblProjectTeamBindingNavigator.TabIndex = 1;
            this.tblProjectTeamBindingNavigator.Text = "bindingNavigator1";
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
            // tblProjectTeamBindingSource
            // 
            this.tblProjectTeamBindingSource.DataMember = "tblProjectTeam";
            this.tblProjectTeamBindingSource.DataSource = this.beaDBDataSet;
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tblProjectTeamBindingNavigatorSaveItem
            // 
            this.tblProjectTeamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblProjectTeamBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblProjectTeamBindingNavigatorSaveItem.Image")));
            this.tblProjectTeamBindingNavigatorSaveItem.Name = "tblProjectTeamBindingNavigatorSaveItem";
            this.tblProjectTeamBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblProjectTeamBindingNavigatorSaveItem.Text = "Save Data";
            this.tblProjectTeamBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblProjectTeamBindingNavigatorSaveItem_Click);
            // 
            // tblProjectTeamDataGridView
            // 
            this.tblProjectTeamDataGridView.AutoGenerateColumns = false;
            this.tblProjectTeamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProjectTeamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.prteamRole,
            this.prteamBudget,
            this.availabilityIcon,
            this.availability});
            this.tblProjectTeamDataGridView.DataSource = this.tblProjectTeamBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblProjectTeamDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblProjectTeamDataGridView.Location = new System.Drawing.Point(150, 184);
            this.tblProjectTeamDataGridView.MultiSelect = false;
            this.tblProjectTeamDataGridView.Name = "tblProjectTeamDataGridView";
            this.tblProjectTeamDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProjectTeamDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tblProjectTeamDataGridView.StandardTab = true;
            this.tblProjectTeamDataGridView.TabIndex = 3;
            this.tblProjectTeamDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblProjectTeamDataGridView_CellContentClick);
            this.tblProjectTeamDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblProjectTeamDataGridView_RowValidated);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "prteamID";
            this.dataGridViewTextBoxColumn1.HeaderText = "prteamID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "projID";
            this.dataGridViewTextBoxColumn2.HeaderText = "projID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "personID";
            this.dataGridViewTextBoxColumn3.DataSource = this.vPersonsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "personName";
            this.dataGridViewTextBoxColumn3.HeaderText = "personID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "personID";
            // 
            // vPersonsBindingSource
            // 
            this.vPersonsBindingSource.DataMember = "vPersons";
            this.vPersonsBindingSource.DataSource = this.beaDBDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "prteamWorkBudget1";
            this.dataGridViewTextBoxColumn4.HeaderText = "prteamWorkBudget";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // prteamRole
            // 
            this.prteamRole.DataPropertyName = "prteamRole";
            this.prteamRole.HeaderText = "prteamRole";
            this.prteamRole.Name = "prteamRole";
            // 
            // prteamBudget
            // 
            this.prteamBudget.DataPropertyName = "prteamBudget";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.prteamBudget.DefaultCellStyle = dataGridViewCellStyle1;
            this.prteamBudget.HeaderText = "prteamBudget";
            this.prteamBudget.Name = "prteamBudget";
            // 
            // availabilityIcon
            // 
            this.availabilityIcon.HeaderText = "availabilityIcon";
            this.availabilityIcon.Image = global::BEAProjectManagement.Properties.Resources.availability;
            this.availabilityIcon.Name = "availabilityIcon";
            // 
            // availability
            // 
            this.availability.HeaderText = "availability";
            this.availability.Name = "availability";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(1190, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // lblBudget
            // 
            this.lblBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblBudget.Location = new System.Drawing.Point(1313, 96);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(47, 17);
            this.lblBudget.TabIndex = 5;
            this.lblBudget.Text = "label3";
            this.lblBudget.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(1191, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // lblRemainingBudget
            // 
            this.lblRemainingBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemainingBudget.AutoSize = true;
            this.lblRemainingBudget.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblRemainingBudget.Location = new System.Drawing.Point(1313, 119);
            this.lblRemainingBudget.Name = "lblRemainingBudget";
            this.lblRemainingBudget.Size = new System.Drawing.Size(47, 17);
            this.lblRemainingBudget.TabIndex = 7;
            this.lblRemainingBudget.Text = "label5";
            this.lblRemainingBudget.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCurrentProject
            // 
            this.lblCurrentProject.AutoSize = true;
            this.lblCurrentProject.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCurrentProject.Location = new System.Drawing.Point(300, 97);
            this.lblCurrentProject.Name = "lblCurrentProject";
            this.lblCurrentProject.Size = new System.Drawing.Size(47, 17);
            this.lblCurrentProject.TabIndex = 8;
            this.lblCurrentProject.Text = "label3";
            // 
            // tblProjectTeamTableAdapter
            // 
            this.tblProjectTeamTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblPersonAvailabilityTableAdapter = null;
            this.tableAdapterManager.tblPersonCostTableAdapter = null;
            this.tableAdapterManager.tblPersonHourAvailabilityTableAdapter = null;
            this.tableAdapterManager.tblPersonsTableAdapter = null;
            this.tableAdapterManager.tblProjectActivitiesTableAdapter = null;
            this.tableAdapterManager.tblProjectRolesTableAdapter = null;
            this.tableAdapterManager.tblProjectsTableAdapter = null;
            this.tableAdapterManager.tblProjectTeamTableAdapter = this.tblProjectTeamTableAdapter;
            this.tableAdapterManager.tblUserRolesTableAdapter = null;
            this.tableAdapterManager.tblUsers1TableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblWorkActionsTableAdapter = null;
            this.tableAdapterManager.tblYearsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vPersonsTableAdapter
            // 
            this.vPersonsTableAdapter.ClearBeforeFill = true;
            // 
            // frmProjectTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1444, 501);
            this.Controls.Add(this.lblCurrentProject);
            this.Controls.Add(this.lblRemainingBudget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tblProjectTeamDataGridView);
            this.Controls.Add(this.tblProjectTeamBindingNavigator);
            this.Name = "frmProjectTeam";
            this.Load += new System.EventHandler(this.frmProjectTeam_Load);
            this.Controls.SetChildIndex(this.tblProjectTeamBindingNavigator, 0);
            this.Controls.SetChildIndex(this.tblProjectTeamDataGridView, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblBudget, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblRemainingBudget, 0);
            this.Controls.SetChildIndex(this.lblCurrentProject, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectTeamBindingNavigator)).EndInit();
            this.tblProjectTeamBindingNavigator.ResumeLayout(false);
            this.tblProjectTeamBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectTeamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectTeamDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPersonsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private beaDBDataSet beaDBDataSet;
        private System.Windows.Forms.BindingSource tblProjectTeamBindingSource;
        private beaDBDataSetTableAdapters.tblProjectTeamTableAdapter tblProjectTeamTableAdapter;
        private beaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblProjectTeamBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblProjectTeamBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblProjectTeamDataGridView;
        private System.Windows.Forms.BindingSource vPersonsBindingSource;
        private beaDBDataSetTableAdapters.vPersonsTableAdapter vPersonsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRemainingBudget;
        private System.Windows.Forms.Label lblCurrentProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn prteamRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn prteamBudget;
        private System.Windows.Forms.DataGridViewImageColumn availabilityIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn availability;
    }
}
