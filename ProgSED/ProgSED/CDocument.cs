using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSED
{
    class CDocument
    {
        protected string Name;
        protected string Status;
        protected string Type;
        protected string Author_1;
        protected string Author_2;
        protected string Admin;
        protected string Number;
        protected string Comments;
        protected double Summa;
        protected DateTime Date_Start;
        protected DateTime Date_Finish;

        CDocument()
        {
            Name = Status = Type = Author_1 = Author_2 = Admin = Number = Comments = "";
            Summa = 0.0;
            var Date_Start = new DateTime (1,1,1900);
            var Date_Finish = new DateTime(1, 1, 9999);
        }
        public void Create()
        {

        }
        public void Edit()
        {

        }
        public void Remove()
        {

        }
        public void Watch()
        {

        }
    }
}
