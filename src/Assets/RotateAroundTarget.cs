using UnityEngine;

public class RotateAroundTarget : MonoBehaviour
{
    public Transform target;

    public float rotationSpeed = 10.0f;

    void Update()
    {
        if (target == null)
        {
            Debug.LogWarning("ターゲットが設定されていません。");
            return;
        }

        transform.RotateAround(target.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}     