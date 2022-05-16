using System.Data.SQLite;
using System.Data;
using Flurl.Http;
using System.Text.Json;
using System.Text;

namespace Millionaire
{
    public partial class Form1 : Form
    {
        List<Question> questions = new List<Question>();
        private Random rnd = new Random();
        int level = 0;
        bool extraChance = false;
        Question currentQuestion;
        string playerName = "";
        int fireproofLevel = 0;

        static string[] winnings = new string[16] {
            "0",
            "500",
            "1000",
            "2000",
            "3000",
            "5000",
            "10000",
            "15000",
            "25000",
            "50000",
            "100000",
            "200000",
            "400000",
            "800000",
            "1500000",
            "3000000"};

        public Form1()
        {
            InitializeComponent();
            ReadQuestionsFromDB();
            //StartGame();
        }

        private async void ReadQuestionsFromDB()
        {
            // Query to DBHub.io API
            var responseString = await "https://api.dbhub.io/v1/query"
                .PostUrlEncodedAsync(new {
                    apikey = "29AGoJB7pTmxXtcr8N0GByFd8a1",
                    dbowner = "Nick-Kolchanov",
                    dbname = "dbMillionaire.db",
                    sql = Convert.ToBase64String(Encoding.UTF8.GetBytes("SELECT * FROM QuestionsMillionaire"))
                })
                .ReceiveString();
            var tableContent = JsonSerializer.Deserialize<List<List<JsonResponse>>>(responseString);
            if (tableContent == null)
                return;

            foreach (var results in tableContent)
            {
                string[] questionArr = new string[7];
                for (int i = 0; i < 7; i++)
                {
                    questionArr[i] = results[i].Value;
                }
                questions.Add(new Question(questionArr));
            }

            var wrongData = questions.Where(e => e.Level == -1).Count();
            var correctData = questions.Count() - wrongData;

            Registration regForm = new Registration();
            regForm.ShowDialog();
            playerName = regForm.PlayerName;
            fireproofLevel = regForm.FireproofIndex;

            fireproofLevelLabel.Text = winnings[fireproofLevel];

            StartGame();
        }

        private void ShowQuestion(Question q)
        {
            LblQuestion.Text = q.Text;
            BtnAnswerA.Text = q.Answers[0];
            BtnAnswerB.Text = q.Answers[1];
            BtnAnswerC.Text = q.Answers[2];
            BtnAnswerD.Text = q.Answers[3];
        }

        private Question GetQuestion(int level)
        {
            var questionsWithLevel = questions.Where(q => q.Level == level).ToList();
            return questionsWithLevel[rnd.Next(questionsWithLevel.Count)];
        }
        private void StartGame()
        {
            using SQLiteConnection myconnection = new SQLiteConnection("Data Source=../../../leaderboardDB.db");
            myconnection.Open();
            
            if (level >= fireproofLevel || level != 0)
            {
                SQLiteCommand mycommand = new SQLiteCommand("INSERT INTO leaderboard(player_name, score) VALUES (@playerName, @score)", myconnection);
                mycommand.Parameters.AddWithValue("@playerName", playerName);
                mycommand.Parameters.AddWithValue("@score", winnings[fireproofLevel]);
                mycommand.ExecuteNonQuery();
            }
            myconnection.Close();

            level = 0;
            BtnAskTheAudience.Enabled = true;
            BtnExtraChance.Enabled = true;
            BtnFiftyFifty.Enabled = true;
            BtnFriendCall.Enabled = true;
            BtnChangeQuestion.Enabled = true;
            NextStep();
        }

