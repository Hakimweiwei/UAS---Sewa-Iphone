﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace UTS___Sewa_Iphone
{
    public partial class Form1Login : Form
    {
        TampilanUtama tampilanUtama = new TampilanUtama();
        public Form1Login()
        {
            InitializeComponent();
        }

        private void Form1Login_Load(object sender, EventArgs e)
        {
            this.Hide();
            tampilanUtama.ShowDialog();
            this.Close();
        }
    }
}
