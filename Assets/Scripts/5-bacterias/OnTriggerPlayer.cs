using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class OnTriggerPlayer : MonoBehaviour
{

    [SerializeField] string triggeringTag_good;
    [SerializeField] string triggeringTag_bad;
    [SerializeField] string sceneName;

    [SerializeField] public GameObject[] Heart=new GameObject[3];
    /*
    [SerializeField] GameObject heartLeft;
    [SerializeField] GameObject heartRight;
    [SerializeField] GameObject heartMiddle;
    */
    [SerializeField] public Text Score_Text = null;
    public static int Score;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == triggeringTag_good)
        {
           
            Debug.Log(collision.gameObject.name);
            Destroy(collision.gameObject);
            Score = Score + 1;
            Score_Text.text = "Score:" + Score;
            Debug.Log("Score "+Score);
        }
        if (collision.tag == triggeringTag_bad)
        {
           
            
            Debug.Log("badddd");

            if (Heart[0] != null)  //heartLeft.GetComponent<Renderer>().enabled) 
            {
                Debug.Log("destroy left");
                //heartLeft.GetComponent<Renderer>().enabled = false;
                Destroy(Heart[0].gameObject);
            }
            else
            {
                Debug.Log("no left");
                if (Heart[1] != null)  // 
                {
                    Debug.Log("destroy middle");

                    //heartMiddle.GetComponent<Renderer>().enabled = false;
                    Destroy(Heart[1].gameObject);
                }
                else
                {
                    if (Heart[2] != null)
                    {
                        //heartRight.GetComponent<Renderer>().enabled = false;
                         Destroy(Heart[2].gameObject);
                        Debug.Log(collision.gameObject.name);
                        Score = 0;
                        SceneManager.LoadScene(sceneName);
                    }
                }
            }
          

        }
            
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
