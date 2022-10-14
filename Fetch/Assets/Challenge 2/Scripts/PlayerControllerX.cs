using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timePassed = 0.25f;
    // Update is called once per frame
    void Update()
    {
        if (timePassed >= 0)
        {
            timePassed -= Time.deltaTime;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timePassed < 0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timePassed = 0.25f;
        }
    }
}
