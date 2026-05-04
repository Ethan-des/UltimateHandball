using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Spawner : MonoBehaviour
{
    enum SpawnerType {Straight, Spin}

    [Header("Bullet Attributes")]
    public GameObject Bullet;
    public float bulletLife = 1f;
    public float speed = 1f;

    [Header("Spawner Attributes")]
    [SerializeField] private SpawnerType spawnerType;
    [SerializeField] private float firingRate = 1f;

    private GameObject spawnedBullet;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //Spin spawner on Z Axis if we specifically want spin
        if (spawnerType == SpawnerType.Spin) transform.eulerAngles = new Vector3(0f, 0f, transform.eulerAngles.z + 1f);
        if(timer >= firingRate){
            Fire();
            timer = 0;
        }
    }

    //Having the spawner fire
    private void Fire()
    {
        if(Bullet)
        {
            spawnedBullet = Instantiate(Bullet, transform.position, Quaternion.identity);
            spawnedBullet.GetComponent<Bullet_Movement>().speed = speed;
            spawnedBullet.GetComponent<Bullet_Movement>().bulletLife = bulletLife;
            spawnedBullet.transform.rotation = transform.rotation;
        }
    }
}
