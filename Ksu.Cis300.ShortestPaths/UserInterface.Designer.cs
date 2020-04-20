﻿namespace Ksu.Cis300.ShortestPaths
{
    partial class UserInterface
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
            this.uxFindPath = new System.Windows.Forms.Button();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxMap = new System.Windows.Forms.WebBrowser();
            this.uxNodeList = new System.Windows.Forms.ListBox();
            this.uxPathLabel = new System.Windows.Forms.Label();
            this.uxDistance = new System.Windows.Forms.TextBox();
            this.uxDistanceLabel = new System.Windows.Forms.Label();
            this.uxLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSetEnd = new System.Windows.Forms.Button();
            this.uxEndNode = new System.Windows.Forms.TextBox();
            this.uxSetStart = new System.Windows.Forms.Button();
            this.uxStartLabel = new System.Windows.Forms.Label();
            this.uxEndLabel = new System.Windows.Forms.Label();
            this.uxStartNode = new System.Windows.Forms.TextBox();
            this.uxToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEntireMap = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuBar = new System.Windows.Forms.MenuStrip();
            this.uxMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxFindPath
            // 
            this.uxFindPath.Enabled = false;
            this.uxFindPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFindPath.Location = new System.Drawing.Point(32, 221);
            this.uxFindPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxFindPath.Name = "uxFindPath";
            this.uxFindPath.Size = new System.Drawing.Size(552, 65);
            this.uxFindPath.TabIndex = 51;
            this.uxFindPath.Text = "Find Shortest Path";
            this.uxFindPath.UseVisualStyleBackColor = true;
            this.uxFindPath.Click += new System.EventHandler(this.uxFindPath_Click);
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.Filter = "Comma-separated value files (*.csv)|*.csv";
            // 
            // uxMap
            // 
            this.uxMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxMap.Location = new System.Drawing.Point(596, 104);
            this.uxMap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxMap.MinimumSize = new System.Drawing.Size(40, 38);
            this.uxMap.Name = "uxMap";
            this.uxMap.Size = new System.Drawing.Size(1610, 1317);
            this.uxMap.TabIndex = 50;
            this.uxMap.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.uxMap_Navigated);
            // 
            // uxNodeList
            // 
            this.uxNodeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uxNodeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNodeList.FormattingEnabled = true;
            this.uxNodeList.ItemHeight = 37;
            this.uxNodeList.Location = new System.Drawing.Point(258, 360);
            this.uxNodeList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxNodeList.Name = "uxNodeList";
            this.uxNodeList.Size = new System.Drawing.Size(322, 1040);
            this.uxNodeList.TabIndex = 49;
            this.uxNodeList.SelectedIndexChanged += new System.EventHandler(this.uxNodeList_SelectedIndexChanged);
            // 
            // uxPathLabel
            // 
            this.uxPathLabel.AutoSize = true;
            this.uxPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPathLabel.Location = new System.Drawing.Point(24, 360);
            this.uxPathLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxPathLabel.Name = "uxPathLabel";
            this.uxPathLabel.Size = new System.Drawing.Size(220, 37);
            this.uxPathLabel.TabIndex = 48;
            this.uxPathLabel.Text = "Shortest Path:";
            // 
            // uxDistance
            // 
            this.uxDistance.Enabled = false;
            this.uxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDistance.Location = new System.Drawing.Point(188, 298);
            this.uxDistance.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxDistance.Name = "uxDistance";
            this.uxDistance.ReadOnly = true;
            this.uxDistance.Size = new System.Drawing.Size(392, 44);
            this.uxDistance.TabIndex = 47;
            // 
            // uxDistanceLabel
            // 
            this.uxDistanceLabel.AutoSize = true;
            this.uxDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDistanceLabel.Location = new System.Drawing.Point(24, 304);
            this.uxDistanceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxDistanceLabel.Name = "uxDistanceLabel";
            this.uxDistanceLabel.Size = new System.Drawing.Size(150, 37);
            this.uxDistanceLabel.TabIndex = 46;
            this.uxDistanceLabel.Text = "Distance:";
            // 
            // uxLoad
            // 
            this.uxLoad.Name = "uxLoad";
            this.uxLoad.Size = new System.Drawing.Size(359, 44);
            this.uxLoad.Text = "Load a map";
            this.uxLoad.Click += new System.EventHandler(this.uxLoad_Click);
            // 
            // uxSetEnd
            // 
            this.uxSetEnd.Enabled = false;
            this.uxSetEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSetEnd.Location = new System.Drawing.Point(514, 160);
            this.uxSetEnd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxSetEnd.Name = "uxSetEnd";
            this.uxSetEnd.Size = new System.Drawing.Size(70, 50);
            this.uxSetEnd.TabIndex = 45;
            this.uxSetEnd.Text = "<-";
            this.uxSetEnd.UseVisualStyleBackColor = true;
            this.uxSetEnd.Click += new System.EventHandler(this.uxSetEnd_Click);
            // 
            // uxEndNode
            // 
            this.uxEndNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEndNode.Location = new System.Drawing.Point(258, 160);
            this.uxEndNode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxEndNode.Name = "uxEndNode";
            this.uxEndNode.Size = new System.Drawing.Size(240, 44);
            this.uxEndNode.TabIndex = 44;
            this.uxEndNode.Click += new System.EventHandler(this.uxEndNode_TextChanged);
            this.uxEndNode.TextChanged += new System.EventHandler(this.uxEndNode_TextChanged);
            // 
            // uxSetStart
            // 
            this.uxSetStart.Enabled = false;
            this.uxSetStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSetStart.Location = new System.Drawing.Point(514, 98);
            this.uxSetStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxSetStart.Name = "uxSetStart";
            this.uxSetStart.Size = new System.Drawing.Size(70, 50);
            this.uxSetStart.TabIndex = 42;
            this.uxSetStart.Text = "<-";
            this.uxSetStart.UseVisualStyleBackColor = true;
            this.uxSetStart.Click += new System.EventHandler(this.uxSetStart_Click);
            // 
            // uxStartLabel
            // 
            this.uxStartLabel.AutoSize = true;
            this.uxStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartLabel.Location = new System.Drawing.Point(24, 104);
            this.uxStartLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxStartLabel.Name = "uxStartLabel";
            this.uxStartLabel.Size = new System.Drawing.Size(223, 37);
            this.uxStartLabel.TabIndex = 40;
            this.uxStartLabel.Text = "Starting Node:";
            // 
            // uxEndLabel
            // 
            this.uxEndLabel.AutoSize = true;
            this.uxEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEndLabel.Location = new System.Drawing.Point(24, 165);
            this.uxEndLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxEndLabel.Name = "uxEndLabel";
            this.uxEndLabel.Size = new System.Drawing.Size(212, 37);
            this.uxEndLabel.TabIndex = 43;
            this.uxEndLabel.Text = "Ending Node:";
            // 
            // uxStartNode
            // 
            this.uxStartNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartNode.Location = new System.Drawing.Point(258, 98);
            this.uxStartNode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxStartNode.Name = "uxStartNode";
            this.uxStartNode.Size = new System.Drawing.Size(240, 44);
            this.uxStartNode.TabIndex = 41;
            this.uxStartNode.Click += new System.EventHandler(this.uxStartNode_TextChanged);
            this.uxStartNode.TextChanged += new System.EventHandler(this.uxStartNode_TextChanged);
            // 
            // uxToolsMenu
            // 
            this.uxToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxLoad,
            this.uxEntireMap});
            this.uxToolsMenu.Name = "uxToolsMenu";
            this.uxToolsMenu.Size = new System.Drawing.Size(90, 38);
            this.uxToolsMenu.Text = "Tools";
            this.uxToolsMenu.Click += new System.EventHandler(this.uxToolsMenu_Click);
            // 
            // uxEntireMap
            // 
            this.uxEntireMap.Enabled = false;
            this.uxEntireMap.Name = "uxEntireMap";
            this.uxEntireMap.Size = new System.Drawing.Size(359, 44);
            this.uxEntireMap.Text = "Show entire map";
            this.uxEntireMap.Click += new System.EventHandler(this.uxEntireMap_Click);
            // 
            // uxMenuBar
            // 
            this.uxMenuBar.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.uxMenuBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.uxMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxToolsMenu});
            this.uxMenuBar.Location = new System.Drawing.Point(0, 0);
            this.uxMenuBar.Name = "uxMenuBar";
            this.uxMenuBar.Size = new System.Drawing.Size(2230, 44);
            this.uxMenuBar.TabIndex = 39;
            this.uxMenuBar.Text = "menuStrip1";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2230, 1427);
            this.Controls.Add(this.uxFindPath);
            this.Controls.Add(this.uxMap);
            this.Controls.Add(this.uxNodeList);
            this.Controls.Add(this.uxPathLabel);
            this.Controls.Add(this.uxDistance);
            this.Controls.Add(this.uxDistanceLabel);
            this.Controls.Add(this.uxSetEnd);
            this.Controls.Add(this.uxEndNode);
            this.Controls.Add(this.uxSetStart);
            this.Controls.Add(this.uxStartLabel);
            this.Controls.Add(this.uxEndLabel);
            this.Controls.Add(this.uxStartNode);
            this.Controls.Add(this.uxMenuBar);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UserInterface";
            this.Text = "Shortest Path Finder";
            this.uxMenuBar.ResumeLayout(false);
            this.uxMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxFindPath;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.WebBrowser uxMap;
        private System.Windows.Forms.ListBox uxNodeList;
        private System.Windows.Forms.Label uxPathLabel;
        private System.Windows.Forms.TextBox uxDistance;
        private System.Windows.Forms.Label uxDistanceLabel;
        private System.Windows.Forms.ToolStripMenuItem uxLoad;
        private System.Windows.Forms.Button uxSetEnd;
        private System.Windows.Forms.TextBox uxEndNode;
        private System.Windows.Forms.Button uxSetStart;
        private System.Windows.Forms.Label uxStartLabel;
        private System.Windows.Forms.Label uxEndLabel;
        private System.Windows.Forms.TextBox uxStartNode;
        private System.Windows.Forms.ToolStripMenuItem uxToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem uxEntireMap;
        private System.Windows.Forms.MenuStrip uxMenuBar;
    }
}

