using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class corona : MonoBehaviour
{
    public AudioSource som1;
    public AudioSource som2;
    public Text txtVidas;
    private static int vidas = 3;

    void Start()
    {
        som1 = GetComponents<AudioSource>()[0];
        som2 = GetComponents<AudioSource>()[1];
        txtVidas.text = "Lifes: " + vidas;
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.relativeVelocity.magnitude > 2) {
            som1.Play();
        }
    }

    void OnTriggerEnter(Collider outro){
        if(outro.gameObject.CompareTag("vermelho")){
            vidas--;
            txtVidas.text = "Lifes: " + vidas;

            som2.Play();
            InvokeRepeating("perder",0.5f, 1);
        }
        else if(outro.gameObject.CompareTag("verde")){
            SceneManager.LoadScene("vencedor");
            som1.Play();
        }
    }

    void perder(){
        if(vidas<1) {
                SceneManager.LoadScene("gameOver");
        }else{
                SceneManager.LoadScene("SampleScene");
        }
    }
}
