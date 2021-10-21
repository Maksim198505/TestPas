using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flover : MonoBehaviour
{
    public int med = 150;
    public GameObject parent;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDestroy() 
    { 
        Destroy(this.gameObject);
        
    }
    //Получение дочерних объектов списка
    public GameObject get_child_by_name(GameObject parent, string name) 
    {
        Transform[] children = parent.GetComponentsInChildren<Transform>();

        foreach (Transform t in children)
        {
            if(t.gameObject.name == name)
            {
                return t.gameObject;
            }
        }
        return null;
    }
}
