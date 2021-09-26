using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    //public AudioSource eatPelletSound;
    //public AudioSource movingSound;
    //public AudioSource wallCollisionSound;
    //public AudioSource deathSound;

    public AudioClip thiefNormalSound;
    public AudioClip startSound;
    public AudioSource audioSource;
    public AudioSource carAudioSource;

    private float lastTime = 0.0f;
    public static bool gameIsPaused;
    private float timer = 0.0f;
    private float moveTimer = 0.0f;
    private float seconds = 0.0f;
    [SerializeField]
    private Transform[] transformArray;
    public const float moveWait = 2.0f;
    private IEnumerator coroutine;
    int counter = 0;
    public Animator animationController;

    void Start()
    {
        audioSource.Play();
        ResetTime();
    }

    void Update()
    {
        if(!audioSource.isPlaying)
        {
            Debug.Log("Not Playing");
            audioSource.clip = thiefNormalSound;
            audioSource.Play();
        } 
        else if(audioSource.clip != startSound)
        {
             GameStart();
        }
    }
    
    void GameStart ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spacebar pressed");;
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
        if(!gameIsPaused) {
            lastTime = Mathf.FloorToInt(timer);
            seconds = Mathf.FloorToInt(timer % 60);
            timer += Time.deltaTime;
            moveTimer += Time.deltaTime;
            if(Mathf.FloorToInt(timer) > lastTime){
                Debug.Log($"{seconds + 1}");
            }
            if(moveTimer > moveWait){
                moveTimer = moveTimer - moveWait;
                MoveObjects();
            }
        }
    }

    void PauseGame ()
    {
        if(gameIsPaused)
        {
            Time.timeScale = 0f;
        }
        else 
        {
            Time.timeScale = 1;
        }
    }

    void ResetTime()
    {
        timer = 0;
    }

    void MoveObjects() 
    {
        carAudioSource.Play();
        Tweener tweener = gameObject.GetComponent<Tweener>();
        if(counter < 3){
            if(counter == 0){
                animationController.SetTrigger("RightParam");
                Vector3 endPos = new Vector3(-0.54f, 2.47f, 0f);
                float duration = 1f;
                tweener.AddTween(transformArray[0].transform, transformArray[0].transform.position, endPos, duration);
            }else if(counter == 1){
                animationController.SetTrigger("DownParam");
                Vector3 endPos = new Vector3(-0.48f, -1.62f, 0f);
                float duration = 1f;
                tweener.AddTween(transformArray[0].transform, transformArray[0].transform.position, endPos, duration);
            }else if(counter == 2){
                animationController.SetTrigger("LeftParam");
                Vector3 endPos = new Vector3(-5.46f, -1.62f, 0f);
                float duration = 1f;
                tweener.AddTween(transformArray[0].transform, transformArray[0].transform.position, endPos, duration);
            }
            counter++;
        } else {
            counter = 0;
            animationController.SetTrigger("UpParam");
            Vector3 endPos = new Vector3(-5.46f, 2.47f, 0f);
            float duration = 1f;
            tweener.AddTween(transformArray[0].transform, transformArray[0].transform.position, endPos, duration);
        }
    }   

}
