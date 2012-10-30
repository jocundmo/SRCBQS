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
            // Should be copy.
            Questionnaire qn = currentQNReader.Entity.MakeCopy();
            availableQNs.Add(qn);
            currentQNReader = new QuestionnaireReader(qn);
            //FillAnswer(2);
            //while (true)
            //{
            //    FillAnswer(2);
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Questionnaire qn = Questionnaire.MakeNew(@"D:\SourceRoot\SRCBQS\Resources\Questionnaire1.xml");
            availableQNs.Add(qn);
            currentQNReader = new QuestionnaireReader(qn);
        }

        private void comboBoxAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAnswer(((ComboBox)sender).SelectedIndex);
            if (currentQNReader.Read())
            {
                PopulateQuestion(currentQNReader.Question);
            }
            else
            {
                ClearQuestionUI();
            }
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

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmdStack.Count <= 0)
            {
                MessageBox.Show("没有上一题了！");
                return;
            }
            FillAnswerCommand cmd = (FillAnswerCommand)cmdStack.Pop();
            cmd.Undo();
            currentQNReader.SetIndex(cmd.Question.Index);
            PopulateQuestion(cmd.Question);
        }

        private void FillAnswerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentQNReader.Read())
            {
                PopulateQuestion(currentQNReader.Question);
            }
        }

        #endregion

        #region Methods
        private void FillAnswer(int index)
        {
            Question q = currentQNReader.Question;
            FillAnswerCommand cmd = new FillAnswerCommand(q);
            cmd.Sym = Utility.ConvertToSymbol(index);
            cmd.Do();
            cmdStack.Push(cmd);
        }

        private void ClearQuestionUI()
        {
            this.labelQuestion.Text = string.Empty;
            this.comboBox1.Items.Clear();
        }

        private void PopulateQuestion(Question q)
        {
            labelQuestion.Text = q.Title + Environment.NewLine + q.Subtitle;
            this.comboBox1.Items.Clear();
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