        private void NextStep()
        {
            level++;

            if (level == 15)
            {
                MessageBox.Show("Поздравляю! Вы выиграли 3 000 000 р.!!! Сможете повторить это достижение еще раз?");
                StartGame();
            }

            Button[] buttons = new Button[] { BtnAnswerA, BtnAnswerB, BtnAnswerC, BtnAnswerD };

            foreach (Button btn in buttons)
                btn.Enabled = true;

            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            ListLevel.SelectedIndex = ListLevel.Items.Count - level;
        }
        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()!))
                NextStep();
            else if (extraChance)
            {
                button.Enabled = false;
            }
            else
            {
                MessageBox.Show("Неверный ответ!");
                level--;
                StartGame();
            }

            extraChance = false;
        }

        private void BntFiftyFifty_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;

            Button[] btns = new Button[] { BtnAnswerA, BtnAnswerB, BtnAnswerC, BtnAnswerD };

            int count = 0;
            while (count < 2)
            {
                int n = rnd.Next(4);
                int answer = int.Parse(btns[n].Tag.ToString()!);

                if (answer != currentQuestion.RightAnswer && btns[n].Enabled)
                {
                    btns[n].Enabled = false;
                    count++;
                }
            }
        }

        private void BntExtraChance_Click(object sender, EventArgs e)
        {            
            Button button = (Button)sender;
            button.Enabled = false;

            extraChance = true;
        }

        private void BtnAskTheAudience_Click(object sender, EventArgs e)
        {
            string helpString = "";
            var percents = new int[4];            
            for (int i = 0; i < 4; i++)
            {
                percents[i] = 20 + rnd.Next(10);                
            }
            percents[currentQuestion.RightAnswer - 1] += 7;

            int cnt = 0;
            while(percents.Sum() > 100)
            {
                percents[cnt % 4] -= 1;
                cnt++;
            }

            for (int i = 0; i < 4; i++)
            {
                helpString += currentQuestion.Answers[i] + " - " + percents[i] + "%\n";
            }
            MessageBox.Show(helpString);

            Button button = (Button)sender;
            button.Enabled = false;
        }

        private void BtnFriendCall_Click(object sender, EventArgs e)
        {
            int answer = 0;
            answer += currentQuestion.RightAnswer - 1;

            if (rnd.Next(10) < 2) // 20% for wrong answer
            {
                answer += rnd.Next(3) + 1;
                answer %= 4;
            }

            MessageBox.Show("Алло, привет! Помочь с вопросом? Хмм....");
            MessageBox.Show($"Я думаю, ответ - {currentQuestion.Answers[answer]}");
            
            Button button = (Button)sender;
            button.Enabled = false; 
        }

        private void BtnChangeQuestion_Click(object sender, EventArgs e)
        {
            level--;
            NextStep();

            Button button = (Button)sender;
            button.Enabled = false;
        }

        private void ListLevel_MouseClick(object sender, MouseEventArgs e)
        {
            ListBox textBox = (ListBox)sender;
            textBox.SelectedIndex = ListLevel.Items.Count - level;
        }

        private void BtnLeaderboard_Click(object sender, EventArgs e)
        {
            using SQLiteConnection myconnection = new SQLiteConnection("Data Source=../../../leaderboardDB.db");
            myconnection.Open();
            SQLiteCommand mycommand = new SQLiteCommand("SELECT * FROM leaderboard", myconnection);
            SQLiteDataReader reader = mycommand.ExecuteReader();

            var leaderboard = new List<(string name, string score)>();
            while (reader.Read())
            {
                leaderboard.Add((reader["player_name"].ToString()!, reader["score"].ToString()!));
            }
            myconnection.Close();

            if (leaderboard.Count == 0)
            {
                MessageBox.Show("На доске лидеров пока что пусто.");
                return;
            }

            leaderboard = leaderboard.OrderByDescending(e => int.Parse(e.score)).Take(10).ToList();
            var leaderboardStr = new StringBuilder("Доска лидеров: \n\n");
            foreach (var results in leaderboard)
            {
                leaderboardStr.Append(results.name).Append(" - ").Append(results.score).Append('\n');
            }

            MessageBox.Show(leaderboardStr.ToString());
        }

        private void BtnChangePlayerInfo_Click(object sender, EventArgs e)
        {
            Registration regForm = new Registration();
            regForm.PlayerName = playerName;
            regForm.ShowDialog();
            playerName = regForm.PlayerName;
            fireproofLevel = regForm.FireproofIndex;

            fireproofLevelLabel.Text = winnings[fireproofLevel];

            StartGame();
        }
    }
}