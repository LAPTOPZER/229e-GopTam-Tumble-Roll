using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectible : MonoBehaviour
{
    public int scoreValue = 1;
    public float rotationSpeed = 30f;

    private void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("? Collected! + " + scoreValue + " points");

            ScoreManager.instance.AddScore(scoreValue);
            Destroy(this.gameObject);
        }
    }

}
