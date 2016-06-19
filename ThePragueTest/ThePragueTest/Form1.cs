using System;
using System.Windows.Forms;
using ThePragueTestControls;

namespace ThePragueTest
{
    public partial class Form1 : Form
    {   // Vectorii care retin numerele
        private int[] bigNumbers;
        private int[] smallNumbers;
        private int[] answerNumbers;

        // Cele doua suprafete de lucru (stanga - numere, dreapta - raspunsuri)
        Panel numbersSurface = new Panel();
        Panel answersSurface = new Panel();

        // Timpul - initial avem 0 ore, 4 minute si 0 secunde
        TimeSpan time = new TimeSpan(0, 4, 0);

        // Secunda - tot un obiect de tip TimeSpan. Din time vom scadea
        // o secunda la fiecare apel al metodei Tick().
        TimeSpan second = new TimeSpan(0, 0, 1);

        // Vom stoca toate inputurile (casutele in care o sa scrie
        // userul intr-un vector de TextBox-uri
        TextBox[] inputs = new TextBox[101];

        // Prin acest label o sa vedem timpul
        Label timeView = new Label();

        public Form1()
        {
            InitializeComponent();

            CreateTestSurface();

            InitializeNumbers();

            InitializeNumbersSurface();
            InitializeAnswersSurface();

            CustomizeTimeView();

            CreateRightBarFunctionality();

            SetTimer();
        }

        private void CreateRightBarFunctionality()
        {
            CreateExitButton();
            CreateCheckButton();
        }

        private void CreateCheckButton()
        {
            Button checkButton = new Button();

            int buttonWidth = answersSurface.Width / 13;
            int buttonHeight = 2 * answersSurface.Height / 27 - 10;

            checkButton.AutoSize = false;
            checkButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            checkButton.Text = "Check";
            checkButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            checkButton.Location = new System.Drawing.Point(answersSurface.Width - buttonWidth - 4,
                                                            answersSurface.Height - 2 * buttonHeight);
            checkButton.Click += new EventHandler(check_Click);

            answersSurface.Controls.Add(checkButton);
        }

        /*  Aceasta este metoda butonului de check. Butonul check se activeaza atunci cand 
            userul termina de completat tabla de joc in mai putin de 4 minute. Aici verificam
            daca exista vreun input necompletat. Daca exista, nu facem nimic, altfel verificam
            rezultatele
            */
        private void check_Click(object sender, EventArgs e)
        {
            for(int i = 1; i<=100; i++)
                if (inputs[i].Text == "")
                    return;

            CheckResults();
        }

        /*
            Aici cream butonul de exit, il pozitionam in dreapta jos, ii dam dimensiunea
            si ii atribuim handler-ul de eveniment redat prin metoda exit_Click, dupa care
            il adaugam la answersSurface

            */
        private void CreateExitButton()
        {
            Button exitButton = new Button();

            int buttonWidth =  answersSurface.Width / 13;
            int buttonHeight = 2 * answersSurface.Height / 27 - 10;

            exitButton.AutoSize = false;
            exitButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            exitButton.Text = "Exit"; 
            exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            exitButton.Location = new System.Drawing.Point(answersSurface.Width - buttonWidth - 4,
                                                           answersSurface.Height - buttonHeight);
            exitButton.Click += new EventHandler(exit_Click);

            answersSurface.Controls.Add(exitButton);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
            Aici setam modul in care timpul o sa apara pe ecran. El o sa fie
            pozitionat in dreapta sus, evident pe panoul de raspunsuri pentru ca
            nu avem unde in alta parte sa il pozitionam. 

            Prin Dock ii spunem sa fie situat in partea de sus.
            */
        private void CustomizeTimeView()
        {
            answersSurface.Controls.Add(timeView);

            timeView.Dock = DockStyle.Top;
            timeView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            timeView.AutoSize = false;

            timeView.Font = new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Bold);
        }


        /*
            Un timer este un obiect special, legat strict de Windows Forms, care
            are un rol foarte simplu: apeleaza o metoda la un interval de timp specificat.

            In metoda de mai jos se realizeaza configurarea acestuia. Adica ii spunem
            ce metoda sa apeleze la intervalul default de 1000 de ms ( = 1 secunda), in 
            cazul nostru metoda se numeste timer_Tick, si il pornim prin apelul metodei
            Start().

            Evident, ii putem seta intervalul la care sa apeleze respectiva metoda, asa
            cum se vede in linia comentata

            */
        private void SetTimer()
        {
            timer.Tick += new EventHandler(timer_Tick);
            // Exemplu: timer.Interval = 500;
            timer.Start();
        }



        /* Aceasta este metoda apelata de catre timer la fiecare secunda

           Ce se realizeaza aici: se scade din timpul total o secunda, dupa
           care se afiseaza timpul nou rezultat. Daca am ajuns la timp 0, atunci
           oprim timer-ul si verificam rezultatele dupa care inchidem aplicatia.

        */
        private void timer_Tick(object sender, EventArgs e)
        {
            time = time.Subtract(second);
            timeView.Text = "Time left: " + time.ToString().Split(':')[1] + ":" +
                            time.ToString().Split(':')[2];

            if (time.Minutes == 0 && time.Seconds == 0)
            {
                timer.Stop();
                CheckResults();
                Application.Exit();
            }
        }

        /*
            Aici verificam rezultatele. Atunci cand timpul a expirat sau cand s-a apasat
            butonul de "Check", se face call catre aceasta functie. 
            Este o verificare simpla, cu contorizarea raspunsurilor corecte.
         */

