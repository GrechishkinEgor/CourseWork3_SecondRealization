using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Бэкэнд
{
    public class Task : TaskBasic
    {
        protected bool AnswersRandomOrder = false;
        protected override void ReadFromFile(BinaryReader Reader) 
        {
            base.ReadFromFile(Reader);
            AnswersRandomOrder = Reader.ReadBoolean();
        }

        public Task() : base() { }
        public Task(BinaryReader Reader) : base(Reader) { }

        public bool IsAnswersRandomOrder() { return AnswersRandomOrder; }
        public void SetQuestion(String Question) { this.Question = Question; }
        public void SetMaxMark(int Mark) { this.MaxMark = Mark; }
        public void SetExecutionTime(int ExecutionTime) { this.ExecutionTime = ExecutionTime; } 
        public void SetId(int Id) { this.Id = Id; } 
        public void SetAnswersRandomOrder(bool Random) { this.AnswersRandomOrder = Random; }
        public void AddNewAnswer(String Answer, bool IsRight)
        {
            Array.Resize<String>(ref this.Answers, this.Answers.Length + 1);
            this.Answers[this.Answers.Length - 1] = Answer;
            Array.Resize<bool>(ref this.IsRightAnswer, this.IsRightAnswer.Length + 1);
            this.IsRightAnswer[this.IsRightAnswer.Length - 1] = IsRight;
        }
        //Нет метода SetFlagOfOneRightAnswer
        public void ClearAnswers()
        {
            Array.Resize<String>(ref this.Answers, 0);
            Array.Resize<bool>(ref this.IsRightAnswer, 0);
        }
        public void SetFlagOfOneRightAnswer(bool IsOneRightAnswer) { this.IsWithOneRightAnswer = IsOneRightAnswer; }

        public override void WriteInFile(BinaryWriter Writer)
        {
            base.WriteInFile(Writer);
            Writer.Write(AnswersRandomOrder);
        }
    }
}
