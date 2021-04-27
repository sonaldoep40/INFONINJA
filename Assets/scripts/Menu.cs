using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
	public string cena;
	public string menu;
	public string creditos;
	public string pergunta1;
	public string pergunta2;
	public string pergunta3;
	public string pergunta4;
	public string pergunta5;
	public static string respostaCorreta;
	public static string incorreta1;
	public static string incorreta2;
	public static int proximaPergunta;
	


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void ChamaCreditos()
	{
		SceneManager.LoadScene(creditos);
	}
	public void ChamaMenu()
	{
		SceneManager.LoadScene(menu);
	}
	public void StartGame()
	{
		proximaPergunta = 1;
		respostaCorreta = "B";
		incorreta1 = "A";
		incorreta2 = "C";
		SceneManager.LoadScene(cena);
	}
	public void QuitGame()
	{	
		//Editor Unity
		UnityEditor.EditorApplication.isPlaying = false;
		//Jogo Compilado
		//Application.Quit();
		
	}
	public void ChamaP1()
	{
		respostaCorreta = "B";
		incorreta1 = "A";
		incorreta2 = "C";
		SceneManager.LoadScene(pergunta1);
	}
	public void ChamaP2()
	{
		respostaCorreta = "C";
		incorreta1 = "A";
		incorreta2 = "B";
		SceneManager.LoadScene(pergunta2);
	}
	public void ChamaP3()
	{
		respostaCorreta = "C";
		incorreta1 = "A";
		incorreta2 = "B";
		SceneManager.LoadScene(pergunta3);
	}
	public void ChamaP4()
	{
		respostaCorreta = "A";
		incorreta1 = "C";
		incorreta2 = "B";
		SceneManager.LoadScene(pergunta4);
	}
	public void ChamaP5()
	{
		respostaCorreta = "A";
		incorreta1 = "C";
		incorreta2 = "B";
		SceneManager.LoadScene(pergunta5);
	}
	public static void Proxima(){
		proximaPergunta = proximaPergunta + 1;
	}
	
}
