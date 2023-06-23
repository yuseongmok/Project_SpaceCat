using UnityEngine;

public class JumpSound : MonoBehaviour
{
    public AudioClip soundEffect;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaySoundEffect();
        }
    }

    private void PlaySoundEffect()
    {
        if (soundEffect != null)
        {
            AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        }
    }
}
