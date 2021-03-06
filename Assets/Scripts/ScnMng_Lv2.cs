using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScnMng_Lv2 : MonoBehaviour
{

    public bool auxVidaBoss = true;
    public bool finNivel;
    public float setoutfnd;

    public GameObject canvas_pause;
    public GameObject canvas_UI;
    public Jugador pj;
    public Text obj_Text;
    public Image barradeVida;
    public GameObject barra;
    public GameObject contVida_pn;
    public CamaraScript cs;
    public Boss_Script_Lv2 bs_lv2;

    public Text vid_Text;

    // Start is called before the first frame update
    void Start()
    {
        barra.SetActive(false);
        contVida_pn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        obj_Text.text = "X " + pj.objRecog.ToString();

        if (cs.movCam == false)
        {
            if (auxVidaBoss == true)
            {
                contVida_pn.SetActive(true);
                barra.SetActive(true);
            }
        }
        else if (cs.movCam == true || auxVidaBoss == false)
        {
            contVida_pn.SetActive(false);
            barra.SetActive(false);
        }

        if (contVida_pn.activeSelf == true)
        {
            vid_Text.text = "X " + pj.vidas.ToString();

            if (pj.vidas < 0)
            {
                vid_Text.text = "X 0";
            }

            barradeVida.fillAmount = bs_lv2.vida / bs_lv2.vidaMax;

            if (barradeVida.fillAmount == 0)
            {
                auxVidaBoss = false;
            }
        }
    }

    public void Continuar()
    {
        Debug.Log("Continuuaaa");
        canvas_pause.SetActive(false);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Guardar()
    {

    }

    public void Salir()
    {
        Application.Quit();
    }

    public void FinNivel()
    {
        finNivel = true;
    }
}
