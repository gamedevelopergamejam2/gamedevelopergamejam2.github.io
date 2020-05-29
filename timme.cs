using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timme : MonoBehaviour
{
    Player player;
    int hgf;
    GameObject go;
    public float speed;
    public bool ifii;
    public GameObject gg;

    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.FindWithTag("NewPlayer");
        player = go.GetComponent<Player>();
        hgf = player.posugol;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, 0, speed);
    }

    void Update()
    {
        if (transform.position.z < -20)
        {
            Destroy(gameObject);
        }

        if (player.hgfc == true)
        {
            if (!ifii)
            {
                speed = 0;
                ifii = true;
            }
        }
        else
        {
            if (ifii)
            {
               // speed = player.Glspeed;
  
                ifii = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(gg, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
            player.hgfc = true;
            Destroy(gameObject);
        }

    }
}
