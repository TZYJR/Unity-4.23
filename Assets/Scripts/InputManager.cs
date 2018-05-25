using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {




    void Update()
    {
        KeyboardControl();
    }

    void KeyboardControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireManager.Instance.Fire();
        }
    }
}
