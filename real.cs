using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class real : MonoBehaviour
{
    public int pos;
    public int posugol;
    public int ugol = 90;
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;
    public Transform pos5;
    public Transform pos6;
    public Transform pos7;
    public Transform pos8;
    bool gfh;
    bool gfh2;
    bool hhuy;
    Animator anim;
    public AudioSource tr;
    public GameObject eng;
    public GameObject panal;
    public bool sd;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if(sd)
        {
            ugol = 90;
        }
        else
        {
            switch (pos)
            {
                case 0:
                    transform.rotation = Quaternion.Euler(-9.05f, 0, 0);
                    ugol = 90;
                    transform.position = new Vector3(pos1.position.x, pos1.position.y, pos1.position.z);

                    break;
                case 1:
                    transform.rotation = Quaternion.Euler(0, 0, 60);
                    transform.position = new Vector3(pos2.position.x, pos2.position.y, pos2.position.z);
                    ugol = 45;

                    break;
                case 2:
                    transform.rotation = Quaternion.Euler(0, 0, 90);
                    transform.position = new Vector3(pos3.position.x, pos3.position.y, pos3.position.z);
                    ugol = 0;

                    break;
                case 3:
                    transform.rotation = Quaternion.Euler(0, 0, 120);
                    transform.position = new Vector3(pos4.position.x, pos4.position.y, pos4.position.z);
                    ugol = -45;

                    break;
                case 4:
                    transform.rotation = Quaternion.Euler(-9.05f, 0, 0);
                    transform.position = new Vector3(pos5.position.x, pos5.position.y, pos5.position.z);
                    ugol = 90;

                    break;
                case 5:
                    transform.rotation = Quaternion.Euler(0, 0, -120);
                    transform.position = new Vector3(pos6.position.x, pos6.position.y, pos6.position.z);
                    ugol = 45;

                    break;
                case 6:
                    transform.rotation = Quaternion.Euler(0, 0, -90);
                    transform.position = new Vector3(pos7.position.x, pos7.position.y, pos7.position.z);
                    ugol = 0;

                    break;
                case 7:
                    transform.rotation = Quaternion.Euler(0, 0, -60);
                    transform.position = new Vector3(pos8.position.x, pos8.position.y, pos8.position.z);
                    ugol = -45;

                    break;


            }
        }

        

       
    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (!gfh)
            {
                if (pos < 7)
                {
                    StartCoroutine(ydyi());
                    gfh = true;
                }
                else
                {
                    pos = -1;

                }
                tr.pitch = Random.Range(0.8f, 1.2f);
                tr.Play();
            }

        }


        if (Input.GetKey(KeyCode.A))
        {
            if (!gfh)
            {
                if (pos > 0)
                {
                    StartCoroutine(ydyi2());
                    gfh = true;
                }
                else
                {
                    pos = 8;
                }
                tr.pitch = Random.Range(0.8f, 1.2f);
                tr.Play();
            }

        }

       
    }


    public IEnumerator ydyi()
    {
        pos += 1;
        yield return new WaitForSeconds(0.07f);
        gfh = false;
    }

    public IEnumerator ydyi2()
    {
        pos -= 1;
        yield return new WaitForSeconds(0.07f);
        gfh = false;
    }

    
}

