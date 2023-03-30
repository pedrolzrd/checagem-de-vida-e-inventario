using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Personagem : MonoBehaviour

{

    public string nome;

    public int vidas;

    public string[] armas = new string[4];

    void Start()

    {



        bool isValid = true;

        foreach (string arma in armas)

        {

            if (string.IsNullOrEmpty(arma))

            {

                isValid = false;

            }

        }



        if (!isValid)

        {

            print("preencha armas");

        }



        if (string.IsNullOrEmpty(nome))

        {

            isValid = false;

            print("preencha nome");

        }



        if (isValid)

        {

            foreach (string i in armas)

            {

                print(i);

            }



            ChecarVida(vidas);

        }



    }

    void ChecarVida(int vidas)
    {



        if (vidas <= 0)

        {

            print($"você tem {vidas} vidas");

            print("fim de jogo");

        }

        else

        {

            print($"você tem {vidas} vidas");

            print("jogo em andamento");

        }

    }

}