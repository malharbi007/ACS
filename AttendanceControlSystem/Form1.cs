using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = this.depNameTextBox.Text;
            // TODO: This line of code loads data into the 'attendLinkDataSet.DepartmentName' table. You can move, or remove it, as needed.
            this.departmentNameTableAdapter.Fill(this.attendLinkDataSet.DepartmentName);
            // TODO: This line of code loads data into the 'attendLinkDataSet.SectionEmployee' table. You can move, or remove it, as needed.
            this.sectionEmployeeTableAdapter.Fill(this.attendLinkDataSet.SectionEmployee);
            // TODO: This line of code loads data into the 'attendLinkDataSet.TitleEmployee' table. You can move, or remove it, as needed.
            this.titleEmployeeTableAdapter.Fill(this.attendLinkDataSet.TitleEmployee);
            // TODO: This line of code loads data into the 'attendLinkDataSet.EmployeeView' table. You can move, or remove it, as needed.
            this.employeeViewTableAdapter.Fill(this.attendLinkDataSet.EmployeeView);
            this.comboBox1.SelectedIndex = -1;
            this.comboBox2.SelectedIndex = -1;
            this.comboBox3.SelectedIndex = -1;
            this.comboBox4.SelectedIndex = -1;
            this.label7.Text = this.employeeViewDataGridView.RowCount.ToString();
        }

        private void employeeViewDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
        }
     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // this.ranksEmployeeTableAdapter.Fill(this.attendLinkDataSet.RanksEmployee, comboBox1.SelectedValue.ToString());
                Cursor.Current = Cursors.AppStarting;
                this.ranksEmployeeTableAdapter.Fill(this.attendLinkDataSet.RanksEmployee, comboBox1.Text);
                this.comboBox2.SelectedIndex =-1;
                this.employeeViewBindingSource.Filter = "[اللقب] like '*" + this.comboBox1.Text + "' and [الرتبة] like '*"+this.comboBox2.Text +"'  and [الموظف] like '*"+this.textBox1.Text+"*' and [بطاقة الأحوال] like '*"+this.textBox2.Text+"*' and [الشعبة] like '*"+this.comboBox3.Text+"' and [الوحدة] like '*"+this.comboBox4.Text +"' " ;
                this.label7.Text = this.employeeViewDataGridView.RowCount.ToString();

                Cursor.Current = Cursors.Default;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.AppStarting;

               
                this.unitEmployeeTableAdapter.Fill(this.attendLinkDataSet.UnitEmployee, comboBox3.Text);
                this.comboBox4.SelectedIndex = -1;
                this.employeeViewBindingSource.Filter = "[اللقب] like '*" + this.comboBox1.Text + "' and [الرتبة] like '*" + this.comboBox2.Text + "'  and [الموظف] like '*" + this.textBox1.Text + "*' and [بطاقة الأحوال] like '*" + this.textBox2.Text + "*' and [الشعبة] like '*" + this.comboBox3.Text + "' and [الوحدة] like '*" + this.comboBox4.Text + "' ";
                this.label7.Text = this.employeeViewDataGridView.RowCount.ToString();

                Cursor.Current = Cursors.Default;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {


            Cursor.Current = Cursors.AppStarting;
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.comboBox1.SelectedIndex =-1;
            this.comboBox2.SelectedIndex = -1;
            this.comboBox3.SelectedIndex = -1;
            this.comboBox4.SelectedIndex = -1;

            Cursor.Current = Cursors.Default;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            //this.employeeViewBindingSource.Filter = "[اللقب] like '*" + this.comboBox1.Text + "' and [الرتبة] like '*" + this.comboBox2.Text + "'";
            this.employeeViewBindingSource.Filter = "[اللقب] like '*" + this.comboBox1.Text + "' and [الرتبة] like '*" + this.comboBox2.Text + "'  and [الموظف] like '*" + this.textBox1.Text + "*' and [بطاقة الأحوال] like '*" + this.textBox2.Text + "*' and [الشعبة] like '*" + this.comboBox3.Text + "' and [الوحدة] like '*" + this.comboBox4.Text + "' ";
            this.label7.Text = this.employeeViewDataGridView.RowCount.ToString();

            Cursor.Current = Cursors.Default;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.employeeViewBindingSource.Filter = "[اللقب] like '*" + this.comboBox1.Text + "' and [الرتبة] like '*" + this.comboBox2.Text + "'  and [الموظف] like '*" + this.textBox1.Text + "*' and [بطاقة الأحوال] like '*" + this.textBox2.Text + "*' and [الشعبة] like '*" + this.comboBox3.Text + "' and [الوحدة] like '*" + this.comboBox4.Text + "' ";
            this.label7.Text = this.employeeViewDataGridView.RowCount.ToString();

            Cursor.Current = Cursors.Default;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.employeeViewBindingSource.Filter = "[اللقب] like '*" + this.comboBox1.Text + "' and [الرتبة] like '*" + this.comboBox2.Text + "'  and [الموظف] like '*" + this.textBox1.Text + "*' and [بطاقة الأحوال] like '*" + this.textBox2.Text + "*' and [الشعبة] like '*" + this.comboBox3.Text + "' and [الوحدة] like '*" + this.comboBox4.Text + "' ";
            this.label7.Text = this.employeeViewDataGridView.RowCount.ToString();

            Cursor.Current = Cursors.Default;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.employeeViewBindingSource.Filter = "[اللقب] like '*" + this.comboBox1.Text + "' and [الرتبة] like '*" + this.comboBox2.Text + "'  and [الموظف] like '*" + this.textBox1.Text + "*' and [بطاقة الأحوال] like '*" + this.textBox2.Text + "*' and [الشعبة] like '*" + this.comboBox3.Text + "' and [الوحدة] like '*" + this.comboBox4.Text + "' ";
            this.label7.Text = this.employeeViewDataGridView.RowCount.ToString();

            Cursor.Current = Cursors.Default;
        }
    }
}
