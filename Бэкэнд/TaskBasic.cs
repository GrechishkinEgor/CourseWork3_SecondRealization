using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Бэкэнд
{
    public abstract class TaskBasic
    {
        protected String Question = "";
        protected String[] Answers = {};
        protected bool[] IsRightAnswer = {};
        protected int MaxMark = 0;
        protected int ExecutionTime = 0;
        protected int Id;
        protected bool IsWithOneRightAnswer = false;

        protected virtual void ReadFromFile(BinaryReader Reader)
        {
            Question = Reader.ReadString();
            Array.Resize<String>(ref Answers, Reader.ReadInt32());
            for (int i = 0; i < Answers.Length; i++)
                Answers[i] = Reader.ReadString();
            Array.Resize<bool>(ref IsRightAnswer, Answers.Length);
            for (int i = 0; i < IsRightAnswer.Length; i++)
                IsRightAnswer[i] = Reader.ReadBoolean();
            MaxMark = Reader.ReadInt32();
            ExecutionTime = Reader.ReadInt32();
            Id = Reader.ReadInt32();
            IsWithOneRightAnswer = Reader.ReadBoolean();
        }

        public TaskBasic() { }
        public TaskBasic(BinaryReader Reader) { ReadFromFile(Reader); }

        public String GetQuestion() { return Question; }
        public String[] GetAnswers() { return Answers; }
        public int GetMaxMark() { return MaxMark; }
        public int GetExecutionTime() { return ExecutionTime; }
        public int GetId() { return Id; }
        public bool[] GetNumsOfRightAnswers() { return IsRightAnswer; }
        public bool IsTaskWithOneRightAnswer() { return IsWithOneRightAnswer; }

        virtual public void WriteInFile(BinaryWriter Writer)
        {
            Writer.Write(Question);
            Writer.Write(Answers.Length);
            for (int i = 0; i < Answers.Length; i++)
                Writer.Write(Answers[i]);
            for (int i = 0; i < IsRightAnswer.Length; i++)
                Writer.Write(IsRightAnswer[i]);
            Writer.Write(MaxMark);
            Writer.Write(ExecutionTime);
            Writer.Write(Id);
            Writer.Write(IsWithOneRightAnswer);
            return;
        }
    }
}
