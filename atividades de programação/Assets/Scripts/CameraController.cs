using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public float time;
    public float minX, maxX;

    private void FixedUpdate()
    {
        Vector3 newPosition = player.position + new Vector3(0,0,-10);
        newPosition.y = 0.1f;
        newPosition = Vector3.Lerp(transform.position, newPosition, time);
        transform.position = newPosition;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.z);
    }




}
