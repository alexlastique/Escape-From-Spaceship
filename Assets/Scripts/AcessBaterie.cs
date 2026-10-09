using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class AcessBaterie : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> tpArea;

    [SerializeField]
    private GameObject TpBattery;

    // Update is called once per frame
    void Update()
    {
        // Check if all teleportation areas are active
        bool allActive = true;
        foreach (GameObject area in tpArea)
        {
            if (!area.activeSelf)
            {
                allActive = false;
                break;
            }
        }
        if (allActive)
        {
            TpBattery.SetActive(true);
        }
    }
}
