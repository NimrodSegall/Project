using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairWheelsSound : MonoBehaviour
{
    private GameState state = null;
    private AudioSource wheelsAudio = null;
    private bool currentlyPlayingSoung = false;

    // Start is called before the first frame update
    void Start()
    {
        state = GetComponent<GameState>();
        wheelsAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckToggleSound();
    }

    private void CheckToggleSound()
    {
        if (state.PlayerIsTryingToMove() && !wheelsAudio.isPlaying)
        {
            wheelsAudio.pitch = Random.Range(0.8f, 1.2f);
            wheelsAudio.Play();
        }
    }
}
