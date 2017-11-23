using System;
using System.Collections;
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
        Stack<float> liczba = new Stack<float>();
        Stack<DateTime> data = new Stack<DateTime>();


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

        //-----------------------------CYFRY------------------------------//
        private void button20_Click(object sender, EventArgs e) //Przycisk . 
        {
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Red;
        } 
        private void button30_Click(object sender, EventArgs e) // Przycisk :
        {
            textBox1.Text = textBox1.Text + ":";
            textBox1.ForeColor = Color.Red;
        }
        private void button19_Click(object sender, EventArgs e) // Przycisk 0
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

        //-----------------------------FUNKCJE------------------------------//
        private void button1_Click(object sender, EventArgs e) // Przycisk ON
        {
            enable();
        }
        private void button2_Click(object sender, EventArgs e) // Przycisk OFF
        {
            disable();
        }
        private void button3_Click(object sender, EventArgs e)// Przycisk <--
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
        private void button4_Click(object sender, EventArgs e) // Clear
        {
            textBox1.Text = "";
        }
        private void button21_Click(object sender, EventArgs e) //Enter
        {
            liczba.Push(float.Parse(textBox1.Text));    // wrzucanie liczby na stos
            textBox1.Clear();                           //czyszczenie ekraniu dla kolejnej cyfry
            textBox1.Focus();                           //przygotowanie ekranu dla kolejnej cyfry
            label1.Text = liczba.Peek().ToString() + " ";//Wyswietlenie ostatniej liczby na stosie
        }
        private void button25_Click(object sender, EventArgs e) // DROP - usuniecie ostatniej cyfry ze stosu
        {
            liczba.Pop();
            label1.Text = " ";
            label1.Text = liczba.Peek().ToString();
        }

        //-----------------------------DZIAŁANIA----------------------------//
        private void button5_Click(object sender, EventArgs e) // suma
        {
            float liczba1 = liczba.Pop();
            float wynik = liczba.Pop() + liczba1;
            textBox1.Text = wynik.ToString();
            //liczba.Push(float.Parse(textBox1.Text));   //przypisanie cyfry gdo zmiennej num
            //textBox1.Clear();                   //czyszczenie ekraniu dla kolejnej cyfry
            //textBox1.Focus();                   //przygotowanie ekranu dla kolejnej cyfry
            //label1.Text = num.ToString() + "+"; //wypisanie liczby oraz + na ekranie
            //label1.Text = liczba.Peek().ToString();// wypisanie liczby , nie kasujac stosu
        }
        private void button9_Click(object sender, EventArgs e) // roznica 
        {
            float liczba1 = liczba.Pop();
            float wynik = liczba.Pop() - liczba1;
            textBox1.Text = wynik.ToString();
        }
        private void button13_Click(object sender, EventArgs e) // mnozenie
        {
            float liczba1 = liczba.Pop();
            float wynik = liczba.Pop() * liczba1;
            textBox1.Text = wynik.ToString();
        }
        private void button18_Click(object sender, EventArgs e) // dzielenie
        {
            float liczba1 = liczba.Pop();
            float wynik = liczba.Pop() / liczba1;
            textBox1.Text = wynik.ToString();
        }
        private void button22_Click(object sender, EventArgs e) //  1/x
        {
            float wynik = 1 / liczba.Pop();
            textBox1.Text = wynik.ToString();
        }
        private void button23_Click(object sender, EventArgs e) // pierwiastek SQRT
        {
            //double liczba1 = liczba.Pop();
            double wynik = Math.Sqrt(liczba.Pop());//, liczba1);
            textBox1.Text = wynik.ToString();
        }
        private void button24_Click(object sender, EventArgs e) // x do potegi y
        {
            double liczba1 = liczba.Pop();
            double wynik = Math.Pow(liczba.Pop(), liczba1);
            textBox1.Text = wynik.ToString();
        }
        private void button16_Click(object sender, EventArgs e) // Data +
        {
            var data1 = data.Pop();
            var data2 = data.Pop();
            TimeSpan timeOfDay = data1.TimeOfDay;

            //TimeSpan timeOfDay2 = data2.TimeOfDay;
            //DateTime data3 = data1.Add(timeOfDay);

            var wynik = data2 + timeOfDay;
            textBox1.Text = wynik.ToString();
        }

        private void button26_Click(object sender, EventArgs e) // Data -
        {
            DateTime data1 = data.Pop();
            DateTime data2 = data.Pop();
            TimeSpan wynik = data2.Subtract(data1);
            textBox1.Text = wynik.ToString();            
        }
        private void button27_Click(object sender, EventArgs e) // Data ENTER
        {
            data.Push(DateTime.Parse(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();                           //przygotowanie ekranu dla kolejnej cyfry
            label1.Text = data.Peek().ToString() + " ";//Wyswietlenie ostatniej liczby na stosie
        }
        private void button28_Click(object sender, EventArgs e) // H+
        {
            var data1 = data.Pop();
            var data2 = data.Pop();
            TimeSpan timeOfDay1 = data1.TimeOfDay;
            TimeSpan timeOfDay2 = data2.TimeOfDay;
            var wynik = timeOfDay1 + timeOfDay2;
            textBox1.Text = wynik.ToString();
        }
        private void button29_Click(object sender, EventArgs e) // H-
        {
            var data1 = data.Pop();
            var data2 = data.Pop();
            TimeSpan timeOfDay1 = data1.TimeOfDay;
            TimeSpan timeOfDay2 = data2.TimeOfDay;
            var wynik = timeOfDay2 - timeOfDay1;
            textBox1.Text = wynik.ToString();
        }

        
    }
}