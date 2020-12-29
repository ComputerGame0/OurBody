using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetInfo : MonoBehaviour
{
    [SerializeField] Text infoForPlayer;

    // Start is called before the first frame update
    void Start()
    {
        infoForPlayer.text = "Your level score: " + OnTriggerPlayer.Score;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
