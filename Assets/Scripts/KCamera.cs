using UnityEngine;

public class KCamera : MonoBehaviour
{

    public Transform player;
    public int distance = -1;
    public float lift = 0;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + new Vector3(0, lift, distance);
        transform.LookAt(player);
    }
}