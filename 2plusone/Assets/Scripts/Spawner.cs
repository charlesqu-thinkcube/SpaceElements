using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] bullets;
    public static Spawner Instance;
    public GameObject[] bulletVisuals;
    private int CurrentBullet;
    // Use this for initialization

    public void nextBullet()
    {
        upNext();
        //random index
        playerScript.Instance.bullet = bullets[CurrentBullet];
    }

    public void upNext()
    {
        CurrentBullet = Random.Range(0, bullets.Length);
        foreach(GameObject obj in bulletVisuals)
        {
            obj.SetActive(false);
        }
        bulletVisuals[CurrentBullet].SetActive(true);
    }

    public void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        nextBullet();
    }
}