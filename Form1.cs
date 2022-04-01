using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practise_datatable
{
    public partial class Form1 : Form
    {
        DataTable data = new DataTable();
        int index;
        public Form1()
        {
            InitializeComponent();
            data.Columns.Add(" name");
            data.Columns.Add(" id");
            data.Columns.Add(" CNIC");
            data.Columns.Add(" AGE");
            data.Columns.Add(" gender");
            data.Columns.Add(" skills");
            data.Columns.Add(" campus");
            dataGridView1.DataSource = data;
            dataGridView1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s=" ";
            DataRow row1 = data.NewRow();

            row1[" name"] = textBox1.Text;
            row1[" id"] = textBox2.Text;
            row1[" CNIC"] = textBox3.Text;
            row1[" AGE"] = textBox4.Text;

            if (checkBox1.Checked)
            {
                //row1[" skills"] = checkBox1.Text;
                s = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
              //  row1[" skills"] = s +" "+checkBox2.Text;
                s = s + " " + checkBox2.Text;


            }
            if (checkBox3.Checked)
            {
               // row1[" skills"] = s+" "+checkBox3.Text;
                s = s + " " + checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
               // row1[" skills"] = s+" "+checkBox4.Text;
                s = s + " " + checkBox4.Text;
            }
            if (checkBox5.Checked)
            {
               // row1[" skills"] = s+" " +checkBox5.Text;
                s = s + " " + checkBox5.Text;
            }
            row1[" skills"] = s;

            if(radioButton1.Checked)
            {
                row1[" gender"] = "male";
            }
            else
            {
                row1[" gender"] = "female";
            }
            row1[" campus"] = comboBox1.SelectedItem;

            data.Rows.Add(row1);

            dataGridView1.DataSource = data;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = " ";
            index = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = textBox1.Text;
            newdata.Cells[1].Value = textBox2.Text;
            newdata.Cells[2].Value = textBox3.Text;
            newdata.Cells[3].Value = textBox4.Text;
            if(radioButton1.Checked)
            {
                newdata.Cells[4].Value = "male";
            }
            else
            {
                newdata.Cells[4].Value = "female";
            }
            if (checkBox1.Checked)
            {
                //row1[" skills"] = checkBox1.Text;
                s = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                //  row1[" skills"] = s +" "+checkBox2.Text;
                s = s + " " + checkBox2.Text;


            }
            if (checkBox3.Checked)
            {
                // row1[" skills"] = s+" "+checkBox3.Text;
                s = s + " " + checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                // row1[" skills"] = s+" "+checkBox4.Text;
                s = s + " " + checkBox4.Text;
            }
            if (checkBox5.Checked)
            {
                // row1[" skills"] = s+" " +checkBox5.Text;
                s = s + " " + checkBox5.Text;
            }
            newdata.Cells[5].Value = s;
            newdata.Cells[6].Value = comboBox1.SelectedItem;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
