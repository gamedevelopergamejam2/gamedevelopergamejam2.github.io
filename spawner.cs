using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Slider = UnityEngine.UI.Slider;

public class spawner : MonoBehaviour
{
    
    public int pos;
    public float hard;
    public int bee;
    public int doloo;
    int rana;
    public int зел;
    int hgu;
    public int бел;
    int rer;
    public int кра;
    int vov;
    public int син;
    int xox;
    public int ror;
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;
    public Transform pos5;
    public Transform pos6;
    public Transform pos7;
    public Transform pos8;
    public GameObject bob;
    public GameObject bob2;
    public GameObject bob3;
    public GameObject bob4;
    public GameObject bobtime;
    public GameObject bobded;
    bool hgfdy;
    bool fgh;
    bool vvh;
    public int totro = 8;
    int lyt;
    int yoi;
    bool fag;
    bool NONL;
    Player player;
    int hgf;
    GameObject go;
    public int dodf = 20;
    int rsw;
    bool fcr;
    bool jhf;
    bool fds;
    int posa;
    int controj;
    int куе;
    bool gkuy;
    int drew = 5;
    public GameObject eng;
    public GameObject panal;
    public GameObject rule;
    public GameObject back;
    public GameObject Menu;
    public GameObject Tim;
    public AudioMixerGroup Mixer;
    public bool vu;
    public int scened;
    public Slider deee;
    public Slider deee2;
    public Slider deee3;
    // Start is called before the first frame update
    void Start()
    {
        


        go = GameObject.FindWithTag("NewPlayer");
        player = go.GetComponent<Player>();
        hgf = player.posugol;
        
    }

    // Update is called once per frame
    void Update()
    {
        deee.value = PlayerPrefs.GetFloat("awert", 1f);
        deee2.value = PlayerPrefs.GetFloat("dfe", 1f);
        deee3.value = PlayerPrefs.GetFloat("cbn", 1f);
        if (!vu)
        {
            if (!fag)
            {
                StartCoroutine(bhпа());
                fag = true;
            }

            if (!fgh && hard >= 1)
            {
                StartCoroutine(bh());
                fgh = true;
            }

            if (doloo == 0)
            {

                pos = Random.Range(0, 8);
                switch (pos)
                {
                    case 0:
                        if (!hgfdy)
                        {
                            StartCoroutine(pos1b());

                            hgfdy = true;
                        }

                        break;
                    case 1:
                        if (!hgfdy)
                        {
                            StartCoroutine(pos2b());

                            hgfdy = true;
                        }

                        break;
                    case 2:
                        if (!hgfdy)
                        {
                            StartCoroutine(pos3b());

                            hgfdy = true;
                        }

                        break;
                    case 3:
                        if (!hgfdy)
                        {
                            StartCoroutine(pos4b());

                            hgfdy = true;
                        }

                        break;
                    case 4:
                        if (!hgfdy)
                        {
                            StartCoroutine(pos5b());

                            hgfdy = true;
                        }

                        break;
                    case 5:
                        if (!hgfdy)
                        {
                            StartCoroutine(pos6b());

                            hgfdy = true;
                        }

                        break;
                    case 6:
                        if (!hgfdy)
                        {
                            StartCoroutine(pos7b());

                            hgfdy = true;
                        }

                        break;
                    case 7:
                        if (!hgfdy)
                        {
                            StartCoroutine(pos8b());

                            hgfdy = true;
                        }

                        break;


                }
            }
            else
            {
                if (doloo == 1)
                {
                    if (!vvh)
                    {
                        StartCoroutine(Timmme());
                        vvh = true;
                    }
                }
                else
                {
                    if (doloo == 2)
                    {
                        if (!jhf)
                        {
                            StartCoroutine(ded());
                            jhf = true;
                        }
                    }
                }
            }
        }
        

    }


