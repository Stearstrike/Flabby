using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float maxTime;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    public float spaceBetween;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(Random.Range(spaceBetween, -spaceBetween), Random.Range(-height, height), 0);
            Destroy(newpipe, 25);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
