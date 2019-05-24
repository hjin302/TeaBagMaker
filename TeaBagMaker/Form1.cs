using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
       
        string[] SList = new string[]{"홍차", "녹차", "루이보스차", "국화차"};
        string orgStr = "";
        int CountOrgNum = 0; // 초기 카운터

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.SList.Length; i++)
            {
                this.comboBox1.Items.Add(SList[i]);
            }
            this.orgStr = this.txt.Text;
            if (SList.Count() > 0)
            {
                this.comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            
        }
    }
}
