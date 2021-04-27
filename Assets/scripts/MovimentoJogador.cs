using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    private Rigidbody rb;
	public string menu;
	public float velocidade;
	public float maxAltura;
	private int pontuacao;
	//public Rect pontuacaoText;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		pontuacao = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		float pulo = 0;
		if ((Input.GetKey (KeyCode.Space)) && (rb.position.y < maxAltura)) {
			pulo = 3;
		}
		if (Input.GetKey (KeyCode.Escape)) {
			ChamaMenu();
		}
		Vector3 forca = new Vector3 (h, pulo, v);
		rb.AddForce (forca * velocidade);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Moeda")) {
			other.gameObject.SetActive (false);
			pontuacao++;
		}
	}

	//void mostraPontuacao() {
	//	pontuacaoText.text = "Pontos: " + pontuacao;
	//}
	public void ChamaMenu()
	{
		SceneManager.LoadScene(menu);
	}
	public void acabou() {
		Application.Quit();
	}
}
