using System;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public static event Action<Gate> OnGateEntered;

    [SerializeField]
    private string GateName;

    private void OnCollisionEnter2D( Collision2D collision )
    {
        OnGateEntered?.Invoke(this);
    }

    public string GetGateName()
    {
        return GateName;
    }
}
