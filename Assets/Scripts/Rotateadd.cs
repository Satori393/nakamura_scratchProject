using UnityEngine;

public class RotateOnKeyXAxis : MonoBehaviour
{
    public float rotationAngle = 15f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0, 0, rotationAngle, Space.Self);
        }
    }
}