using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField]private GameObject spawnPointPrefab;
    private void Spawn()
    {
        Instantiate(spawnPointPrefab,transform.position,transform.rotation);
    }
   
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.P))
        {
            Spawn();
        }
    }
}
