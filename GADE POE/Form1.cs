using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_POE
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Map mapForm = new Map();
     
        private void Form1_Load(object sender, EventArgs e)
            {
            Button start = new Button();
            Button stop = new Button();

            start.Location = new Point(650, 350);
            start.Size = new Size(100, 100);
            start.Text = "start";
            this.Controls.Add(start);
            start.Click += new EventHandler(Button_Click);

            stop.Location = new Point(650, 450);
            stop.Size = new Size(100, 100);
            stop.Text = "stop";
            this.Controls.Add(stop);
            stop.Click += new EventHandler(Button2_Click);
            mapForm.CreatingMap(this);
                mapForm.SpawnUnits(this);
           


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            mapForm.Move(this);
        }

        

        public void Button_Click(object sender, EventArgs args)
        {
            timer1.Start();
        }
        public void Button2_Click(object sender, EventArgs args)
        {
            timer1.Stop();
        }

    }
    }
