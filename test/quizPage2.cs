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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            _quizPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.Show();
        }

        private void quizPage2_Load(object sender, EventArgs e)
        {
            string one = textBox1.Text;
            string two = textBox2.Text;

            if (one.Equals("해바라기씨"))
            {
                _mainForm.DataFromForm += " 4";
            }
            else
            {
                _mainForm.DataFromForm1 += " 4";
            }

            if (two.Equals("살이 빠진다"))
            {
                _mainForm.DataFromForm += " 5";
            }
            else
            {
                _mainForm.DataFromForm1 += " 5";
            }
        }
    }
}
