using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboBoxElementDropDown : MonoBehaviour {

    private Animator buttonAnim;
    public ComboBoxController btnCon;

	// Use this for initialization
	void Start () {
        buttonAnim = GetComponent<Animator>();
        //btnCon = GameObject.Find("opciones").GetComponent<ComboBoxController>();
	}

    // Update is called once per frame
    void Update()
    {
        if (btnCon.showMenu)
        {
            buttonAnim.SetBool("button_show", true);
        }
        else
        {
            buttonAnim.SetBool("button_show", false);
        }
    }
}
