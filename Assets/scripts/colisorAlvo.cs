using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class colisorAlvo : MonoBehaviour
{
    public string pergunta1;
	public string pergunta2;
	public string pergunta3;
	public string pergunta4;
	public string pergunta5;
	public string creditos;
    public static string correta = Menu.respostaCorreta;
    public static string errada1 = Menu.incorreta1;
    public static string errada2 = Menu.incorreta2;
    public static int proxima = Menu.proximaPergunta;

    
    private void Start() {
        
    }

    private void update(){
        Menu.proximaPergunta = proxima ;
    }
    private void OnCollisionEnter(Collision objeto) {
        if (objeto.gameObject.CompareTag(correta))
        {
            FindObjectOfType<UIManager>().setMessage("PARABÉNS!!! CERTA RESPOSTA!!!");
            Destroy(objeto.gameObject);     
            if (proxima==1)
            {   
                proxima=2;
                StartCoroutine(ChamaP2());
            }
            else if (proxima==2)
            {
                proxima = 3;
                StartCoroutine(ChamaP3());
            }
            else if (proxima==3)
            {
                proxima= 4;
                StartCoroutine(ChamaP4());
            }
            else if (proxima==4)
            {
                proxima = 5;
                StartCoroutine(ChamaP5());
            }
            else if (proxima == 5)
            
            {
                FindObjectOfType<UIManager>().setMessage("PARABÉNS!!! VOCÊ CONSEGUIU CONCLUIR O JOGO!!!");
                StartCoroutine(ChamaCreditos());
            }
        
        }
        if (objeto.gameObject.CompareTag(errada2) ||objeto.gameObject.CompareTag(errada1))
        {
            FindObjectOfType<UIManager>().setMessage("Tente Novamente");
            if (proxima==1)
            {                
                StartCoroutine(ChamaP1());
            }
            if (proxima==2)
            {
                StartCoroutine(ChamaP2());
            }
            if (proxima==3)
            {
                StartCoroutine(ChamaP3());
                ChamaP3();
            }
            if (proxima==4)
            {
                StartCoroutine(ChamaP4());
            }
            if (proxima==5)
            {
                StartCoroutine(ChamaP5());
            }
        }
    }
    public IEnumerator ChamaP1()
	{
        yield return new WaitForSeconds(3f);
		correta = "B";
		errada1 = "A";
		errada2 = "C";
        Menu.respostaCorreta = "B";
		Menu.incorreta1 = "A";
		Menu.incorreta2 = "C";
		SceneManager.LoadScene(pergunta1);
	}
	public IEnumerator ChamaP2()
	{
        yield return new WaitForSeconds(3f);
        correta = "C";
		errada1 = "A";
		errada2 = "B";
		Menu.respostaCorreta = "C";
		Menu.incorreta1 = "A";
		Menu.incorreta2 = "B";
		SceneManager.LoadScene(pergunta2);
	}
	public IEnumerator ChamaP3()
	{
        yield return new WaitForSeconds(3f);
        correta = "C";
		errada1 = "A";
		errada2 = "B";
		Menu.respostaCorreta = "C";
		Menu.incorreta1 = "A";
		Menu.incorreta2 = "B";
		SceneManager.LoadScene(pergunta3);
	}
	public IEnumerator ChamaP4()
	{
        yield return new WaitForSeconds(3f);
        correta = "A";
		errada1 = "B";
		errada2 = "C";
		Menu.respostaCorreta = "A";
		Menu.incorreta1 = "C";
		Menu.incorreta2 = "B";
		SceneManager.LoadScene(pergunta4);
	}
	public IEnumerator ChamaP5()
	{
        yield return new WaitForSeconds(3f);
        correta = "A";
		errada1 = "B";
		errada2 = "C";
		Menu.respostaCorreta = "A";
		Menu.incorreta1 = "C";
		Menu.incorreta2 = "B";
		SceneManager.LoadScene(pergunta5);
	}
    public IEnumerator ChamaCreditos()
	{
        yield return new WaitForSeconds(3f);
		SceneManager.LoadScene(creditos);
	}
    
}
