using System.Windows.Forms;

namespace Chummer
{
    partial class frmSelectLifestyleAdvanced
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
            if (disposing)
            {
                components?.Dispose();
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Positive Qualities");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Negative Qualities");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Entertainments");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Free Matrix Grids");
            this.Label_SelectAdvancedLifestyle_Upgrade_Comforts = new System.Windows.Forms.Label();
            this.cmdOKAdd = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.lblTotalLPLabel = new System.Windows.Forms.Label();
            this.lblTotalLP = new System.Windows.Forms.Label();
            this.lblCostLabel = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblLifestyleNameLabel = new System.Windows.Forms.Label();
            this.txtLifestyleName = new System.Windows.Forms.TextBox();
            this.nudPercentage = new System.Windows.Forms.NumericUpDown();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblSourceLabel = new System.Windows.Forms.Label();
            this.nudRoommates = new System.Windows.Forms.NumericUpDown();
            this.lblRoommates = new System.Windows.Forms.Label();
            this.cboBaseLifestyle = new System.Windows.Forms.ComboBox();
            this.Label_SelectAdvancedLifestyle_Lifestyle = new System.Windows.Forms.Label();
            this.nudSecurity = new System.Windows.Forms.NumericUpDown();
            this.nudArea = new System.Windows.Forms.NumericUpDown();
            this.nudComforts = new System.Windows.Forms.NumericUpDown();
            this.Label_SelectAdvancedLifestyle_Comforts = new System.Windows.Forms.Label();
            this.Label_SelectAdvancedLifestyle_Neighborhood = new System.Windows.Forms.Label();
            this.Label_SelectAdvancedLifestyle_Securities = new System.Windows.Forms.Label();
            this.cmdAddQuality = new System.Windows.Forms.Button();
            this.cmdDeleteQuality = new System.Windows.Forms.Button();
            this.treLifestyleQualities = new System.Windows.Forms.TreeView();
            this.chkTrustFund = new System.Windows.Forms.CheckBox();
            this.lblQualityLp = new System.Windows.Forms.Label();
            this.lblQualityLPLabel = new System.Windows.Forms.Label();
            this.lblQualitySource = new System.Windows.Forms.Label();
            this.lblQualitySourceLabel = new System.Windows.Forms.Label();
            this.lblQualityCost = new System.Windows.Forms.Label();
            this.lblQualityCostLabel = new System.Windows.Forms.Label();
            this.chkPrimaryTenant = new System.Windows.Forms.CheckBox();
            this.lblSecurityTotal = new System.Windows.Forms.Label();
            this.lblAreaTotal = new System.Windows.Forms.Label();
            this.lblComfortTotal = new System.Windows.Forms.Label();
            this.chkQualityContributesLP = new System.Windows.Forms.CheckBox();
            this.lblBonusLP = new System.Windows.Forms.Label();
            this.nudBonusLP = new System.Windows.Forms.NumericUpDown();
            this.chkBonusLPRandomize = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_SelectAdvancedLifestyle_Base_Comforts = new System.Windows.Forms.Label();
            this.Label_SelectAdvancedLifestyle_Base_Neighborhood = new System.Windows.Forms.Label();
            this.Label_SelectAdvancedLifestyle_Base_Security = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoommates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudComforts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonusLP)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_SelectAdvancedLifestyle_Upgrade_Comforts
            // 
            this.Label_SelectAdvancedLifestyle_Upgrade_Comforts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_SelectAdvancedLifestyle_Upgrade_Comforts.AutoSize = true;
            this.Label_SelectAdvancedLifestyle_Upgrade_Comforts.Location = new System.Drawing.Point(153, 85);
            this.Label_SelectAdvancedLifestyle_Upgrade_Comforts.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Label_SelectAdvancedLifestyle_Upgrade_Comforts.Name = "Label_SelectAdvancedLifestyle_Upgrade_Comforts";
            this.Label_SelectAdvancedLifestyle_Upgrade_Comforts.Size = new System.Drawing.Size(51, 13);
            this.Label_SelectAdvancedLifestyle_Upgrade_Comforts.TabIndex = 2;
            this.Label_SelectAdvancedLifestyle_Upgrade_Comforts.Tag = "Label_SelectAdvancedLifestyle_Rating";
            this.Label_SelectAdvancedLifestyle_Upgrade_Comforts.Text = "Upgrade:";
            // 
            // cmdOKAdd
            // 
            this.cmdOKAdd.Location = new System.Drawing.Point(456, 406);
            this.cmdOKAdd.Name = "cmdOKAdd";
            this.cmdOKAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdOKAdd.TabIndex = 27;
            this.cmdOKAdd.Tag = "String_AddMore";
            this.cmdOKAdd.Text = "&Add && More";
            this.cmdOKAdd.UseVisualStyleBackColor = true;
            this.cmdOKAdd.Click += new System.EventHandler(this.cmdOKAdd_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(375, 406);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 28;
            this.cmdCancel.Tag = "String_Cancel";
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(537, 406);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 26;
            this.cmdOK.Tag = "String_OK";
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // lblTotalLPLabel
            // 
            this.lblTotalLPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalLPLabel.AutoSize = true;
            this.lblTotalLPLabel.Location = new System.Drawing.Point(3, 188);
            this.lblTotalLPLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTotalLPLabel.Name = "lblTotalLPLabel";
            this.lblTotalLPLabel.Size = new System.Drawing.Size(63, 13);
            this.lblTotalLPLabel.TabIndex = 12;
            this.lblTotalLPLabel.Tag = "Label_SelectAdvancedLifestyle_UnusedLP";
            this.lblTotalLPLabel.Text = "Unused LP:";
            // 
            // lblTotalLP
            // 
            this.lblTotalLP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalLP.AutoSize = true;
            this.lblTotalLP.Location = new System.Drawing.Point(93, 188);
            this.lblTotalLP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTotalLP.Name = "lblTotalLP";
            this.lblTotalLP.Size = new System.Drawing.Size(26, 13);
            this.lblTotalLP.TabIndex = 13;
            this.lblTotalLP.Text = "[LP]";
            // 
            // lblCostLabel
            // 
            this.lblCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCostLabel.AutoSize = true;
            this.lblCostLabel.Location = new System.Drawing.Point(3, 265);
            this.lblCostLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCostLabel.Name = "lblCostLabel";
            this.lblCostLabel.Size = new System.Drawing.Size(66, 13);
            this.lblCostLabel.TabIndex = 18;
            this.lblCostLabel.Tag = "Label_SelectLifestyle_CostPerMonth";
            this.lblCostLabel.Text = "Cost/Month:";
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(93, 265);
            this.lblCost.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(34, 13);
            this.lblCost.TabIndex = 19;
            this.lblCost.Text = "[Cost]";
            // 
            // lblLifestyleNameLabel
            // 
            this.lblLifestyleNameLabel.AutoSize = true;
            this.lblLifestyleNameLabel.Location = new System.Drawing.Point(3, 6);
            this.lblLifestyleNameLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLifestyleNameLabel.Name = "lblLifestyleNameLabel";
            this.lblLifestyleNameLabel.Size = new System.Drawing.Size(38, 13);
            this.lblLifestyleNameLabel.TabIndex = 0;
            this.lblLifestyleNameLabel.Tag = "Label_Name";
            this.lblLifestyleNameLabel.Text = "Name:";
            // 
            // txtLifestyleName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtLifestyleName, 3);
            this.txtLifestyleName.Location = new System.Drawing.Point(93, 3);
            this.txtLifestyleName.Name = "txtLifestyleName";
            this.txtLifestyleName.Size = new System.Drawing.Size(205, 20);
            this.txtLifestyleName.TabIndex = 1;
            // 
            // nudPercentage
            // 
            this.nudPercentage.DecimalPlaces = 2;
            this.nudPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPercentage.Location = new System.Drawing.Point(93, 236);
            this.nudPercentage.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.nudPercentage.Name = "nudPercentage";
            this.nudPercentage.Size = new System.Drawing.Size(54, 20);
            this.nudPercentage.TabIndex = 17;
            this.nudPercentage.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPercentage.ValueChanged += new System.EventHandler(this.nudPercentage_ValueChanged);
            // 
            // lblPercentage
            // 
            this.lblPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(3, 239);
            this.lblPercentage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(51, 14);
            this.lblPercentage.TabIndex = 16;
            this.lblPercentage.Tag = "Label_SelectLifestyle_PercentToPay";
            this.lblPercentage.Text = "% to Pay:";
            // 
            // lblSource
            // 
            this.lblSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(93, 290);
            this.lblSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(47, 13);
            this.lblSource.TabIndex = 21;
            this.lblSource.Text = "[Source]";
            this.lblSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblSourceLabel
            // 
            this.lblSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSourceLabel.AutoSize = true;
            this.lblSourceLabel.Location = new System.Drawing.Point(3, 290);
            this.lblSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSourceLabel.Name = "lblSourceLabel";
            this.lblSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblSourceLabel.TabIndex = 20;
            this.lblSourceLabel.Tag = "Label_Source";
            this.lblSourceLabel.Text = "Source:";
            // 
            // nudRoommates
            // 
            this.nudRoommates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRoommates.Location = new System.Drawing.Point(93, 210);
            this.nudRoommates.Name = "nudRoommates";
            this.nudRoommates.Size = new System.Drawing.Size(54, 20);
            this.nudRoommates.TabIndex = 15;
            this.nudRoommates.ValueChanged += new System.EventHandler(this.nudRoommates_ValueChanged);
            // 
            // lblRoommates
            // 
            this.lblRoommates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRoommates.AutoSize = true;
            this.lblRoommates.Location = new System.Drawing.Point(3, 213);
            this.lblRoommates.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblRoommates.Name = "lblRoommates";
            this.lblRoommates.Size = new System.Drawing.Size(66, 14);
            this.lblRoommates.TabIndex = 14;
            this.lblRoommates.Tag = "Label_SelectLifestyle_Roommates";
            this.lblRoommates.Text = "Roommates:";
            // 
            // cboBaseLifestyle
            // 
            this.cboBaseLifestyle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.cboBaseLifestyle, 3);
            this.cboBaseLifestyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaseLifestyle.FormattingEnabled = true;
            this.cboBaseLifestyle.Location = new System.Drawing.Point(93, 29);
            this.cboBaseLifestyle.Name = "cboBaseLifestyle";
            this.cboBaseLifestyle.Size = new System.Drawing.Size(205, 21);
            this.cboBaseLifestyle.TabIndex = 32;
            this.cboBaseLifestyle.SelectedIndexChanged += new System.EventHandler(this.cboBaseLifestyle_SelectedIndexChanged);
            // 
            // Label_SelectAdvancedLifestyle_Lifestyle
            // 
            this.Label_SelectAdvancedLifestyle_Lifestyle.AutoSize = true;
            this.Label_SelectAdvancedLifestyle_Lifestyle.Location = new System.Drawing.Point(3, 32);
            this.Label_SelectAdvancedLifestyle_Lifestyle.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Label_SelectAdvancedLifestyle_Lifestyle.Name = "Label_SelectAdvancedLifestyle_Lifestyle";
            this.Label_SelectAdvancedLifestyle_Lifestyle.Size = new System.Drawing.Size(48, 13);
            this.Label_SelectAdvancedLifestyle_Lifestyle.TabIndex = 31;
            this.Label_SelectAdvancedLifestyle_Lifestyle.Tag = "Label_SelectAdvancedLifestyle_Lifestyle";
            this.Label_SelectAdvancedLifestyle_Lifestyle.Text = "Lifestyle:";
            // 
            // nudSecurity
            // 
            this.nudSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSecurity.Location = new System.Drawing.Point(153, 159);
            this.nudSecurity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSecurity.Name = "nudSecurity";
            this.nudSecurity.Size = new System.Drawing.Size(99, 20);
            this.nudSecurity.TabIndex = 41;
            this.nudSecurity.ValueChanged += new System.EventHandler(this.nudSecurity_ValueChanged);
            // 
            // nudArea
            // 
            this.nudArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudArea.Location = new System.Drawing.Point(153, 133);
            this.nudArea.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudArea.Name = "nudArea";
            this.nudArea.Size = new System.Drawing.Size(99, 20);
            this.nudArea.TabIndex = 40;
            this.nudArea.ValueChanged += new System.EventHandler(this.nudArea_ValueChanged);
            // 
            // nudComforts
            // 
            this.nudComforts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudComforts.Location = new System.Drawing.Point(153, 107);
            this.nudComforts.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudComforts.Name = "nudComforts";
            this.nudComforts.Size = new System.Drawing.Size(99, 20);
            this.nudComforts.TabIndex = 39;
            this.nudComforts.ValueChanged += new System.EventHandler(this.nudComforts_ValueChanged);
            // 
            // Label_SelectAdvancedLifestyle_Comforts
            // 
            this.Label_SelectAdvancedLifestyle_Comforts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_SelectAdvancedLifestyle_Comforts.AutoSize = true;
            this.Label_SelectAdvancedLifestyle_Comforts.Location = new System.Drawing.Point(3, 110);
            this.Label_SelectAdvancedLifestyle_Comforts.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Label_SelectAdvancedLifestyle_Comforts.Name = "Label_SelectAdvancedLifestyle_Comforts";
            this.Label_SelectAdvancedLifestyle_Comforts.Size = new System.Drawing.Size(51, 14);
            this.Label_SelectAdvancedLifestyle_Comforts.TabIndex = 42;
            this.Label_SelectAdvancedLifestyle_Comforts.Tag = "Label_SelectAdvancedLifestyle_Comforts";
            this.Label_SelectAdvancedLifestyle_Comforts.Text = "Comforts:";
            // 
            // Label_SelectAdvancedLifestyle_Neighborhood
            // 
            this.Label_SelectAdvancedLifestyle_Neighborhood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_SelectAdvancedLifestyle_Neighborhood.AutoSize = true;
            this.Label_SelectAdvancedLifestyle_Neighborhood.Location = new System.Drawing.Point(3, 136);
            this.Label_SelectAdvancedLifestyle_Neighborhood.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Label_SelectAdvancedLifestyle_Neighborhood.Name = "Label_SelectAdvancedLifestyle_Neighborhood";
            this.Label_SelectAdvancedLifestyle_Neighborhood.Size = new System.Drawing.Size(77, 14);
            this.Label_SelectAdvancedLifestyle_Neighborhood.TabIndex = 46;
            this.Label_SelectAdvancedLifestyle_Neighborhood.Tag = "Label_SelectAdvancedLifestyle_Neighborhood";
            this.Label_SelectAdvancedLifestyle_Neighborhood.Text = "Neighborhood:";
            // 
            // Label_SelectAdvancedLifestyle_Securities
            // 
            this.Label_SelectAdvancedLifestyle_Securities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_SelectAdvancedLifestyle_Securities.AutoSize = true;
            this.Label_SelectAdvancedLifestyle_Securities.Location = new System.Drawing.Point(3, 162);
            this.Label_SelectAdvancedLifestyle_Securities.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Label_SelectAdvancedLifestyle_Securities.Name = "Label_SelectAdvancedLifestyle_Securities";
            this.Label_SelectAdvancedLifestyle_Securities.Size = new System.Drawing.Size(48, 14);
            this.Label_SelectAdvancedLifestyle_Securities.TabIndex = 48;
            this.Label_SelectAdvancedLifestyle_Securities.Tag = "Label_SelectAdvancedLifestyle_Security";
            this.Label_SelectAdvancedLifestyle_Securities.Text = "Security:";
            // 
            // cmdAddQuality
            // 
            this.cmdAddQuality.Location = new System.Drawing.Point(12, 12);
            this.cmdAddQuality.Name = "cmdAddQuality";
            this.cmdAddQuality.Size = new System.Drawing.Size(120, 23);
            this.cmdAddQuality.TabIndex = 51;
            this.cmdAddQuality.Tag = "Button_AddQuality";
            this.cmdAddQuality.Text = "Add Quality";
            this.cmdAddQuality.UseVisualStyleBackColor = true;
            this.cmdAddQuality.Click += new System.EventHandler(this.cmdAddQuality_Click);
            // 
            // cmdDeleteQuality
            // 
            this.cmdDeleteQuality.Enabled = false;
            this.cmdDeleteQuality.Location = new System.Drawing.Point(138, 12);
            this.cmdDeleteQuality.Name = "cmdDeleteQuality";
            this.cmdDeleteQuality.Size = new System.Drawing.Size(120, 23);
            this.cmdDeleteQuality.TabIndex = 52;
            this.cmdDeleteQuality.Tag = "Button_DeleteQuality";
            this.cmdDeleteQuality.Text = "Delete Quality";
            this.cmdDeleteQuality.UseVisualStyleBackColor = true;
            this.cmdDeleteQuality.Click += new System.EventHandler(this.cmdDeleteQuality_Click);
            // 
            // treLifestyleQualities
            // 
            this.treLifestyleQualities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treLifestyleQualities.HideSelection = false;
            this.treLifestyleQualities.Location = new System.Drawing.Point(12, 41);
            this.treLifestyleQualities.Name = "treLifestyleQualities";
            treeNode1.Name = "nodPositiveLifestyleQualities";
            treeNode1.Tag = "Node_SelectAdvancedLifestyle_PositiveQualities";
            treeNode1.Text = "Positive Qualities";
            treeNode2.Name = "nodNegativeLifestyleQualities";
            treeNode2.Tag = "Node_SelectAdvancedLifestyle_NegativeQualities";
            treeNode2.Text = "Negative Qualities";
            treeNode3.Name = "nodLifestyleEntertainments";
            treeNode3.Tag = "Node_SelectAdvancedLifestyle_Entertainments";
            treeNode3.Text = "Entertainments";
            treeNode4.Name = "nodFreeMatrixGrids";
            treeNode4.Tag = "Node_SelectAdvancedLifestyle_FreeMatrixGrids";
            treeNode4.Text = "Free Matrix Grids";
            this.treLifestyleQualities.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treLifestyleQualities.Size = new System.Drawing.Size(293, 388);
            this.treLifestyleQualities.TabIndex = 53;
            this.treLifestyleQualities.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treLifestyleQualities_AfterSelect);
            // 
            // chkTrustFund
            // 
            this.chkTrustFund.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTrustFund.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkTrustFund, 2);
            this.chkTrustFund.Location = new System.Drawing.Point(153, 237);
            this.chkTrustFund.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkTrustFund.Name = "chkTrustFund";
            this.chkTrustFund.Size = new System.Drawing.Size(77, 18);
            this.chkTrustFund.TabIndex = 54;
            this.chkTrustFund.Text = "Trust Fund";
            this.chkTrustFund.UseVisualStyleBackColor = true;
            this.chkTrustFund.Visible = false;
            this.chkTrustFund.CheckedChanged += new System.EventHandler(this.chkTrustFund_Changed);
            // 
            // lblQualityLp
            // 
            this.lblQualityLp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQualityLp.AutoSize = true;
            this.lblQualityLp.Location = new System.Drawing.Point(93, 315);
            this.lblQualityLp.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQualityLp.Name = "lblQualityLp";
            this.lblQualityLp.Size = new System.Drawing.Size(26, 13);
            this.lblQualityLp.TabIndex = 71;
            this.lblQualityLp.Text = "[LP]";
            // 
            // lblQualityLPLabel
            // 
            this.lblQualityLPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQualityLPLabel.AutoSize = true;
            this.lblQualityLPLabel.Location = new System.Drawing.Point(3, 315);
            this.lblQualityLPLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQualityLPLabel.Name = "lblQualityLPLabel";
            this.lblQualityLPLabel.Size = new System.Drawing.Size(58, 13);
            this.lblQualityLPLabel.TabIndex = 70;
            this.lblQualityLPLabel.Tag = "Label_QualityLP";
            this.lblQualityLPLabel.Text = "Quality LP:";
            this.lblQualityLPLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblQualityLPLabel.Visible = false;
            // 
            // lblQualitySource
            // 
            this.lblQualitySource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQualitySource.AutoSize = true;
            this.lblQualitySource.Location = new System.Drawing.Point(93, 365);
            this.lblQualitySource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQualitySource.Name = "lblQualitySource";
            this.lblQualitySource.Size = new System.Drawing.Size(47, 17);
            this.lblQualitySource.TabIndex = 69;
            this.lblQualitySource.Text = "[Source]";
            this.lblQualitySource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblQualitySourceLabel
            // 
            this.lblQualitySourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQualitySourceLabel.AutoSize = true;
            this.lblQualitySourceLabel.Location = new System.Drawing.Point(3, 365);
            this.lblQualitySourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQualitySourceLabel.Name = "lblQualitySourceLabel";
            this.lblQualitySourceLabel.Size = new System.Drawing.Size(79, 17);
            this.lblQualitySourceLabel.TabIndex = 68;
            this.lblQualitySourceLabel.Tag = "Label_QualitySource";
            this.lblQualitySourceLabel.Text = "Quality Source:";
            this.lblQualitySourceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblQualitySourceLabel.Visible = false;
            // 
            // lblQualityCost
            // 
            this.lblQualityCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQualityCost.AutoSize = true;
            this.lblQualityCost.Location = new System.Drawing.Point(93, 340);
            this.lblQualityCost.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQualityCost.Name = "lblQualityCost";
            this.lblQualityCost.Size = new System.Drawing.Size(34, 13);
            this.lblQualityCost.TabIndex = 73;
            this.lblQualityCost.Text = "[Cost]";
            // 
            // lblQualityCostLabel
            // 
            this.lblQualityCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQualityCostLabel.AutoSize = true;
            this.lblQualityCostLabel.Location = new System.Drawing.Point(3, 340);
            this.lblQualityCostLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQualityCostLabel.Name = "lblQualityCostLabel";
            this.lblQualityCostLabel.Size = new System.Drawing.Size(66, 13);
            this.lblQualityCostLabel.TabIndex = 72;
            this.lblQualityCostLabel.Tag = "Label_QualityCost";
            this.lblQualityCostLabel.Text = "Quality Cost:";
            this.lblQualityCostLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblQualityCostLabel.Visible = false;
            // 
            // chkPrimaryTenant
            // 
            this.chkPrimaryTenant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkPrimaryTenant.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkPrimaryTenant, 2);
            this.chkPrimaryTenant.Location = new System.Drawing.Point(153, 211);
            this.chkPrimaryTenant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkPrimaryTenant.Name = "chkPrimaryTenant";
            this.chkPrimaryTenant.Size = new System.Drawing.Size(97, 18);
            this.chkPrimaryTenant.TabIndex = 74;
            this.chkPrimaryTenant.Tag = "Label_SelectAdvancedLifestyle_Tenant";
            this.chkPrimaryTenant.Text = "Primary Tenant";
            this.chkPrimaryTenant.UseVisualStyleBackColor = true;
            this.chkPrimaryTenant.CheckedChanged += new System.EventHandler(this.chkPrimaryTenant_CheckedChanged);
            // 
            // lblSecurityTotal
            // 
            this.lblSecurityTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSecurityTotal.AutoSize = true;
            this.lblSecurityTotal.Location = new System.Drawing.Point(258, 162);
            this.lblSecurityTotal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSecurityTotal.Name = "lblSecurityTotal";
            this.lblSecurityTotal.Size = new System.Drawing.Size(19, 14);
            this.lblSecurityTotal.TabIndex = 77;
            this.lblSecurityTotal.Tag = "";
            this.lblSecurityTotal.Text = "[0]";
            // 
            // lblAreaTotal
            // 
            this.lblAreaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAreaTotal.AutoSize = true;
            this.lblAreaTotal.Location = new System.Drawing.Point(258, 136);
            this.lblAreaTotal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAreaTotal.Name = "lblAreaTotal";
            this.lblAreaTotal.Size = new System.Drawing.Size(19, 14);
            this.lblAreaTotal.TabIndex = 76;
            this.lblAreaTotal.Tag = "";
            this.lblAreaTotal.Text = "[0]";
            // 
            // lblComfortTotal
            // 
            this.lblComfortTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComfortTotal.AutoSize = true;
            this.lblComfortTotal.Location = new System.Drawing.Point(258, 110);
            this.lblComfortTotal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblComfortTotal.Name = "lblComfortTotal";
            this.lblComfortTotal.Size = new System.Drawing.Size(19, 14);
            this.lblComfortTotal.TabIndex = 75;
            this.lblComfortTotal.Tag = "";
            this.lblComfortTotal.Text = "[0]";
            // 
            // chkQualityContributesLP
            // 
            this.chkQualityContributesLP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkQualityContributesLP.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkQualityContributesLP, 2);
            this.chkQualityContributesLP.Location = new System.Drawing.Point(153, 313);
            this.chkQualityContributesLP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkQualityContributesLP.Name = "chkQualityContributesLP";
            this.chkQualityContributesLP.Size = new System.Drawing.Size(142, 17);
            this.chkQualityContributesLP.TabIndex = 78;
            this.chkQualityContributesLP.Tag = "Label_SelectAdvancedLifestyle_LPContribution";
            this.chkQualityContributesLP.Text = "Quality Contributes to LP";
            this.chkQualityContributesLP.UseVisualStyleBackColor = true;
            this.chkQualityContributesLP.Visible = false;
            this.chkQualityContributesLP.CheckedChanged += new System.EventHandler(this.chkQualityContributesLP_CheckedChanged);
            // 
            // lblBonusLP
            // 
            this.lblBonusLP.AutoSize = true;
            this.lblBonusLP.Location = new System.Drawing.Point(3, 59);
            this.lblBonusLP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBonusLP.Name = "lblBonusLP";
            this.lblBonusLP.Size = new System.Drawing.Size(56, 13);
            this.lblBonusLP.TabIndex = 81;
            this.lblBonusLP.Tag = "Label_BonusLP";
            this.lblBonusLP.Text = "Bonus LP:";
            this.lblBonusLP.Visible = false;
            // 
            // nudBonusLP
            // 
            this.nudBonusLP.Location = new System.Drawing.Point(93, 56);
            this.nudBonusLP.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudBonusLP.Name = "nudBonusLP";
            this.nudBonusLP.Size = new System.Drawing.Size(48, 20);
            this.nudBonusLP.TabIndex = 82;
            this.nudBonusLP.Visible = false;
            this.nudBonusLP.ValueChanged += new System.EventHandler(this.nudBonusLP_ValueChanged);
            // 
            // chkBonusLPRandomize
            // 
            this.chkBonusLPRandomize.AutoSize = true;
            this.chkBonusLPRandomize.Checked = true;
            this.chkBonusLPRandomize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel1.SetColumnSpan(this.chkBonusLPRandomize, 2);
            this.chkBonusLPRandomize.Location = new System.Drawing.Point(153, 57);
            this.chkBonusLPRandomize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBonusLPRandomize.Name = "chkBonusLPRandomize";
            this.chkBonusLPRandomize.Size = new System.Drawing.Size(102, 17);
            this.chkBonusLPRandomize.TabIndex = 83;
            this.chkBonusLPRandomize.Tag = "Checkbox_Randomize1D6";
            this.chkBonusLPRandomize.Text = "Randomize 1D6";
            this.chkBonusLPRandomize.UseVisualStyleBackColor = true;
            this.chkBonusLPRandomize.Visible = false;
            this.chkBonusLPRandomize.CheckedChanged += new System.EventHandler(this.chkTravelerBonusLPRandomize_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.lblQualitySource, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.lblQualityCost, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.lblQualitySourceLabel, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.nudBonusLP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQualityCostLabel, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.chkPrimaryTenant, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.chkBonusLPRandomize, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQualityLp, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.lblLifestyleNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQualityLPLabel, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtLifestyleName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBonusLP, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Label_SelectAdvancedLifestyle_Lifestyle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkTrustFund, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.cboBaseLifestyle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label_SelectAdvancedLifestyle_Comforts, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSource, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.Label_SelectAdvancedLifestyle_Neighborhood, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSourceLabel, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.Label_SelectAdvancedLifestyle_Securities, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblCost, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblComfortTotal, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCostLabel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblAreaTotal, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.nudPercentage, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.nudRoommates, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblPercentage, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblSecurityTotal, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblRoommates, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.nudComforts, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.nudArea, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.nudSecurity, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.Label_SelectAdvancedLifestyle_Upgrade_Comforts, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalLPLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalLP, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.chkQualityContributesLP, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.Label_SelectAdvancedLifestyle_Base_Comforts, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Label_SelectAdvancedLifestyle_Base_Neighborhood, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Label_SelectAdvancedLifestyle_Base_Security, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(311, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 388);
            this.tableLayoutPanel1.TabIndex = 84;
            // 
            // Label_SelectAdvancedLifestyle_Base_Comforts
            // 
            this.Label_SelectAdvancedLifestyle_Base_Comforts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_SelectAdvancedLifestyle_Base_Comforts.AutoSize = true;
            this.Label_SelectAdvancedLifestyle_Base_Comforts.Location = new System.Drawing.Point(93, 110);
            this.Label_SelectAdvancedLifestyle_Base_Comforts.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Label_SelectAdvancedLifestyle_Base_Comforts.Name = "Label_SelectAdvancedLifestyle_Base_Comforts";
            this.Label_SelectAdvancedLifestyle_Base_Comforts.Size = new System.Drawing.Size(46, 14);
            this.Label_SelectAdvancedLifestyle_Base_Comforts.TabIndex = 84;
            this.Label_SelectAdvancedLifestyle_Base_Comforts.Tag = "Label_SelectAdvancedLifestyle_Base_Comforts";
            this.Label_SelectAdvancedLifestyle_Base_Comforts.Text = "[{0}/{1}]";
            // 
            // Label_SelectAdvancedLifestyle_Base_Neighborhood
            // 
            this.Label_SelectAdvancedLifestyle_Base_Neighborhood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_SelectAdvancedLifestyle_Base_Neighborhood.AutoSize = true;
            this.Label_SelectAdvancedLifestyle_Base_Neighborhood.Location = new System.Drawing.Point(93, 136);
            this.Label_SelectAdvancedLifestyle_Base_Neighborhood.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Label_SelectAdvancedLifestyle_Base_Neighborhood.Name = "Label_SelectAdvancedLifestyle_Base_Neighborhood";
            this.Label_SelectAdvancedLifestyle_Base_Neighborhood.Size = new System.Drawing.Size(46, 14);
            this.Label_SelectAdvancedLifestyle_Base_Neighborhood.TabIndex = 85;
            this.Label_SelectAdvancedLifestyle_Base_Neighborhood.Tag = "Label_SelectAdvancedLifestyle_Base_Neighborhood";
            this.Label_SelectAdvancedLifestyle_Base_Neighborhood.Text = "[{0}/{1}]";
            // 
            // Label_SelectAdvancedLifestyle_Base_Security
            // 
            this.Label_SelectAdvancedLifestyle_Base_Security.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_SelectAdvancedLifestyle_Base_Security.AutoSize = true;
            this.Label_SelectAdvancedLifestyle_Base_Security.Location = new System.Drawing.Point(93, 162);
            this.Label_SelectAdvancedLifestyle_Base_Security.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Label_SelectAdvancedLifestyle_Base_Security.Name = "Label_SelectAdvancedLifestyle_Base_Security";
            this.Label_SelectAdvancedLifestyle_Base_Security.Size = new System.Drawing.Size(46, 14);
            this.Label_SelectAdvancedLifestyle_Base_Security.TabIndex = 86;
            this.Label_SelectAdvancedLifestyle_Base_Security.Tag = "Label_SelectAdvancedLifestyle_Base_Security";
            this.Label_SelectAdvancedLifestyle_Base_Security.Text = "[{0}/{1}]";
            // 
            // frmSelectLifestyleAdvanced
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.treLifestyleQualities);
            this.Controls.Add(this.cmdDeleteQuality);
            this.Controls.Add(this.cmdAddQuality);
            this.Controls.Add(this.cmdOKAdd);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectLifestyleAdvanced";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Title_SelectAdvancedLifestyle";
            this.Text = "Build Advanced Lifestyle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSelectLifestyleAdvanced_FormClosing);
            this.Load += new System.EventHandler(this.frmSelectAdvancedLifestyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoommates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudComforts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonusLP)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void nudSecurity_ValueChanged(object sender, System.EventArgs e)
        {
            CalculateValues();
        }

        private void nudComforts_ValueChanged(object sender, System.EventArgs e)
        {
            CalculateValues();
        }

        private void nudArea_ValueChanged(object sender, System.EventArgs e)
        {
            CalculateValues();
        }

        private void nudSecurityEntertainment_ValueChanged(object sender, System.EventArgs e)
        {
            CalculateValues();
        }

        private void nudComfortsEntertainment_ValueChanged(object sender, System.EventArgs e)
        {
            CalculateValues();
        }

        private void nudAreaEntertainment_ValueChanged(object sender, System.EventArgs e)
        {
            CalculateValues();
        }

        #endregion

        private System.Windows.Forms.Label Label_SelectAdvancedLifestyle_Upgrade_Comforts;
        private System.Windows.Forms.Button cmdOKAdd;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label lblTotalLPLabel;
        private System.Windows.Forms.Label lblTotalLP;
        private System.Windows.Forms.Label lblCostLabel;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblLifestyleNameLabel;
        private System.Windows.Forms.TextBox txtLifestyleName;
        private System.Windows.Forms.NumericUpDown nudPercentage;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblSourceLabel;
        private System.Windows.Forms.NumericUpDown nudRoommates;
        private System.Windows.Forms.Label lblRoommates;
        private System.Windows.Forms.ComboBox cboBaseLifestyle;
        private System.Windows.Forms.Label Label_SelectAdvancedLifestyle_Lifestyle;
        private System.Windows.Forms.NumericUpDown nudSecurity;
        private System.Windows.Forms.NumericUpDown nudArea;
        private System.Windows.Forms.NumericUpDown nudComforts;
        private System.Windows.Forms.Label Label_SelectAdvancedLifestyle_Comforts;
        private System.Windows.Forms.Label Label_SelectAdvancedLifestyle_Neighborhood;
        private System.Windows.Forms.Label Label_SelectAdvancedLifestyle_Securities;
        private System.Windows.Forms.Button cmdAddQuality;
        private System.Windows.Forms.Button cmdDeleteQuality;
        private System.Windows.Forms.TreeView treLifestyleQualities;
        private System.Windows.Forms.CheckBox chkTrustFund;
        private System.Windows.Forms.Label lblQualityLp;
        private System.Windows.Forms.Label lblQualityLPLabel;
        private System.Windows.Forms.Label lblQualitySource;
        private System.Windows.Forms.Label lblQualitySourceLabel;
        private System.Windows.Forms.Label lblQualityCost;
        private System.Windows.Forms.Label lblQualityCostLabel;
        private System.Windows.Forms.CheckBox chkPrimaryTenant;
        private System.Windows.Forms.Label lblSecurityTotal;
        private System.Windows.Forms.Label lblAreaTotal;
        private System.Windows.Forms.Label lblComfortTotal;
        private System.Windows.Forms.CheckBox chkQualityContributesLP;
        private System.Windows.Forms.Label lblBonusLP;
        private System.Windows.Forms.NumericUpDown nudBonusLP;
        private System.Windows.Forms.CheckBox chkBonusLPRandomize;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Label_SelectAdvancedLifestyle_Base_Comforts;
        private Label Label_SelectAdvancedLifestyle_Base_Neighborhood;
        private Label Label_SelectAdvancedLifestyle_Base_Security;
    }
}
