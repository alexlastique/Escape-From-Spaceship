using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

public class ActiveTeleportationKnob : MonoBehaviour
{

    public GameObject teleportationArea;

    public XRKnob Knob;

    public void ActiveTeleportationArea()
    {
        if (Knob.value == 1)
        {
            teleportationArea.SetActive(true);
        }
    }
}
