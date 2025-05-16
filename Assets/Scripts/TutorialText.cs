using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialText : MonoBehaviour
{


    public TMP_Text Text;
    int count = 0;

    public GameObject ContinueText;

    Animator anim;

    void Start()
    {
        Text.text = "  ";

        anim = GetComponent<Animator>();
    }

   
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Return) == true)
        {
            count++;
            anim.SetBool("talk", true);
        }

        if (count == 1)
        {
            ContinueText.SetActive(false);
            Text.text = "Thank you for agreeing to help out!";
        }

        if (count == 2)
        {
            Text.text = "Remember, you can use WASD or the arrow keys to move";
        }

        if (count == 3)
        {
            Text.text = "...and if you want to jump, then use the space key!";
        }

        if (count == 4)
        {
            Text.text = "Once you spot a teru teru bozu, stand near it and use the right mouse button to collect it!";
        }

        if (count == 5)
        {
            Text.text = "This button can also be used to interact with me!";

        }

        if (count == 6)
        {
            Text.text = "Now then...";

        }

        if (count == 7)
        {
            Text.text = "It's time for you to start looking!";

        }

        if (count == 8)
        {
            Text.text = "Good luck! Please don't hesitate to ask me if you need advice!";

        }

        if (count == 9)
        {
            SceneManager.LoadScene("MAIN");

        }

    }
}
