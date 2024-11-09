using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainscript : MonoBehaviour
{
    private float bullshit;
    public Rigidbody2D player;
    bool yerde = false;
    bool gravitybenderalindi = false;
    public AudioSource jumpsound;
    public AudioSource flagsound;
    public AudioSource deathsound;
    public AudioSource coinsound;
    bool gamefinished = false;
    public GameObject flag;
    public GameObject flag2;
    public GameObject flag3;
    public GameObject flag4;
    public GameObject flag5;
    public GameObject flag6;
    public GameObject allbarriers;
    public GameObject greenbarrier;
    public GameObject ghostplane;


    private void FixedUpdate()
    {
            GameObject.FindWithTag("rotate").GetComponent<Rigidbody2D>().transform.Rotate(0, 0, -0.5f);
            GameObject.FindWithTag("rotate2").GetComponent<Rigidbody2D>().transform.Rotate(0, 0, -0.5f);
            GameObject.FindWithTag("rotate3").GetComponent<Rigidbody2D>().transform.Rotate(0, 0, -0.5f);
    }

    void Update()
    {
        if (gamefinished == false)
        {
            if (gravitybenderalindi == false)
            {
                if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(4, GetComponent<Rigidbody2D>().velocity.y);
                    GetComponent<Rigidbody2D>().transform.rotation = Quaternion.Euler(0, 180, 0);
                }
                if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(-4, GetComponent<Rigidbody2D>().velocity.y);
                    GetComponent<Rigidbody2D>().transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space))
                {
                    if (yerde == true)
                    {
                        jumpsound.Play();
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 6.5f);
                        yerde = false;
                    }
                }
            }


            if(gravitybenderalindi == true)
            {
                if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(4, GetComponent<Rigidbody2D>().velocity.y);
                    GetComponent<Rigidbody2D>().transform.rotation = Quaternion.Euler(0, 0, 180);
                }
                if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(-4, GetComponent<Rigidbody2D>().velocity.y);
                    GetComponent<Rigidbody2D>().transform.rotation = Quaternion.Euler(0, 180, 180);
                }
                if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space))
                {
                    if (yerde == true)
                    {
                        jumpsound.Play();
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -6.5f);
                        yerde = false;
                    }
                }
            }


            bullshit += 50 * Time.deltaTime;
            if (bullshit % 100 >= 50)
            {
                ghostplane.SetActive(false);
            }
            else
            {
                ghostplane.SetActive(true);
            }
        }

        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Invoke("lvlagain", 0.5f);
        }
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Coin")
        {
            coinsound.Play();
            Destroy(collision.gameObject);
        }

        if (collision.collider.tag == "Enemy")
        {
            deathsound.Play();
            gamefinished = true;
        }
        if (collision.collider.tag == "Flag")
        {
            flagsound.Play();
            Invoke("lvltwo", 0f);
            lvlsscript.lvl1 = true;
        }
        if (collision.collider.tag == "Flag2")
        {
            flagsound.Play();
            Invoke("lvlthree", 0f);
            lvlsscript.lvl2 = true;
        }
        if (collision.collider.tag == "Flag3")
        {
            flagsound.Play();
            Invoke("lvlfour", 0f);
            lvlsscript.lvl3 = true;
        }
        if (collision.collider.tag == "Flag4")
        {
            flagsound.Play();
            Invoke("lvlfive", 0f);
            lvlsscript.lvl4 = true;
        }
        if (collision.collider.tag == "Flag5")
        {
            flagsound.Play();
            Invoke("lvlsix", 0f);
            lvlsscript.lvl5 = true;
        }
        if (collision.collider.tag == "Flag6")
        {
            flagsound.Play();
            Invoke("levels", 0f);
        }
        if (collision.collider.tag == "key")
        {
            flagsound.Play();
            Destroy(collision.gameObject);
            flag.SetActive(true);
        }
        if (collision.collider.tag == "key2")
        {
            flagsound.Play();
            Destroy(collision.gameObject);
            flag2.SetActive(true);
        }
        if (collision.collider.tag == "key3")
        {
            flagsound.Play();
            Destroy(collision.gameObject);
            flag3.SetActive(true);
        }
        if (collision.collider.tag == "key4")
        {
            flagsound.Play();
            Destroy(collision.gameObject);
            flag4.SetActive(true);
        }
        if (collision.collider.tag == "key5")
        {
            flagsound.Play();
            Destroy(collision.gameObject);
            flag5.SetActive(true);
        }
        if (collision.collider.tag == "key6")
        {
            flagsound.Play();
            Destroy(collision.gameObject);
            flag6.SetActive(true);
        }
        if (collision.collider.tag == "gravitybender")
        {
            flagsound.Play();
            Destroy(collision.gameObject);
            player.gravityScale = -1;
            GetComponent<Rigidbody2D>().transform.Rotate(0,0,180);
            gravitybenderalindi = true;
        }
        if (collision.collider.tag == "planedestroying")
        {
            flagsound.Play();
            Destroy(collision.gameObject);
            greenbarrier.SetActive(false);
        }
        if (collision.collider.tag == "yellowkey")
        {
            flagsound.Play();
            Destroy(collision.gameObject);
            allbarriers.SetActive(false);
        }


        if (collision.collider.tag == "plane")
        {
            yerde = true;
        }
    }

    public void lvlagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gamefinished = false;
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
    public void lvlone()
    {
        SceneManager.LoadScene(2);
        gamefinished = false;
    }
    public void lvltwo()
    {
        SceneManager.LoadScene(3);
        gamefinished = false;
    }
    public void lvlthree()
    {
        SceneManager.LoadScene(4);
        gamefinished = false;
    }
    public void lvlfour()
    {
        SceneManager.LoadScene(5);
        gamefinished = false;
    }
    public void lvlfive()
    {
        SceneManager.LoadScene(6);
        gamefinished = false;
    }
    public void lvlsix()
    {
        SceneManager.LoadScene(7);
        gamefinished = false;
    }
    public void levels()
    {
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
        Application.Quit();
    }
}
