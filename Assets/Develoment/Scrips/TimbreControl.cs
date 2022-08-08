using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimbreControl : MonoBehaviour
{
   [SerializeField] bool IsReady;
    AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsReady && Input.GetKeyDown("e")&& !source.isPlaying) source.Play();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Personaje") IsReady = true;
        else IsReady = false;
    }
}
