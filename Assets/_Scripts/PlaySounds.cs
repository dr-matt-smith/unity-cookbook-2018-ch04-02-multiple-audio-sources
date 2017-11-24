using UnityEngine;

public class PlaySounds : MonoBehaviour 
{
    public AudioSource musicMedieval;
    public AudioSource musicArcade;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
            if (musicArcade.time > 0)
                musicArcade.UnPause();
            else
                musicArcade.Play();            
        }

        if (Input.GetKey(KeyCode.DownArrow))
            musicArcade.Pause();

        if (Input.GetKey(KeyCode.RightArrow)){            
            if (musicMedieval.time > 0)
                musicMedieval.UnPause();
                    else
                musicMedieval.Play();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
                musicMedieval.Pause();

    }
}
