using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using SearchInfo;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DotaCC
{

    public partial class Form1 : Form
    {
        
        SearchHero SearchTo = new SearchHero();
        public bool isSecondFormOpen = false;
        Timing form2 = new Timing();
        System.Media.SoundPlayer play = new System.Media.SoundPlayer($"resx\\sounds\\Ui_menu_click.wav");
        System.Media.SoundPlayer plays = new System.Media.SoundPlayer($"resx\\sounds\\Ui_menu_close.wav");
        Form4 Clock = new Form4();
        public bool isFourFormOpen = false;
        Point lastpoint;
        int heroId { get; set; }
        public Form1()
        {
            InitializeComponent();

            comboBoxHeroes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxHeroes.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxHeroes.AutoCompleteCustomSource.AddRange(hero);
        }
        string[] hero = {
                    "anti-mage",
                    "axe",
                    "bane",
                    "bloodseeker",
                    "crystal maiden",
                    "drow ranger",
                    "earthshaker",
                    "juggernaut",
                    "mirana",
                    "morphling",
                    "shadow fiend",
                    "phantom lancer",
                    "puck",
                    "pudge",
                    "razor",
                    "sand king",
                    "storm spirit",
                    "sven",
                    "tiny",
                    "vengeful spirit",
                    "windranger",
                    "zeus",
                    "kunkka",
                    "lina",
                    "lion",
                    "shadow shaman",
                    "slardar",
                    "tidehunter",
                    "witch doctor",
                    "lich",
                    "riki",
                    "enigma",
                    "tinker",
                    "sniper",
                    "necrophos",
                    "warlock",
                    "beastmaster",
                    "queen of pain",
                    "venomancer",
                    "faceless void",
                    "wraith king",
                    "death prophet",
                    "phantom assassin",
                    "pugna",
                    "templar assassin",
                    "viper",
                    "luna",
                    "dragon knight",
                    "dazzle",
                    "clockwerk",
                    "leshrac",
                    "nature's prophet",
                    "lifestealer",
                    "dark seer",
                    "clinkz",
                    "omniknight",
                    "enchantress",
                    "huskar",
                    "night stalker",
                    "broodmother",
                    "bounty hunter",
                    "weaver",
                    "jakiro",
                    "batrider",
                    "chen",
                    "spectre",
                    "ancient apparition",
                    "doom",
                    "ursa",
                    "spirit breaker",
                    "gyrocopter",
                    "alchemist",
                    "invoker",
                    "silencer",
                    "outworld destroyer",
                    "lycan",
                    "brewmaster",
                    "shadow demon",
                    "lone druid",
                    "chaos knight",
                    "meepo",
                    "treant protector",
                    "ogre magi",
                    "undying",
                    "rubick",
                    "disruptor",
                    "nyx assassin",
                    "naga siren",
                    "keeper of the light",
                    "io",
                    "visage",
                    "slark",
                    "medusa",
                    "troll warlord",
                    "centaur warrunner",
                    "magnus",
                    "timbersaw",
                    "bristleback",
                    "tusk",
                    "skywrath mage",
                    "abaddon",
                    "elder titan",
                    "legion commander",
                    "techies",
                    "ember spirit",
                    "earth spirit",
                    "underlord",
                    "terrorblade",
                    "phoenix",
                    "oracle",
                    "winter wyvern",
                    "arc warden",
                    "monkey king",
                    "dark willow",
                    "pangolier",
                    "grimstroke",
                    "hoodwink",
                    "void spirit",
                    "snapfire",
                    "mars",
                    "ringmaster",
                    "dawnbreaker",
                    "marci",
                    "primal beast",
                    "muerta"
                };


        //формат объектов в листе
        public class HeroMatchup
        {
            public int hero_id { get; set; }
            public double games_played { get; set; }
            public double wins { get; set; }
            public double WinRate()
            {
                return wins / games_played * 100;
            }
        }
        //дизайн
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
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void iftouchedmusic(object sender, EventArgs e)
        {
            plays.Play();
        }
        private void iftouchedclose(object sender, EventArgs e)
        {
            plays.Play();
            pictureBox5.Image = Image.FromFile("Red_X.png");
        }
        private void iftouchedminimized(object sender, EventArgs e)
        {
            plays.Play();
            pictureBox6.Image = Image.FromFile("minimized_red.png");
        }
        private void iftouchedlightbulb(object sender, EventArgs e)
        {
            plays.Play();
            pictureBox7.Image = Image.FromFile("light_on.png");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            play.Play();
            if (isSecondFormOpen)
            {
                form2.Close();
                isSecondFormOpen= false;
            }
            else 
            {   
                form2 = new Timing();
                form2.Show();
                isSecondFormOpen = true;
            }
            
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile("X.png");
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile("minimized.png");
        }
        private void label4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer playw = new System.Media.SoundPlayer($"resx\\sounds\\secret.wav"); //Проигрывание звука при нажатии
            playw.Play();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
                pictureBox7.Image = Image.FromFile("light_off.png");
        }
        
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            play.Play();
            if (isFourFormOpen)
            {
                Clock.Close();
                isFourFormOpen = false;
            }
            else
            {
                Clock = new Form4();
                Clock.Show();
                isFourFormOpen = true;
            }
        }
        //основная кнопка поиска
        private async void pictureBox8_Click_1(object sender, EventArgs e)
        {
            pictureBox10.Image = null; //Очистка для презентабельности
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox2.Image = Image.FromFile("load.gif");//Очистка для презентабельности
            pictureBox3.Image = Image.FromFile("load.gif");
            pictureBox1.Image = Image.FromFile("load.gif");
            label1.Text = ""; //Очистка для презентабельности
            label2.Text = ""; 
            label3.Text = ""; 
            play.Play();
            heroId = SearchTo.Name(comboBoxHeroes.Text);
            if (heroId == 139)//Error
            {
                pictureBox4.Image = Image.FromFile("resx\\Hero_icon\\139.png");
            }
            else
            {
                pictureBox13.Image = Image.FromFile("ramka.png");
                pictureBox4.Image = Image.FromFile($"resx\\Hero_icon\\{heroId}.png");
                List<HeroMatchup> heroMatchups = await SearchTo.Api(heroId);//запрос в api.opendota
                heroMatchups.Sort((x, y) => y.WinRate().CompareTo(x.WinRate()));// Сортировка по убыванию WinRate
                System.Media.SoundPlayer player = new System.Media.SoundPlayer($"resx\\sounds\\Culling_Blade.wav");
                player.Play();
                foreach (var hero in heroMatchups.ToArray())
                {
                    if (hero.games_played < 100)//убираем героев у которых меньше 100 игр
                    {
                        heroMatchups.Remove(hero);
                    }
                }
                //вывод картинок и текста к лучшим контерпикам
                if (heroMatchups.Count >= 1)
                {
                    var bestcp = heroMatchups[0];
                    pictureBox1.Image = Image.FromFile($"resx\\Hero_icon\\{bestcp.hero_id}.png");
                    label1.Text = $"{SearchTo.Id(bestcp.hero_id)}\nWinRate:{bestcp.WinRate():0.##}%";
                    pictureBox12.Image = Image.FromFile("ramka.png");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("resx\\Hero_icon\\139.png");
                }
                if (heroMatchups.Count >= 2)
                {
                    var mediumcp = heroMatchups[1];
                    pictureBox2.Image = Image.FromFile($"resx\\Hero_icon\\{mediumcp.hero_id}.png");
                    label2.Text = $"{SearchTo.Id(mediumcp.hero_id)}\nWinRate:{mediumcp.WinRate():0.##}%";
                    pictureBox11.Image = Image.FromFile("ramka.png");
                }
                else
                {
                    pictureBox2.Image = Image.FromFile("resx\\Hero_icon\\139.png");
                }
                if (heroMatchups.Count >= 3)
                {
                    var lowcp = heroMatchups[2];
                    pictureBox3.Image = Image.FromFile($"resx\\Hero_icon\\{lowcp.hero_id}.png");
                    label3.Text = $"{SearchTo.Id(lowcp.hero_id)}\nWinRate:{lowcp.WinRate():0.##}%";
                    pictureBox10.Image = Image.FromFile("ramka.png");
                }
                else
                {
                    pictureBox3.Image = Image.FromFile("resx\\Hero_icon\\139.png");
                }
            }
        }
    }
}