using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioMixer Mixer;
    [SerializeField] Slider Vol, VolCasa, VolParlante;
    FirstPersonController player;
    void Start()
    {
        Cursor.visible = false;
        player = FindObjectOfType<FirstPersonController>();
    }


    void Update()
    {
        Mixer.SetFloat("Master", Vol.value);
        Mixer.SetFloat("Casa", VolCasa.value);
        Mixer.SetFloat("Parlante", VolParlante.value);
        if (Input.GetKeyDown("escape"))
        {
            if(Time.timeScale== 0)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
                player.cameraCanMove = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Confined;
                Time.timeScale = 0;
                player.cameraCanMove = false;
            }
        }

    }
}
