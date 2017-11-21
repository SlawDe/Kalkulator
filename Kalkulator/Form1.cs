﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num, ans;
        int count;
        public void disable() //Disable method - blokada kalkulatora
        {
            textBox1.Text = "";
            textBox1.Enabled = false;
            button1.Show();
            button2.Hide();
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
        }
        public void enable() // Enable method - odblokowanie kalkulatora
        {
            textBox1.Enabled = true;
            button1.Hide();
            button2.Show();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)// Przycisk <--
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0;i <lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
        private void button20_Click(object sender, EventArgs e) //przecinek
        {
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Red;
        }
        private void button19_Click(object sender, EventArgs e) // przyciski 0 - 9 Przycisk0
        {
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Red;
        }
        private void button14_Click(object sender, EventArgs e) // Przycisk 1
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Red;
        }
        private void button15_Click(object sender, EventArgs e) // Przycisk 2
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Red;
        }
        private void button17_Click(object sender, EventArgs e) // Przycisk 3
        {
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Red;
        }
        private void button10_Click(object sender, EventArgs e) // Przycisk 4
        {
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Red;
        }
        private void button11_Click(object sender, EventArgs e) // Przycisk 5
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Red;
        }
        private void button12_Click(object sender, EventArgs e) // Przycisk 6
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Red;
        }
        private void button6_Click(object sender, EventArgs e) // Przycisk 7
        {
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Red;
        }
        private void button7_Click(object sender, EventArgs e) // Przycisk 8
        {
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Red;
        }
        private void button8_Click(object sender, EventArgs e) // Przycisk 9
        {
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Red;
        }
        private void button1_Click(object sender, EventArgs e) // Przycisk ON
        {
            enable();
        }
        private void button2_Click(object sender, EventArgs e) // Przycisk OFF
        {
            disable();
        }

        //DZIAŁANIA
        private void button5_Click(object sender, EventArgs e) //suma
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void button9_Click(object sender, EventArgs e) //roznica 
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void button13_Click(object sender, EventArgs e) // mnozenie
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button18_Click(object sender, EventArgs e) // dzielenie
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void button16_Click(object sender, EventArgs e) //znak równa się
        {
            wynik();
            label1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e) // Clear
        {
            textBox1.Text = "";
        }

        public void wynik()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                default:
                    break;
            }
        }

    }
}


/*
            //preparation for storage of numbers or operand
            int prevNum, currNum = 0;
            string operand;
            prevNum = int.Parse(stack.Pop().ToString());
            operand = stack.Pop().ToString();

            //answer.Text = "prev: " + prevNum + "op:" + operand;
            //currNum = int.Parse(stack.Pop().ToString());

            do
            {
                operand = stack.Pop().ToString();
                if (count == "+")
                {
                    currNum = int.Parse(stack.Pop().ToString());
                    prevNum = currNum + prevNum;
                    textBox1.Text = prevNum.ToString();
                }

                if (count == "-")
                {
                    currNum = int.Parse(stack.Pop().ToString());
                    prevNum = currNum - prevNum;
                    textBox1.Text = prevNum.ToString();
                }

                if (count == "/")
                {
                    currNum = int.Parse(stack.Pop().ToString());
                    prevNum = currNum / prevNum;
                    textBox1.Text = prevNum.ToString();
                }

                if (count == "*")
                {
                    currNum = int.Parse(stack.Pop().ToString());
                    prevNum = currNum * prevNum;
                    textBox1.Text = prevNum.ToString();
                }
            } while (operand != " ");
            */
