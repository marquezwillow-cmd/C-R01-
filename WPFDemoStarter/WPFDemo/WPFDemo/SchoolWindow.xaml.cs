using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace WPFDemo
{
    public partial class SchoolWindow : Window
    {
        private School school = new School();

        public SchoolWindow()
        {
            InitializeComponent();

            // Map seeded array entities directly onto corresponding list views
            lbCampuses.ItemsSource = school.Campuses;
            lbCourses.ItemsSource = school.Courses;
            lbMajors.ItemsSource = school.Majors;

            // Bind student roster directly to master collection
            lbStudents.ItemsSource = school.Students;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student();
            StudentWindow studentWindow = new StudentWindow(newStudent);

            // Invoke sub-window element as a modal dialog
            studentWindow.Owner = this;
            if (studentWindow.ShowDialog() == true)
            {
                MessageBox.Show("Student " + newStudent.StudentNumber + " Added!", "Success", MessageBoxButton.OK, MessageBoxIcon.Information);
                school.Students.Add(newStudent);

                // Instruct target layout wrapper to force rebuild visual layout
                lbStudents.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Dialog Cancelled!", "Operation Terminated", MessageBoxButton.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Documents (*.txt)|*.txt|All Resource Files (*.*)|*.*";
            saveFile.Title = "Save Student Data Archive Records";

            if (saveFile.ShowDialog() == true)
            {
                try
                {
                    using (StreamWriter file = new StreamWriter(saveFile.OpenFile()))
                    {
                        foreach (var student in school.Students)
                        {
                            file.WriteLine(student.ToString());
                        }
                    }
                    MessageBox.Show("Data exported successfully to chosen destination path.", "Export Complete", MessageBoxButton.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during file persistence workflows: " + ex.Message, "IO System Exception", MessageBoxButton.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}