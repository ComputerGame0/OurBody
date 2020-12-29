using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class ClickOnLevel : MonoBehaviour
{
   
   // [SerializeField] float rayLength = 100f;
   // [SerializeField] float rayDuration = 1f;
   // [SerializeField] Color rayColor = Color.white;
    [SerializeField] string sceneNameLevel1;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray rayFromCameraToClickPosition = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;
            bool hasHit = Physics.Raycast(rayFromCameraToClickPosition, out hitInfo);
            if (hasHit)
            {
                if (hitInfo.collider.tag == "ToLevel1")
                {
                    Debug.Log("level1click");
                    SceneManager.LoadScene(sceneNameLevel1);
                }
               
            }
        }
    }
}
