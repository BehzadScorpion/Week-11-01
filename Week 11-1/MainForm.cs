using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_11_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event Handler for MainForm's form closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            // u can also close startform since thats how we opened the application in program.cs
        }

        /// <summary>
        /// Event Handler for the exitToolStripMenueItem Click event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
/// <summary>
/// Event Handler for the aboutToolStripMenueItem
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutform.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'section_CDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.section_CDataSet.StudentTable);

        }

        private void ShowdataButton_Click(object sender, EventArgs e)
        {
            var StudentList =
                from student in this.section_CDataSet.StudentTable
                select student;

            foreach (var student in StudentList.ToList())
            {
                Debug.WriteLine("Student ID: " + student.Student_Id + " last name: " + student.LastName);
                }
        }

        //private void ShowdataButton_Click(object sender, EventArgs e)
        //{
        //    var StudentList =
        //        from student in this.section_CDataSet.StudentTable
        //        select student;

        //    foreach (var students in StudentList.ToList())
        //    {
        //        Debug.WriteLine("Student ID: " + student.StudentID+ "last name: " )
        //    }
        //}
    }
}
