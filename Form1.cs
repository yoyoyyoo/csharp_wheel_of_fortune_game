using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//COMP62 Assignment2, lucky wheel spelling game by Yanan Liu
namespace Comp60Ass2
{

    public partial class Form1 : Form
    {
        Player playerOne;
        Player playerTwo;
        Game gameOne;
        char[] wordArray; 
        int length;
        string hiddenString="";
        // playerRecord[], scoreRecord[], and ctr are for top10 listing function
        string[] playerRecord = new string[100]; 
        int[] scoreRecord = new int[100];
        int ctr = 0;


        public Form1()
        {
            InitializeComponent();
            
        }

        //start button function to initialize the game
        private void startGame_Click(object sender, EventArgs e)
        {
            
            initialGame();
           
        }

        //initial the game 
        //- input new player's name
        //- generate new words, score

        private void initialGame()
        {
            playerOne = new Player(playerOneNameInput.Text);
            playerTwo = new Player(playerTwoNameInput.Text);

            gameOne = new Game();
            gameOne.PlayerNo++;

            playerOneNameInput.Text = playerOne.Name;
            playerTwoNameInput.Text = playerTwo.Name;

            wordArray = gameOne.TargetWords.ToCharArray();
            length = wordArray.Length;


            for (int index = 0; index < length; index++)
            {
                hiddenString = hiddenString.Insert(index, "-");
            }

            showTargetGuess.Text = hiddenString;

            showPlayerOneName.Text = playerOne.Name;
            showPlayerTwoName.Text = playerTwo.Name;

            gameOne.generateScore();
           
            displayScore(gameOne.CurrentScore);

            if (gameOne.PlayerNo % 2 == 1)
                MessageBox.Show(playerOne.Name + "'s turn. \n\n Please enter a letter and press OK to continue.", "", MessageBoxButtons.OK);
            else
                MessageBox.Show(playerTwo.Name + "'s turn. \n\n Please enter a letter and press OK to continue.", "", MessageBoxButtons.OK);
        }

        //function to run the wheel and land on the assigned value points' picture.
        private void displayScore(int currentScore)
        {
            for (int times = 0; times < 1; times++)
            {
                wheel.Image = Comp60Ass2.Properties.Resources._50;
                wheel.Refresh();
                Thread.Sleep(100);
                wheel.Image = Comp60Ass2.Properties.Resources._30;
                wheel.Refresh();
                Thread.Sleep(100);
                wheel.Image = Comp60Ass2.Properties.Resources._20;
                wheel.Refresh();
                Thread.Sleep(100);
                wheel.Image = Comp60Ass2.Properties.Resources._10;
                wheel.Refresh();
                Thread.Sleep(100);

            }

         switch (currentScore)
            {
                case 50:
                    wheel.Image = Comp60Ass2.Properties.Resources._50;
                    break;
                case 30:
                    wheel.Image = Comp60Ass2.Properties.Resources._30;
                    break;
                case 20:
                    wheel.Image = Comp60Ass2.Properties.Resources._20;
                    break;
                default:
                    wheel.Image = Comp60Ass2.Properties.Resources._10;
                    break;
            }
        }

