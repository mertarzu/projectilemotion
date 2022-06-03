using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] UIController uiController;
    [SerializeField] ObjectSpawner objectSpawner;
    [SerializeField] TargetInputController targetInputController;
    [SerializeField] Player player;
    void InitializeUIController()
    {
        uiController.Initialize();
    }

    private void InitializeObjectSpawner()
    {
        objectSpawner.Initialize();
    }

    private void InitializeTargetInputController()
    {
        targetInputController.Initialize();
    }

    void InitializePlayer()
    {
        player.Initialize();
    }

    public void StartGame()
    {
        InitializeUIController();
        InitializeObjectSpawner();
        InitializeTargetInputController();
        InitializePlayer();      
    }

}
