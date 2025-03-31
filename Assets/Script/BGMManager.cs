using UnityEngine;
using UnityEngine.UI;

public class BGMManager : MonoBehaviour
{
    public static BGMManager instance;
    public AudioSource bgmSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (!bgmSource.isPlaying)
        {
            bgmSource.Play();
        }
    }
}
