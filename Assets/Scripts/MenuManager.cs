using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Animator>().SetTrigger("SkipToGameStart");
        }
    }




}
