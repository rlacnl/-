using System;
using System.Windows.Forms;

namespace test
{
    public partial class quizPage : Form
    {
        private main _mainForm;

        public quizPage(main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            quizPage2 quizPage2 = new quizPage2(_mainForm, this);
            quizPage2.Show();
        }

        private void quizPage_Load(object sender, EventArgs e)
        {
            // Do nothing here for now
        }

        public void CollectResults()
        {
            string correctNumbers = "";
            string incorrectNumbers = "";

            if (NUM1_TRUE.Checked)
            {
                correctNumbers += "1 ";
            }
            else
            {
                incorrectNumbers += "1 ";
            }

            if (NUM2_TRUE.Checked)
            {
                correctNumbers += "2 ";
            }
            else
            {
                incorrectNumbers += "2 ";
            }

            if (NUM3_TRUE.Checked)
            {
                correctNumbers += "3 ";
            }
            else
            {
                incorrectNumbers += "3 ";
            }

            _mainForm.DataFromForm = "맞은 번호: " + correctNumbers.Trim();
            _mainForm.DataFromForm1 = "틀린 번호: " + incorrectNumbers.Trim();
        }
    }
}
