using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject stone;
    
    public float maxX;//maximum x position

    public Transform spanwPoint;//position where we want stone to start

    int score = 0;

    public TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnStone", 0.5f, 1.5f);//drop stone after every 0.5 seconds and after every 1.5 seconds

        InvokeRepeating("UpdateScore", 3f, 2f);//update scroe after 3 seconds and on every 2 seconds

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnStone()
    {
     
       Vector3 spawnPos = spanwPoint.position;

       spawnPos.x = Random.Range(-maxX, maxX);

       Instantiate(stone, spawnPos, Quaternion.identity);

    }


    void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }



}
