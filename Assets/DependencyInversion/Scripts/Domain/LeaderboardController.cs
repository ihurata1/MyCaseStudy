namespace CaseStudyDependencyInversion.Unity.Domain
{
	using CaseStudyDependencyInversion.Unity.Domain.Model;
    using Simsoft.CaseStudyDependencyInversion.Unity;
    using System.Collections.Generic;
	using UnityEngine;

	public class LeaderboardController
	{
		private ILeaderBoard leaderBoard;

		public LeaderboardController(ILeaderBoard leaderBoard){
			this.leaderBoard = leaderBoard;
		}

		public IEnumerable<LeaderboardItem> GetItems()
		{
			var leaderboardProvider = new FakeLeaderboardProvider();
			var sortType = PlayerPrefs.GetInt("SortType", 0);
			if (sortType == 0)
			{
				return leaderBoard.Sort(leaderboardProvider);
			}

			return leaderBoard.Sort(leaderboardProvider);
		}
	}
}
