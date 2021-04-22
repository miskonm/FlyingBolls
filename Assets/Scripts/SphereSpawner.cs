using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    #region Variables

    public InputManager inputManager;
    public Sphere spherePrefab;
    public Transform spawnPoint;

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        inputManager.OnSpacePressed += Spawn;
    }

    #endregion


    #region Private methods

    private void Spawn()
    {
        Sphere sphere = Instantiate(spherePrefab);
        sphere.transform.position = spawnPoint.position;
    }

    #endregion
}
