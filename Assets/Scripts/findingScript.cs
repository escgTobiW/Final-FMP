using UnityEngine;

public class findingScript : MonoBehaviour
{
   
    public bool nearPlayer = false;
    //public int totalTeru = 10;

    public GameObject Confetti;

    public float wait = 0;
    bool waitTime = false;

    void Start()
    {
        Confetti.SetActive(false);
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

        if ((Input.GetMouseButtonDown(1) == true) && (nearPlayer == true))
        {

            //make count go down
            countText.instance.SetCount(1);


            Confetti.SetActive(true);
            
  

            waitTime = true;

            
        }

        if (wait > 0.7f)
        {
            
            waitTime = false;

            //make object go away
            Destroy(gameObject);
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

        }
    }

}
