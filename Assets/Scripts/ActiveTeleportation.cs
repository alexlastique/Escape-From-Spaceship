using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

public class ActiveTeleportation : MonoBehaviour
{

    public GameObject teleportationArea;

    public void ActiveTeleportationArea()
    {
        teleportationArea.SetActive(true);
    }
}
