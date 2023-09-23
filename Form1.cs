using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[,] cards = new string[5,14];
        private void create_card()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    char f = ' ', ten = ' ';
                    switch (i)
                    {
                        case 1:
                            f = 'C';
                            break;
                        case 2:
                            f = 'D';
                            break;
                        case 3:
                            f = 'H';
                            break;
                        case 4:
                            f = 'S';
                            break;
                    }
                    if (j > 10)
                    {
                        switch (j)
                        {
                            case 11:
                                ten = 'J';
                                break;
                            case 12:
                                ten = 'Q';
                                break;
                            case 13:
                                ten = 'K';
                                break;
                        }
                        cards[i,j] = cards[i, j] + ten.ToString() + f.ToString();
                    }
                    else
                    {
                        cards[i, j] = cards[i, j] + j.ToString() + f.ToString();
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            create_card();
        }
        private void show_all_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Flowers", typeof(string));
            dataTable.Columns.Add("Cards", typeof(string));
            dataGridView1.DataSource = dataTable;
            for (int i = 1; i <= 4; i++)
            {
                DataRow row = dataTable.NewRow();
                row[0] = i;
                for(int j=1; j <= 13; j++)
                {
                    row[1] = row[1] + cards[i,j] + ",";
                }
                
                dataTable.Rows.Add(row);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ramdom_card_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Cards", typeof(string));
            dataGridView1.DataSource = dataTable;
            int suit = 0, rank = 0;
            Random r=new Random();
            char f=' ',ten=' ';
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 13; j++)
                {
                    cards[i, j] = "0";
                }
            }
            for (int p = 1; p <= 4; p++)
            {DataRow row = dataTable.NewRow();
                for (int i = 1; i <= 13; i++)
                { 
                    suit = r.Next(1, 5);
                    rank = r.Next(1, 14);
                    while (int.Parse(cards[suit, rank]) > 0)
                    {
                        suit = r.Next(1, 5);
                        rank = r.Next(1, 14);
                    }
                    cards[suit, rank] = "1";
                    switch (suit)
                    {
                        case 1:
                            f = 'C';
                            break;
                        case 2:
                            f = 'D';
                            break;
                        case 3:
                            f = 'H';
                            break;
                        case 4:
                            f = 'S';
                            break;
                    }
                    if (rank > 10)
                    {
                        switch (rank)
                        {
                            case 11:
                                ten = 'J';
                                break;
                            case 12:
                                ten = 'Q';
                                break;
                            case 13:
                                ten = 'K';
                                break;
                        }
                        row[0] = row[0] + ten.ToString() + f.ToString() + ",";
                    }
                    else
                    {
                        row[0] = row[0] + rank.ToString() +f.ToString()+ ",";
                    }
                }dataTable.Rows.Add(row);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void give_card_Click(object sender, EventArgs e)
        {

        }

        private void bouble_sort_Click(object sender, EventArgs e)
        {

        }

        private void bouble_sort_hard_Click(object sender, EventArgs e)
        {

        }

        private void show_img_Click(object sender, EventArgs e)
        {

        }
    }
}