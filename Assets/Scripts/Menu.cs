using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PauseMenuCoroutine());
    }

    IEnumerator PauseMenuCoroutine()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                pauseMenuUI.SetActive(false);
                yield break;
            }

            yield return null;
        }
    }
}
