using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform player;
    public float time;
    public float minX, maxX;


    private void FixedUpdate()
    {
        Vector3 newPoasition = player.position + new Vector3(0, 0, -10);
        newPoasition.y = 0.14f;
        newPoasition.y = transform.position.y;
        newPoasition = Vector3.Lerp(transform.position, newPoasition, time);
        transform.position = newPoasition;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);
    }

}