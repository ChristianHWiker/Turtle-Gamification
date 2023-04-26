using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningFunction : MonoBehaviour
{

    public int spawnAm=1;
    public GameObject EntityToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 point;
        //randomLocation(30.0f, 1.4f, 30.0f, out point);
        for (int i = 0; i < spawnAm; i++)
        {
            Instantiate(EntityToSpawn, transform.position, transform.rotation);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    //bool randomLocation(float x, float y, float z, out Vector3 result)
    //{
    //    Vector3 randLoc = (random.range(x,z),0.0f, random.range(x, z));
    //    out Vector3 result;
    //    return false;
    //}
}
