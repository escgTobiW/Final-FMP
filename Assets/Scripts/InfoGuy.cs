using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class InfoGuy : MonoBehaviour
{

    public bool nearPlayer = false;

    public TMP_Text Text;


    public float wait = 0;
    bool waitTime = false;

    Animator anim;

    public GameObject player;
    Vector3 playerPos;
    Vector3 startLook;

    public GameObject konbiniTeru;
    bool konbiniTeruExist = true;

    public GameObject dangoTeru;
    bool dangoTeruExist = true;

    public GameObject boxTeru;
    bool boxTeruExist = true;

    public GameObject roofTeru;
    bool roofTeruExist = true;

    public GameObject hangingTeru;
    bool hangingTeruExist = true;

    public GameObject eatenTeru;
    bool eatenTeruExist = true;

    void Start()
    {
        Text.text = "  ";

        anim = GetComponent<Animator>();

    }

    



    void Update()
    {

        playerPos = new Vector3(player.transform.position.x, 0, player.transform.position.z);
        startLook = new Vector3(1.75f, 0f, -1f);

        if (waitTime == true)
        {
            wait += Time.deltaTime;
        }

        if (waitTime == false)
        {
            wait = 0;
        }

        //-------------------------
        if (konbiniTeru.transform.childCount > 0)
        {
            konbiniTeruExist = true;
        }
        else if (konbiniTeru.transform.childCount <= 0)
        {
            konbiniTeruExist = false;
        }
        //-------
        if (dangoTeru.transform.childCount > 0)
        {
            dangoTeruExist = true;
        }
        else if (dangoTeru.transform.childCount <= 0)
        {
            dangoTeruExist = false;
        }
        //-------
        if (boxTeru.transform.childCount > 0)
        {
            boxTeruExist = true;
        }
        else if (boxTeru.transform.childCount <= 0)
        {
            boxTeruExist = false;
        }
        //-------
        if (roofTeru.transform.childCount > 0)
        {
            roofTeruExist = true;
        }
        else if (roofTeru.transform.childCount <= 0)
        {
            roofTeruExist = false;
        }
        //-------
        if (hangingTeru.transform.childCount > 0)
        {
            hangingTeruExist = true;
        }
        else if (hangingTeru.transform.childCount <= 0)
        {
            hangingTeruExist = false;
        }
        //-------
        if (eatenTeru.transform.childCount > 0)
        {
            eatenTeruExist = true;
        }
        else if (eatenTeru.transform.childCount <= 0)
        {
            eatenTeruExist = false;
        }
        //-------------------------

        if (wait > 1.5)
        {
            giveHint();
            waitTime = false;
        }

        //-------------------------
        if (nearPlayer == true)
        {
            transform.LookAt(playerPos, Vector3.up);
        }
        else if (nearPlayer == false)
        {
            transform.LookAt(startLook, Vector3.up);
        }

        if ((Input.GetMouseButtonDown(1) == true) && (nearPlayer == true))
        {
            anim.SetBool("talk", true);
            

            //--------------------------
            if (countText.instance.GetCount() >= 20)
            {

                Text.text = "Still so many to find...";
                waitTime = true;

            }
            //------------
            if ((countText.instance.GetCount() >= 13) && (countText.instance.GetCount() < 20))
            {

                Text.text = "Getting there...";

                waitTime = true;
            }
            //------------
            if ((countText.instance.GetCount() >= 10) && (countText.instance.GetCount() < 13))
            {

                Text.text = "You're over halfway there!";

                waitTime = true;
            }
            //------------
            if ((countText.instance.GetCount() >= 5) && (countText.instance.GetCount() < 10))
            {

                Text.text = "Nearly got them all!";

                waitTime = true;

            }
            //------------
            if ((countText.instance.GetCount() > 0) && (countText.instance.GetCount() < 5))
            {

                Text.text = "Oh, you're so close...!";

                waitTime = true;

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
        if (dangoTeruExist == true)
        {
            Text.text = "Hmmmmm... those dango over there look tasty";

        }

        if ((roofTeruExist == true) && (!dangoTeruExist))
        {
            Text.text = "I hope none of them got stuck up on top of the stalls... that'd be hard to reach";

        }

        if ((eatenTeruExist == true) && (!dangoTeruExist) && (!roofTeruExist))
        {
            Text.text = "Oh...? What...? Uhhhh, someone over there is... eating a Teru Teru Bozu?";

        }

        if ((boxTeruExist == true) && (!dangoTeruExist) && (!roofTeruExist) && (!eatenTeruExist))
        {
            Text.text = "So many boxes around... something is bound to get lost among them all";

        }

        if ((hangingTeruExist == true) && (!dangoTeruExist) && (!roofTeruExist) && (!eatenTeruExist) && (!boxTeruExist))
        {
           
            Text.text = "Some of them might have been hung up wrong... too high or upside down?";

        }

        if ((konbiniTeruExist == true) && (!dangoTeruExist) && (!roofTeruExist) && (!eatenTeruExist) && (!boxTeruExist) && (!hangingTeruExist) )
        {
            Text.text = "Maybe try looking in the NightMart?";

        }

        if ((!konbiniTeruExist) && (!dangoTeruExist) && (!roofTeruExist) && (!eatenTeruExist) && (!boxTeruExist) && (!hangingTeruExist))
        {
            Text.text = "Where could the last ones be... they have to be lying around somewhere, right?";

        }

    }
    
}
