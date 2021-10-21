using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pchla : MonoBehaviour
{
    public Flover Flover;
    public Ulei Ulei;

    public GameObject Health;
    private int medosbor = 1;
    public Transform t;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Поиск цветов на сцене
        float dist = Vector3.Distance(t.position, transform.position);
        if(dist >= 16)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x < -7f)
            {
                speed = -speed;
            }
            if (transform.position.x < 8f)
            {
                speed = 2;
            }
        }
        else
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, t.position, step);
        }
        //Активация панели здоровья
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Health.SetActive(true);
        }

        if (medosbor <= 15)
        {
            SborMeda();
        }
    }
    //Сбор меда и отправка его в улей
    public void SborMeda()
    {
        Flover.med -= medosbor;
        medosbor++;

        if (medosbor >= 15)
        {
            Ulei.Sota += medosbor;
        }
    }  

}
