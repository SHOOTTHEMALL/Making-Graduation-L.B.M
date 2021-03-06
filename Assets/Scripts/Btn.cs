using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Btn : MonoBehaviour
{
    public List<GameObject> images = new List<GameObject>();
    int current = 0;

    public void LeftBtn()
    {
        if (current == 0) return;

        images[current].gameObject.SetActive(false);
        images[current -1].gameObject.SetActive(true);
        current--;
    }

    public void RightBtn()
    {
        if (current == images.Count -1) return;

        images[current].gameObject.SetActive(false);
        images[current + 1].gameObject.SetActive(true);
        current++;
    }

    public void Return()
    {
        SceneManager.LoadScene(0);
    }
}
