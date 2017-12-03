using UnityEngine;
using System.Collections;

public class End : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Application.Quit();

        print("Exit");
    }
}
