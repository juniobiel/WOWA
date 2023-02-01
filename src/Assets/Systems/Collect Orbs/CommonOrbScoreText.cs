using TMPro;
using UnityEngine;

public class CommonOrbScoreText : MonoBehaviour
{
    private TMP_Text ScoreText;

    private void Start()
    {
        ScoreText = GetComponent<TMP_Text>();
        ScoreText.text = CollectOrbsSystem.CollectedOrbs.ToString();
        CollectOrbsSystem.UpdateCommonOrbScore += ComputeOrbPoint_OnOrbCollected_UpdateScore;
    }

    private void ComputeOrbPoint_OnOrbCollected_UpdateScore( int collectedOrbs )
    {
        ScoreText.text = collectedOrbs.ToString();
    }
}