    public void dsa()
    {
        if(куе == 0)
        {

            if (!player.hlo)
            {
                if (!fds)
                {
                    posa = Random.Range(1, 9);
                    fds = true;
                }
                else
                {
                    if (controj < 7)
                    {
                        if (posa < 8)
                        {
                            posa = posa + 1;
                            controj = controj + 1;
                        }
                        else
                        {
                            posa = 0;
                        }
                    }


                }
                if (controj < 7)
                {
                    player.xlo = false;
                    switch (posa)
                    {
                        case 1:
                            Instantiate(bobded, new Vector3(pos1.position.x, pos1.position.y, player.gif), Quaternion.Euler(0, 0, 0));
                            break;
                        case 2:
                            Instantiate(bobded, new Vector3(pos2.position.x, pos2.position.y, player.gif), Quaternion.Euler(0, 0, 45));
                            break;
                        case 3:
                            Instantiate(bobded, new Vector3(pos3.position.x, pos3.position.y, player.gif), Quaternion.Euler(0, 0, 90));
                            break;
                        case 4:
                            Instantiate(bobded, new Vector3(pos4.position.x, pos4.position.y, player.gif), Quaternion.Euler(0, 0, 120));
                            break;
                        case 5:
                            Instantiate(bobded, new Vector3(pos5.position.x, pos5.position.y, player.gif), Quaternion.Euler(0, 0, 0));
                            break;
                        case 6:
                            Instantiate(bobded, new Vector3(pos6.position.x, pos6.position.y, player.gif), Quaternion.Euler(0, 0, -120));
                            break;
                        case 7:
                            Instantiate(bobded, new Vector3(pos7.position.x, pos7.position.y, player.gif), Quaternion.Euler(0, 0, -90));
                            break;
                        case 8:
                            Instantiate(bobded, new Vector3(pos8.position.x, pos8.position.y, player.gif), Quaternion.Euler(0, 0, -45));
                            break;

                    }
                }
                else
                {
                    StartCoroutine(ghy());
                }
            }
        }
        else
        {
            if(куе == 1)
            {
                if (!player.hlo)
                {
                    
                        
                       
                    
                    
                        if (controj < 7)
                        {
                            if (posa < 8)
                            {
                            posa = Random.Range(1, 9);
                            controj = controj + 1;
                            }
                            else
                            {
                                posa = 0;
                            }
                        }


                    
                    if (controj < 7)
                    {
                        player.xlo = false;
                        switch (posa)
                        {
                            case 1:
                                Instantiate(bobded, new Vector3(pos1.position.x, pos1.position.y, player.gif), Quaternion.Euler(0, 0, 0));
                                break;
                            case 2:
                                Instantiate(bobded, new Vector3(pos2.position.x, pos2.position.y, player.gif), Quaternion.Euler(0, 0, 45));
                                break;
                            case 3:
                                Instantiate(bobded, new Vector3(pos3.position.x, pos3.position.y, player.gif), Quaternion.Euler(0, 0, 90));
                                break;
                            case 4:
                                Instantiate(bobded, new Vector3(pos4.position.x, pos4.position.y, player.gif), Quaternion.Euler(0, 0, 120));
                                break;
                            case 5:
                                Instantiate(bobded, new Vector3(pos5.position.x, pos5.position.y, player.gif), Quaternion.Euler(0, 0, 0));
                                break;
                            case 6:
                                Instantiate(bobded, new Vector3(pos6.position.x, pos6.position.y, player.gif), Quaternion.Euler(0, 0, -120));
                                break;
                            case 7:
                                Instantiate(bobded, new Vector3(pos7.position.x, pos7.position.y, player.gif), Quaternion.Euler(0, 0, -90));
                                break;
                            case 8:
                                Instantiate(bobded, new Vector3(pos8.position.x, pos8.position.y, player.gif), Quaternion.Euler(0, 0, -45));
                                break;

                        }
                    }
                    else
                    {
                        StartCoroutine(ghy());
                    }
                }
            }
        }
    }


