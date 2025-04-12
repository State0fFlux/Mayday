using Unity.VisualScripting;
using UnityEngine;

public class WaterRaiser : MonoBehaviour
{
    public float growthRate = 0.05f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        gameObject.transform.localPosition += new Vector3(0,growthRate * Time.fixedDeltaTime,0);
    }
}
