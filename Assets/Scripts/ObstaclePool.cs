using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePool : MonoBehaviour
{
    public int obstaclePoolSize = 10;
    public GameObject obstaclePrefab;
    public float SpawnRate = 3f;
    public float obstacleMin = -1f;
    public float obstacleMax = 5f;
    public float speed = 2;
    //public float switchTime  = 2;
    public bool itemBounceUp = true;

    private GameObject[] obstacles;
    private Vector2 objectPoolPosition = new Vector2 (-15, -25);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 20f;
    private int currentObstacle = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        timeSinceLastSpawned = 0f;

        obstacles = new GameObject[obstaclePoolSize];
        for (int i = 0; i < obstaclePoolSize; i++)
        {   
            obstacles[i] = (GameObject) Instantiate(obstaclePrefab,objectPoolPosition,Quaternion.identity);
        }
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed; 
        //InvokeRepeating("Switch", 0, switchTime);
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (timeSinceLastSpawned >= SpawnRate)
        {
            timeSinceLastSpawned = 0f;

            float spawnYPositon = Random.Range (obstacleMin,obstacleMax);
            spawnXPosition += 5;
            obstacles[currentObstacle].transform.position = new Vector2(spawnXPosition,spawnYPositon);
            //movingUpDown();
            currentObstacle++;
            
            if (currentObstacle >= obstaclePoolSize)
            {
                currentObstacle = 0;
            }

           
        }

        
    }

    //Moving obstacles up and down
    void movingUpDown(){
            int counter = 0;
            while (true){
                if (counter % 2 == 0)
                obstacles[currentObstacle].GetComponent<Rigidbody2D>().AddForce(Vector2.down * speed);
                else
                obstacles[currentObstacle].GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed);
            }  
    }
}
