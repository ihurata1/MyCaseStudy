using System.Collections;
using System.Collections.Generic;
using CaseStudyDependencyInversion.Unity.Domain;
using CaseStudyDependencyInversion.Unity.Domain.Model;
using UnityEngine;

namespace Simsoft.CaseStudyDependencyInversion.Unity
{
    public interface ILeaderBoard 
    {
        IEnumerable<LeaderboardItem> Sort(FakeLeaderboardProvider leaderboardProvider);
    }
}
