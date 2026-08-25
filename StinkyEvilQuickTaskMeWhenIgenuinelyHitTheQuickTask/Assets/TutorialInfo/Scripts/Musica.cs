using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Musica : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip AllTheThingsSheSaid;
    public string playerTag = "Player";
    public bool useTrigger = true;
    public bool playOnce = true;
    private bool played;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.playOnAwake = false;
            audioSource.loop = false;
            audioSource.Stop();
        }
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (!useTrigger || (playOnce && played)) return;
        if (other.CompareTag(playerTag)) { PlayClip(); played = true; }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (useTrigger || (playOnce && played)) return;
        if (collision.gameObject.CompareTag(playerTag)) { PlayClip(); played = true; }
    }

    void PlayClip()
    {
        if (audioSource == null) audioSource = GetComponent<AudioSource>();
        if (audioSource != null && AllTheThingsSheSaid != null)
            audioSource.PlayOneShot(AllTheThingsSheSaid);
    }
}