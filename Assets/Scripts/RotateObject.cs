using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float xRotation, yRotation, zRotation;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(xRotation, yRotation, zRotation);
    }
}
