using UnityEngine;

public class BoxControl : MonoBehaviour
{
    public Rigidbody2D boxRb;
    void Start()
    {
        boxRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    public void Close()
    {
        boxRb.Sleep();
    }

    public void OpenRb()
    {
        boxRb.WakeUp();
    }

    public void GetGrivity()
    {
        boxRb.gravityScale = 1;
    }

    public void CloseGrivity()
    {
        boxRb.gravityScale = 0;
    }
}
