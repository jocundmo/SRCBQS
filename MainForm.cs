using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRCBQuestionnaireStatistic.Model;
using SRCBQuestionnaireStatistic.Command;
using System.IO;

namespace SRCBQuestionnaireStatistic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<Questionnaire> availableQNs = new List<Questionnaire>();
        private QuestionnaireReader currentQNReader = null;
        private CommandStack cmdStack = new CommandStack();

        #region Events
        private void NewQuestionnaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Questionnaire qn = currentQNReader.Entity.MakeCopy();
            availableQNs.Add(qn);
            currentQNReader = new QuestionnaireReader(qn);

            if (currentQNReader.ReadNext())
            {
                PopulateQuestionUI(currentQNReader.Question);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] filenames = Directory.GetFiles(@"..\..\Resources", "*.xml");
            int index = 0;
            foreach (string filename in filenames)
            {
                Questionnaire qn = Questionnaire.MakeNew(filename);
                if (index == 0)
                    currentQNReader = new QuestionnaireReader(qn);
                availableQNs.Add(qn);
                index++;
            }
            
            InitializeTreeView(availableQNs);
        }
        
        private void ComboBoxAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex;
            FillAnswerAndPopulateNext(index);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveStatistic(availableQNs);
        }

        private void StatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataTable statisticResult = new DataTable("Statistic");
            //DataColumn dc;
            //dc = new DataColumn("Questionnaire", typeof(string));
            //statisticResult.Columns.Add(dc);
            //dc = new DataColumn("Question", typeof(string));
            //statisticResult.Columns.Add(dc);
            //dc = new DataColumn("Branch", typeof(string));
            //statisticResult.Columns.Add(dc);
            //dc = new DataColumn("Answer", typeof(Answer.Symbol));
            //statisticResult.Columns.Add(dc);
            //dc = new DataColumn("Statistic", typeof(int));
            //statisticResult.Columns.Add(dc);

            DataTable result = new DataTable("ABC");
            result.ReadXmlSchema(@"C:\abc.xml");
            result.ReadXml(@"C:\abc.xml");
            Dictionary<string, int> statisticDic = new Dictionary<string, int>();
            //string key = string.Empty;
            foreach (DataRow dr in result.Rows)
            {
                string loopKey = string.Format("{0}>{1}>{2}>{3}", (string)dr["Questionnaire"], (string)dr["Question"], (string)dr["Branch"], (string)dr["Answer"]);
                if (!statisticDic.ContainsKey(loopKey))
                {
                    statisticDic[loopKey] = 1;
                }
                else
                {
                    statisticDic[loopKey]++;
                }
                //if (loopKey == key)
                //{
                //    int i = (int)dr["Statistic"];
                //    i++;
                //    dr["Statistic"] = i;
                //    //((int)dr["Statistic"])++;
                //}
                //else
                //{
                //    DataRow ddr = statisticResult.NewRow();
                //    ddr["Questionnaire"] = dr["Questionnaire"];
                //    ddr["Question"] = dr["Question"];
                //    ddr["Branch"] = dr["Branch"];
                //    ddr["Answer"] = dr["Answer"];
                //    key = loopKey;
                //    statisticResult.Rows.Add(ddr);
                //}
                //key = string.Format("{0}>{1}>{2}", (string)dr["Questionnaire"], (string)dr["Question"], (string)dr["Answer"]);
                
            }
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmdStack.Count <= 0)
            {
                MessageBox.Show("没有上一题了！");
                return;
            }
            FillAnswerCommand cmd = (FillAnswerCommand)cmdStack.Pop();
            cmd.Undo();
            currentQNReader.SetIndex(cmd.Question.Index);
            PopulateQuestionUI(cmd.Question);
        }

        private void FillAnswerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentQNReader.ReadNext())
            {
                PopulateQuestionUI(currentQNReader.Question);
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            int index = int.Parse(e.KeyChar.ToString()) - 1;
            FillAnswerAndPopulateNext(index);
            //suppressEvent = true;
            //int loop = 0;
            //foreach (Answer selected in comboBox1.Items)
            //{
            //    if (selected.Sym == Utility.ConvertToSymbol(index))
            //    {
            //        comboBox1.SelectedIndex = loop;
            //        break;
            //    }

            //    loop++;
            //}
            //suppressEvent = false;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name.StartsWith("root"))
                return;
            Questionnaire qn = null;
            if (e.Node.Name.StartsWith("qn_"))
            {
                qn = availableQNs[e.Node.Index];
            }
            else if (e.Node.Name.StartsWith("menu_node_"))
            {
                qn = availableQNs[e.Node.Parent.Index]; // There is a bug, cannot direct select from AvailableQN since the questionnaire index is not correct.
            }

            if (qn.IsQuestionnaireFinished())
            {
                ClearQuestionUI();
            }
            else
            {
                currentQNReader = new QuestionnaireReader(qn);
                if (currentQNReader.ReadNext())
                {
                    PopulateQuestionUI(currentQNReader.Question);
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        private void InitializeTreeView(List<Questionnaire> qns)
        {
            treeView1.Nodes.Clear();
            TreeNode rootNode = treeView1.Nodes.Add("rootNode", "农商银行问卷调查统计系统");
            foreach (Questionnaire qn in qns)
            {
                TreeNode nodeQN = rootNode.Nodes.Add("qn_node_" + qn.Id, qn.Subject);
                nodeQN.Nodes.Add("menu_node_" + qn.Id + "_Fill", "录入");
                nodeQN.Nodes.Add("menu_node_" + qn.Id + "_Clear", "清空");

                if (qn.IsBossManager)
                    nodeQN.Nodes.Add("menu_node_" + qn.Id + "_BossManager", "领导管理");
                if (qn.IsBranchManager)
                    nodeQN.Nodes.Add("menu_node_" + qn.Id + "_BranchManager", "支行管理");
            }

            treeView1.ExpandAll();
            treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
        }

        private void FillAnswerAndPopulateNext(int index)
        {
            FillAnswer(index);
            this.lblSelectedAnswer.Text = string.Format("您上一题选择了：{0}", currentQNReader.Question.SelectedAnswer.FullText);
            if (currentQNReader.ReadNext())
            {
                PopulateQuestionUI(currentQNReader.Question);
            }
            else
            {
                ClearQuestionUI();
                this.lblSelectedAnswer.Text = string.Empty;
            }
        }
        private void FillAnswer(int index)
        {
            Question q = currentQNReader.Question;
            FillAnswerCommand cmd = new FillAnswerCommand(q);
            cmd.Sym = Utility.ConvertToSymbol(index);
            cmd.Do();
            cmdStack.Push(cmd);
        }

        //private void PopulateQuestionnaireUI(Questionnaire qn)
        //{
        //    labelQuestionnaireName.Text = qn.Subject;
        //}

        private void PopulateQuestionUI(Question q)
        {
            labelQuestionnaireIndex.Text = string.Format("第 {0} 份", q.Questionnaire.Index);
            labelQuestionnaireName.Text = q.Questionnaire.Subject;
            //lblSelectedAnswer.Text = q.SelectedAnswer.FullText;
            this.richTxtQuestion.Text = q.Title + Environment.NewLine + q.Subtitle;
            this.comboBox1.Items.Clear();
            this.comboBox1.Enabled = true;
            this.comboBox1.DisplayMember = "FullText";
            this.comboBox1.ValueMember = "Sym";
            //this.comboBox1.DataSource = qn.Questions[0].AvailableAnswers;
            object[] list = new object[q.AvailableAnswers.Count];
            for (int i = 0; i < q.AvailableAnswers.Count; i++)
            {
                list[i] = q.AvailableAnswers[i];
            }
            //this.comboBox1.Items.Insert(0, Answer.Empty);
            this.comboBox1.Items.AddRange(list);
        }

        private void ClearQuestionUI()
        {
            this.richTxtQuestion.Text = string.Empty;
            this.labelQuestionnaireIndex.Text = "已经完成了";
            this.lblSelectedAnswer.Text = "na";
            this.comboBox1.Items.Clear();
            this.comboBox1.Enabled = false;
        }

        private void SaveStatistic(List<Questionnaire> availableQNs)
        {
            DataTable result = new DataTable();
            result.TableName = "ABC";
            DataColumn dc;
            dc = new DataColumn("Questionnaire", typeof(string));
            result.Columns.Add(dc);
            dc = new DataColumn("Boss", typeof(string));
            result.Columns.Add(dc);
            dc = new DataColumn("Branch", typeof(string));
            result.Columns.Add(dc);
            dc = new DataColumn("Question", typeof(string));
            result.Columns.Add(dc);
            dc = new DataColumn("Answer", typeof(Answer.Symbol));
            result.Columns.Add(dc);

            foreach (Questionnaire qn in availableQNs)
            {
                foreach (Question q in qn.Questions)
                {
                    DataRow dr = result.NewRow();
                    dr["Questionnaire"] = qn.Subject;
                    dr["Boss"] = qn.Bosses.Count <= 0 ? string.Empty : qn.Bosses[0].Name;
                    dr["Branch"] = qn.Branches.Count <= 0 ? string.Empty : qn.Branches[0].Name;
                    dr["Question"] = q.Subject;
                    dr["Answer"] = q.SelectedAnswer.Sym;
                    result.Rows.Add(dr);
                }
            }

            result.WriteXml(@"C:\abc.xml");
        }

        #endregion
    }
}
