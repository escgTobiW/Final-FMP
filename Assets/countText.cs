using UnityEngine;

public class countText : MonoBehaviour
{

    public static countText instance;
    public int totalTeru = 10;

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
        
    }

    /*
  
    private void OnGUI()
    {
        //read variable from LevelManager singleton
        int score = LevelManager.instance.GetHighScore();

        string text = "High score: " + score;

        // define debug text area
        GUI.contentColor = Color.white;
        GUILayout.BeginArea(new Rect(10f, 10f, 1600f, 1600f));
        GUILayout.Label($"<size=24>{text}</size>");
        GUILayout.EndArea();
    }

    */
}
