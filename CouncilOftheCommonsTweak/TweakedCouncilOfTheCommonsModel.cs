using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents;


namespace CouncilOfTheCommonsTweak
{
    public class TweakedCouncilOfTheCommonsModel : DefaultClanPoliticsModel
    {
        public override float CalculateInfluenceChange(Clan clan, StatExplainer explanation = null)
        {
            float influenceChange = 0f;
            if(clan.Kingdom != null)
            {
                clan.Kingdom.ActivePolicies.Remove(DefaultPolicies.CouncilOfTheCommons);
                influenceChange = base.CalculateInfluenceChange(clan, explanation);
                clan.Kingdom.ActivePolicies.Add(DefaultPolicies.CouncilOfTheCommons);
            }    
            return influenceChange;
        }
    }
}
