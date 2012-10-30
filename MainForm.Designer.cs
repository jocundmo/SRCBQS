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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("录入");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("清空");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("领导管理");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("分行管理");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("支行领导班子民主测评统计表", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("支行领导班子成员民主测评统计表");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("巡察工作调查问卷");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("农商银行问卷调查统计系统", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewQuestionnaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FillAnswerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelQuestionnaireName = new System.Windows.Forms.Label();
            this.labelQuestionnaireIndex = new System.Windows.Forms.Label();
            this.richTxtQuestion = new System.Windows.Forms.RichTextBox();
            this.lblSelectedAnswer = new System.Windows.Forms.Label();
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
            this.文件ToolStripMenuItem,
            this.操作ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = "保存";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewQuestionnaireToolStripMenuItem,
            this.FillAnswerToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.StatisticToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // NewQuestionnaireToolStripMenuItem
            // 
            this.NewQuestionnaireToolStripMenuItem.Name = "NewQuestionnaireToolStripMenuItem";
            this.NewQuestionnaireToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.NewQuestionnaireToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.NewQuestionnaireToolStripMenuItem.Text = "新建问卷";
            this.NewQuestionnaireToolStripMenuItem.Click += new System.EventHandler(this.NewQuestionnaireToolStripMenuItem_Click);
            // 
            // FillAnswerToolStripMenuItem
            // 
            this.FillAnswerToolStripMenuItem.Name = "FillAnswerToolStripMenuItem";
            this.FillAnswerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.FillAnswerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.FillAnswerToolStripMenuItem.Text = "录入";
            this.FillAnswerToolStripMenuItem.Click += new System.EventHandler(this.FillAnswerToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.undoToolStripMenuItem.Text = "撤销";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // StatisticToolStripMenuItem
            // 
            this.StatisticToolStripMenuItem.Name = "StatisticToolStripMenuItem";
            this.StatisticToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.StatisticToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.StatisticToolStripMenuItem.Text = "统计";
            this.StatisticToolStripMenuItem.Click += new System.EventHandler(this.StatisticToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem1});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.关于ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.关于ToolStripMenuItem1.Text = "关于";
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
            treeNode1.Name = "nodeQN1_Fill";
            treeNode1.Text = "录入";
            treeNode2.Name = "nodeQN1_Clear";
            treeNode2.Text = "清空";
            treeNode3.Name = "nodeQN1_BossMgr";
            treeNode3.Text = "领导管理";
            treeNode4.Name = "nodeQN1_BranchMgr";
            treeNode4.Text = "分行管理";
            treeNode5.Name = "nodeQN1";
            treeNode5.Text = "支行领导班子民主测评统计表";
            treeNode6.Name = "nodeQN2";
            treeNode6.Text = "支行领导班子成员民主测评统计表";
            treeNode7.Name = "nodeQN3";
            treeNode7.Text = "巡察工作调查问卷";
            treeNode8.Name = "nodeRoot";
            treeNode8.Text = "农商银行问卷调查统计系统";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
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
            // labelQuestionnaireName
            // 
            this.labelQuestionnaireName.AutoSize = true;
            this.labelQuestionnaireName.Location = new System.Drawing.Point(12, 11);
            this.labelQuestionnaireName.Name = "labelQuestionnaireName";
            this.labelQuestionnaireName.Size = new System.Drawing.Size(35, 13);
            this.labelQuestionnaireName.TabIndex = 2;
            this.labelQuestionnaireName.Text = "label1";
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
            // lblSelectedAnswer
            // 
            this.lblSelectedAnswer.Location = new System.Drawing.Point(352, 11);
            this.lblSelectedAnswer.Name = "lblSelectedAnswer";
            this.lblSelectedAnswer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSelectedAnswer.Size = new System.Drawing.Size(159, 68);
            this.lblSelectedAnswer.TabIndex = 4;
            this.lblSelectedAnswer.Text = "label1";
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
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewQuestionnaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FillAnswerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
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
    }
}

