using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Бэкэнд
{
    public class ReadyTask : TaskBasic
    {
        protected bool[] UserAnswer = {};
        protected int LastUserMark = 0;

        protected override void ReadFromFile(BinaryReader Reader)
        {
            base.ReadFromFile(Reader);
            Array.Resize<bool>(ref UserAnswer, Answers.Length);
            for (int i = 0; i < Answers.Length; i++)
                UserAnswer[i] = Reader.ReadBoolean();
            LastUserMark = Reader.ReadInt32();
        }

        public ReadyTask(Task SomeTask)
        {
            this.Question = String.Copy(SomeTask.GetQuestion());
            String[] SomeTaskAnswers = SomeTask.GetAnswers();
            Array.Resize(ref Answers, SomeTaskAnswers.Length);
            bool[] SomeTaskRightAnswers = SomeTask.GetNumsOfRightAnswers();
            Array.Resize(ref IsRightAnswer, SomeTaskAnswers.Length);
            if (SomeTask.IsAnswersRandomOrder())
            {
                bool[] UsedAnswers = {};
                Array.Resize(ref UsedAnswers, SomeTaskAnswers.Length);
                for (int i = 0; i < UsedAnswers.Length; i++)
                    UsedAnswers[i] = false;
                Random Randomizer = new Random();
                for (int i = 0; i < Answers.Length; i++)
                {
                    int RandIndex = 0;
                    do
                        RandIndex = Randomizer.Next(SomeTaskAnswers.Length);
                    while (UsedAnswers[RandIndex]);
                    UsedAnswers[RandIndex] = true;
                    Answers[i] = String.Copy(SomeTaskAnswers[RandIndex]);
                    IsRightAnswer[i] = SomeTaskRightAnswers[RandIndex];
                }
            }
            else
                for (int i = 0; i < Answers.Length; i++)
                {
                    Answers[i] = String.Copy(SomeTaskAnswers[i]);
                    IsRightAnswer[i] = SomeTaskRightAnswers[i];
                }


            this.ExecutionTime = SomeTask.GetExecutionTime();
            this.MaxMark = SomeTask.GetMaxMark();
            this.Id = SomeTask.GetId();
            this.IsWithOneRightAnswer = SomeTask.IsTaskWithOneRightAnswer();
            Array.Resize(ref UserAnswer, SomeTaskAnswers.Length);
            LastUserMark = 0;
            return;
        }

        public ReadyTask(BinaryReader Reader) : base(Reader) { }

        public int GetLastUserMark() { return LastUserMark; }
        public bool[] GetUserAnswer() { return UserAnswer; }

        public int CheckAnswer(bool[] UserAnswer)
        {
            for (int i = 0; i < this.UserAnswer.Length; i++)
                this.UserAnswer[i] = UserAnswer[i];
            if (IsWithOneRightAnswer)
            {
                for (int i = 0; i < this.Answers.Length; i++)
                    if (this.IsRightAnswer[i])
                    {
                        if (UserAnswer[i])
                            LastUserMark = MaxMark;
                        else
                            LastUserMark = 0;
                        break;
                    }
            }
            else
            {
                int RightAnswersCount = 0;
                for (int i = 0; i < this.UserAnswer.Length; i++)
                    if (this.UserAnswer[i] == this.IsRightAnswer[i])
                        RightAnswersCount++;
                LastUserMark = (int)((double)RightAnswersCount / this.Answers.Length * MaxMark);
            }

            return LastUserMark;
        }

        public override void WriteInFile(BinaryWriter Writer)
        {
            base.WriteInFile(Writer);
            for (int i = 0; i < Answers.Length; i++)
                Writer.Write(UserAnswer[i]);
            Writer.Write(LastUserMark);
        }
    }
}
