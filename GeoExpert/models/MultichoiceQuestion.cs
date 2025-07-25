using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoExpert.models
{
    class MultiChoiceQuestion : Question
    {
        public MultiChoiceQuestion()
        {
            Type = "Multiple choices";
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
