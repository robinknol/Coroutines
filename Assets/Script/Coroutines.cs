using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("Test");
        }
    }

    IEnumerator Test()
    {
        print("Ik start nu de coroutine");

        yield return new WaitForSeconds(0.5f);
        
        print("coroutine update");

        yield return new WaitForSeconds(0.5f);

        print("coroutine einde");
    }
}
