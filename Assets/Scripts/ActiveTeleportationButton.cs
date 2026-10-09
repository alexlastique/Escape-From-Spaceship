using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

public class ActiveTeleportationButton : MonoBehaviour
{

    public GameObject teleportationArea;

    public void ActiveTeleportationArea()
    {
        teleportationArea.SetActive(true);
    }
}
