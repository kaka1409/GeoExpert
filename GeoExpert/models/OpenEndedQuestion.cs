using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoExpert.models
{
    class OpenEndedQuestion : Question
    {

        public OpenEndedQuestion()
        {
            Type = "Open-ended";
        }
        public override bool CheckAnswer()
        {
            return true;
        }

        public override string getAnswer()
        {
            return "";
        }
    }
}
