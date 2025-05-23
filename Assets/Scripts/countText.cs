using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countText : MonoBehaviour
{

    public static countText instance;
    public int totalTeru = 25;

    public TMP_Text TextCount;


    public float wait = 0;
    bool waitTime = false;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

  
    public void SetCount(int one)
    {
        totalTeru = totalTeru - one;
    }

    public int GetCount()
    {
        return totalTeru;
    }



    void Start()
    {
        
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

        TextCount.text = "Left to find: " + totalTeru;

        if (totalTeru <= 0)
        {

            TextCount.text = "All found!";
            waitTime = true;
        }

        if (wait > 3)
        {
            Object.FindFirstObjectByType<AudioManagerScript>().Play("click");
            SceneManager.LoadScene("END");

        }
        
    }


}
