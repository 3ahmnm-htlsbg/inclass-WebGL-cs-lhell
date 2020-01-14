using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movingBall : MonoBehaviour
{
    public GameObject football;
        [SerializeField] private GameObject[] footballPositions;
        
    private int RandomNumbers(){
    
            return Random.Range(0,4);
    
        }
        
        
    public void randomNumbersTwo(){
    
            football.transform.position = footballPositions[RandomNumbers()].transform.position;
            
        }
}
