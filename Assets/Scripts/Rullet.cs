using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rullet : MonoBehaviour
{
    public float spinSpeed = 50;
    public bool isRolling = false;
    public GameObject Arrow;
    Vector3 dirVec;
    float a;
    float b;

    private void Start()
    {
        dirVec = Vector3.down;
        a = Random.Range(0.975f, 3f);
        b = Random.Range(1, 3);
    }

    private void Update()
    {
        if (isRolling)
        {
            spinSpeed -= a;
            transform.Rotate(0, 0, spinSpeed);

            if(spinSpeed <= 0.5)
            {
                Debug.DrawRay(Arrow.transform.position, dirVec * 4, new Color(1, 0, 1));
                RaycastHit2D Hit = Physics2D.Raycast(Arrow.transform.position, dirVec, 4);
                isRolling = false;
                spinSpeed = 0;
                //Hit.collider.gameObject.SetActive(false);
                //Debug.Log(Hit.collider.gameObject.name);

                if (b == 1)
                    SceneManager.LoadScene(1);
                else if (b == 2)
                    SceneManager.LoadScene(2);
                else
                    SceneManager.LoadScene(3);

            }
        }
    }

    public void RollingStart()
    {
        isRolling = true;
    }
}
