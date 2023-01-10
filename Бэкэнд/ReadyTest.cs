using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Бэкэнд
{
    public class ReadyTest : TestBasic
    {
        protected ReadyTask[] TasksList = {};
        protected String StudentName = "";

        protected override void ReadFromFile(BinaryReader Reader)
        {
            base.ReadFromFile(Reader);
            Array.Resize(ref TasksList, Reader.ReadInt32());
            for (int i = 0; i < TasksList.Length; i++)
                TasksList[i] = new ReadyTask(Reader);
            StudentName = Reader.ReadString();
            return;
        }

        public ReadyTest(Test SomeTest) : base() 
        {
            TestName = SomeTest.GetTestName();
            Id = SomeTest.GetId();
            Task[] SomeTestTasks = SomeTest.GetTasksList();
            Array.Resize(ref TasksList, SomeTestTasks.Length);
            if (SomeTest.IsTaskInRandomOrder())
            {
                bool[] UsedTasks = { };
                Array.Resize(ref UsedTasks, SomeTestTasks.Length);
                for (int i = 0; i < UsedTasks.Length; i++)
                    UsedTasks[i] = false;
                Random Randomizer = new Random();
                for (int i = 0; i < SomeTestTasks.Length; i++)
                {
                    int RandIndex = 0;
                    do
                        RandIndex = Randomizer.Next(SomeTestTasks.Length);
                    while (UsedTasks[RandIndex]);
                    UsedTasks[RandIndex] = true;
                    TasksList[i] = new ReadyTask(SomeTestTasks[RandIndex]);
                }
            }
            else
            { 
                for (int i = 0; i < SomeTestTasks.Length; i++)
                    TasksList[i] = new ReadyTask(SomeTestTasks[i]);
            }

            StudentName = "";
            return;
        }
        public ReadyTest(BinaryReader Reader) : base(Reader) { }

        public ReadyTask[] GetTasksList() => TasksList;
        public String GetStudentName() => StudentName;
        public int CalculateTotalMarkInPercent()
        {
            int SumMarks = 0, SumMaxMarks = 0;
            for (int i = 0; i < TasksList.Length; i++)
            {
                SumMarks += TasksList[i].GetLastUserMark();
                SumMaxMarks += TasksList[i].GetMaxMark();
            }
            return (int)((double)SumMarks / SumMaxMarks * 100);
        }

        public void SetStudentName(String Name) => StudentName = Name;

        public override void WriteInFile(BinaryWriter Writer)
        {
            base.WriteInFile(Writer);
            Writer.Write(TasksList.Length);
            for (int i = 0; i < TasksList.Length; i++)
                TasksList[i].WriteInFile(Writer);
            Writer.Write(StudentName);
            return;
        }
    }
}
