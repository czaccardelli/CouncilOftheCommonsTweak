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
                //remove and then re-add policy before calculating influence change if it exists within kingdom
                if(clan.Kingdom.ActivePolicies.Remove(DefaultPolicies.CouncilOfTheCommons))
                {
                    influenceChange = base.CalculateInfluenceChange(clan, explanation);
                    clan.Kingdom.ActivePolicies.Add(DefaultPolicies.CouncilOfTheCommons);
                }
            }    
            return influenceChange;
        }
    }
}
