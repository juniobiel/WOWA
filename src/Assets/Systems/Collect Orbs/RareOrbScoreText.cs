using TMPro;
using UnityEngine;

public class RareOrbScoreText : MonoBehaviour
{
    private TMP_Text ScoreText;

    private void Start()
    {
        ScoreText = GetComponent<TMP_Text>();
        ScoreText.text = CollectOrbsSystem.CollectedRareOrbs.ToString();
        CollectOrbsSystem.UpdateRareOrbScore += ComputeOrbPoint_OnOrbCollected_UpdateScore;
    }

    private void ComputeOrbPoint_OnOrbCollected_UpdateScore( int collectedRareOrbs )
    {
        ScoreText.text = collectedRareOrbs.ToString();
    }
}
