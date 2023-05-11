using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float velocidade = 5;
    public float velocidadeCorrida = 9;
    public KeyCode teclaDeCorrida = KeyCode.LeftShift;
    public Animator anim;
    private Rigidbody rb;

    [SerializeField]
    private float velocidadeAtual;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        velocidadeAtual = velocidade;
    }
    void FixedUpdate()
    {
        var inputX = Input.GetAxis("Horizontal");
        var inputZ = Input.GetAxis("Vertical");
        if (inputX != 0 || inputZ != 0) {
            {
                transform.Translate(new Vector3(inputX, 0, inputZ) * Time.deltaTime * velocidadeAtual, Space.Self);
                if (Input.GetKey(teclaDeCorrida))
                {
                    //anim.SetBool("run", true);
                    velocidadeAtual = velocidadeCorrida;
                }

                else
                {
                    //anim.SetBool("run", false);
                    velocidadeAtual = velocidade;
                }
            }

         }
        }
    } 
