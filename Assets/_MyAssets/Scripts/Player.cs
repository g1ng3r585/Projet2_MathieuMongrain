using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField]   
    private float _vitesse = 10;


    // Start is called before the first frame update
    private void Start()
    {
        this.transform.position = new Vector3(-25f,0.51f,-30f);
    }

    // Update is called once per frame
    private void Update()
    {
        //if(Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(Vector3.right * Time.deltaTime * _vitesse);
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * Time.deltaTime * _vitesse);
        //}

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.forward * Time.deltaTime * _vitesse);
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(Vector3.back * Time.deltaTime * _vitesse);
        //}
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _vitesse *= 2;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift)) 
        {
            _vitesse /= 2;
        }

        MouvementsJoueur();

        
    }

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        transform.Translate(direction * Time.deltaTime * _vitesse);
    }
}
