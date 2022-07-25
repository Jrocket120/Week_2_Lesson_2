using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{

    public GameObject bullet;
    public Transform spawnPoint;
    public Transform Trash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var bulletVar = Instantiate(bullet,spawnPoint.position, Quaternion.identity);
            bulletVar.transform.SetParent(Trash);
        }
    }
}

