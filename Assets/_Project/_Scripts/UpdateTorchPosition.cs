using UnityEngine;


[ExecuteAlways, ExecuteInEditMode]
public class UpdateTorchPosition : MonoBehaviour
{
    private void Update()
    {
        Shader.SetGlobalVector("_VisibilitySphereCoords", transform.position);
    }
}
