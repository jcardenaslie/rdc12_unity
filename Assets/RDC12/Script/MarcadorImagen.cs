using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcadorImagen : MonoBehaviour {
    
    [SerializeField]
    private string patrimonio;
    private Vector3 initialPosition;

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


    // Use this for initializatio
    void Start () {
        initialPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
	}


    public void RestartPosition() {
        transform.position = initialPosition;
    }

}
