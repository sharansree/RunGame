using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class spawned : MonoBehaviour
{
    public GameObject plane;
    public List<GameObject> spawning;
    float time;
    float t;
    Vector3 pos;
    int n = 43;
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
            spawning.Add(Instantiate(plane, pos, Quaternion.identity));
            time = 0f;
        }

        t  += Time.deltaTime;

        if (t >= 7f)
        {
            for (int i = spawning.Count -1; i < spawning.Count; i++)
            {
                Destroy(spawning[i]);
            }
            t = 0f;
        }
    }
}
