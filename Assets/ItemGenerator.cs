using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject carPrefab;
    public GameObject conePrefab;
    private GameObject unitychan;
    public int startPos = 80;
    public int goalPos = 360;
    public float posRange = 3.4f;
    private int itemGeneratePosZ = 70;
    
    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");

        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (this.unitychan.transform.position.z > itemGeneratePosZ && this.unitychan.transform.position.z< goalPos - 50)
        {
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, this.unitychan.transform.position.z + 50);
                }
            }
            else
            {
                for (int j = -1; j <= 1; j++)
                {
                    int item = Random.Range(1, 11);
                    int offsetZ = Random.Range(-5, 6);
                    if (1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, this.unitychan.transform.position.z + 50 + offsetZ);

                    }
                    else if (7 <= item && item <= 9)
                    {
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, this.unitychan.transform.position.z + 50 + offsetZ);
                    }
                }
            }
            itemGeneratePosZ += 15;
            
        }
    }
}

