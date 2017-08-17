using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_StudentID
{
    class ScoreBoard
    {
        private TextBox _finalScoreTextBox { get; set; }
        private int _score {get; set;}
        private TextBox _scoreTextBox { get; set; }
        private int _time { get; set; }
        private TextBox _timeTextBox { get; set; }
        

        ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            _scoreTextBox = scoreTextBox;
            _timeTextBox = timeTextBox;
            _finalScoreTextBox = finalScoreTextBox;
        }

        public void UpdateTime()
        {

            _scoreTextBox.Text = "" + _score;
            _timeTextBox.Text = "" + _time;

        }

        public int score
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

        public int time
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
