using static System.Windows.Forms.ListViewItem;

namespace TennisScoreApplication
{
    public partial class ScoreForm : Form
    {
        private static Dictionary<string, int> playersWithPoints = new()
        {
            { "R. Federer", 4},
            { "G. Dimitrov", 5},
            { "R. Nadal", 5}
        };
        private static Dictionary<(string, int), List<(string, int)>> games = new()
        {
            { ( "G. Dimitrov", 3), new List<(string, int)>{("R. Nadal", 2)} },
            { ( "R. Nadal", 3), new List<(string, int)>{("R. Federer", 1)} },
            { ( "G. Dimitrov", 2), new List<(string, int)>{("R. Federer", 2)} },
        };
        public ScoreForm()
        {
            InitializeComponent();
            ResizeColumnsListViewRanking();
            ResizeColumnsListViewLatestGames();
            FillRankingListView();
            FillLatestGamesListView();
        }

        private void ResizeColumnsListViewRanking()
        {
            if (listViewRanking.Columns.Count == 0) return;

            int totalWidth = listViewRanking.ClientSize.Width;
            int columnWidth = totalWidth / listViewRanking.Columns.Count;

            foreach (ColumnHeader column in listViewRanking.Columns)
            {
                column.Width = columnWidth;
            }
        }

        private void ResizeColumnsListViewLatestGames()
        {
            if (listViewLatestGames.Columns.Count == 0) return;

            int totalWidth = listViewLatestGames.ClientSize.Width;
            int columnWidth = totalWidth / listViewLatestGames.Columns.Count;

            foreach (ColumnHeader column in listViewLatestGames.Columns)
            {
                column.Width = columnWidth;
            }
        }

        private void listViewRanking_Resize(object sender, EventArgs e)
        {
        }

        private void FillRankingListView()
        {
            this.listViewRanking.Items.Clear();

            foreach (var player in playersWithPoints.OrderByDescending(x => x.Value))
            {
                string playerName = player.Key;
                string playerPoints = player.Value.ToString();

                ListViewItem rollInRankingListView = new();

                rollInRankingListView.SubItems[0].Text = playerName;
                rollInRankingListView.SubItems.Add(playerPoints);

                this.listViewRanking.Items.Add(rollInRankingListView);
            }
        }
        private void FillLatestGamesListView()
        {
            this.listViewLatestGames.Items.Clear();


            foreach (var game in games.ToArray())
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
        }
        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);

            ListViewItem rollInLatestGamesListView = new();

            rollInLatestGamesListView.SubItems[0].Text = firstPlayer.Item1;
            rollInLatestGamesListView.SubItems.Add(secondPlayer.Item1);
            rollInLatestGamesListView.SubItems.Add(winner);
            rollInLatestGamesListView.SubItems.Add($"{firstPlayer.Item2} - {secondPlayer.Item2}");

            this.listViewLatestGames.Items.Add(rollInLatestGamesListView);
        }

        private string GetWinner((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (firstPlayer.Item2 < secondPlayer.Item2)
            {
                return secondPlayer.Item1;
            }
            else if (firstPlayer.Item2 > secondPlayer.Item2)
            {
                return firstPlayer.Item1;
            }

            return "Draw";
        }

        private void buttonAddNewGame_Click(object sender, EventArgs e)
        {
            using (NewGameForms newGameForm = new NewGameForms())
            {
                if (newGameForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }
        }

        private void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            FillGamesData(firstPlayer, secondPlayer);

            FillPlayerWithPoints(firstPlayer);
            FillPlayerWithPoints(secondPlayer);

            FillRankingListView();
            FillLatestGamesListView();
        }

        private void FillGamesData((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (games.ContainsKey(firstPlayer))
            {
                games[firstPlayer].Add(secondPlayer);
            }
            else if (games.ContainsKey(secondPlayer))
            {
                games[secondPlayer].Add(firstPlayer);
            }
            else
            {
                games.Add(firstPlayer, new List<(string, int)> { secondPlayer });
            }
        }

        private void FillPlayerWithPoints((string, int) player)
        {
            if (playersWithPoints.ContainsKey(player.Item1))
            {
                playersWithPoints[player.Item1] += player.Item2;
            }
            else
            {
                playersWithPoints.Add(player.Item1, player.Item2);
            }
        }

        private void listViewRanking_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedRow = this.listViewRanking.SelectedItems[0];
            ListViewSubItem playerNameCell = selectedRow.SubItems[0];

            string playerName = playerNameCell.Text;

            using(PlayerInfoForm playerInfoForm = new PlayerInfoForm(
                playerName, GetPlayerGames(playerName)))
            {
                playerInfoForm.ShowDialog();
            }
        }

        private Dictionary<(string, int), List<(string, int)>> GetPlayerGames(string playerName)
            => games.Where(x => x.Key.Item1 == playerName
            || x.Value.Any(y => y.Item1 == playerName))
            .ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == playerName || x.Key.Item1 == playerName).ToList());
    }
}
