using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHazard : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    public float follow_Distance = 0.5f;
    public float slither_Factor = 2f;

    void Update()
    {
        if (target != null)
        {
            // direction to the target
            Vector3 direction = (target.position - transform.position).normalized;
            // slithering effectt
            float slitherOffset = Mathf.Sin(Time.time * slither_Factor) * 0.5f;
            Vector3 slitherMovement = transform.right * slitherOffset;

            // move smoothly (using lerp)
            transform.position = Vector3.Lerp(transform.position, target.position - (direction * follow_Distance), speed * Time.deltaTime) + slitherMovement;

            // rotate towards the target
            transform.LookAt(target);
        }
    }
}
