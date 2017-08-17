using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_StudentID
{
    public class ScoreBoard
    {
        private static TextBox _finalScoreTextBox { get; set; }
        private static int _score {get; set;}
        private static TextBox _scoreTextBox { get; set; }
        private static int _time { get; set; }
        private static TextBox _timeTextBox { get; set; }
        

        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            init(scoreTextBox, timeTextBox, finalScoreTextBox);
            
        }

        public void init(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            _scoreTextBox = scoreTextBox;
            _timeTextBox = timeTextBox;
            _finalScoreTextBox = finalScoreTextBox;
        }

        public static void UpdateTime()
        {

            _scoreTextBox.Text = "" + _score;
            _timeTextBox.Text = "" + _time;

        }

        public static int score
        {

            get
            {
                return _score;
            }

            set
            {
                _score = value;
            }

        }

        public static int time
        {

            get
            {
                return _time;
            }

            set
            {
                _time = value;
            }
        }



    }// end of scoreboard
}
