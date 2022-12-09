﻿using System;
using System.Windows.Forms;

namespace TetrisOOP.Data.GUI.UserStatistics
{
	public partial class UserStatistic : Form
	{
		public UserStatistic()
		{
			InitializeComponent();
		}

		private void UserStatistic_Load(object sender, EventArgs e)
		{
			lbTimeInGame.Text = Properties.Settings.Default.TimeInGame.ToString(@"hh\:mm\:ss");
			lbNumberOfGame.Text = Properties.Settings.Default.NumberOfGames.ToString();
		}
	}
}
