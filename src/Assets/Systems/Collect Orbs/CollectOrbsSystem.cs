using System;
using UnityEngine;

public class CollectOrbsSystem : MonoBehaviour
{
    public static int CollectedOrbs;
    public static int CollectedRareOrbs;

    public static event Action<int> UpdateCommonOrbScore;
    public static event Action<int> UpdateRareOrbScore;
    
    private void Start()
    {
        RareOrb.OnRareOrbCollected += RareOrb_OnRareOrbCollected;
        CommonOrb.OnOrbCollected += Orb_OnOrbCollected;
    }

    private void Orb_OnOrbCollected(CommonOrb orb)
    {        
        CollectedOrbs += 1;

        UpdateCommonOrbScore.Invoke(CollectedOrbs);
        

        Destroy(orb.gameObject);
    }

    private void RareOrb_OnRareOrbCollected(RareOrb rareOrb)
    {
        CollectedRareOrbs += 1;

        UpdateRareOrbScore.Invoke(CollectedRareOrbs);

        Destroy(rareOrb.gameObject);
    }

}
