using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform spawnPoint;

    private void Start()
    {
        if (spawnPoint == null)
        {
            spawnPoint = transform;
        }
    }

    public void Respawn()
    {
        transform.position = spawnPoint.position;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
