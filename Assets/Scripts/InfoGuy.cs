using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class InfoGuy : MonoBehaviour
{

    public bool nearPlayer = false;

    public TMP_Text Text;

    public int clickA = 1;
    public int clickB = 1;
    public int clickC = 1;
    public int clickD = 1;
    public int clickE = 1;

    public float wait = 0;
    bool waitTime = false;

    Animator anim;

    public GameObject konbiniTeru;
    bool konbiniTeruExist = true;

    void Start()
    {
        Text.text = "  ";

        anim = GetComponent<Animator>();

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

        if (konbiniTeru.transform.childCount > 0)
        {
            konbiniTeruExist = true;
        }
        else if (konbiniTeru.transform.childCount <= 0)
        {
            konbiniTeruExist = false;
        }

        if ((Input.GetMouseButtonDown(1) == true) && (nearPlayer == true))
        {
            anim.SetBool("talk", true);
            

            //--------------------------
            if (countText.instance.GetCount() >= 20)
            {

              
                Text.text = "Still so many to find...";
                waitTime = true;

                if (wait > 1.5)
                {
                    giveHint();
                    waitTime = false;
                }
             

                
            }
            //------------
            if ((countText.instance.GetCount() >= 13) && (countText.instance.GetCount() < 20))
            {
              
                Text.text = "Getting there...";

                waitTime = true;

                if (wait > 1.5)
                {
                    giveHint();
                    waitTime = false;
                }

            }
            //------------
            if ((countText.instance.GetCount() >= 10) && (countText.instance.GetCount() < 13))
            {
                
                    Text.text = "You're over halfway there!";

                    waitTime = true;

                    if (wait > 1.5)
                    {
                        giveHint();
                        waitTime = false;
                    }

            }
            //------------
            if ((countText.instance.GetCount() >= 5) && (countText.instance.GetCount() < 10))
            {
                if (clickD == 1)
                {
                    Text.text = "Nearly got them all!";
                    clickD = 2;
                }

                if (clickD == 2)
                {
                    giveHint();
                    clickD = 1;
                }
                
            }
            //------------
            if ((countText.instance.GetCount() > 0) && (countText.instance.GetCount() < 5))
            {
                if (clickE == 1)
                {
                    Text.text = "Oh, you're so close...!";
                    clickE = 2;
                }

                if (clickE == 2)
                {
                    giveHint();
                    clickE = 1;
                }
                
            }
            //------------
            if (countText.instance.GetCount() == 0)
            {
                Text.text = "Well done!";
            }
            //--------------------------
        }

    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nearPlayer = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nearPlayer = false;
            Text.text = "  ";
            anim.SetBool("talk", false);

        }
    }

    private void giveHint()
    {
    

        if (konbiniTeruExist == true)
        {
            Text.text = "Maybe try looking in the NightMart?";
         
        }

    }
    
}
