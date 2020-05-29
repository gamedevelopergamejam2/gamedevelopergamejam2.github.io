using System.Collections;<br>
using System.Collections.Generic;<br>
using UnityEngine;<br>

public class Player : MonoBehaviour<br>
{
    public int pos;<br>
    public int posugol2;<br>
    public int posugol;<br>
    public int ugol = 90;<br>
    public Transform pos1;<br>
    public Transform pos2;<br>
    public Transform pos3;<br>
    public Transform pos4;<br>
    public Transform pos5;<br>
    public Transform pos6;<br>
    public Transform pos7;<br>
    public Transform pos8;<br>
    public float Glspeed;<br>
    public bool hgfc;<br>
    bool gfh;<br>
    public bool gfh2;<br>
    bool hhuy;<br>
    Animator anim;<br>
    public bool jghtg;<br>
    public int nuz2;<br>
    public bool gfhrf;<br>
    public int nuz;<br>
    public bool hyfy;<br>
    public float Starttime;<br>
    public float Stime;<br>
    public float Stime2;<br>
    public bool ggf;<br>
    public bool jhfc;<br>
    public bool gdus;<br>
    public float gif;<br>
    public bool hlo;<br>
    public bool xlo;<br>
    public bool hu;<br>
    public GameObject Tim;<br>
    // Start is called before the first frame update<br>
    void Start()<br>
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
