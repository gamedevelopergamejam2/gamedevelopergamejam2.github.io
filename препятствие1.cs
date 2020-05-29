using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class препятствие1 : MonoBehaviour
{

    public float speed;
    public bool ggj;
    Player player;
    int hgf;
    public int jgfs;
    public GameObject ppp;
    GameObject go;
    GameObject go2;
    public bool ifii;
    public GameObject gg;
    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.FindWithTag("NewPlayer");
        player = go.GetComponent<Player>();
        hgf = player.posugol;

        go2 = GameObject.FindWithTag("Player");
   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, 0, -speed);
    }

    void Update()
    {
        if (transform.position.z < -20)
        {
            Destroy(gameObject);
        }

        if(player.hgfc == true)
        {
            if(!ifii)
            {
                speed = 0;
                ifii = true;
            }
        }
        else
        {
            if (ifii)
            {
                //speed = player.Glspeed;
  
                ifii = false;
            }
           
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
                if (player.nuz == jgfs)
                {
                     Instantiate(gg, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
                     Destroy(gameObject);
                    player.hyfy = true;
                }
                else
                {
                    if (player.nuz != jgfs)
                    {
                        player.gfhrf = true;
                   
                    player.hyfy = false;
                    Instantiate(gg, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
                    Destroy(gameObject);
                }

                }
            
            
            
            
        }

    }
}
