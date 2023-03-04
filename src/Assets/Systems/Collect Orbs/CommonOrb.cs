using System;
using UnityEngine;

public class CommonOrb : Orb
{
    public static event Action<CommonOrb> OnOrbCollected;

    private void OnTriggerEnter2D( Collider2D collision )
    {
        OnOrbCollected?.Invoke(this);
    }
}
