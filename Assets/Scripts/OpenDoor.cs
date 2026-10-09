
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField]
    private Vector3 intitialPostiion;

    [SerializeField]
    private Vector3 targetPosition;

    [SerializeField]
    private float speed = 2f;

    private bool open = false;

    public void Open()
    {
        open = true;
    }

    void Update()
    {
        if (open)
        {
            transform.localPosition = Vector3.MoveTowards(
                transform.localPosition,
                targetPosition,
                speed * Time.deltaTime
            );

            if (transform.localPosition == targetPosition)
            {
                open = false;
            }
        }
    }
}