using System;
using System.Windows.Forms;

namespace test
{
    public partial class quizPage2 : Form
    {
        private main _mainForm;
        private quizPage _quizPage;

        public quizPage2(main mainForm, quizPage quizPage)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _quizPage = quizPage;
        }

        public quizPage2(quizPage quizPage)
        {
            this._quizPage = quizPage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _quizPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CollectResults();
            this.Close();
            _mainForm.Show();
            _mainForm.UpdateLabels();
        }

        private void CollectResults()
        {
            string one = textBox1.Text;
            string two = textBox2.Text;

            string true_num = "";
            string false_num = "";

            if (one.Equals("해바라기씨"))
            {
                true_num += "4 ";
            }
            else
            {
                false_num += "4 ";
            }

            if (two.Equals("살이 빠진다"))
            {
                true_num += "5 ";
            }
            else
            {
                false_num += "5 ";
            }

            main.DataFromForm += true_num;
            main.DataFromForm1 += false_num;
        }

        private void quizPage2_Load(object sender, EventArgs e)
        {
        }
    }
}
