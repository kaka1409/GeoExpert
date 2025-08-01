using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoExpert.models
{
    class MultiChoiceQuestion : Question
    {
        private QuestionType type = QuestionType.MultipleChoice;
        public QuestionType Type
        {
            get { return type; }
            set { type = value; }
        }
        public MultiChoiceQuestion()
        {

        }

        public override bool CheckAnswer()
        {
            return true;
        }

    }
}