        private void CheckResults()
        {
            int points = 0;

            for(int i = 0; i<100; i++)
            {
                if(inputs[i+1].Text.Equals(smallNumbers[Array.IndexOf(bigNumbers, i+1)].ToString()) == true)
                {
                    points += 1;
                }
            }

            MessageBox.Show("You have won " + points.ToString() + " points!");
        }

        /* Ideea este similara celei de la functia InitializeNumbersSurface, numai ca
           panoul este impartit un pic diferit: un answer control este format dintr-un
           label in care ne apare numarul al carui corespundent il cautam, si dintr-un
           textBox in care introducem respectivul numar. 
           
           Pentru o impartire exacta a panoului, vom alege ca unitate atomica de divizare
           jumatatea unui answer control, adica dimensiunea unui label dintr-un answer 
           control, care este egala cu dimensiunea unui textBox din acelasi control.

            Astfel, latimea panoului o vom imparti la 13, pentru ca avem 4 randuri de controale,
            fiecare avand 2 atomi, deci 8 atomi in total. Intre aceste 4 randuri, mai avem 3 atomi
            (zona libera), deci 11 in total, si inca 2 atomi la capete, de unde rezulta acel 13.

            Pe inaltime, fiecare coloana are 25 de controale, adica 25 de inaltimi de atomi la care
            adaugam 2 latimi la capete (adica sus si jos) de unde rezulta 27 de atomi.
        
        */
        private void InitializeAnswersSurface()
        {
            int verticalOffset = answersSurface.Height / 27;
            int horizontalOffset = answersSurface.Width / 13;

            // Parcurgerea o facem normal, numai ca iteram peste controalele noastre,
            // nu ne intereseaza zonele libere dintre controale
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    AnswersControl answerControl = new AnswersControl(

                        answerNumbers[4 * i + j],

                        2 * horizontalOffset,

                        verticalOffset

                        );

                    inputs[answerNumbers[4 * i + j]] = answerControl.NumberInput;

                    answerControl.Location = new System.Drawing.Point(

                        (j + 1) * horizontalOffset + j * answerControl.Width,
                        (i + 1) * (answerControl.Height + 1)

                        );

                    answersSurface.Controls.Add(answerControl);
                }
            }
        }

        /*
            Aici initializam zona de numere, adica in panoul numbersSurface trebuie sa adaugam
            controalele noastre denumite Numbers. Cu alte cuvinte, vom imparti acest panou intr-o
            matrice de 10 x 10 si vom pozitiona fiecare control de tip Numbers la locatia lui exacta,
            atribuindu-i acelasi timp si cele doua numere (big si small).

        */

        private void InitializeNumbersSurface()
        {
            int numberControlWidth = numbersSurface.Width / 10;
            int numberControlHeight = numbersSurface.Height / 10;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    // Aici construim efectiv obiectul, pasandu-i ca parametrii
                    // in constructor dimensiunea lui si cele doua numere.
                    Numbers numberControl = new Numbers(

                        numberControlWidth + 15,
                        numberControlHeight + 3,

                        bigNumbers[10 * i + j],
                        smallNumbers[10 * i + j]

                        );

                    // Setam locatia controlului. Acel -14 este o ajustare a pozitiei
                    numberControl.Location = new System.Drawing.Point(

                        j * numberControlWidth - 14,
                        i * numberControlHeight

                        );

                    // Adaugam controlul la panoul de numere
                    numbersSurface.Controls.Add(numberControl);
                }
            }
        }

        /* Aici e destul de clar ce facem. Numerele nu le putem genera
           random pentru ca testul in sine nu ne permite acest lucru, 
           din moment ce sunt unele numere pozitionate de 2 ori
        */

        private void InitializeNumbers()
        {
            bigNumbers = new int[]
            {
                73,18,7,4,97,33,31,69,49,35,23,8,79,96,92,40,78,22,65,1,

                19,24,72,51,62,81,9,91,17,61,30,41,98,80,66,59,55,95,58,6,

                54,21,45,84,99,75,56,10,67,38,3,93,2,20,44,77,82,36,32,88,

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

        /* In aceasta metoda o sa impartim ecranul in cele 2 parti, dupa care vom
           initializa cele doua Panel-uri: numbersSurface si answersSurface si le
           vom adauga la fereastra principala (adica la this).
        */

        public void CreateTestSurface()
        {
            // Setam lungimea si latimea panoului de numere (cel din stanga). Pozitia
            // lui este direct 0,0, deci nu trebuie sa o ajustam.
            // Functia Screen.FromControl(this) obtine dimensiunile reale ale ecranului
            numbersSurface.Width = Screen.FromControl(this).Bounds.Width / 2;
            numbersSurface.Height = Screen.FromControl(this).Bounds.Height;

            // Panoul de raspunsuri trebuie pozitionat la (jumatateaea ecranului, 0)
            answersSurface.Location = new System.Drawing.Point(
                Screen.FromControl(this).Bounds.Width / 2, 0);

            answersSurface.Width = Screen.FromControl(this).Bounds.Width / 2 + 1;
            answersSurface.Height = Screen.FromControl(this).Bounds.Height;

            // Setam marginea panourilor la FixedSingle, pentru a o ascunde.
            answersSurface.BorderStyle = BorderStyle.FixedSingle;
            numbersSurface.BorderStyle = BorderStyle.FixedSingle;

            // Adaugam cele doua panouri la fereastra principala (la this), dar
            // nu mai punem this pentru ca e redundant.
            Controls.Add(answersSurface);
            Controls.Add(numbersSurface);
        }
    }
}
