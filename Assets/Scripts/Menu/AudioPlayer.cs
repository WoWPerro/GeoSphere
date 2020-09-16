using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioManager AM;
    // Start is called before the first frame update
    void Start()
    {
        AM.Play("Welcome");
        StartCoroutine(ExecuteAfterTime(1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        StartCoroutine(AM.Play("MenuSong", 1, .001f));
    }
}
