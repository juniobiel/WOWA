using System;
using UnityEngine;

public class RareOrb : Orb
{
    public static event Action<RareOrb> OnRareOrbCollected;

    private void OnTriggerEnter2D( Collider2D collision )
    {
        OnRareOrbCollected?.Invoke(this);
    }
}
