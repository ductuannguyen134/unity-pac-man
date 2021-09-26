using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostStateTest : MonoBehaviour
{
    public Animator blackAnimatorController;
    public Animator redAnimatorController;
    public Animator blueAnimatorController;
    public Animator greenAnimatorController;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            blackAnimatorController.SetTrigger("LeftBlackParam");
            blueAnimatorController.SetTrigger("LeftBlueParam");
            greenAnimatorController.SetTrigger("LeftGreenParam");
            redAnimatorController.SetTrigger("LeftRedParam");
        }
        if (Input.GetKeyDown(KeyCode.D)){
            blackAnimatorController.SetTrigger("RightBlackParam");
            blueAnimatorController.SetTrigger("RightBlueParam");
            greenAnimatorController.SetTrigger("RightGreenParam");
            redAnimatorController.SetTrigger("RightRedParam");
        }
        if (Input.GetKeyDown(KeyCode.W)) {          
            blackAnimatorController.SetTrigger("UpBlackParam");
            blueAnimatorController.SetTrigger("UpBlueParam");
            greenAnimatorController.SetTrigger("UpGreenParam");
            redAnimatorController.SetTrigger("UpRedParam");
        }
        if (Input.GetKeyDown(KeyCode.S)) {           
            blackAnimatorController.SetTrigger("DownBlackParam");
            blueAnimatorController.SetTrigger("DownBlueParam");
            greenAnimatorController.SetTrigger("DownGreenParam");
            redAnimatorController.SetTrigger("DownRedParam");
        }
        if (Input.GetKeyDown(KeyCode.Space)) {           
            blackAnimatorController.SetTrigger("DieBlackParam");
            blueAnimatorController.SetTrigger("DieParam");
            greenAnimatorController.SetTrigger("DieParam");
            redAnimatorController.SetTrigger("DieParam");
        }
        if (Input.GetKeyDown(KeyCode.Z)) {           
            blackAnimatorController.SetTrigger("ScaredParam");
            blueAnimatorController.SetTrigger("ScaredParam");
            greenAnimatorController.SetTrigger("ScaredParam");
            redAnimatorController.SetTrigger("ScaredParam");
        }
        if (Input.GetKeyDown(KeyCode.X)) {
            blackAnimatorController.SetTrigger("RecoverParam");
            blueAnimatorController.SetTrigger("RecoverParam");
            greenAnimatorController.SetTrigger("RecoverParam");
            redAnimatorController.SetTrigger("RecoverParam");
        }
    }
}
