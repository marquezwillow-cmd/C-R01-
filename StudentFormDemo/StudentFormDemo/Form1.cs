using StudentForm;
using System.Xml.Schema;

namespace StudentFormDemo
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //get major
            string major = "TBD";
            if (rbIT.Checked) major = rbIT.Text;
            else if (rbProgramming.Checked) major = rbProgramming.Text;
            else if (rbWebDesign.Checked) major = rbWebDesign.Text;

            //initiate student
            Student st = new Student(txtStudentID.Text, txtFirstName.Text, txtLastName.Text, major);
            //set student properties from form
            int count = 0;
            if (cbxCIS101.Checked) count++;
            if (cbxCIS102.Checked) count++;
            if (cbxCIS103.Checked) count++;
            if (cbxCIS104.Checked) count++;

            string[] courses = new string[count];
            int[] scores = new int[count];

            int index = 0;
            if (cbxCIS101.Checked)
            {
                courses[index] = cbxCIS101.Text;
                int.TryParse(txbScore1.Text, out scores[index++]);
            }
            if (cbxCIS102.Checked)
            {
                courses[index] = cbxCIS102.Text;
                int.TryParse(txbScore2.Text, out scores[index++]);
            }
            if (cbxCIS103.Checked)
            {
                courses[index] = cbxCIS103.Text;
                int.TryParse(txbScore3.Text, out scores[index++]);
            }
            if (cbxCIS104.Checked)
            {
                courses[index] = cbxCIS104.Text;
                int.TryParse(txbScore4.Text, out scores[index++]);
            }

            //set new arrays into student object
            st.Scores = scores;
            st.Courses = courses;

            //display in text box
            txbResult.Text = st.ToString();
        }

        private void llCengage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://www.corse.com");
            llCengage.LinkVisited = true;
        }

        private void pbSubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
