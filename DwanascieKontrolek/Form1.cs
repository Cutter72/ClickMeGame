using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace DwanascieKontrolek
{
    public partial class ClickMeGame : Form
    {
        //Pola
        private const int minX = 0;
        private const int minY = 12;
        private int gameTimeMillis;
        private int score;
        private int clickCounter;
        private int sizePoints;
        private int colorPoints;
        private string playerName;
        private Point newLocation;
        private Size newSize;
        private Random random;
        private System.Windows.Forms.Timer timer;

        //Konstruktor w którym inicjalizujemy niezainicjalizowane zmienne
        public ClickMeGame()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            gameTimeMillis = 10000;
            sizePoints = 3;
            colorPoints = 2;
            newSize = new Size(40, 40);
            random = new Random();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += TimerTickAction;
            resetClickMeButtonLocation();
        }

        //Wyśrodkowanie przycisku
        private void resetClickMeButtonLocation()
        {
            newLocation.X = gameArena.Size.Width / 2 - clickMe.Size.Width / 2;
            newLocation.Y = gameArena.Size.Height / 2 - clickMe.Size.Height / 2;
            clickMe.Location = newLocation;
        }

        /* Zmiana położenia przycisku w zależności od rozmiaru tak aby
           nie wyszedł poza obszar Game Arena */
        private void changeClickMeLocation()
        {
            setClickMeButtonRandomLocation(gameArena.Size.Width - clickMe.Size.Width);
        }

        //Losowanie współrzędnych przycisku i ustawienie ich
        private void setClickMeButtonRandomLocation(int maxValue)
        {
            newLocation.X = random.Next(minX, maxValue);
            newLocation.Y = random.Next(minY, maxValue);
            clickMe.Location = newLocation;
        }

        //Metoda wywoływana przez Timer co ustawiony interwał czasowy
        private void TimerTickAction(object sender, EventArgs e)
        {
            if (gameTimeMillis > 0)
            {
                gameTimeMillis -= 10;
                progressBarTimer.Value -= 1;
                labelTimer.Text = $"{gameTimeMillis / 1000d} s";
            }
            else
            {
                timer.Stop();
                enableSettingsControls();
                clickMe.Text = "Reset";
                highScoresTable.AppendText($"{score} points, " +
                    $"{clickCounter} clicks - {playerName}\n");
                MessageBox.Show($"Well done {playerName}!\nYour score is {score}" +
                    $" points with {clickCounter} clicks!", "Time has run out!");
            }
        }

        //Zmiana koloru na żółty (domyślny)
        private void radioBtnClickMeColorYellow_CheckedChanged(object sender, EventArgs e)
        {
            colorPoints = 2;
            clickMe.BackColor = Color.Yellow;
        }
        //Zmiana koloru na normalny (szary)
        private void radioBtnClickMeColorNormal_CheckedChanged(object sender, EventArgs e)
        {
            colorPoints = 3;
            clickMe.BackColor = Color.FromArgb(240, 240, 240);
        }

        //Obsługa naciśnięcia klawisza Enter w polu textowym
        private void inputPlayerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                playerName = inputPlayerName.Text;
            }
        }

        //Obsługa zmiany rozmiaru
        private void trackBarClickMeSizeChange_Scroll(object sender, EventArgs e)
        {
            switch (trackBarClickMeSizeChange.Value)
            {
                case 0:
                    {
                        setNewClickMeButtonSize(80, 1);
                        break;
                    }
                case 1:
                    {
                        setNewClickMeButtonSize(60, 2);
                        break;
                    }
                case 2:
                    {
                        setNewClickMeButtonSize(40, 3);
                        break;
                    }
                case 3:
                    {
                        setNewClickMeButtonSize(20, 4);
                        break;
                    }
            }
        }
        //Metoda zmiany rozmiaru
        private void setNewClickMeButtonSize(int size, int pointsForSize)
        {
            newSize.Width = size;
            newSize.Height = size;
            clickMe.Size = newSize;
            sizePoints = pointsForSize;
            labelClickMeSizeChange.Text = $"'Click me!' button size (+{sizePoints}p):";
            resetClickMeButtonLocation();
        }

        //Obsługa przycisku Click me!
        private void clickMe_MouseClick(object sender, MouseEventArgs e)
        {
            if (clickMe.Text.Equals("Start"))
            {
                if (inputPlayerName.Text == null)
                {
                    MessageBox.Show("Please enter your name in Settings!");
                }
                else if (inputPlayerName.Text.Equals(""))
                {
                    MessageBox.Show("Please enter your name in Settings!");
                }
                else
                {
                    //Akcja startująca grę gdy imie gracza zostało wprowadzone
                    startGame();
                }
            }
            else if (clickMe.Text.Equals("Click me!"))
            {
                //Akcja podczas trwania gry
                updateScoreAndMoveToRandomLocation();
            }
            else
            {
                //Akcja po wyczerpaniu limitu czasowego
                resetGame();
            }
        }

        //Akcja przycisku podczas trwania gry
        private void updateScoreAndMoveToRandomLocation()
        {
            clickCounter++;
            score = clickCounter * (colorPoints + sizePoints);
            scoreValue.Text = $"{score} p";
            changeClickMeLocation();
        }

        //Akcja przycisku startująca grę gdy imie gracza zostało wprowadzone
        private void startGame()
        {
            clickMe.Text = "Click me!";
            playerName = inputPlayerName.Text;
            disableSettingsControls();
            changeClickMeLocation();
            timer.Start();
        }

        private void disableSettingsControls()
        {
            inputPlayerName.Enabled = false;
            trackBarClickMeSizeChange.Enabled = false;
            radioBtnClickMeColorNormal.Enabled = false;
            radioBtnClickMeColorYellow.Enabled = false;
        }

        private void enableSettingsControls()
        {
            inputPlayerName.Enabled = true;
            trackBarClickMeSizeChange.Enabled = true;
            radioBtnClickMeColorNormal.Enabled = true;
            radioBtnClickMeColorYellow.Enabled = true;
        }

        //Zresetowanie parametrów gry do stanu początkowego
        private void resetGame()
        {
            clickMe.Text = "Start";
            score = 0;
            clickCounter = 0;
            gameTimeMillis = 10000;
            progressBarTimer.Value = 1000;
            labelTimer.Text = $"{gameTimeMillis / 1000d} s";
            scoreValue.Text = $"{score} p";
            resetClickMeButtonLocation();
        }
    }
}
