using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;



public class ELife : MonoBehaviour
{
    [SerializeField] GameObject player=null;
    [SerializeField] float distance = 6f;
   

    [SerializeField] GameObject heart_in_box;
    [SerializeField] public GameObject newLife;

    GameObject[] Heart;
    [SerializeField] Vector3 [] Heartposition;


    // Start is called before the first frame update
    void Start()
    {
        GameObject thePlayer = GameObject.Find("Player");
        OnTriggerPlayer playerScript = thePlayer.GetComponent<OnTriggerPlayer>();
        Heart = playerScript.Heart;
       // Heartposition = new Vector3[3];
        //newLife.GetComponent<Renderer>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Vector3.Distance(player.transform.position, this.transform.position) < distance)
            {
                Debug.Log("e");
                Destroy(heart_in_box.gameObject);
                /*    score !!!
                OnTriggerPlayer.Score += 2;
                score =OnTriggerPlayer.Score;
                Destroy(in_Box2.gameObject);
                Destroy(in_Box.gameObject);
                Score_Text.text = "Score:" + score;
                
                */
                //newLife.position = this.transform.position;


                //newLife.GetComponent<Renderer>().enabled = true;
                if (Heart[1] == null)
                {

                    Heart[1] = newLife;
                    newLife.transform.position = player.transform.position;
                     Debug.Log(Heartposition[1] + "  Heartposition[1]");
                    Debug.Log(newLife.transform.position+ " newLife.transform.position");
                   

                }
                else
                {
                    if (Heart[0] == null)
                    {
                       
                       Heart[0] = newLife;
                       
                         newLife.transform.position = player.transform.position;
                      
                        Debug.Log(newLife.transform.position + " newLife.transform.position");

                    }
                }
                
                
            }
        }
        
    }
}
