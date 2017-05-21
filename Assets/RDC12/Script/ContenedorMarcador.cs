using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContenedorMarcador : MonoBehaviour {


    private string patrimonio;
    private MarcadorImagen marcImagen;
    private bool imageMatch = false;

    public ComboBoxController cController;
    public Image answerRight;
    public Image answerWrong;

    public string Patrimonio
    {
        get
        {
            return patrimonio;
        }

        set
        {
            patrimonio = value;
        }
    }

    public MarcadorImagen MarcImagen
    {
        get
        {
            return marcImagen;
        }

        set
        {
            marcImagen = value;
        }
    }

    public bool ImageMatch
    {
        get
        {
            return imageMatch;
        }

        set
        {
            imageMatch = value;
        }
    }


    public void SwitchMarcador(MarcadorImagen mi)
    {
        if (MarcImagen != null) {
            // le digo a la imgan antigua que vuelva a su posicion
            MarcImagen.RestartPosition();
        }
        MarcImagen = mi;
        Patrimonio = mi.Patrimonio;
        CheckImageMatch();
    }

    public void CheckImageMatch()
    {
        if (cController.seleccion == patrimonio)
        {
            answerRight.gameObject.SetActive(true);
            answerWrong.gameObject.SetActive(false);
            this.imageMatch = true;
        }
        else {
            answerRight.gameObject.SetActive(false);
            answerWrong.gameObject.SetActive(true);
            this.imageMatch = false;
        }
    }
}
