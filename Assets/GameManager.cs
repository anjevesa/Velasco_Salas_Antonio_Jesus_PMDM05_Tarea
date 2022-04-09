using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text Paddle_ScoreText_Left;
    [SerializeField] private TMP_Text Paddle_ScoreText_Right;

    [SerializeField] private Transform Paddle_Transform_Left;
    [SerializeField] private Transform Paddle_Transform_Right;
    [SerializeField] private Transform Paddle_Transform_Left_2;
    [SerializeField] private Transform Paddle_Transform_Right_2;
    [SerializeField] private Transform Ball_Transform;
    [SerializeField] private Button BotonSalir;
    [SerializeField] private Button BotonReiniciar;

    public List<GameObject> objetivos;


    [SerializeField] private TMP_Text resultado;

    private int Paddle_Score_Left;
    private int Paddle_Score_Right;


    private static GameManager instance;

    private SoundManager soundManager;

    private void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }


    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    } 

    public void Paddle_Scored_Left()
    {
        Paddle_Score_Left++;
        Paddle_ScoreText_Left.text = Paddle_Score_Left.ToString();

        if (Paddle_Score_Left == 5)
        {
            //Muestro el resultado y, pauso el juego
            resultado.text = "¡Jugador Azul GANA!";
            Time.timeScale = 0;

            //Seleccionamos el sonido por la posición en el array, en este caso es 0.
            soundManager.SeleccionAudio(0, 0.5f);

            //Activamos el botón Salir
            BotonSalir.gameObject.SetActive(true);

            //Activamos el botón Reiniciar
            BotonReiniciar.gameObject.SetActive(true);
        }
    }

    public void Paddle_Scored_Right()
    {
        Paddle_Score_Right++;
        Paddle_ScoreText_Right.text = Paddle_Score_Right.ToString();

        if (Paddle_Score_Right == 5)
        {
            //Muestro el resultado y, pauso el juego
            resultado.text = "¡Jugador Rojo GANA!";
            Time.timeScale = 0;
            //Seleccionamos el sonido por la posición en el array, en este caso es 0.
            soundManager.SeleccionAudio(0, 0.5f);

            //Activamos el botón Salir
            BotonSalir.gameObject.SetActive(true);

            //Activamos el botón Reiniciar
            BotonReiniciar.gameObject.SetActive(true);


        }
         
    }

    public void Restart()
    {
        Paddle_Transform_Left.position = new Vector2(Paddle_Transform_Left.position.x, 0);
        Paddle_Transform_Right.position = new Vector2(Paddle_Transform_Right.position.x, 0);

        Paddle_Transform_Left_2.position = new Vector2(-3, 0);
        Paddle_Transform_Right_2.position = new Vector2(3, 0);


        Ball_Transform.position = new Vector2(0, 0);
    }

}
