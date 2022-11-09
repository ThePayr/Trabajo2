using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantallaBalas : MonoBehaviour {
    public Text texto;
    public LogicaArma logicaArma;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        texto.text = logicaArma.balasEnCartucho + "/" + logicaArma.tamañoDeCartucho
                    + "\n" + logicaArma.balasRestantes;
	}
}
