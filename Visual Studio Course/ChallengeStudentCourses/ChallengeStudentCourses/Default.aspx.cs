using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            List<Course> courses = new List<Course>() {
                new Course() { CourseId = 1, Name = "Intro to Business", Students=new List<Student>() {
                    new Student() { StudentId = 100, Name = "Wesley Kennedy"},
                    new Student() { StudentId = 101, Name = "Laura Willey" }}},
                new Course() { CourseId = 2, Name = "Marine Biology 101", Students=new List<Student>() {
                    new Student(){ StudentId = 102, Name = "John O'Connor"},
                    new Student(){ StudentId = 103, Name = "John Hemmingson"}}},
                 new Course() { CourseId = 3, Name = "Networking and Solutions", Students=new List<Student>() {
                    new Student(){ StudentId = 104, Name = "Michael Hemmingson"},
                    new Student(){ StudentId = 105, Name = "Rhys Bussiere"}}},
            };

            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("<br/>{0} - {1}", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("<br/>&nbsp;&nbsp;Student:  {0} - {1}", student.StudentId, student.Name);
                }
            }
        }


        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            Course course1 = new Course() { CourseId = 1, Name = "Intro to Business" };
            Course course2 = new Course() { CourseId = 2, Name = "Marine Biology 101" };
            Course course3 = new Course() { CourseId = 3, Name ="Networking and Solutions" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 1, new Student { StudentId = 100, Name = "Weslesy Kennedy", Courses = new List<Course> { course1, course2} } },
                { 2, new Student { StudentId = 105, Name = "Rhys Bussiere", Courses = new List<Course> { course2, course3} } },
                { 3, new Student { StudentId = 104, Name = "Michael Hemmingson", Courses = new List<Course> { course1, course3} } }
            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<br/>Student: {0} - {1}", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("<br/>&nbsp;&nbsp;Course: {0} - {1}", course.CourseId, course.Name);
                }
            }
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentId = 105;
            student.Name = "Rhys Bussiere";
            student.Enrollment = new List<Enrollment>()
            {
                new Enrollment { Grade = 97, Course = new Course { CourseId = 1, Name = "Networking and Solutions"}},
                new Enrollment { Grade = 86, Course = new Course {CourseId = 1, Name = "Intro to Business" }},
            };

            resultLabel.Text += String.Format("<br/>Student: {0} - {1}", student.StudentId, student.Name);
            foreach (var enrollment in student.Enrollment)
            {
                resultLabel.Text += String.Format("<br/>Enrolled In: {0} - Grade: {1}", enrollment.Course.Name, enrollment.Grade);
            }
        }
    }
}