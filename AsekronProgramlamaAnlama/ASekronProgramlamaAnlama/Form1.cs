using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SekronProgramlamaAnlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label1.Text = await ToplaAsync(3,10)+"";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = Carp(int.Parse(textBox2.Text), int.Parse(textBox1.Text)).ToString();
        }


        private Task<int> ToplaAsync(int sayi1, int sayi2) {
             return Task.Run(() =>
            {
                Thread.Sleep(10000);
                return sayi1 + sayi2;
            });
            
        }
        private int Carp(int sayi1, int sayi2)
        {

            return sayi1 * sayi2;
        }
    }



}
