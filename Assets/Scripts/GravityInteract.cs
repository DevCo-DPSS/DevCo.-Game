using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityInteract : MonoBehaviour
{
    public GameObject canvas;
    public PlayerController playerController;

    void Start()
    {
        canvas.SetActive(false);
        playerController = FindAnyObjectByType<PlayerController>();
    }

    // Update is called once per frame
    public void OnInteract()
    {
        canvas.SetActive(true);
        playerController.moveSpeed = 0;
    }

    public void XButton()
    {
        canvas.SetActive(false);
        playerController.moveSpeed = 5;
    }
}
