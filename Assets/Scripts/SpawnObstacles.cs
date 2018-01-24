using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour {

    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject newObstaclePosition;

    private int random = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        random = Random.Range(1, 5);

        if(collision.gameObject.tag == "Obstacle")
        {
            if (random == 1)
            {
                Instantiate(obstacle1, new Vector2(newObstaclePosition.transform.position.x, obstacle1.transform.position.y), Quaternion.identity);
            }

            else if(random == 2)
            {
                Instantiate(obstacle2, new Vector2(newObstaclePosition.transform.position.x, obstacle2.transform.position.y), Quaternion.identity);
            }
            
            else if(random == 3)
            {
                Instantiate(obstacle3, new Vector2(newObstaclePosition.transform.position.x, obstacle3.transform.position.y), Quaternion.identity);
            }

            else if (random == 4)
            {
                Instantiate(obstacle4, new Vector2(newObstaclePosition.transform.position.x, obstacle4.transform.position.y), Quaternion.identity);
            }

            Destroy(collision.gameObject);
        }
    }
}
