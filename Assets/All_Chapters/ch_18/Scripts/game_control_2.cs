using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_control_2 : MonoBehaviour
{

    public GameObject character;

    private void Awake()
    {
        character.AddComponent<character_motion_2_1>();
    }
}
