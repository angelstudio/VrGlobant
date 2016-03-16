using UnityEngine;
using System.Collections;

public class VideoPlay : MonoBehaviour {
     Renderer r;
     MovieTexture _movie;
     AudioSource _audio;

    void Awake () {
        r = GetComponent<Renderer>();
        _movie = (MovieTexture)r.material.mainTexture;
        _audio = GetComponent<AudioSource>();
        _audio.clip = _movie.audioClip;
	}

    void Start() {
        _movie.Play();
        _audio.Play();
    }
	
	void Update () {
        
       
        if (Input.GetButtonDown("Jump"))
        {
            PauseAndPlay();
        }

        //((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
	}

    public void PauseAndPlay() {
        if (_movie.isPlaying)
        {
            print("Pause");
            _movie.Pause();
        }
        else
        {
            print("Play");
            _movie.Play();
        }
    }
}
