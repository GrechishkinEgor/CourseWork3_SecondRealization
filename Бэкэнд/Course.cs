using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Бэкэнд
{
    internal class Course
    {
        protected String CourseName = "";
        protected String TeacherName = "";
        protected String TeacherPassword = "";
        protected bool InDevelopmentFlag = true;
        protected Test[] ListOfTests = {};
        protected int IdLastTest = 0;

        protected void ReadFromFile(BinaryReader Reader)
        {
            CourseName = Reader.ReadString();
            TeacherName = Reader.ReadString();
            TeacherPassword = Reader.ReadString();
            InDevelopmentFlag = Reader.ReadBoolean();
            Array.Resize(ref ListOfTests, Reader.ReadInt32());
            for (int i = 0; i < ListOfTests.Length; i++)
                ListOfTests[i] = new Test(Reader);
            IdLastTest = Reader.ReadInt32();
            return;
        }

        public Course() { }
        public Course(String CourseName, String TeacherName, String TeacherPassword) : this()
        {
            this.CourseName = CourseName;
            this.TeacherName = TeacherName;
            this.TeacherPassword = TeacherPassword.Trim(' '); //Удаление пробелов в начале и конце пароля
            return;
        }
        public Course(BinaryReader Reader) => ReadFromFile(Reader);

        public String GetCourseName() => CourseName;
        public String GetTeacherName() => TeacherName;
        public bool IsInDevelopment() => InDevelopmentFlag;
        public bool CheckPassword(String UserPassword)
        {
            return TeacherPassword == UserPassword.Trim(' '); //Усекаются пробелы в начале и конце
        }
        public Test[] GetListOfTests() => ListOfTests;

        public void SetCourseName(String Name) => this.CourseName = Name;
        public void SetTeacherName(String TeacherName) => this.TeacherName = TeacherName;
        public bool SetNewPassword(String OldPassword, String NewPassword)
        {
            if (OldPassword == this.TeacherPassword)
            {
                this.TeacherPassword = NewPassword.Trim(' ');
                return true;
            }
            else
                return false;
        }
        public void FinishDevelopment() => InDevelopmentFlag = false;

        public void AddNewTest(Test NewTest)
        {
            IdLastTest++;
            NewTest.SetId(IdLastTest);
            Array.Resize(ref ListOfTests, ListOfTests.Length + 1);
            ListOfTests[ListOfTests.Length - 1] = NewTest;
            return;
        }
        public bool RemoveTestWithId(int Id)
        {
            for (int i = 0; i < ListOfTests.Length; i++)
                if (ListOfTests[i].GetId() == Id)
                {
                    for (int j = i; j < ListOfTests.Length - 1; j++)
                        ListOfTests[j] = ListOfTests[j + 1];
                    Array.Resize(ref ListOfTests, ListOfTests.Length - 1);
                    return true;
                }
            return false;
        }
        public Test GetTestWithId(int Id)
        {
            for (int i = 0; i < ListOfTests.Length; i++)
                if (ListOfTests[i].GetId() == Id)
                    return ListOfTests[i];
            return null;
        }

        public void WriteInFile(BinaryWriter Writer)
        {
            Writer.Write(CourseName);
            Writer.Write(TeacherName);
            Writer.Write(TeacherPassword);
            Writer.Write(InDevelopmentFlag);
            Writer.Write(ListOfTests.Length);
            for (int i = 0; i < ListOfTests.Length; i++)
                ListOfTests[i].WriteInFile(Writer);
            Writer.Write(IdLastTest);
            return;
        }
    }
}
