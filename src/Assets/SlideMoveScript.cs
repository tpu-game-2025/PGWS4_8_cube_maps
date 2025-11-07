using UnityEngine;

public class SlideMoveScript : MonoBehaviour
{

    [SerializeField] Camera mainCamera;
    [SerializeField] GameObject targetPoint;
    Vector3 defaultCameraPos;
    [SerializeField] Vector3 cameraMoveDir;
    [SerializeField] float slideSpeed;
    [SerializeField] float slideDistance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        defaultCameraPos = mainCamera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.LookAt(targetPoint.transform);
        mainCamera.transform.position = defaultCameraPos + cameraMoveDir * Mathf.Sin(Time.time * slideSpeed);
    }
}
