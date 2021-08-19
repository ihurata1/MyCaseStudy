namespace CaseStudyDependencyInversion.Unity.Domain
{
	using CaseStudyDependencyInversion.Unity.Domain.Model;
    using Simsoft.CaseStudyDependencyInversion.Unity;
    using System.Collections.Generic;
	using System.Linq;

	public class LeaderboardSorterByScore: ILeaderBoard
	{
		public IEnumerable<LeaderboardItem> Sort(FakeLeaderboardProvider leaderboardProvider) =>
			leaderboardProvider.GetItems().OrderByDescending(i => i.Score);
	}
}
