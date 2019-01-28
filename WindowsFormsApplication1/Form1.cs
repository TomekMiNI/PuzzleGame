using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private bool Start = false;
        private int[] maxpion;
        private int[] maxpoziom;
        private bool[,] active;
        private int lifespan = 3;
        private int maxlifespan = 3;
        private int gametime = 10;
        private int finalscore = 0;
        private int kuniec = 0;
        private int counttowin = 0;
        private bool exitflag;
        private bool win;
        private bool modeedit;
        private bool generalstart;
        Timer ftime = new Timer();
        public Form1()
        {
            InitializeComponent();
        }
        public int getlifespan
        {
            get { return lifespan; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void lb_MouseEnter(object sender, EventArgs e)
        {
            if (modeedit == false)
            {
                Button bc = (sender as Button);
                if (bc.BackColor == Color.RoyalBlue)
                    (sender as Button).BackColor = Color.Yellow;
            }
            
        }
        private void lb_MouseLeave(object sender, EventArgs e)
        {
            if (modeedit == false)
            {
                Button bc = (sender as Button);
                if (bc.BackColor == Color.Yellow)
                    (sender as Button).BackColor = Color.RoyalBlue;
            }
            
        }
        private void byebye()
        {
            ftime.Stop();
            MessageBox.Show("Your final score is " + finalscore.ToString(), "Congratulations!");
        }
        private void TimerEventProcessor(object sender, EventArgs e)
        {
            (sender as Timer).Stop();
            exitflag = true;
        }
        private void TimeToSayGoodBye(object sender, EventArgs e)
        {
            if (lifespan == 0) (sender as Timer).Stop();
            toolStripProgressBar1.Value -= 10;
            if (toolStripProgressBar1.Value == 0)
            {
                Start = false;
                byebye();
            }
        }
        private void lifescore()
        {
            toolStripStatusLabel1.Text = "lifes: " + lifespan.ToString() + " highscore: " + finalscore.ToString();
        }
        private void lb_MouseDown(object sender, MouseEventArgs e)
        {
            if(Start)   
            switch (e.Button)
            {
                case MouseButtons.Left:
                {
                            if (modeedit == false)
                            {
                                if (active[tlp.GetPositionFromControl(sender as Control).Row - 1, tlp.GetPositionFromControl(sender as Control).Column - 1])
                                {
                                    (sender as Button).BackColor = Color.Black;
                                    finalscore += 50;
                                    counttowin++;
                                    lifescore();
                                    if (counttowin == kuniec)
                                    {
                                        win = true;
                                        finalscore += 500;
                                        newGameToolStripMenuItem_Click(sender, e);
                                    }
                                }
                                else
                                {
                                    //na 0,5 sekundy czerwony
                                    Timer mytime = new Timer();
                                    mytime.Tick += new EventHandler(TimerEventProcessor);
                                    mytime.Interval = 500;

                                    (sender as Button).BackColor = Color.Red;
                                    mytime.Start();
                                    lifespan--;
                                    lifescore();
                                    if (lifespan == 0)
                                    {
                                        Start = false;
                                        byebye();
                                    }
                                    while (exitflag == false)
                                        Application.DoEvents();
                                    (sender as Button).BackColor = Color.RoyalBlue;
                                    exitflag = false;
                                }
                            }
                            else
                            {
                                (sender as Button).BackColor = Color.Black;
                                kuniec++;
                                active[tlp.GetPositionFromControl(sender as Control).Row - 1, tlp.GetPositionFromControl(sender as Control).Column - 1] = true;
                                maxpoziom[tlp.GetPositionFromControl(sender as Control).Row - 1]++;
                                maxpion[tlp.GetPositionFromControl(sender as Control).Column - 1]++;
                            }
                    break;
                }
                case MouseButtons.Right:
                        if (modeedit == false)
                        {
                            if ((sender as Button).BackColor != Color.Black)
                                (sender as Button).BackColor = Color.White;
                        }
                        else
                        {
                            (sender as Button).BackColor = Color.White;
                            kuniec--;
                            active[tlp.GetPositionFromControl(sender as Control).Row - 1, tlp.GetPositionFromControl(sender as Control).Column - 1] = false;
                            maxpoziom[tlp.GetPositionFromControl(sender as Control).Row - 1]--;
                            maxpion[tlp.GetPositionFromControl(sender as Control).Column - 1]--;
                        }
                        break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftime.Stop();
            toolStripProgressBar1.Value = toolStripProgressBar1.Maximum = 10 * gametime;
            ftime.Interval = 1000;
            if (generalstart == false)
            {
                ftime.Tick += new EventHandler(TimeToSayGoodBye);
                generalstart = true;
            }
            ftime.Start();
            Start = true;
            Random rnd = new Random();
            counttowin = 0;
            if (!win)
            {
                finalscore = 0;
            }
            else
            {
                win = false;
            }
            lifespan = maxlifespan;
            lifescore();
            if (modeedit == false)
            {
                kuniec = 0;
                active = new bool[4, 4];
                maxpion = new int[4];
                maxpoziom = new int[4];
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        if (rnd.Next(0, 2) == 1)
                        {
                            active[i, j] = true;
                            maxpion[j]++;
                            maxpoziom[i]++;
                            kuniec++;
                        }
            }
            else modeedit = false;
            for (int i = 0; i < tlp.Controls.Count; i++)
            {
                if (tlp.Controls[i] is Label)
                {
                    int liczba = 0;
                    if (tlp.GetPositionFromControl(tlp.Controls[i]).Row == 0)
                        liczba = maxpion[tlp.GetPositionFromControl(tlp.Controls[i]).Column - 1];
                    else
                        liczba = maxpoziom[tlp.GetPositionFromControl(tlp.Controls[i]).Row - 1];
                    (tlp.Controls[i] as Label).Text = liczba.ToString();
                }
                if(tlp.Controls[i] is Button)
                {
                    (tlp.Controls[i] as Button).BackColor = Color.RoyalBlue;
                    (tlp.Controls[i] as Button).Text = "?";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tlp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                byebye();
                e.Cancel = false;
            }
        }

        private void ss_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftime.Stop();
            Form2 frm2 = new Form2(maxlifespan, gametime);
            frm2.ShowDialog(this);
            maxlifespan = frm2.lifeisbrutal;
            gametime = frm2.timeisbrutal;
            lifespan = maxlifespan;
            lifescore();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftime.Stop();
            Start = true;
            kuniec = 0;
            if(gameToolStripMenuItem.Checked)
                gameToolStripMenuItem.Checked = false;
            newGameToolStripMenuItem.Enabled = !editToolStripMenuItem.Checked;
            settingsToolStripMenuItem.Enabled = !editToolStripMenuItem.Checked;
            openToolStripMenuItem.Enabled = !editToolStripMenuItem.Checked;
            saveToolStripMenuItem.Enabled = editToolStripMenuItem.Checked;
            ms.BackColor = Color.Gold;
            modeedit = true;
            active = new bool[4, 4];
            maxpion = new int[4];
            maxpoziom = new int[4];
            for (int i = 0; i < tlp.Controls.Count; i++)
            {
                if (tlp.Controls[i] is Label)
                {
                    (tlp.Controls[i] as Label).Text = "";
                }
                if (tlp.Controls[i] is Button)
                {
                    (tlp.Controls[i] as Button).BackColor = Color.White;
                    (tlp.Controls[i] as Button).Text = "";

                }
            }
            //zrob wszysktie biale i obsluz ppm i uzupelnij tablice activate czarnymi przyciskami; yolo

        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ms.BackColor = DefaultBackColor;
            if (editToolStripMenuItem.Checked)
                editToolStripMenuItem.Checked = false;
            if (modeedit)
            {
                newGameToolStripMenuItem.Enabled = settingsToolStripMenuItem.Enabled = openToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = false;
                newGameToolStripMenuItem_Click(sender, e);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "pg files (*.pg)|*.pg";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    BinaryWriter bw = new BinaryWriter(myStream);
                    for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 4; j++)
                        {
                            if (active[i, j])
                                bw.Write((double)1);
                            else bw.Write((double)0);
                        }
                    bw.Close();
                    myStream.Close();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftime.Stop();
            System.IO.Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "pg files (*.pg)|*.pg";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            BinaryReader br = new BinaryReader(myStream);
                            active = new bool[4, 4];
                            maxpoziom = new int[4];
                            maxpion = new int[4];
                            double[,] tab = new double[4, 4];
                            kuniec = 0;
                            for(int i=0;i<4;i++)
                                for(int j=0;j<4;j++)
                                {
                                    tab[i, j] = br.ReadDouble();
                                    if(tab[i,j]==1)
                                    {
                                        active[i, j] = true;
                                        kuniec++;
                                        maxpoziom[i]++;
                                        maxpion[j]++;
                                    }
                                }
                            br.Close();
                            myStream.Close();
                            modeedit = true;
                            newGameToolStripMenuItem_Click(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
    partial class Form2 : Form
    {
        public Form2(int l, int t)
        {
            lifeisbrutal = l;
            timeisbrutal = t;
            InitializeComponent();
        }
        public int lifeisbrutal;
        public int timeisbrutal;
        private bool okclicked;
        private void OKClick(object sender, EventArgs e)
        {
            okclicked = true;
            this.Close();
        }
        private void CANCELClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ZamknijMnie(object sender, FormClosingEventArgs e)
        {
            if (okclicked)
            {
                lifeisbrutal = (int)n1.Value;
                timeisbrutal = (int)n2.Value;
            }
        }
        private void keyevencior(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OKClick(sender, (EventArgs)e);
            if (e.KeyCode == Keys.Escape)
                CANCELClick(sender, (EventArgs)e);
        }

    }
}
