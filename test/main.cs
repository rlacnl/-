using System;
using System.Windows.Forms;

namespace test
{
    public partial class main : Form
    {
        public string DataFromForm { get; set; }
        public string DataFromForm1 { get; set; }

        public main()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            string number = num.Text;
            string Name = name.Text; // Assuming you have a TextBox named 'name'
            string message = "메세지";

            if (string.IsNullOrWhiteSpace(number) && string.IsNullOrWhiteSpace(Name))
            {
                MessageBox.Show("학번 또는 이름을 적어주세요.", message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("시작합니다", message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                quizPage quizPage = new quizPage(this);
                quizPage.Show();
                quizPage.FormClosed += (s, args) => this.Show();
            }

            Bingo.Text = DataFromForm;
            wrong.Text = DataFromForm1;
        }
    }
}
