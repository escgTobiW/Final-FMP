using UnityEngine;

public class findingScript : MonoBehaviour
{
   
    public bool nearPlayer = false;
    //public int totalTeru = 10;




    void Start()
    {
        
    }


    void Update()
    {

        if ((Input.GetMouseButtonDown(1) == true) && (nearPlayer == true))
        {

            countText.instance.SetCount(1);

            //make count go down
            //totalTeru--;
            //countText.totalTeru--;

            //make screen text say well done or something

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
