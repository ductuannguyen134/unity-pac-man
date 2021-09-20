using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCar : MonoBehaviour
{
    public Animator animatorController;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
            animatorController.SetTrigger("LeftParam");
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
            animatorController.SetTrigger("RightParam");
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
            animatorController.SetTrigger("UpParam");
        if (Input.GetKeyDown(KeyCode.DownArrow)) 
            animatorController.SetTrigger("DownParam");
    }
}
