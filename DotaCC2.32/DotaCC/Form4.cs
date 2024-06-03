using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
namespace DotaCC
{

    public partial class Form4 : Form
    {
        System.Timers.Timer timer;
        int m, s;
        public Form4()
        {
            InitializeComponent();
        }
        bool isthisopen = true;
        private async void movepanel1(object sender, EventArgs e)
        {

            if (isthisopen)
            {
                pictureBox10.Image = Image.FromFile("walk right2.gif");
                isthisopen = false;
                button1.Text = "Вернись \nпожалуйста";
                System.Media.SoundPlayer play = new System.Media.SoundPlayer(@"resx\\sounds\\pudmove2.wav"); //Проигрывание звука при нажатии
                play.Play();
                for (int x = 138; x <= 485; x += 5)
                {
                    await Task.Delay(20);
                    pictureBox10.Location = new Point(x, 198);

                }
            }
            else
            {
                pictureBox10.Image = Image.FromFile("walk left2.gif");
                isthisopen = false;
                button1.Text = "Попросить \nподвинуться*";
                System.Media.SoundPlayer play = new System.Media.SoundPlayer(@"resx\\sounds\\pudmove1.wav"); //Проигрывание звука при нажатии
                play.Play();
                for (int x = 485; x >= 138; x -= 5)
                {
                    await Task.Delay(20);
                    pictureBox10.Location = new Point(x, 198);
                }
                isthisopen = true;
                pictureBox10.Image = Image.FromFile("idle2.png");
            }
        }
        bool buttonClicked = false;
        private async void button1_Click(object sender, EventArgs e)
        {
            
            if (buttonClicked == false)
            {
                buttonClicked = true;
                movepanel1(sender, e);
                await Task.Delay(2000);
                buttonClicked = false;
            }
        }
        private async void Form4_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
            timer.Start();
            await Task.Delay(1000);
        }
  
        Point lastpoint;
        private void panel1MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }


        private void StopPic_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Close();

        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {

            Invoke(new Action(() =>
            {
                s += 1; // Секунды Для наглядности выставить 60
                progressBar1.Value += 1; //Вывод на прогресс бар. для наглядности выставить 60
                if (s >= 60) //Перевод 60 секунд в минуты
                {
                    s = 0;
                    m += 1;
                }
                Label1.Text = string.Format("{0}:{1}", m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'));

            }));

            if (m == 5 && s == 0) //Прошло 5 минут 0 секунд = аегис закончился
            {
                aegis.Text = "Аегис утрачен";
                aegis.ForeColor = Color.Red;
                System.Media.SoundPlayer psay = new System.Media.SoundPlayer(@"resx\\souds\\pudalert1.wav"); //Проигрывание звука при нажатии
                psay.Play();
            }
            if (m == 8 && s == 0) //Прошло 8 минут 0 секунд = рошан может возродится
            {
                label3.Text = "Рошан возродится\n в любую секунду!";
                label3.ForeColor = Color.Yellow;
            }
            if (m == 11 && s == 0) //Прошло 11 минут 0 секунд = рошан уже возродился
            {
                label3.Text = "Рошан возродился!";
                label3.ForeColor = Color.Red;
                timer.Stop();
            }

        }
       
    }
}
