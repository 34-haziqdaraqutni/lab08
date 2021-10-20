using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawnerscript : MonoBehaviour
{
    List<GameObject> prefablist = new List<GameObject>();
    public GameObject SpawnObject;
    public GameObject spawnObject1;
    public GameObject spawnObject2;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        //Instantiate(SpawnObject, transform.position, transform.rotation);
        prefablist.Add(spawnObject1);
        prefablist.Add(SpawnObject);
        prefablist.Add(spawnObject2);
        int prefabIndex = UnityEngine.Random.Range(0, 3);
        Instantiate(prefablist[prefabIndex]);
    }
}
