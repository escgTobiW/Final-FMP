using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroText : MonoBehaviour
{

    public TMP_Text Text;
    int count = 0;

    public Image Teru;

    public GameObject ContinueText;

    void Start()
    {
        Teru.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) == true)
        {
            count++;
            Object.FindFirstObjectByType<AudioManagerScript>().Play("click");
        }

        if (count == 1)
        {
            ContinueText.SetActive(false);
            Text.text = "The Night Market should be opening soon...";
        }

        if (count == 2)
        {
            Text.text = "...but it looks like it's going to rain.";
        }

        if (count == 3)
        {
            Text.text = "If that happens, the market will have to close.";
        }

        if (count == 4)
        {
            Teru.enabled = true;
            Text.text = "Find the teru teru bozu that have been lost around the market...";
        }

        if (count == 5)
        {
            Text.text = "With them, maybe the rain can be prevented!";

        }

        if (count == 6)
        {
            SceneManager.LoadScene("BEGIN");

        }
       
    }


}
