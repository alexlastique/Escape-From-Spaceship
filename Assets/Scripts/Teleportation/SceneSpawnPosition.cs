
using UnityEngine;

public class SceneSpawnPosition : MonoBehaviour
{
    [SerializeField] private Transform playerRig;

    private void Start()
    {
        string spawnName = SceneSpawnManager.TargetSpawnPoint;

        if (string.IsNullOrEmpty(spawnName))
            return;

        GameObject spawn =
            GameObject.Find(spawnName);

        if (spawn == null)
        {
            Debug.LogError(
                "Point d'arrivée introuvable : " + spawnName);
            return;
        }

        // Si aucun rig n'est renseigné, cherche le joueur.
        if (playerRig == null)
        {
            GameObject player =
                GameObject.FindGameObjectWithTag("Player");

            if (player == null)
            {
                Debug.LogError(
                    "Rig VR introuvable : vérifie le tag Player.");
                return;
            }

            playerRig = player.transform;
        }

        // Place le rig à l'emplacement prévu.
        playerRig.SetPositionAndRotation(
            spawn.transform.position,
            Quaternion.Euler(
                0f,
                spawn.transform.eulerAngles.y,
                0f));

        // Efface la destination mémorisée.
        SceneSpawnManager.TargetSpawnPoint = null;
    }
}