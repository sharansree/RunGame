using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    public GameObject obstacle;
    float rand;
    Vector3 pos;
    float time;
    float rand2;
    // Start is called before the first frame update
    void Start()
    {
        rand2 = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 3f)
        {
            rand = Random.Range(-2, 3);
            rand2-=5;
            pos = new Vector3(rand2, .2f, transform.position.z+rand);
            Instantiate(obstacle, pos, Quaternion.identity);
            time = 0f;
        }
    }
}
