using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private Tween activeTween;
    //private List<Tween> activeTweens = new List<Tween>();

    // Start is called before the first frame update
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    

                if(activeTween != null)
                {
                        float distance = Vector3.Distance(activeTween.Target.position, activeTween.EndPos);
                    if(distance > 0.1f)
                    {
                        float time = (Time.time - activeTween.StartTime)/activeTween.Duration;
                        Vector3 interpolatedPosition = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, time);
                        activeTween.Target.position = interpolatedPosition;
                    }
                    else 
                    {
                        activeTween.Target.position = activeTween.EndPos;
                        activeTween = null;
                    }
                } else {
                    //do nothing
                }

    }

    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration) 
    {

        if(activeTween == null)
        {
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
    }
}
