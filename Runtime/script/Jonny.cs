using UnityEngine;

public class Jonny : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Jonny script from package has started!");
    }

    void Update()
    {
        // Example behaviour
        transform.Rotate(Vector3.up * Time.deltaTime * 50f);
    }
}
