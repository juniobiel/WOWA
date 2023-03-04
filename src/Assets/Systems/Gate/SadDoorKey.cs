using System;
using UnityEngine;

public class SadDoorKey : MonoBehaviour
{
    public static event Action<SadDoorKey> OnSadDoorKeyCollect;

    private void OnTriggerEnter2D( Collider2D collision )
    {
        OnSadDoorKeyCollect?.Invoke(this);
    }
}
