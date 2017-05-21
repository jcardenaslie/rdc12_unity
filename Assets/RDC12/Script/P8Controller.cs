using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P8Controller : MonoBehaviour {


    public ContenedorMarcador[] contenedores;
    //public ComboBoxController[] comboControllers;
    private GameObject btnNext;

    // Use this for initialization
    void Start () {
        DeactivateNextButton();

    }

    private void Update()
    {
        CheckGameState();
    }

    public void CheckGameState() {
        int indexCount = 0;
        for (int i = 0; i < contenedores.Length; i++)
        {
            if (contenedores[i].ImageMatch)
            {
                indexCount++;
            }
            //if (contenedores[i].Patrimonio == comboControllers[i].seleccion)
            //{
            //    //Debug.Log("Contenedor: " + contenedores[i].Patrimonio + " ComboBox: " + comboControllers[i].seleccion);
            //    indexCount++;
            //}
        }

        if (indexCount == contenedores.Length)
        {
            btnNext.SetActive(true);
        }
    }

    private void DeactivateNextButton()
    {
        Transform panelMenu = this.transform.FindChild("BottomMenu");
        btnNext = panelMenu.transform.FindChild("Next").gameObject;
        btnNext.SetActive(false);
    }
}
