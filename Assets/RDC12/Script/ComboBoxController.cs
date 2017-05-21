using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboBoxController : MonoBehaviour {

    public bool showMenu;
    public Text btnComboBox;
    public string seleccion;



    // Use this for initialization

    public void ButtonShowMenu() {
        if (!showMenu) {
            showMenu = true;
        } else {
            showMenu = false;
        }
        Debug.Log("Set showMenu:" + showMenu);
    }



    private void SetComboBoxText(string s){
        btnComboBox.text = s;
        showMenu = false;
    }
    public void LaTirana() {
        seleccion = "La Tirana";
        SetComboBoxText(seleccion);
    }
    public void LaCueca()
    {
        seleccion = "La Cueca";
        SetComboBoxText(seleccion);
    }
    public void ElCuranto()
    {
        seleccion = "El Curanto";
        SetComboBoxText(seleccion);
    }
    public void LasLeyendas()
    {
        seleccion = "Las Leyendas";
        SetComboBoxText(seleccion);
    }
    public void FiestaTapi()
    {
        seleccion = "Fiesta Tapi";
        SetComboBoxText(seleccion);
    }
    public void LosJuegos()
    {
        seleccion = "Los Juegos";
        SetComboBoxText(seleccion);
    }
    public void LaMinga()
    {
        seleccion = "La Minga";
        SetComboBoxText(seleccion);
    }
    public void LaDibam()
    {
        seleccion = "La Dibam";
        SetComboBoxText(seleccion);
    }

}
