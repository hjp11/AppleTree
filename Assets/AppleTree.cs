using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{

    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceTChangeDirection = 0.1f;
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //dropping apples ever second
        InvokeRepeating("DropApple", 2f, secondsBetweenAppleDrops);
        
    }

    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //basic movment
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
       //changing direction
       if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        }

        
             void Fixedupdate()
    {
        if (Random.value < chanceTChangeDirection)
        {
            speed *= -1;
        }
        }

    }
