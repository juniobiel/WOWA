using UnityEngine;

public class GatesManager : MonoBehaviour
{
    private static bool SadDoorKeyCollected = false;

    private void Start()
    {
        SadDoorKey.OnSadDoorKeyCollect += SadDoorKey_OnSadDoorKeyCollect;

        Gate.OnGateEntered += Gate_OnGateEntered;
    }

    private void Gate_OnGateEntered( Gate obj )
    {
        if (SadDoorKeyCollected)
            Debug.Log("Open the gate");
    }

    private void SadDoorKey_OnSadDoorKeyCollect( SadDoorKey sadDoorKey )
    {
        SadDoorKeyCollected = true;
        Destroy(sadDoorKey.gameObject);
    }
}
