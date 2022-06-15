using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rullet : MonoBehaviour
{
    public float spinSpeed = 50;
    public bool isRolling = false;
    public GameObject Arrow;
    Vector3 dirVec = Vector3.down;

    private void Update()
    {
        if (isRolling)
        {
            transform.Rotate(0, 0, spinSpeed);
            float a = Random.Range(0.975f, 3f);
            spinSpeed -= a;
            if(spinSpeed <= 0.5)
            {
                Debug.DrawRay(Arrow.transform.position, dirVec * 4, new Color(1, 0, 1));
                RaycastHit2D Hit = Physics2D.Raycast(Arrow.transform.position, dirVec, 4);
                isRolling = false;
                spinSpeed = 0;
            }
        }
    }

    public void RollingStart()
    {
        isRolling = true;
    }
}
