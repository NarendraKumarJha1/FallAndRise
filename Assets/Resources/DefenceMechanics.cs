using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenceMechanics : MonoBehaviour
{
    public int rotatingSpeed;
    public bool shallRotate;

    private void Start()
    {
        if (shallRotate)
        {
           StartCoroutine(Rotate());
        }
    }
    public IEnumerator Rotate()
    {
        while (true)
        {

            transform.Rotate(new Vector3(0, rotatingSpeed * Time.deltaTime, 0));
            yield return new WaitForSecondsRealtime(0.001f);
        }

    }

}
