using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoExpert.models
{
    class TFQuestion : Question
    {
        public TFQuestion()
        {
            Type = "True/False";
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
