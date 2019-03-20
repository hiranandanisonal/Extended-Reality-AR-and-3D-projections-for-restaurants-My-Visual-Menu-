using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

// using System.Diagnostics;
using System;

public class Menuuu : MonoBehaviour
{
   public void ChangeScene(string sceneName)
   {
       Application.LoadLevel(sceneName);
   }
}
