using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    internal class Question
    {
        public string Text { get; private set; }
        public string[] Answers { get; private set; }
        public int RightAnswer { get; private set; }
        public int Level { get; private set; }
        public Question(string[] s)
        {
            Text = s[0];
            Answers = new string[4];
            for (int i = 0; i < 4; i++)
                Answers[i] = s[i + 1];
            if (!int.TryParse(s[5], out int newRightAnswer) || !int.TryParse(s[6], out int newLevel))
            {
                RightAnswer = 0;
                Level = -1;
            }
            else
            {
                RightAnswer = newRightAnswer;
                Level = newLevel;
            }
        }
    }
}
