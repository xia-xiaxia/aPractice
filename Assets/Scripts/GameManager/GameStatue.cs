using UnityEngine;

public class GameStatue : MonoBehaviour
{
    public GameObject player;
    public static GameStatue instance;
    public GameObject Box;


    void Start()
    {
        if(instance == null)
            instance = new GameStatue();
        else
            Destroy(gameObject);

    }

    void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Box.GetComponent<BoxControl>().GetGrivity();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            Box.GetComponent<BoxControl>().CloseGrivity();
        }
    }

}
