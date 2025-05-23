using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EndScript : MonoBehaviour
{
    public GameObject ContinueText;

    public float wait = 0;
    bool waitTime = false;

    void Start()
    {
        ContinueText.SetActive(false);
        waitTime = true;
    }


    void Update()
    {

        if (waitTime == true)
        {
            wait += Time.deltaTime;
        }

        if (waitTime == false)
        {
            wait = 0;
        }

        

        if (Input.GetKeyDown(KeyCode.Return) && (wait > 2) == true)
        {
            Object.FindFirstObjectByType<AudioManagerScript>().Play("click");
            SceneManager.LoadScene("MENU");
        }

        if (wait > 2)
        {
            ContinueText.SetActive(true);
            
        }
    }
}
