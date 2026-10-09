
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

        bool isPlayer = other.CompareTag("Player") || other.transform.root.CompareTag("Player");

        if (!isPlayer)
            return;

        isLoading = true;

        // Mémorise le point d'arrivée pour la prochaine scène.
        SceneSpawnManager.TargetSpawnPoint = targetSpawnPoint;

        // Charge la scène de destination.
        SceneManager.LoadScene(targetScene);
    }
}

public static class SceneSpawnManager
{
    public static string TargetSpawnPoint;
}