using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;  
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade;
    public Animator anim;
    public Camera mainCamera;
    public string menu;
    public float velocidadeCamera;
    public float velocidadeRotacaoCamera;
    public Vector3 cameraOffSet;
    private Rigidbody rb;
    

    float InputX; //A, D
    float InputZ; //W, S
    float InputHit; //space

    Vector3 Direcao;

    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }

    void Update()
    {
        
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");
        InputHit = Input.GetAxis("Fire1");
        
        
	
		if (Input.GetKey (KeyCode.Escape)) {
			ChamaMenu();
		}
        if (Input.GetKeyDown("space"))
        {
            
        }
        Direcao = new Vector3(InputX, 0, InputZ);
        if (InputX != 0 || InputZ != 0)
        {
            var camrot = mainCamera.transform.rotation;
            camrot.x = 0;
            camrot.z = 0;
            transform.Translate(0, 0, velocidade * Time.deltaTime);
            anim.SetBool("walk", true);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Direcao) * camrot, 5 * Time.deltaTime);
        }
        if (InputX == 0 && InputZ == 0)
        {
            anim.SetBool("walk", false);
        }

        if (InputHit != 0)
        {
            anim.SetBool("hit", true);
        }
        if (InputHit == 0)
        {
            anim.SetBool("hit", false);
        }


        mainCamera.transform.rotation = Quaternion.Lerp(mainCamera.transform.rotation, transform.rotation, velocidadeRotacaoCamera * Time.deltaTime);
    }

    private void LateUpdate()
    {
        var pos = transform.position - mainCamera.transform.forward * cameraOffSet.z
            + mainCamera.transform.up * cameraOffSet.y +mainCamera.transform.right *cameraOffSet.x;
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, pos, velocidadeCamera * Time.deltaTime);
    }
    public void ChamaMenu()
	{
		SceneManager.LoadScene(menu);
	}
    
}