    public void traj(bool hyt)
    {
        for(lyt = totro; lyt>0; lyt--)
        {
            if(lyt == 8)
            {
                yoi = Random.Range(0, 2);
                if(yoi == 0)
                {
                    Instantiate(bob, new Vector3(pos1.position.x, pos1.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
                }
                else
                {
                    if (yoi == 1)
                    {
                        if (hyt)
                        {
                            Instantiate(bob, new Vector3(pos1.position.x, pos1.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
                        }
                        else
                        {
                            if (!hyt)
                            {
                                Instantiate(bobtime, new Vector3(pos1.position.x, pos1.position.y, transform.position.z), Quaternion.Euler(0, 180, 0));
                                hyt = true;
                            }
                        }
                    }
                }
                
            }
            else
            {
                if (lyt == 7)
                {
                    yoi = Random.Range(0, 2);
                    if (yoi == 0)
                    {
                        Instantiate(bob, new Vector3(pos2.position.x, pos2.position.y, transform.position.z), Quaternion.Euler(0, 0, 45));
                    }
                    else
                    {
                        if (yoi == 1)
                        {
                            if (hyt)
                            {
                                Instantiate(bob, new Vector3(pos2.position.x, pos2.position.y, transform.position.z), Quaternion.Euler(0, 0, 45));
                            }
                            else
                            {
                                if (!hyt)
                                {
                                    Instantiate(bobtime, new Vector3(pos2.position.x, pos2.position.y, transform.position.z), Quaternion.Euler(0, 180, -45));
                                    hyt = true;
                                }
                            }
                        }
                    }
                    
                }
                else
                {
                    if (lyt == 6)
                    {
                        yoi = Random.Range(0, 2);
                        if (yoi == 0)
                        {
                            Instantiate(bob, new Vector3(pos3.position.x, pos3.position.y, transform.position.z), Quaternion.Euler(0, 0, 90));
                        }
                        else
                        {
                            if (yoi == 1)
                            {
                                if (hyt)
                                {
                                    Instantiate(bob, new Vector3(pos3.position.x, pos3.position.y, transform.position.z), Quaternion.Euler(0, 0, 90));
                                }
                                else
                                {
                                    if (!hyt)
                                    {
                                        Instantiate(bobtime, new Vector3(pos3.position.x, pos3.position.y, transform.position.z), Quaternion.Euler(0, 180, -90));
                                        hyt = true;
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        if (lyt == 5)
                        {
                            yoi = Random.Range(0, 2);
                            if (yoi == 0)
                            {
                                Instantiate(bob, new Vector3(pos4.position.x, pos4.position.y, transform.position.z), Quaternion.Euler(0, 0, 120));
                            }
                            else
                            {
                                if (yoi == 1)
                                {
                                    if (hyt)
                                    {
                                        Instantiate(bob, new Vector3(pos4.position.x, pos4.position.y, transform.position.z), Quaternion.Euler(0, 0, 120));
                                    }
                                    else
                                    {
                                        if (!hyt)
                                        {
                                            Instantiate(bobtime, new Vector3(pos4.position.x, pos4.position.y, transform.position.z), Quaternion.Euler(0, 180, -120));
                                            hyt = true;
                                        }
                                    }
                                }
                            }
                           
                        }
                        else
                        {
                            if (lyt == 4)
                            {
                                yoi = Random.Range(0, 2);
                                if (yoi == 0)
                                {
                                    Instantiate(bob, new Vector3(pos5.position.x, pos5.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
                                }
                                else
                                {
                                    if (yoi == 1)
                                    {
                                        if (hyt)
                                        {
                                            Instantiate(bob, new Vector3(pos5.position.x, pos5.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
                                        }
                                        else
                                        {
                                            if (!hyt)
                                            {
                                                Instantiate(bobtime, new Vector3(pos5.position.x, pos5.position.y, transform.position.z), Quaternion.Euler(0, 180, 180));
                                                hyt = true;
                                            }
                                        }
                                    }
                                }
                               
                            }
                            else
                            {
                                if (lyt == 3)
                                {
                                    yoi = Random.Range(0, 2);
                                    if (yoi == 0)
                                    {
                                        Instantiate(bob, new Vector3(pos6.position.x, pos6.position.y, transform.position.z), Quaternion.Euler(0, 0, -120));
                                    }
                                    else
                                    {
                                        if (yoi == 1)
                                        {
                                            if (hyt)
                                            {
                                                Instantiate(bob, new Vector3(pos6.position.x, pos6.position.y, transform.position.z), Quaternion.Euler(0, 0, -120));
                                            }
                                            else
                                            {
                                                if (!hyt)
                                                {
                                                    Instantiate(bobtime, new Vector3(pos6.position.x, pos6.position.y, transform.position.z), Quaternion.Euler(0, 180, 120));
                                                    hyt = true;
                                                }
                                            }
                                            

                                        }
                                    }
                                    
                                }
                                else
                                {
                                    if (lyt == 2)
                                    {
                                        yoi = Random.Range(0, 2);
                                        if (yoi == 0)
                                        {
                                            Instantiate(bob, new Vector3(pos7.position.x, pos7.position.y, transform.position.z), Quaternion.Euler(0, 0, -90));
                                        }
                                        else
                                        {
                                            if (yoi == 1)
                                            {
                                                if (hyt)
                                                {
                                                    Instantiate(bob, new Vector3(pos7.position.x, pos7.position.y, transform.position.z), Quaternion.Euler(0, 0, -90));
                                                }
                                                else
                                                {
                                                    if (!hyt)
                                                    {
                                                        Instantiate(bobtime, new Vector3(pos7.position.x, pos7.position.y, transform.position.z), Quaternion.Euler(0, 180, 90));
                                                        hyt = true;
                                                    }
                                                }
                                            }
                                        }
                                       
                                    }
                                    else
                                    {
                                        if (lyt == 1)
                                        {
                                            if(hyt)
                                            {
                                                Instantiate(bob, new Vector3(pos8.position.x, pos8.position.y, transform.position.z), Quaternion.Euler(0, 0, -45));
                                            }
                                            else
                                            {
                                                if (!hyt)
                                                {
                                                    Instantiate(bobtime, new Vector3(pos8.position.x, pos8.position.y, transform.position.z), Quaternion.Euler(0, 180, 45));
                                                    hyt = true;
                                                }
                                            }

                                            
                                            
                                               
                                            
                                           
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }

    public void fatata(int pov, Transform fg)
    {
        if(bee == 0)
        {
            
                Instantiate(bob, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
               
        }
        else
        {
            if (bee == 1)
            {
                if (ror > 0)
                {
                    rana = Random.Range(0, 4);
                    if (rana == 0)
                    {
                        if (rer > 0)
                        {
                            Instantiate(bob, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                            rer -= 1;
                        }
                        else
                        {
                            if (hgu > 0)
                            {
                                Instantiate(bob2, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                hgu -= 1;
                            }
                            else
                            {

                                if (vov > 0)
                                {
                                    Instantiate(bob3, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                    vov -= 1;
                                }
                                else
                                {
                                    Instantiate(bob4, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                    xox -= 1;
                                }

                            }
                        }

                    }
                    else
                    {
                        if (rana == 1)
                        {
                            if (hgu > 0)
                            {
                                Instantiate(bob2, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                hgu -= 1;
                            }
                            else
                            {
                                if (rer > 0)
                                {
                                    Instantiate(bob, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                    rer -= 1;
                                }
                                else
                                {

                                    if (vov > 0)
                                    {
                                        Instantiate(bob3, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                        vov -= 1;
                                    }
                                    else
                                    {
                                        Instantiate(bob4, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                        xox -= 1;
                                    }

                                }
                            }

                        }
                        else
                        {
                            if (rana == 2)
                            {
                                if (vov > 0)
                                {
                                    Instantiate(bob3, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                    vov -= 1;
                                }
                                else
                                {
                                    if (hgu > 0)
                                    {
                                        Instantiate(bob2, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                        hgu -= 1;
                                    }
                                    else
                                    {
                                        if (rer > 0)
                                        {
                                            Instantiate(bob, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                            rer -= 1;
                                        }
                                        else
                                        {
                                            Instantiate(bob4, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                            xox -= 1;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (rana == 3)
                                {
                                    if (xox > 0)
                                    {
                                        Instantiate(bob4, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                        xox -= 1;
                                    }
                                    else
                                    {
                                        if (hgu > 0)
                                        {
                                            Instantiate(bob2, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                            hgu -= 1;
                                        }
                                        else
                                        {
                                            if (rer > 0)
                                            {
                                                Instantiate(bob, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                                rer -= 1;
                                            }
                                            else
                                            {

                                                Instantiate(bob3, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                                vov -= 1;

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    ror -= 1;
                }
                else
                {
                    ror = 6;
                    hgu = зел;
                    rer = бел;
                    vov = кра;
                    xox = син;
                    rana = Random.Range(0, 4);

                    if (rana == 0)
                    {
                        if (rer > 0)
                        {
                            Instantiate(bob, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                            rer -= 1;
                        }
                        else
                        {
                            if (hgu > 0)
                            {
                                Instantiate(bob2, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                hgu -= 1;
                            }
                            else
                            {

                                if (vov > 0)
                                {
                                    Instantiate(bob3, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                    vov -= 1;
                                }
                                else
                                {
                                    Instantiate(bob4, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                    xox -= 1;
                                }

                            }
                        }

                    }
                    else
                    {
                        if (rana == 1)
                        {
                            if (hgu > 0)
                            {
                                Instantiate(bob2, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                hgu -= 1;
                            }
                            else
                            {
                                if (rer > 0)
                                {
                                    Instantiate(bob, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                    rer -= 1;
                                }
                                else
                                {

                                    if (vov > 0)
                                    {
                                        Instantiate(bob3, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                        vov -= 1;
                                    }
                                    else
                                    {
                                        Instantiate(bob4, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                        xox -= 1;
                                    }

                                }
                            }

                        }
                        else
                        {
                            if (rana == 2)
                            {
                                if (vov > 0)
                                {
                                    Instantiate(bob3, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                    vov -= 1;
                                }
                                else
                                {
                                    if (hgu > 0)
                                    {
                                        Instantiate(bob2, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                        hgu -= 1;
                                    }
                                    else
                                    {
                                        if (rer > 0)
                                        {
                                            Instantiate(bob, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                            rer -= 1;
                                        }
                                        else
                                        {
                                            Instantiate(bob4, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                            xox -= 1;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (rana == 3)
                                {
                                    if (xox > 0)
                                    {
                                        Instantiate(bob4, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                        xox -= 1;
                                    }
                                    else
                                    {
                                        if (hgu > 0)
                                        {
                                            Instantiate(bob2, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                            hgu -= 1;
                                        }
                                        else
                                        {
                                            if (rer > 0)
                                            {
                                                Instantiate(bob, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                                rer -= 1;
                                            }
                                            else
                                            {

                                                Instantiate(bob3, new Vector3(fg.position.x, fg.position.y, transform.position.z), Quaternion.Euler(0, 0, pov));
                                                vov -= 1;

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    public IEnumerator pos1b()
    {
        fatata(0, pos1);
        yield return new WaitForSeconds(hard);
        hgfdy = false;
    }

    public IEnumerator pos2b()
    {
        fatata(45, pos2);

        yield return new WaitForSeconds(hard);
        hgfdy = false;
    }

    public IEnumerator pos3b()
    {
        fatata(90, pos3);
        yield return new WaitForSeconds(hard);
        hgfdy = false;
    }

    public IEnumerator pos4b()
    {
        fatata(120, pos4);
        yield return new WaitForSeconds(hard);
        hgfdy = false;
    }
    public IEnumerator pos5b()
    {

        fatata(0, pos5);
        yield return new WaitForSeconds(hard);
        hgfdy = false;
    }

    public IEnumerator pos6b()
    {
        fatata(-120, pos6);
        yield return new WaitForSeconds(hard);
        hgfdy = false;
    }

    public IEnumerator pos7b()
    {
        fatata(-90, pos7);
        yield return new WaitForSeconds(hard);
        hgfdy = false;
    }

    public IEnumerator pos8b()
    {
        fatata(-45, pos8);
        yield return new WaitForSeconds(hard);
        hgfdy = false;
    }

    public IEnumerator Timmme()
    {
        traj(false);
        yield return new WaitForSeconds(hard+2f);
        vvh = false;
    }

    public IEnumerator ded()
    {
        
            dsa();
            yield return new WaitForSeconds(0.2f);
            jhf = false;
        
        
    }

   

    public IEnumerator ghy()
    {
        player.xlo = true;
        player.gif = 147.9f;
        player.hlo = true;
        yield return new WaitForSeconds(0.3f);
   
        fds = false;
        controj = 0;
        куе = Random.Range(0, 2);
        player.hlo = false;

    }

    public IEnumerator bh()
    {
        hard -= 0.2f;
      
        if (dodf>=10)
        {
            rsw = Random.Range(0, 2);
            if(rsw==0)
            {
                dodf -= 10;
            }
            else
            {
                if (rsw == 1)
                {
                    dodf += 10;
                }
            }

        }
        else
        {
            dodf += 10;
        }

        if (hard < 1.8)
        {
            NONL = true;
        }

        if (hard < 1.4)
        {
            gkuy = true;
        }

        if (hard<2.2)
        {
            fcr = true;
            drew = 40;
        }
        yield return new WaitForSeconds(drew);
        fgh = false;
    }

    public IEnumerator bhпа()
    {
        if(!fcr)
        {
            bee = 0;
        }
        else
        {
            bee = 1;
        }
       
        doloo = 0;
        yield return new WaitForSeconds(dodf);
        if(NONL)
        {
            bee = 2;
            doloo =1;
            yield return new WaitForSeconds((dodf/10)*13- dodf);
            
           
        }
        if (gkuy)
        {
            yield return new WaitForSeconds(1f);
            doloo = 2;
            yield return new WaitForSeconds(dodf);
        }
        fag = false;
    }

    public void ftrew()
    {
        eng.SetActive(false);
        panal.SetActive(true);
        if (!player.hgfc)
        {
            back.SetActive(false);
        }
        else
        {
            Tim.SetActive(false);
        }
        Menu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ftrew2()
    {
        eng.SetActive(true);
        panal.SetActive(false);
        if (!player.hgfc)
        {
            back.SetActive(true);
        }
        else
        {
            Tim.SetActive(true);
        }
        Menu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ftrewdd()
    {
        eng.SetActive(false);
        rule.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ftrewdd2()
    {
        eng.SetActive(true);
        rule.SetActive(false);
        Time.timeScale = 1f;
    }
 

     public void ftreddwdd2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(scened);
    }
    public void Effects (float volum2)
    {
  
        Mixer.audioMixer.SetFloat("Eff", Mathf.Lerp(-80, 0, volum2));
        PlayerPrefs.SetFloat("dfe", volum2);
    }

    public void Music(float volum)
    {
       
        Mixer.audioMixer.SetFloat("Muss", Mathf.Lerp(-80, 0, volum));
        PlayerPrefs.SetFloat("awert", volum);
    }

    public void Master(float volum3)
    {

        Mixer.audioMixer.SetFloat("MyExposedParam", Mathf.Lerp(-80, 0, volum3));
        PlayerPrefs.SetFloat("cbn", volum3);
    }
}
