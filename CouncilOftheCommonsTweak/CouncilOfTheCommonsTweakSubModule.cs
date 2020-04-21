using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace CouncilOfTheCommonsTweak
{
    public class CouncilOfTheCommonsTweakSubModule : MBSubModuleBase
    {

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);
            gameStarterObject.AddModel(new TweakedCouncilOfTheCommonsModel());
        }
    }
}
