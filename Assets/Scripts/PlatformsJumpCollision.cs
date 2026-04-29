using UnityEngine;
using UnityEngine.EventSystems;

public class PlatformsJumpCollision : MonoBehaviour
{

    private float oldY;
    private float newY;
    public GameObject fox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        oldY = fox.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        JumpCollision();
    }


    private void JumpCollision()
    {
        newY = fox.transform.position.y;
        if (oldY > newY)
        {
            this.GetComponent<BoxCollider>().isTrigger = false;
        }
        if (oldY < newY)
        {
            this.GetComponent<BoxCollider>().isTrigger = true;
        }

        oldY = newY;
    }
}