        //submit a new guess button to verify if the input guess is correct or not and add corresponding scores to each player
        private void newGuess_Click(object sender, EventArgs e)
        {
            int[] position = new int[200];
            char[] hiddenChar = showTargetGuess.Text.ToCharArray();
            
            //check if there is a matched letter
            for (int index = 0; index < length; index++)
            {
               if (maskedGuessInput.Text == wordArray[index] + "")
                  hiddenChar[index] = Char.Parse(maskedGuessInput.Text);
            }

            maskedGuessInput.Text = "";

            //generate a new string to show in the target guess textbox
            showTargetGuess.Text = new string(hiddenChar);

            //check if there is a change to the hiddenstring, no change means the user didn't get any right letter
            int wrong = showTargetGuess.Text.CompareTo(hiddenString);
            if (wrong == 0)
            {
              if (gameOne.PlayerNo % 2 == 1)
                {
                    MessageBox.Show("Sorry, not the right one! Try another one next time. \n\n\n" + 
                                   playerTwo.Name + "'s turn. Please enter a letter and press OK to continue.");
                    playerOne.NoLoses++;
                }
                else
                {
                    playerTwo.NoLoses++;
                    MessageBox.Show("Sorry, not the right one! Try another one next time. \n\n\n" +
                        playerOne.Name + "'s turn. Please enter a letter and press OK to continue.");
                }
            }
            else //get right letter, player will get the score added up
            {
                if (gameOne.PlayerNo % 2 == 1)
                {
                   playerOne.Score += gameOne.CurrentScore;
                   playerOne.NoWins++;
                   MessageBox.Show("Bingo! You get " + gameOne.CurrentScore + "! \n\n\n" +
                                     playerTwo.Name + "'s turn. Please enter a letter and press OK to continue.");
                }
                else
                {
                   playerTwo.Score += gameOne.CurrentScore;
                   playerTwo.NoWins++;
                   MessageBox.Show("Bingo! You get " + gameOne.CurrentScore + "! \n\n\n" +
                                     playerOne.Name + "'s turn. Please enter a letter and press OK to continue.");
                }
            }

            //show each player's score
            playerOneScore.Text = playerOne.Score + "";
            playerTwoScore.Text = playerTwo.Score + "";

            //check if the target word is correctly guessed. 
            //Yes - ask if the player wants to start a new one, but keep the two players' name; 
            //No - reset everything. 
            int rightAnswer = gameOne.TargetWords.CompareTo(showTargetGuess.Text);
            if (rightAnswer == 0) 
            {
                if (playerOne.Score > playerTwo.Score)
                   MessageBox.Show(playerOne.Name + " win! Congratulations!");
                else
                {
                  if (playerOne.Score == playerTwo.Score)
                     MessageBox.Show(playerOne.Name + " and " + playerTwo.Name + ", you are tiled!");
                  else
                     MessageBox.Show(playerTwo.Name + " win! Congratulations!");
                }

                //load the record and call the ranking fuction to show the top10 players
                ctr = LoadRecord(playerRecord, scoreRecord, ctr, playerOne.Name, playerOne.Score);
                ctr = LoadRecord(playerRecord, scoreRecord, ctr, playerTwo.Name, playerTwo.Score);
                RankingMsg(playerRecord, scoreRecord, ctr);

                //check if the player wants to play another game or not
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Would like to have another game? ", "", MessageBoxButtons.YesNo);
                Reset();

                if (dialogResult == DialogResult.Yes)
                { 
                    playerOneNameInput.Text = playerOne.Name;
                    playerTwoNameInput.Text = playerTwo.Name;
                    initialGame();
                }  
                 
            }
            else
            {
                gameOne.generateScore();
                displayScore(gameOne.CurrentScore);
                gameOne.PlayerNo++; 
            }
            
            hiddenString = showTargetGuess.Text;
        }

        //function to load each players' record to the array for ranking top10
        private int LoadRecord(string[] playerRecord, int[] scoreRecord, int ctr, string playerName, int score)
        {
            int pos = 0;
            if (ctr == 0)
            {
                playerRecord[ctr] = playerName;
                scoreRecord[ctr] = score;
            }
            else
            {
                for (; pos < ctr; pos++)
                {
                    if (scoreRecord[pos] < score)
                        break;
                }

                for (int index = ctr; index > pos; index--)
                {
                    scoreRecord[index] = scoreRecord[index - 1];
                    playerRecord[index] = playerRecord[index - 1];
                }

                scoreRecord[pos] = score;
                playerRecord[pos] = playerName;
            }
            ctr++;
            return ctr;
        }

        // function to show the top10 players' record in textbox
        private void RankingMsg(string[] playerRecord, int[] scoreRecord, int ctr)
        {
            string[] rankingMsg = new string[10];
            string word = "";

            if (ctr > 10)
                ctr = 10;

            for (int index = 0; index < ctr; index++)
            {
                rankingMsg[index] = "No. " + (index + 1) + " - " + playerRecord[index] + ".     Score - " + scoreRecord[index] + "\r\n";
                word = String.Concat(word, ' ', rankingMsg[index]);

            }

            rankingPrint.Text = word;
        }


        // reset button to cancel the current game and start a new one
        private void reset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure to have another game? ", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) 
               Reset();
        }

        // function to reset 
        private void Reset()
        {
           
            playerOneNameInput.Text = "";
            playerTwoNameInput.Text = "";
            showPlayerOneName.Text = "";
            showPlayerTwoName.Text = "";
            showTargetGuess.Text = "";
            playerOneScore.Text = "";
            playerTwoScore.Text = "";
            maskedGuessInput.Text = "";
            wheel.Image= Comp60Ass2.Properties.Resources.wheel;
            hiddenString = "";
        }

        
        //instrunction button about the game
        private void instruction_Click(object sender, EventArgs e)
        {
            string instructionMsg = "1. Each player enter the name and hit start to begin the game. \n" +
                                    "2. Each player input a letter in turn to guess if it is the target word. \n" +
                                    "3. You will receive the wheel score if you get it right. Otherwise, you get 0. \n" +
                                    "4. Once the word is guessed correctly, the highest score wins. \n" +
                                    "** You can start a new game by reset or simpily hit \"Yes\" at the end of each game.** \n" +
                                    "Enjoy~~";
            
            MessageBox.Show(instructionMsg, "Instruction");
        }

        

    }
}
