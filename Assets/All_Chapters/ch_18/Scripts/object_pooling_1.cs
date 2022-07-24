using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_pooling_1 : MonoBehaviour
{
    public List<GameObject> game_objects;
    public Transform start_position;
    int index = 0;
    void Start()
    {
        StartCoroutine(MoveObject());
    }

    IEnumerator MoveObject()
    {
        while (index<game_objects.Count)
        {
            game_objects[index].transform.position = start_position.position;
            game_objects[index].SetActive(true);
            game_objects[index].AddComponent<object_visible_1_1>();
            index = (index + 1) % game_objects.Count;
            yield return new WaitForSeconds(1f);
        }
    }

}
