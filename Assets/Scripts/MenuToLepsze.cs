using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MenuToLepsze : MonoBehaviour
{
     public GameObject gamePoradnik;
     public GameObject gameUstawienia;
     public GameObject gametext;
     public GameObject panelWylaczenia;
     

    public void Graj()
    {
         SceneManager.LoadScene(1);
    }
    public void Poradnik()
    {
       gamePoradnik.SetActive(true);
       gameUstawienia.SetActive(false);
       gametext.SetActive(false);
    }
    public void Ustawienia()
    {
       gamePoradnik.SetActive(false);
       gameUstawienia.SetActive(true);  
       gametext.SetActive(false); 
    }
    public void Wyjdz()
    {
          
          panelWylaczenia.SetActive(true);
    }

    public void discord()
    {
          Application.OpenURL("https://www.youtube.com/");
    }
    public void steam()
    {
         Application.OpenURL("https://www.youtube.com/");
    }
    public void redit()
    {
          Application.OpenURL("https://www.youtube.com/");
    }
    public void twiter()
    {
         Application.OpenURL("https://www.youtube.com/");
    }
    public void arow()
    {
       gamePoradnik.SetActive(false);
       gameUstawienia.SetActive(false);
       gametext.SetActive(true);
    }
    public void tak()
    {
       Application.Quit();
    }
    public void nie()
    {
       panelWylaczenia.SetActive(false);
    }
}
