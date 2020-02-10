using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject shotprefab;
    void Start()
    {
        /*
        enemy e1;

        e1 = new enemy(0,0);

        
        /*
        enemy e1, e2, e3;

        e1 = new enemy();
        e2 = new enemy();
        e3 = new enemy();

        e1.posx = 0;
        e1.posy = 0;

        e2.posx = 5;
        e2.posy = 0;

        e3.posx = 0;
        e3.posy = 5;*/

        /*
        enemy e1, e2, e3, e4;

        e1 = new enemy(0, 0, 10);
        e2 = new enemy(5, 0, 20);
        e3 = new enemy(0, 5, 40);
        e4 = new enemy(10, 10, 10);
        /*
        Debug.Log("e1 tiene en posx " + e1.posx);
        Debug.Log("e1 tiene en posy " + e1.posy);
        e1.move(1);
        Debug.Log("e1 tiene en posx " + e1.posx);
        Debug.Log("e1 tiene en posy " + e1.posy);
        Debug.Log("e4 tiene en posx " + e4.posx);
        Debug.Log("e4 tiene en posy " + e4.posy);
        e4.move(3);
        Debug.Log("e4 tiene en posx " + e4.posx);
        Debug.Log("e4 tiene en posy " + e4.posy);*/
        /*
        Enemy e1;
        Enemy e4;

        e1 = new Enemy();
        e4 = new Enemy();
        e4.IniPos(-5, -3);

        e1.Posx = 5;

        Debug.Log(e1.Posx);

        e1.Posy = 7;

        Debug.Log(e1.Posy);

        e1.Life = 100;

        Debug.Log(e1.Life);


        Shot s1, s3, s4, s5, s6;
        s1 = new Shot();
        /* 2nd metodo
        s2 = new Shot(0, 1, 0, 0, 5);*/

        ////shot
        /*
        Vector2 d, p;
        d = new Vector2(0, 1);
        p = new Vector2(0, 0);
        s3 = new Shot(d, p, 5.0f);

        Vector2 d2;
        d2 = new Vector2(1, 0);
        s4 = new Shot(d2, p, 5.0f);
        Vector2 d3;
        d3 = new Vector2(1, 1);
        s5 = new Shot(d3, p, 5.0f);
        Vector2 d4;
        d4 = new Vector2(Mathf.Cos(30), Mathf.Sin(30));
        s6 = new Shot(d4, p, 5.0f);
        */
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject right=Instantiate(shotprefab);
            right.GetComponent<Shot>().Direction = new Vector2(1, 0);
            right.GetComponent<Shot>().Velocity = 3;
            GameObject up = Instantiate(shotprefab);
            up.GetComponent<Shot>().Direction = new Vector2(0, 1);
            up.GetComponent<Shot>().Velocity = 3;
            GameObject down = Instantiate(shotprefab);
            down.GetComponent<Shot>().Direction = new Vector2(0, -1);
            down.GetComponent<Shot>().Velocity = 3;
            GameObject left = Instantiate(shotprefab);
            left.GetComponent<Shot>().Direction = new Vector2(-1, 0);
            left.GetComponent<Shot>().Velocity = 3;
        }
    }
}
