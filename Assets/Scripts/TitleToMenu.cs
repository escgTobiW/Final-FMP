using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleToMenu : MonoBehaviour
{

    Animator anim;
    
    public GameObject Logo;
    public GameObject ContinueText;

    public GameObject Buttons;


    public float wait = 0;
    bool waitTime = false;



    void Start()
    {
        anim = GetComponent<Animator>();
        Buttons.SetActive(false);
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

        if (Input.GetKeyDown(KeyCode.Return) == true)
        {
            Logo.SetActive(false);
            ContinueText.SetActive(false);
            anim.SetBool("move", true);
            waitTime = true;

        }

        if (wait > 4)
        {
            Buttons.SetActive(true);
            waitTime = false;
        }

    }
}
