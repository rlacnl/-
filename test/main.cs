using System;
using System.Windows.Forms;

namespace test
{
    public partial class main : Form
    {
        

        public main()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            string number = num.Text;
            string Name = name.Text; 
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
        }

        private void main_Load(object sender, EventArgs e)
        {
            Bingo.Text = "맞은 번호 " + quizPage.DataFromForm + quizPage2.DataFromForm3;
            wrong.Text = "틀린 번호 " + quizPage.DataFromForm1 + quizPage2.DataFromForm4;
            int a = 0;
            score.Text = "총점 " +  a.ToString();
            a = Bingo.Text.Length;
        }
    }
}
