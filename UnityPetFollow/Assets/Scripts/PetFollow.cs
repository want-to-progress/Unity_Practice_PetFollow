using UnityEngine;

public class PetFollow : MonoBehaviour
{
    [Header("速度"), Range(0, 1000)]
    public float speed = 5.5f;

    private Transform target;

    private void Start()
    {
        target = GameObject.Find("跟隨座標").transform;
    }

    private void LateUpdate()
    {
        Follow();
    }

    private void Follow()
    {
        Vector3 posTarget = target.position;
        Vector3 posPet = transform.position;

        transform.position = Vector3.Lerp(posPet, posTarget, 0.5f * speed * Time.deltaTime);
        
        posTarget.y = transform.position.y;
        transform.LookAt(posTarget);
    }
}
