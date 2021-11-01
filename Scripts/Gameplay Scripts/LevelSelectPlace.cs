using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectPlace : MonoBehaviour
{
  

    private void OnTriggerEnter(Collider other)
    {
        SceneLoader.instance.LoadLevel("Village");
    }
}
