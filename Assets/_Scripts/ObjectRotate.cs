using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{

    public float timeofRotate = 2f;

    public float rotationAmount = 5f;

    public float anglePause = 90;
    private float rotationCounter = 0f;
    private bool rotateWaitTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update() {
        if (!rotateWaitTime){
            transform.Rotate(new Vector3(0, rotationAmount , 0));
            rotationCounter += 5;
            if (rotationCounter == anglePause && !rotateWaitTime){
                rotateWaitTime = true;
                StartCoroutine(RotateObserver());
            }
        }
    }

    IEnumerator RotateObserver(){
        yield return new WaitForSeconds(timeofRotate);
        rotateWaitTime = false;
        rotationCounter = 0;
    }
}
