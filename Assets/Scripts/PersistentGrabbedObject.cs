using UnityEngine;

public class PersistentGrabbedObject : MonoBehaviour
{
    public static PersistentGrabbedObject Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}