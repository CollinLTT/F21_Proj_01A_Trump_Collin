using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Changer : MonoBehaviour
{
 public void Roll_Character_Scene()
    {
        SceneManager.LoadScene("Scene_Roll_Character");
    }

 public void Main_Menu_Scene()
    {
        SceneManager.LoadScene("Scene_Main_Menu");
    }

}
