using UnityEngine;
using UnityEngine.SceneManagement;

public class LastPlatform : MonoBehaviour
{
    public GameObject fox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Not yet");
        if (collision.gameObject == fox) {
            Debug.Log("Entrado");
            SceneManager.LoadScene("Win");
        }
    }
}
