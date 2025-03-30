using UnityEngine;

public class DestroyArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ��Ǩ�ͺ��Ҫ��Ѻ�١����������
        {
            PlayerRespawn player = other.GetComponent<PlayerRespawn>();
            if (player != null)
            {
                player.Respawn(); // ���¡��ѧ��ѹ�Դ����
            }
        }
    }
}
