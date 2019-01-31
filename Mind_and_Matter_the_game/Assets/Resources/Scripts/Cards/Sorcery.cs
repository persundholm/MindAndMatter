using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Card Types/Sorcery")]
    public class Sorcery : MindCard
    {

        public override void OnSetType(CardViz viz)
        {
            base.OnSetType(viz);

            //viz.statsHolder.SetActive(false);
        }

    }
}
