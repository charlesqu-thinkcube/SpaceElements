using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSound : MonoBehaviour
{

    public AudioClip myclip;

    // Use this for initialization
    void Start()
    {
        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = myclip;
        this.GetComponent<AudioSource>().Play();
    }
}