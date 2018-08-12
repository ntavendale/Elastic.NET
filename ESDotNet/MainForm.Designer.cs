namespace ESDotNet
{
    partial class MainForm
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.gbIndexExists = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIndexExists = new System.Windows.Forms.Button();
            this.tbIndexExists = new System.Windows.Forms.TextBox();
            this.gbCreateIndex = new System.Windows.Forms.GroupBox();
            this.tbReplicas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbShards = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCreateIndex = new System.Windows.Forms.TextBox();
            this.gbAddMessages = new System.Windows.Forms.GroupBox();
            this.btnAddWithNoID = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddWithID = new System.Windows.Forms.Button();
            this.gbBulk = new System.Windows.Forms.GroupBox();
            this.btnMultiIndex = new System.Windows.Forms.Button();
            this.btnSingleIndex = new System.Windows.Forms.Button();
            this.brnDelete = new System.Windows.Forms.Button();
            this.gbIndexExists.SuspendLayout();
            this.gbCreateIndex.SuspendLayout();
            this.gbAddMessages.SuspendLayout();
            this.gbBulk.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(5, 319);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutput.Size = new System.Drawing.Size(955, 211);
            this.tbOutput.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(12, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // gbIndexExists
            // 
            this.gbIndexExists.Controls.Add(this.label1);
            this.gbIndexExists.Controls.Add(this.btnIndexExists);
            this.gbIndexExists.Controls.Add(this.tbIndexExists);
            this.gbIndexExists.Location = new System.Drawing.Point(109, 13);
            this.gbIndexExists.Name = "gbIndexExists";
            this.gbIndexExists.Size = new System.Drawing.Size(274, 100);
            this.gbIndexExists.TabIndex = 2;
            this.gbIndexExists.TabStop = false;
            this.gbIndexExists.Text = "Index Exists";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Index Name";
            // 
            // btnIndexExists
            // 
            this.btnIndexExists.Location = new System.Drawing.Point(6, 63);
            this.btnIndexExists.Name = "btnIndexExists";
            this.btnIndexExists.Size = new System.Drawing.Size(75, 23);
            this.btnIndexExists.TabIndex = 1;
            this.btnIndexExists.Text = "Check";
            this.btnIndexExists.UseVisualStyleBackColor = true;
            this.btnIndexExists.Click += new System.EventHandler(this.btnIndexExists_Click);
            // 
            // tbIndexExists
            // 
            this.tbIndexExists.Location = new System.Drawing.Point(6, 36);
            this.tbIndexExists.Name = "tbIndexExists";
            this.tbIndexExists.Size = new System.Drawing.Size(252, 20);
            this.tbIndexExists.TabIndex = 0;
            // 
            // gbCreateIndex
            // 
            this.gbCreateIndex.Controls.Add(this.tbReplicas);
            this.gbCreateIndex.Controls.Add(this.label4);
            this.gbCreateIndex.Controls.Add(this.tbShards);
            this.gbCreateIndex.Controls.Add(this.label3);
            this.gbCreateIndex.Controls.Add(this.btnCreate);
            this.gbCreateIndex.Controls.Add(this.label2);
            this.gbCreateIndex.Controls.Add(this.tbCreateIndex);
            this.gbCreateIndex.Location = new System.Drawing.Point(400, 12);
            this.gbCreateIndex.Name = "gbCreateIndex";
            this.gbCreateIndex.Size = new System.Drawing.Size(462, 100);
            this.gbCreateIndex.TabIndex = 3;
            this.gbCreateIndex.TabStop = false;
            this.gbCreateIndex.Text = "Create Index";
            // 
            // tbReplicas
            // 
            this.tbReplicas.Location = new System.Drawing.Point(378, 36);
            this.tbReplicas.Name = "tbReplicas";
            this.tbReplicas.Size = new System.Drawing.Size(57, 20);
            this.tbReplicas.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Replicas";
            // 
            // tbShards
            // 
            this.tbShards.Location = new System.Drawing.Point(298, 36);
            this.tbShards.Name = "tbShards";
            this.tbShards.Size = new System.Drawing.Size(57, 20);
            this.tbShards.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shards";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(9, 63);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Index Name";
            // 
            // tbCreateIndex
            // 
            this.tbCreateIndex.Location = new System.Drawing.Point(6, 37);
            this.tbCreateIndex.Name = "tbCreateIndex";
            this.tbCreateIndex.Size = new System.Drawing.Size(281, 20);
            this.tbCreateIndex.TabIndex = 0;
            // 
            // gbAddMessages
            // 
            this.gbAddMessages.Controls.Add(this.brnDelete);
            this.gbAddMessages.Controls.Add(this.btnAddWithNoID);
            this.gbAddMessages.Controls.Add(this.btnUpdate);
            this.gbAddMessages.Controls.Add(this.btnAddWithID);
            this.gbAddMessages.Location = new System.Drawing.Point(109, 130);
            this.gbAddMessages.Name = "gbAddMessages";
            this.gbAddMessages.Size = new System.Drawing.Size(274, 154);
            this.gbAddMessages.TabIndex = 4;
            this.gbAddMessages.TabStop = false;
            this.gbAddMessages.Text = "Add Syslog Messages";
            // 
            // btnAddWithNoID
            // 
            this.btnAddWithNoID.Location = new System.Drawing.Point(145, 34);
            this.btnAddWithNoID.Name = "btnAddWithNoID";
            this.btnAddWithNoID.Size = new System.Drawing.Size(94, 23);
            this.btnAddWithNoID.TabIndex = 2;
            this.btnAddWithNoID.Text = "Add With No ID";
            this.btnAddWithNoID.UseVisualStyleBackColor = true;
            this.btnAddWithNoID.Click += new System.EventHandler(this.btnAddWithNoID_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(9, 78);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update With ID";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddWithID
            // 
            this.btnAddWithID.Location = new System.Drawing.Point(9, 34);
            this.btnAddWithID.Name = "btnAddWithID";
            this.btnAddWithID.Size = new System.Drawing.Size(94, 23);
            this.btnAddWithID.TabIndex = 0;
            this.btnAddWithID.Text = "Add With ID";
            this.btnAddWithID.UseVisualStyleBackColor = true;
            this.btnAddWithID.Click += new System.EventHandler(this.btnAddWithID_Click);
            // 
            // gbBulk
            // 
            this.gbBulk.Controls.Add(this.btnMultiIndex);
            this.gbBulk.Controls.Add(this.btnSingleIndex);
            this.gbBulk.Location = new System.Drawing.Point(400, 130);
            this.gbBulk.Name = "gbBulk";
            this.gbBulk.Size = new System.Drawing.Size(462, 154);
            this.gbBulk.TabIndex = 5;
            this.gbBulk.TabStop = false;
            this.gbBulk.Text = "Bulk API";
            // 
            // btnMultiIndex
            // 
            this.btnMultiIndex.Location = new System.Drawing.Point(122, 34);
            this.btnMultiIndex.Name = "btnMultiIndex";
            this.btnMultiIndex.Size = new System.Drawing.Size(95, 23);
            this.btnMultiIndex.TabIndex = 1;
            this.btnMultiIndex.Text = "Multiple Index";
            this.btnMultiIndex.UseVisualStyleBackColor = true;
            this.btnMultiIndex.Click += new System.EventHandler(this.btnMultiIndex_Click);
            // 
            // btnSingleIndex
            // 
            this.btnSingleIndex.Location = new System.Drawing.Point(9, 34);
            this.btnSingleIndex.Name = "btnSingleIndex";
            this.btnSingleIndex.Size = new System.Drawing.Size(91, 23);
            this.btnSingleIndex.TabIndex = 0;
            this.btnSingleIndex.Text = "Single Index";
            this.btnSingleIndex.UseVisualStyleBackColor = true;
            this.btnSingleIndex.Click += new System.EventHandler(this.btnSingleIndex_Click);
            // 
            // brnDelete
            // 
            this.brnDelete.Location = new System.Drawing.Point(9, 121);
            this.brnDelete.Name = "brnDelete";
            this.brnDelete.Size = new System.Drawing.Size(94, 23);
            this.brnDelete.TabIndex = 3;
            this.brnDelete.Text = "Delete";
            this.brnDelete.UseVisualStyleBackColor = true;
            this.brnDelete.Click += new System.EventHandler(this.brnDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 542);
            this.Controls.Add(this.gbBulk);
            this.Controls.Add(this.gbAddMessages);
            this.Controls.Add(this.gbCreateIndex);
            this.Controls.Add(this.gbIndexExists);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.tbOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ES.Net";
            this.gbIndexExists.ResumeLayout(false);
            this.gbIndexExists.PerformLayout();
            this.gbCreateIndex.ResumeLayout(false);
            this.gbCreateIndex.PerformLayout();
            this.gbAddMessages.ResumeLayout(false);
            this.gbBulk.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.GroupBox gbIndexExists;
        private System.Windows.Forms.TextBox tbIndexExists;
        private System.Windows.Forms.Button btnIndexExists;
        private System.Windows.Forms.GroupBox gbCreateIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCreateIndex;
        private System.Windows.Forms.TextBox tbShards;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReplicas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbAddMessages;
        private System.Windows.Forms.Button btnAddWithID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddWithNoID;
        private System.Windows.Forms.GroupBox gbBulk;
        private System.Windows.Forms.Button btnSingleIndex;
        private System.Windows.Forms.Button btnMultiIndex;
        private System.Windows.Forms.Button brnDelete;
    }
}

