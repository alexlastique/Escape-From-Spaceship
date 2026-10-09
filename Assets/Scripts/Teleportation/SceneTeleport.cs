using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneTeleport : MonoBehaviour
{
    [SerializeField] private string targetScene = "Storage";
    [SerializeField] private string targetSpawnPoint = "SpawnPoint_StorageRoom";

    private bool isLoading;

    private void OnTriggerEnter(Collider other)
    {
        if (isLoading)
            return;

        bool isPlayer = other.CompareTag("Player")
            || other.transform.root.CompareTag("Player");

        if (!isPlayer)
            return;

        isLoading = true;

        // Find the XR Grab Interactable held by the player.
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabbedObject = null;

        foreach (var interactable in FindObjectsByType<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>(
                     FindObjectsSortMode.None))
        {
            if (interactable.isSelected)
            {
                grabbedObject = interactable;
                break;
            }
        }

        // Preserve the held object across scenes.
        if (grabbedObject != null)
        {
            if (grabbedObject.GetComponent<PersistentGrabbedObject>() == null)
                grabbedObject.gameObject.AddComponent<PersistentGrabbedObject>();

            DontDestroyOnLoad(grabbedObject.gameObject);
        }

        SceneSpawnManager.TargetSpawnPoint = targetSpawnPoint;

        SceneManager.LoadScene(targetScene);
    }
}

public static class SceneSpawnManager
{
    public static string TargetSpawnPoint;
}