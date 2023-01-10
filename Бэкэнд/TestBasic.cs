using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Бэкэнд
{
    public class TestBasic
    {
        protected String TestName = "";
        protected int Id = 0;

        protected virtual void ReadFromFile(BinaryReader Reader)
        {
            TestName = Reader.ReadString();
            Id = Reader.ReadInt32();
            return;
        }

        public TestBasic() { }
        public TestBasic(BinaryReader Reader) { ReadFromFile(Reader); }

        public String GetTestName() { return TestName; }
        public int GetId() { return Id; }

        public virtual void WriteInFile(BinaryWriter Writer)
        {
            Writer.Write(TestName);
            Writer.Write(Id);
        }
    }
}
