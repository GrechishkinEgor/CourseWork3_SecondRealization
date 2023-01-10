using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    using CourseWork.Бэкэнд;
    internal class CurrentApplicationContext : ApplicationContext
    {
        static private ChoiceMode ChoiceModeWin = new ChoiceMode();
        static private TeacherMode TeacherModeWin = new TeacherMode();
        static private StudentMode StudentModeWin = new StudentMode();
        static private TeacherCourseView TeacherCourseViewWin = new TeacherCourseView();
        static private StudentCourseView StudentCourseViewWin = new StudentCourseView();

        static private Course CurrentCourse = new Course();
        static private String Path = "";
        
        public CurrentApplicationContext()
        {
            ChoiceModeWin.Show();
            return;
        }

        public static void HideAllForms()
        {
            ChoiceModeWin.Hide();
            TeacherModeWin.Hide();
            StudentModeWin.Hide();
            TeacherCourseViewWin.Hide();
            StudentCourseViewWin.Hide();
            return;
        }
        public static void ShowOnlyChoiceModeWin()
        {
            CurrentApplicationContext.HideAllForms();
            ChoiceModeWin.Show();
        }
        public static void ShowOnlyTeacherModeWin()
        {
            CurrentApplicationContext.HideAllForms();
            TeacherModeWin.Show();
            return;
        }
        public static void ShowOnlyStudentModeWin()
        {
            CurrentApplicationContext.HideAllForms();
            StudentModeWin.Show();
            return;
        }
        public static void ShowOnlyTeacherCourseViewWin()
        {
            HideAllForms();
            TeacherCourseViewWin = new TeacherCourseView();
            TeacherCourseViewWin.Show();
            return;
        }
        public static void ShowOnlyStudentCourseViewWin()
        {
            HideAllForms();
            StudentCourseViewWin = new StudentCourseView();
            StudentCourseViewWin.Show();
            return;
        }
        public static void OpenCourse(String Path)
        {
            FileStream Stream = new FileStream(Path, FileMode.Open);
            BinaryReader Reader = new BinaryReader(Stream);
            CurrentCourse = new Course(Reader);
            Reader.Close();
            CurrentApplicationContext.Path = Path;
            return;
        }
        public static void SaveCourse(String Path)
        {
            FileStream Stream = new FileStream(Path, FileMode.Create);
            BinaryWriter Writer = new BinaryWriter(Stream);
            CurrentCourse.WriteInFile(Writer);
            Writer.Close();
            CurrentApplicationContext.Path = Path;
            return;
        }
        public static void SetNewCourse(Course NewCourse)
        {
            CurrentCourse = NewCourse;
            Path = "";
            return;
        }
        public static Course GetCourse()
        {
            return CurrentCourse;
        }
        public static String GetPath()
        {
            return Path;
        }
        public static bool CheckTeacherPassword(String Password)
        {
            return CurrentCourse.CheckPassword(Password);
        }

    }
}
