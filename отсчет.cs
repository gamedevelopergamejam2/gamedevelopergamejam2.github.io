using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class отсчет : MonoBehaviour
{
    public  int moneycount;
    private Text moneycounter;
    public bool tjtj;
    Player player;
    int hgf;
    bool ijfi;
    GameObject go;
    public GameObject gg;
    public GameObject hty;
    public AudioSource tr;
    public AudioSource ded;
    bool fj;
    public GameObject eng;
    public GameObject Tim;
    // Start is called before the first frame update
    void Start()
    {
        moneycounter = GetComponent<Text>();

        go = GameObject.FindWithTag("NewPlayer");
        player = go.GetComponent<Player>();
        hgf = player.posugol;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.gdus)
        {
            StartCoroutine(ydyi5());
            player.gdus = false;
        }
        if (moneycount < 0)
            {
          if(!fj)
            {
                eng.SetActive(false);
                ded.Play();
                fj = true;
            }
            
            Instantiate(gg, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), Quaternion.identity);
            StartCoroutine(restart());
                Destroy(hty);
            }
            if (moneycount >= 0)
            {
                moneycounter.text = moneycount + "";
            }
            if (!player.hyfy)
            {
            if (!player.hgfc)
            {
                //Tim.SetActive(false);
                if (player.gfhrf)
                {
                    StartCoroutine(ydyi());
                    player.gfhrf = false;
                }
                else
                {
                    if (!tjtj)
                    {
                        StartCoroutine(ydyi3());
                        tjtj = true;
                    }
                }
            }
            else
            {
               
            }
            
            }

            else
            {
                
               
                   
                
                if (!ijfi)
                    {
                if (!player.hgfc)
                {
                    StartCoroutine(ydyi2());
                    ijfi = true;
                }
                else
                {
                    StartCoroutine(ydyi22());
                    ijfi = true;

                }
            }
                    else
                    {
                        if (!tjtj)
                        {
                        if (!player.hgfc)
                        {
                        Tim.SetActive(false);
                        StartCoroutine(ydyi3());
                            tjtj = true;
                        }
                        }
                    }


                
            }
        
        
       
    }

  

    public IEnumerator ydyi3()
    {
        yield return new WaitForSeconds(1f);
        moneycount -= 1;

        tjtj = false;
    }
    public IEnumerator ydyi()
    {
       
        yield return new WaitForSeconds(0.1f);
        moneycount -= 1;
        tr.pitch = Random.Range(0.4f, 0.8f);
        tr.Play();
        yield return new WaitForSeconds(0.1f);
        tr.pitch = Random.Range(0.4f, 0.8f);
        tr.Play();
        moneycount -= 1;
        yield return new WaitForSeconds(0.1f);
        moneycount -= 1;
        tr.pitch = Random.Range(0.4f, 0.8f);
        tr.Play();
        yield return new WaitForSeconds(1f);

    }

    public IEnumerator ydyi2()
    {
        tr.pitch = Random.Range(0.8f, 1.2f);
        tr.Play();
        yield return new WaitForSeconds(0.1f);
        tr.pitch = Random.Range(0.8f, 1.2f);
        tr.Play();
        moneycount += 1;
        yield return new WaitForSeconds(0.1f);
        moneycount += 1;
        tr.pitch = Random.Range(0.8f, 1.2f);
        tr.Play();
        yield return new WaitForSeconds(0.1f);
        moneycount += 1;
        
        yield return new WaitForSeconds(1f);

        ijfi = false;
        player.hyfy = false;
    }
    public IEnumerator ydyi22()
    {
        tr.pitch = Random.Range(0.8f, 1.2f);
        tr.Play();
        yield return new WaitForSeconds(0.1f);
        moneycount += 1;
        tr.pitch = Random.Range(0.8f, 1.2f);
        tr.Play();
        yield return new WaitForSeconds(0.1f);
        moneycount += 1;
        tr.pitch = Random.Range(0.8f, 1.2f);
        tr.Play();
        yield return new WaitForSeconds(0.1f);
        moneycount += 1;
       
        ijfi = false;
    }

    public IEnumerator ydyi5()
    {
        tr.pitch = Random.Range(0.42f, 0.4f);
        tr.Play();
        moneycount = moneycount/2;
        yield return new WaitForSeconds(0f);
       
    }

    public IEnumerator restart()
    {


        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);


    }
}
