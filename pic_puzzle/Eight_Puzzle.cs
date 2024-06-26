﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace N_Puzzle_Game
{
    public partial class Eight_Puzzle : Form
    {
        string path = "";
        Timer t;
        UserControl_Puzzle_Pictures uspc;
        public bool b_bfs = false, b_gbfs = false;

        public Eight_Puzzle()
        {
            InitializeComponent();
            lbl_time.Text = "";
            lbl_time.ForeColor = Color.OrangeRed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_time.Text = "" ;           
            if (radioButton2.Checked && path != "")
            {
                panel1.Controls.Clear();
                uspc = new UserControl_Puzzle_Pictures(path, 270, 3, 90);
                panel1.Controls.Add(uspc);
            }
        }

        private void Eight_Puzzle_Load(object sender, EventArgs e)
        {
            this.Width = 310;
            t = new Timer();
            t.Interval = 5;
            t.Tick += new EventHandler(t_click);          
            radioButton2.Checked = false;
        }

        private void t_click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                int x = this.Width + 1;
                if (x <= 624)
                    this.Width = x;
                else t.Stop();
            }           
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] state;
            string s = "";
            int start = DateTime.Now.Minute * 60 * 1000 +
                DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            if (uspc != null && uspc.state.Length == 9 && radioButton2.Checked)
            {
                state = get_state(uspc.state);
                if (b_bfs && !uspc.is_goal())
                {
                    uspc.obj_bfs = new Bfs(uspc.state);
                    uspc.start();
                    s = "BFS";
                }
                else if (b_gbfs && !uspc.is_goal())
                {
                    uspc.obj_gbfs = new Greedy_Best_First_Search(3);
                    uspc.obj_gbfs.set_goal(uspc.obj_gbfs.get_destination());
                    uspc.obj_gbfs.solve(state); uspc.start();
                    s = "GBFS";
                }

            }
            int end = DateTime.Now.Minute * 60 * 1000 +
                DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            lbl_time.Text = "time required is : " + (end - start).ToString()
                + " ms, " + s;
        }

        private int[,] get_state(string state)
        {
            int N = (int)Math.Sqrt(state.Length);
            int[,] rs = new int[N, N];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    int idx = i * 3 + j;
                    rs[i, j] = state[idx] - 48;
                }
            return rs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog choose = new OpenFileDialog();
            choose.Filter = 
                "Image Files (JPEG, GIF, PNG , JPG) |*.jpeg; *.gif; *.png; *.jpg";

            if (choose.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(choose.FileName);
                path = choose.FileName;
            }
        }

        private void Eight_Puzzle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Start_Window.__main__ != null)
            {
                Start_Window.__main__.Show();
            }
        }

    }
    
}
