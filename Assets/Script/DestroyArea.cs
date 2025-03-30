using UnityEngine;

public class DestroyArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ตรวจสอบว่าชนกับลูกบอลหรือไม่
        {
            PlayerRespawn player = other.GetComponent<PlayerRespawn>();
            if (player != null)
            {
                player.Respawn(); // เรียกใช้ฟังก์ชันเกิดใหม่
            }
        }
    }
}
