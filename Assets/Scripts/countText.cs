using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class countText : MonoBehaviour
{

    public static countText instance;
    public int totalTeru = 21;

    public TMP_Text TextCount;

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
        TextCount.text = "Left to find: " + totalTeru;

        if (totalTeru <= 0)
        {
            TextCount.text = "All found!";
        }
    }


}
