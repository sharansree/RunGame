using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class spawn : MonoBehaviour
{
    public GameObject plane;
    float time;
    float t;
    int n = 43;
    Vector3 pos;
    public List<GameObject> spawned;
    public GameObject point;
    public float ypoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= .5f)
        {
            n--;
            pos = new Vector3(n, ypoint, point.transform.position.z);
            spawned.Add(Instantiate(plane, pos, Quaternion.identity));
            time = 0f;
        }

        t  += Time.deltaTime;

        if (t >= 2.5f)
        {
            for (int i = spawned.Count -1; i < spawned.Count; i++)
            {
                Destroy(spawned[i]);
            }
            t = 0f;
        }
    }
}
