using UnityEngine;

public class CreateMetheors : MonoBehaviour
{
    
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
                GameObject metheor = new GameObject("Metheor");
                metheor.AddComponent<BoxCollider2D>();
        }
    }
}
