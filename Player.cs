using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int pos;
    public int posugol2;
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
    public float Glspeed;
    public bool hgfc;
    bool gfh;
    public bool gfh2;
    bool hhuy;
    Animator anim;
    public bool jghtg;
    public int nuz2;
    public bool gfhrf;
    public int nuz;
    public bool hyfy;
    public float Starttime;
    public float Stime;
    public float Stime2;
    public bool ggf;
    public bool jhfc;
    public bool gdus;
    public float gif;
    public bool hlo;
    public bool xlo;
    public bool hu;
    public GameObject Tim;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        Stime = Starttime;
        Stime2 = Starttime;
    }
    public IEnumerator ydyi4()
    {
        yield return new WaitForSeconds(1f);
        hgfc = false;
        ggf = false;

    }
    void Update()
    {
        if(hgfc)
        {
           
            if (!ggf)
            {
             
                StartCoroutine(ydyi4());
                ggf = true;
            }
        }
        if (Stime > 0)
        {
            Stime -= Time.deltaTime;
        }

        if (Stime2 > 0)
        {
            Stime2 -= Time.deltaTime;
        }
        //anim.SetInteger("hhj", posugol);
        //anim.SetInteger("fif", posugol2);
        anim.SetInteger("nuzu", nuz2);
        nuz = nuz2;
        
    }

    
    void FixedUpdate()
    {


        if(!hu)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (Stime < 0)
                {
                    if (!gfh2)
                    {





                        if (jghtg)
                        {


                            if (posugol2 == 2)
                            {
                                posugol = posugol2 - 1;
                            }
                            else
                            {
                                if (posugol2 == 1 && nuz2 == 2)
                                {
                                    posugol = posugol2 - 1;
                                }

                            }


                        }
                        else
                        {
                            if (!jghtg)
                            {


                                if (posugol < 2)
                                {
                                    posugol += 1;
                                }
                                else
                                {

                                    posugol = 0;
                                }




                            }
                        }




                        if (nuz2 < 2)
                        {
                            nuz2 += 1;

                        }
                        else
                        {
                            nuz2 = 0;


                        }

                        jghtg = false;

                        anim.SetBool("gogo", false);
                    }

                    Stime = Starttime;
                }
            }



            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (Stime2 < 0)
                {
                    if (!jhfc)
                    {
                        if (nuz2 > 0)
                        {
                            nuz2 -= 1;

                        }
                        else
                        {
                            nuz2 = 2;


                        }

                        if (!jghtg)
                        {

                            if (posugol2 == 1)
                            {
                                nuz2 = 2;
                            }




                        }
                        else
                        {
                            if (jghtg)
                            {


                                if (posugol2 < 2)
                                {
                                    posugol2 += 1;

                                }
                                else
                                {
                                    posugol2 = 0;


                                }



                            }
                        }



                        jghtg = true;
                        anim.SetBool("gogo", true);



                    }
                    Stime2 = Starttime;
                }
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
