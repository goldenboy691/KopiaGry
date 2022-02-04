using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;


public class EscMenu : MonoBehaviour
{
   public GameObject escPanel;
   public GameObject consol;
   void Start()
   {
        kb = Keyboard.current;   
   }
   
      
   Keyboard kb;
   public void Update()
   {
       if(kb.escapeKey.isPressed)
       {
           escPanel.SetActive(true);
           Time.timeScale = 0;
       }else
       {
           escPanel.SetActive(false);
           Time.timeScale = 1;
       }
       if(kb.tabKey.isPressed)
       {
           consol.SetActive(true);
       }
       
   }
   public void Tak()
   {
       SceneManager.LoadScene(0);
   }
      

   public void ZamknijKonsole()
   {  
           consol.SetActive(false);
   }
}
