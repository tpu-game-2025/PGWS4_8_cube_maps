using UnityEngine;

public class mirrorScript : MonoBehaviour
{
    ReflectionProbe reflectionProbe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        reflectionProbe = GetComponent<ReflectionProbe>();
    }

    // Update is called once per frame
    void Update()
    {
        reflectionProbe.RenderProbe();
    }
}
