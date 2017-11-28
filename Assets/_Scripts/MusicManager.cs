using UnityEngine;

public class MusicManager : MonoBehaviour 
{
    // audio source component 1
    public AudioSource audioSourceMedieval;

    // audio source component 2
    public AudioSource audioSourceArcade;

    // every frame pause/resume music clip if correct key is pressed
    void Update()
    {
        // Music 1
        // if already started, resume playing
        // else start playing
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (audioSourceMedieval.time > 0)
                audioSourceMedieval.UnPause();
            else
                audioSourceMedieval.Play();
        }

        // pause playing
        if (Input.GetKey(KeyCode.LeftArrow))
            audioSourceMedieval.Pause();

        // Music 2
        // if already started, resume playing
        // else start playing
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (audioSourceArcade.time > 0)
                audioSourceArcade.UnPause();
            else
                audioSourceArcade.Play();
        }

        // pause playing
        if (Input.GetKey(KeyCode.DownArrow))
            audioSourceArcade.Pause();

    }
}