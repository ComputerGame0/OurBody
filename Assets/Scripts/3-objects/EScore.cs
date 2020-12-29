using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EScore : MonoBehaviour
{
    [SerializeField] GameObject player = null;
    [SerializeField] float distance = 6f;
    [SerializeField] GameObject in_Box;
    [SerializeField] GameObject in_Box2;

    [SerializeField] public Text Score_Text = null;
    public int score;
  
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Vector3.Distance(player.transform.position, this.transform.position) < distance)
            {
                Debug.Log("e");
                OnTriggerPlayer.Score += 5;
                score = OnTriggerPlayer.Score;
                Destroy(in_Box2.gameObject);
                Destroy(in_Box.gameObject);
                Score_Text.text = "Score:" + score;
            }
        }
        
    }
}
