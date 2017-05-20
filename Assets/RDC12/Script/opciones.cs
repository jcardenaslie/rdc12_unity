using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opciones : MonoBehaviour {
    private int count=0;
    private GameObject btnNext;


    private void DeactivateNextButton()
    {
        //Transform panelMenu = this.transform.FindChild("BottomMenu");
        //btnNext = panelMenu.transform.FindChild("Next").gameObject;
        //btnNext.SetActive(false);
    }

    public void CheckGameState()
    {
        if (count==3)
        {
            Transform panelMenu = this.transform.FindChild("BottomMenu");
            btnNext = panelMenu.transform.FindChild("Next").gameObject;
            btnNext.SetActive(true);
            Transform correcto = this.transform.FindChild("Correcto");
            correcto.gameObject.SetActive(true);
            Debug.Log(count);
        }
        else
        {
            Transform incorrecto = this.transform.FindChild("Incorrecto");
            incorrecto.gameObject.SetActive(true);
            Debug.Log(count);
        }
    }

    public void Sumar()
    {
        count++;
    }
    public void Restar()
    {
        count--;
    }
    public void sum8()
    {
        if (count == 8)
        {
            Transform panelMenu = this.transform.FindChild("BottomMenu");
            btnNext = panelMenu.transform.FindChild("Next").gameObject;
            btnNext.SetActive(true);
            Debug.Log(count);
        }
    }
    public void inicializar()
    {
        count = 0;
    }
}
