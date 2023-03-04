using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    public CollectOrbsSystem CollectOrbsSystem;
    public GatesManager GatesManager;

    private void Awake()
    {
        if (_instance != null)
            Destroy(this);
        
        _instance = this;
        
        CollectOrbsSystem = gameObject.AddComponent<CollectOrbsSystem>();
        GatesManager = gameObject.AddComponent<GatesManager>();
    }
}
