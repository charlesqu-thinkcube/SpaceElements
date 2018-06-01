using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    //public GameObject[] bullets;
    public List<GameObject> bullets;
    public static Spawner Instance;
    //public GameObject bulletVisuals;
    public List<GameObject> bulletVisuals;
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
        CurrentBullet = Random.Range(0, bullets.Count);
        foreach(GameObject obj in bulletVisuals)
        {
            obj.SetActive(false);
        }
        bulletVisuals[CurrentBullet].SetActive(true);
    }
    /*
    void RemoveBullets()
    {
		if ((GameObject.FindGameObjectsWithTag("WaterEnemy").Length <= 0))
		{
			bullets.Remove("bulletWater");
			//bulletVisuals.Remove(bullets[3]);
		}

		if ((GameObject.FindGameObjectsWithTag("EarthEnemy").Length <= 0))
		{
			bullets.Remove("bulletEarth");
			//bulletVisuals.Remove(bullets[1]);
		}

		if ((GameObject.FindGameObjectsWithTag("AirEnemy").Length <= 0))
		{
			bullets.Remove("bulletAir");
			//bulletVisuals.Remove(bullets[0]);
		}

		if ((GameObject.FindGameObjectsWithTag("FireEnemy").Length <= 0))
		{
			bullets.Remove("bulletFire");
			//bulletVisuals.Remove(bullets[2]);
		}
    }
    */

    public void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        nextBullet();
    }
}