using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FSCLICK : MonoBehaviour
{
    public AudioSource source
    {
        get
        {
            return GetComponent<AudioSource>();
        }
    }
    public Button btn
    {
        get
        {
            return GetComponent<Button>();
        }
    }
    public AudioClip clip;
    public GameObject xd;
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        btn.onClick.AddListener(PlaySound);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(xd);

        }

    }

    void PlaySound()
    {
        source.PlayOneShot(clip);
    }
}
