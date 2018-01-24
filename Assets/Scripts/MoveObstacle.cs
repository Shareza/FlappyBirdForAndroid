using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour {

    public float speed = -2;

    void Update ()
    {
        Move();
	}

    private void Move()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    public void Stop()
    {
        speed = 0;
    }
}
