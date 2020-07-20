using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject Obstacles;
    public GameObject GameArea;
    public GameObject SpawnManager;
    public float xPos;
    public float yPos;
    public float zPos;
    public float a=0;
    public float b=0;
    public float XPos=-15f;
    public float YPos=0f;
    public float ZPos=7.5f;
    public int ObstacleCount;


    IEnumerator Room()
    {
        XPos += 29f;
        YPos += 3.5f;
        Instantiate(GameArea, new Vector3(XPos, YPos, ZPos), Quaternion.identity);
        Instantiate(SpawnManager, new Vector3(XPos, YPos, ZPos), Quaternion.identity);
        yield return new WaitForSeconds(0.01f);
    }
    IEnumerator Hurdles()
    {
            while (ObstacleCount < 10)
        { 
            xPos = Random.Range(-3,3);
            yPos = Random.Range(1, 1);
            zPos = Random.Range(-3.6f, 3.6f);
            Instantiate(Obstacles, new Vector3(xPos*4 +a, yPos*5 +b, zPos*2), Quaternion.identity);
            yield return new WaitForSeconds(0.01f);
            ObstacleCount += 1;
        }
       
    }

     private void OnTriggerEnter(Collider other)
    {
        a += 29f;
        b += 3.5f;
        ObstacleCount = 0;
        StartCoroutine(Room());
        StartCoroutine(Hurdles());    
     }
   
}
