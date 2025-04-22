using UnityEngine;

public class wiggle : MonoBehaviour
{
    // Update is called once per frame

    private float seed_X;
    private float seed_Y;
    private float seed_Z;
    private Vector3 defaultPosition;

    public Vector3 multiplier = Vector3.one;


    private void Start()
    {
        defaultPosition = transform.position;
        var seed = GetInstanceID();


        seed_X = Random.value*seed +  defaultPosition.x;
        seed_Y = Random.value * seed_X +  defaultPosition.y;
        seed_Z =  Random.value * seed_Y+  defaultPosition.z;

        
    }

    void Update()
    {
        float time = Time.time;
        Vector3 displacement = Vector3.zero;

        displacement.x = Mathf.Lerp(-multiplier.x, multiplier.x, Mathf.PerlinNoise(seed_X, time)) + defaultPosition.x;
        displacement.y = Mathf.Lerp(-multiplier.y,multiplier.y, Mathf.PerlinNoise(seed_Y, time)) + defaultPosition.y;
        displacement.z = Mathf.Lerp(-multiplier.z,multiplier.z, Mathf.PerlinNoise(seed_Z, time)) + defaultPosition.z;

        transform.position = displacement;
    }
}
