using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Бэкэнд
{
    public class Test : TestBasic
    {
        protected int IdLastTask = 0;
        protected bool RandomOrder = false;
        protected Task[] TasksList = {};

        protected override void ReadFromFile(BinaryReader Reader)
        {
            base.ReadFromFile(Reader);
            IdLastTask = Reader.ReadInt32();
            RandomOrder = Reader.ReadBoolean();
            Array.Resize(ref TasksList, Reader.ReadInt32());
            for (int i = 0; i < TasksList.Length; i++)
                TasksList[i] = new Task(Reader);
        }

        public Test() { }
        public Test(String Name) : base() { TestName = Name; }
        public Test(BinaryReader Reader) : base(Reader) { }

        public Task GetTaskWithId(int Id)
        {
            for (int i = 0; i < TasksList.Length; i++)
                if (TasksList[i].GetId() == Id)
                    return TasksList[i];
            return null;
        }
        public Task[] GetTasksList() => TasksList;
        public bool IsTaskInRandomOrder() => RandomOrder;

        public void SetTestName(String Name) { TestName = Name; }
        public void SetId(int Id) { this.Id = Id; }
        public void SetRandomOrderFlag(bool IsRandomOrder) { RandomOrder = IsRandomOrder; }
        
        public void AddNewTask(Task NewTask)
        {
            Array.Resize(ref TasksList, TasksList.Length + 1);
            this.IdLastTask++;
            NewTask.SetId(this.IdLastTask);
            TasksList[TasksList.Length - 1] = NewTask;
            return;
        }
        public bool RemoveTaskWithId(int Id)
        {
            for (int i = 0; i < TasksList.Length; i++)
                if (TasksList[i].GetId() == Id)
                {
                    for (int j = i; j < TasksList.Length - 1; j++)
                        TasksList[j] = TasksList[j + 1];
                    Array.Resize(ref TasksList, TasksList.Length - 1);
                    return true;
                }
            return false;
        }

        public override void WriteInFile(BinaryWriter Writer)
        {
            base.WriteInFile(Writer);
            Writer.Write(IdLastTask);
            Writer.Write(RandomOrder);
            Writer.Write(TasksList.Length);
            for (int i = 0; i < TasksList.Length; i++)
                TasksList[i].WriteInFile(Writer);
            return;
        }
    }
}
