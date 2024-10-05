namespace tps_prova1
{
    public partial class Form1 : Form
    {
        private string turno;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(400, 400);
            Random generatore = new Random();
            if (generatore.Next(2) == 0) turno = "X";
            else turno = "O";
            label3.Text = turno;
        }

        private void btn1_Click(object sender, EventArgs e)
        { 
            if (label4.Visible == false)
            {
                Button pulsante = (Button)sender;
                if (pulsante.Text == "")
                {
                    pulsante.Text = turno;
                    if (turno == "X") turno = "O";
                    else turno = "X";
                    label3.Text = turno;
                }
                if (btn1.Text == btn2.Text && btn3.Text == btn1.Text && btn1.Text != "")
                {
                    label4.Visible = true;
                    label5.Text = btn1.Text;
                    label5.Visible = true;
                }
                if (btn4.Text == btn5.Text && btn4.Text == btn6.Text && btn4.Text != "")
                {
                    label4.Visible = true;
                    label5.Text = btn4.Text;
                    label5.Visible = true;
                }
                if (btn7.Text == btn8.Text && btn7.Text == btn9.Text && btn7.Text != "")
                {
                    label4.Visible = true;
                    label5.Text = btn7.Text;
                    label5.Visible = true;
                }
                if (btn1.Text == btn6.Text && btn9.Text == btn1.Text && btn1.Text != "")
                {
                    label4.Visible = true;
                    label5.Text = btn1.Text;
                    label5.Visible = true;
                }
                if (btn5.Text == btn2.Text && btn2.Text == btn8.Text && btn2.Text != "")
                {
                    label4.Visible = true;
                    label5.Text = btn2.Text;
                    label5.Visible = true;
                }
                if (btn3.Text == btn4.Text && btn3.Text == btn7.Text && btn3.Text != "")
                {
                    label4.Visible = true;
                    label5.Text = btn3.Text;
                    label5.Visible = true;
                }
                if (btn1.Text == btn5.Text && btn7.Text == btn1.Text && btn1.Text != "")
                {
                    label4.Visible = true;
                    label5.Text = btn1.Text;
                    label5.Visible = true;
                }
                if (btn3.Text == btn5.Text && btn3.Text == btn9.Text && btn3.Text != "")
                {
                    label4.Visible = true;
                    label5.Text = btn3.Text;
                    label5.Visible = true;
                }
                if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                {
                    label4.Visible = true;
                    label4.Text = "PAREGGIO";
                }
            }
        }
    }
}