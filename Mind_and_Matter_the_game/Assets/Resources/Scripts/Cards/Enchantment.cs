using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SA
{
    [CreateAssetMenu(menuName ="Card Types/Enchantment")]
    public class Enchantment : MindCard
    {
        
        public override void OnSetType(CardViz viz)
        {
            base.OnSetType(viz);

            //viz.statsHolder.SetActive(false);
        }

    }
}
