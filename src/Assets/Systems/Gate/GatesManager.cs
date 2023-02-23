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
        {
            obj.gameObject.GetComponent<Animator>().SetBool("CanOpenGate", true);
        }
            
    }

    private void SadDoorKey_OnSadDoorKeyCollect( SadDoorKey sadDoorKey )
    {
        SadDoorKeyCollected = true;
        Destroy(sadDoorKey.gameObject);
    }
}
