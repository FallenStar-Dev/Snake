using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Snake
{
	public partial class FrmScores : Form
	{
		public FrmScores()
		{
			InitializeComponent();
		}

		private void btnRestart_Click(object sender, EventArgs e)
		{
			Hide();
			new FrmName().ShowDialog();
			GridRefresh();
			Show();

		}

		private void FrmScores_Load(object sender, EventArgs e)
		{
			Hide();
			btnRestart_Click(null, null);
		}

		void GridRefresh()
		{
			List<Person> people = new List<Person>();
			// خواندن داده ها از فایل txt
			string[] lines = File.ReadAllLines(Settings.ScoresFilePath);
			foreach (string line in lines)
			{
				string[] parts = line.Split(':');
				if (parts.Length == 2)
				{
					string name = parts[0];
					int score = int.Parse(parts[1]);

					people.Add(new Person
					{
						Name = name,
						Score = score
					});
				}
			}

			// تنظیم منبع داده GridView
			people.Sort((a, b) => b.Score.CompareTo(a.Score));
			dgvScore.DataSource = people;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			File.WriteAllText(Settings.ScoresFilePath,string.Empty);
			GridRefresh();
		}
	}
	public class Person
	{
		public string Name { get; set; }
		public int Score { get; set; }
	}

}
