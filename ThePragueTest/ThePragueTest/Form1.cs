using System;
using System.Windows.Forms;
using ThePragueTestControls;

namespace ThePragueTest
{
    public partial class Form1 : Form
    {
        private int[] bigNumbers;
        private int[] smallNumbers;
        private int[] answerNumbers;

        Panel numbersSurface = new Panel();
        Panel answersSurface = new Panel();

        TimeSpan time = new TimeSpan(0, 4, 0);
        TimeSpan second = new TimeSpan(0, 0, 1);

        Label timeView = new Label();

        public Form1()
        {
            InitializeComponent();

            CreateTestSurface();

            InitializeNumbers();

            InitializeNumbersSurface();
            InitializeAnswersSurface();

            CustomizeTimeView();

            SetTimer();
        }

        private void CustomizeTimeView()
        {
            answersSurface.Controls.Add(timeView);

            timeView.Dock = DockStyle.Top;
            timeView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            timeView.AutoSize = false;

            timeView.Font = new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Bold);
        }

        private void SetTimer()
        {
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time = time.Subtract(second);
            timeView.Text = time.ToString().Split(':')[1] + ":" +
                            time.ToString().Split(':')[2];
        }

        private void InitializeAnswersSurface()
        {
            int verticalOffset = answersSurface.Height / 27;
            int horizontalOffset = answersSurface.Width / 13;

            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    AnswersControl answerControl = new AnswersControl(

                        answerNumbers[4 * i + j],

                        2 * horizontalOffset,

                        verticalOffset

                        );

                    answerControl.Location = new System.Drawing.Point(

                        (j + 1) * horizontalOffset + j * answerControl.Width,
                        (i + 1) * (answerControl.Height + 1)

                        );

                    answersSurface.Controls.Add(answerControl);
                }
            }
        }

        private void InitializeNumbersSurface()
        {
            int numberControlWidth = numbersSurface.Width / 10;
            int numberControlHeight = numbersSurface.Height / 10;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Numbers numberControl = new Numbers(

                        numberControlWidth + 15,
                        numberControlHeight + 3,

                        bigNumbers[10 * i + j],
                        smallNumbers[10 * i + j]

                        );

                    numberControl.Location = new System.Drawing.Point(

                        j * numberControlWidth - 14,
                        i * numberControlHeight // -2

                        );

                    numbersSurface.Controls.Add(numberControl);
                }
            }
        }

        private void InitializeNumbers()
        {
            bigNumbers = new int[]
            {
                73,18,7,4,97,33,31,69,49,35,23,8,79,96,92,40,78,22,65,1,

                19,24,72,51,62,81,9,91,17,61,30,41,98,80,66,59,55,95,58,6,

                54,21,45,84,99,75,56,10,67,38,3,93,2,30,44,77,82,36,32,88,

                42,94,50,76,90,71,53,5,27,13,57,63,48,68,39,29,16,52,60,89,

                47,64,28,83,87,86,11,85,34,26,37,46,100,15,43,12,74,14,70,25
            };

            smallNumbers = new int[]
            {
                97,39,13,66,68,62,22,48,52,92,38,55,43,30,73,19,28,4,88,84,

                87,18,12,75,25,35,97,31,89,50,17,8,46,95,2,20,80,67,11,83,

                32,40,9,81,49,69,63,41,29,76,64,14,98,71,56,5,1,6,47,27,

                3,65,69,61,51,70,33,86,72,59,79,45,54,91,85,74,99,82,26,36,

                34,58,42,10,57,37,100,21,23,44,78,94,24,77,93,16,7,90,53,15
            };

            answerNumbers = new int[]
            {
                75,34,46,100,20,78,56,44,79,3,7,14,26,18,4,36,2,81,17,8,

                11,62,12,33,74,71,61,82,21,45,9,31,57,13,38,49,19,63,28,43,

                83,1,89,77,6,73,94,84,39,76,95,54,52,5,29,72,27,99,37,60,

                47,15,85,35,25,90,55,48,64,67,51,65,96,10,22,98,58,66,30,41,

                42,70,53,80,68,69,23,86,88,92,32,93,59,87,40,24,50,91,97,16
            };
        }

        public void CreateTestSurface()
        {
            numbersSurface.Width = Screen.FromControl(this).Bounds.Width / 2;
            numbersSurface.Height = Screen.FromControl(this).Bounds.Height;

            answersSurface.Location = new System.Drawing.Point(
                Screen.FromControl(this).Bounds.Width / 2, 0);

            answersSurface.Width = Screen.FromControl(this).Bounds.Width / 2 + 1;
            answersSurface.Height = Screen.FromControl(this).Bounds.Height;

            answersSurface.BorderStyle = BorderStyle.FixedSingle;
            numbersSurface.BorderStyle = BorderStyle.FixedSingle;

            Controls.Add(answersSurface);
            Controls.Add(numbersSurface);
        }
    }
}
