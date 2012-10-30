namespace SRCBQuestionnaireStatistic
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
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("录入");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("清空");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("领导管理");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("分行管理");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("支行领导班子民主测评统计表", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("支行领导班子成员民主测评统计表");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("巡察工作调查问卷");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("农商银行问卷调查统计系统", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode39});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewQuestionnaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FillAnswerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblSelectedAnswer = new System.Windows.Forms.Label();
            this.labelQuestionnaireIndex = new System.Windows.Forms.Label();
            this.labelQuestionnaireName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.richTxtQuestion = new System.Windows.Forms.RichTextBox();
            this.ResumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.ResumeToolStripMenuItem,
            this.PurgeToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.FileToolStripMenuItem.Text = "文件";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.SaveToolStripMenuItem.Text = "保存";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewQuestionnaireToolStripMenuItem,
            this.FillAnswerToolStripMenuItem,
            this.UndoToolStripMenuItem,
            this.StatisticToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.EditToolStripMenuItem.Text = "操作";
            // 
            // NewQuestionnaireToolStripMenuItem
            // 
            this.NewQuestionnaireToolStripMenuItem.Name = "NewQuestionnaireToolStripMenuItem";
            this.NewQuestionnaireToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.NewQuestionnaireToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.NewQuestionnaireToolStripMenuItem.Text = "新建问卷";
            this.NewQuestionnaireToolStripMenuItem.Click += new System.EventHandler(this.NewQuestionnaireToolStripMenuItem_Click);
            // 
            // FillAnswerToolStripMenuItem
            // 
            this.FillAnswerToolStripMenuItem.Name = "FillAnswerToolStripMenuItem";
            this.FillAnswerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.FillAnswerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.FillAnswerToolStripMenuItem.Text = "录入";
            this.FillAnswerToolStripMenuItem.Click += new System.EventHandler(this.FillAnswerToolStripMenuItem_Click);
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.UndoToolStripMenuItem.Text = "撤销";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // StatisticToolStripMenuItem
            // 
            this.StatisticToolStripMenuItem.Name = "StatisticToolStripMenuItem";
            this.StatisticToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.StatisticToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.StatisticToolStripMenuItem.Text = "统计";
            this.StatisticToolStripMenuItem.Click += new System.EventHandler(this.StatisticToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem1});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.HelpToolStripMenuItem.Text = "帮助";
            // 
            // AboutToolStripMenuItem1
            // 
            this.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1";
            this.AboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.AboutToolStripMenuItem1.Text = "关于";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.splitContainer1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(766, 394);
            this.MainPanel.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(766, 394);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode33.Name = "nodeQN1_Fill";
            treeNode33.Text = "录入";
            treeNode34.Name = "nodeQN1_Clear";
            treeNode34.Text = "清空";
            treeNode35.Name = "nodeQN1_BossMgr";
            treeNode35.Text = "领导管理";
            treeNode36.Name = "nodeQN1_BranchMgr";
            treeNode36.Text = "分行管理";
            treeNode37.Name = "nodeQN1";
            treeNode37.Text = "支行领导班子民主测评统计表";
            treeNode38.Name = "nodeQN2";
            treeNode38.Text = "支行领导班子成员民主测评统计表";
            treeNode39.Name = "nodeQN3";
            treeNode39.Text = "巡察工作调查问卷";
            treeNode40.Name = "nodeRoot";
            treeNode40.Text = "农商银行问卷调查统计系统";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode40});
            this.treeView1.Size = new System.Drawing.Size(239, 394);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer2.Panel1.Controls.Add(this.lblSelectedAnswer);
            this.splitContainer2.Panel1.Controls.Add(this.labelQuestionnaireIndex);
            this.splitContainer2.Panel1.Controls.Add(this.labelQuestionnaireName);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer2.Panel1.Controls.Add(this.labelAnswer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer2.Panel2.Controls.Add(this.richTxtQuestion);
            this.splitContainer2.Size = new System.Drawing.Size(523, 394);
            this.splitContainer2.SplitterDistance = 91;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblSelectedAnswer
            // 
            this.lblSelectedAnswer.Location = new System.Drawing.Point(352, 11);
            this.lblSelectedAnswer.Name = "lblSelectedAnswer";
            this.lblSelectedAnswer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSelectedAnswer.Size = new System.Drawing.Size(159, 68);
            this.lblSelectedAnswer.TabIndex = 4;
            this.lblSelectedAnswer.Text = "label1";
            // 
            // labelQuestionnaireIndex
            // 
            this.labelQuestionnaireIndex.AutoSize = true;
            this.labelQuestionnaireIndex.Location = new System.Drawing.Point(12, 35);
            this.labelQuestionnaireIndex.Name = "labelQuestionnaireIndex";
            this.labelQuestionnaireIndex.Size = new System.Drawing.Size(35, 13);
            this.labelQuestionnaireIndex.TabIndex = 3;
            this.labelQuestionnaireIndex.Text = "label1";
            // 
            // labelQuestionnaireName
            // 
            this.labelQuestionnaireName.AutoSize = true;
            this.labelQuestionnaireName.Location = new System.Drawing.Point(12, 11);
            this.labelQuestionnaireName.Name = "labelQuestionnaireName";
            this.labelQuestionnaireName.Size = new System.Drawing.Size(35, 13);
            this.labelQuestionnaireName.TabIndex = 2;
            this.labelQuestionnaireName.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(61, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAnswer_SelectedIndexChanged);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(12, 61);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(43, 13);
            this.labelAnswer.TabIndex = 0;
            this.labelAnswer.Text = "答案：";
            // 
            // richTxtQuestion
            // 
            this.richTxtQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtQuestion.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTxtQuestion.Location = new System.Drawing.Point(0, 0);
            this.richTxtQuestion.Name = "richTxtQuestion";
            this.richTxtQuestion.ReadOnly = true;
            this.richTxtQuestion.Size = new System.Drawing.Size(523, 299);
            this.richTxtQuestion.TabIndex = 1;
            this.richTxtQuestion.Text = "";
            // 
            // ResumeToolStripMenuItem
            // 
            this.ResumeToolStripMenuItem.Name = "ResumeToolStripMenuItem";
            this.ResumeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ResumeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ResumeToolStripMenuItem.Text = "继续上次输入";
            // 
            // PurgeToolStripMenuItem
            // 
            this.PurgeToolStripMenuItem.Name = "PurgeToolStripMenuItem";
            this.PurgeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PurgeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.PurgeToolStripMenuItem.Text = "全部清空";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 418);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewQuestionnaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FillAnswerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatisticToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label labelQuestionnaireName;
        private System.Windows.Forms.Label labelQuestionnaireIndex;
        private System.Windows.Forms.RichTextBox richTxtQuestion;
        private System.Windows.Forms.Label lblSelectedAnswer;
        private System.Windows.Forms.ToolStripMenuItem ResumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurgeToolStripMenuItem;
    }
}

