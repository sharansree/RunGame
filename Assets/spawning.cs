using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject plane;
    Vector3 x;
    Vector3 z;
    float time = 0;
    int n = 43;
    Vector3 pos;
    public List<GameObject> spawned;
    float t = 0f;
    public GameObject point;
    public float ypoint;
    //public GameObject empty;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= .5f)
        {
            n--;
            pos = new Vector3(n, ypoint, point.transform.position.z);
            spawned.Add(Instantiate(plane,pos, Quaternion.identity));
            time = 0f;
        }

        t  += Time.deltaTime;

        if(t >= 4f)
        {
            for(int i = spawned.Count -1; i < spawned.Count; i++)
            {
                Destroy(spawned[i]);    
            }
            t = 0f;
        }

    }
        
}
