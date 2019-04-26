using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HideMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void Quit()
    {
        Application.Quit();    }
    public void ShowMenu()
    {
        transform.Find("Sound").gameObject.SetActive(true);
    }
   
    public void HideMenu()
    {
        transform.Find("Sound").gameObject.SetActive(false);
    }
}
