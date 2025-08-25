using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Course
{
    public partial class Course : Form
    {


        public int totalcr;
        public DataTable showcourse = new DataTable();
        public DataTable selectcourse = new DataTable();
        public DataTable viewcourse = new DataTable();


        public Course()
        {
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            name.Text = Form1.name;
            id.Text = Form1.id;


            course();
            selectcourseview();

            listBox1.DataSource = showcourse;
            listBox1.DisplayMember = "Course Name";

            listBox2.DataSource = selectcourse;           
            listBox2.DisplayMember = "Course Name";

           

        }

        private void course()
        {
            showcourse.Columns.Add("Course No",typeof(int));
            showcourse.Columns.Add("Course Name");
            showcourse.Columns.Add("Course Credit", typeof(int));

            showcourse.Rows.Add(1, "INTRODUCTION TO PROGRAMMING", 3);
            showcourse.Rows.Add(2, "OBJECT ORIENTED PROGRAMMING 1 (JAVA)", 3);
            showcourse.Rows.Add(3, "DATA STRUCTURE", 3);
            showcourse.Rows.Add(4, "NTRODUCTION TO DATABASE", 3);
            showcourse.Rows.Add(5, "ALGORITHMS", 3);
            showcourse.Rows.Add(6, "OBJECT ORIENTED PROGRAMMING 2 (C#)", 3);
            showcourse.Rows.Add(7, "OBJECT ORIENTED ANALYSIS AND DESIGN", 3);
            showcourse.Rows.Add(8, "ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM", 3);
            showcourse.Rows.Add(9, "SOFTWARE ENGINEERING", 3);
            showcourse.Rows.Add(10, "COMPILER DESIGN", 3);
            showcourse.Rows.Add(11, "THEORY OF COMPUTATION", 3);
            showcourse.Rows.Add(12, "COMPUTER NETWORKS", 3);
            showcourse.Rows.Add(13, "OPERATING SYSTEM", 3);
            showcourse.Rows.Add(14, "COMPUTER GRAPHICS", 3);
            showcourse.Rows.Add(15, "MICROPROCESSOR AND EMBEDDED SYSTEMS", 3);

        }


        private void selectcourseview()
        {
            selectcourse.Columns.Add("Course No", typeof(int));
            selectcourse.Columns.Add("Course Name");
            selectcourse.Columns.Add("Course Credit", typeof(int));
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0) {

                selectcourse.ImportRow(showcourse.Rows[listBox1.SelectedIndex]);
                showcourse.Rows[listBox1.SelectedIndex].Delete();

            }
            totalcr = listBox2.Items.Count * 3;
            credit.Text = totalcr.ToString();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {

                showcourse.ImportRow(selectcourse.Rows[listBox2.SelectedIndex]);
                selectcourse.Rows[listBox2.SelectedIndex].Delete();

            }

            if (totalcr <=0)
            {   
              
                credit.Text = "0";
            }
            else
            {
                totalcr -= 3;
                credit.Text = totalcr.ToString();
            }


        }

    

        private void confrim_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0) {

                MessageBox.Show("Please select atleast one course", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure to confrim these course", "Confrimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {

                    courseview.DataSource = selectcourse;
                    //courseview.Enabled = false;
                    //listBox1.Enabled = false;
                    //listBox2.Enabled = false;
                    courseview.ReadOnly = true;   // for DataGridView
                    listBox1.SelectionMode = SelectionMode.None;
                    listBox2.SelectionMode = SelectionMode.None;
                    add.Enabled = false;
                    remove.Enabled = false;
                    confrim.Enabled = false;


                }
                else { }
                
            }

        }




    }
}
