using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource sfxSource;

    public AudioClip battleMusic;
    public AudioClip enemyActSFX;
    public AudioClip playerActSFX;

    void Start()
    {
        // Start playing battle music on loop
        if (battleMusic != null)
        {
            musicSource.clip = battleMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
    }

    public void PlayEnemyActSound()
    {
        if (enemyActSFX != null)
            sfxSource.PlayOneShot(enemyActSFX);
    }

    public void PlayPlayerActSound()
    {
        if (playerActSFX != null)
            sfxSource.PlayOneShot(playerActSFX);
    }
}