using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hamster3 : MonoBehaviour
{
    float love = 100; //love, quando chegar a zero o mesmo Runaway
    float Energy = 100; //Energy, quando chegar a zero o mesmo fica Angry
    float Hungry = 100; //Hungry, quando chegar a zero o mesmo Run
    int Status = 1; //controla qual animação executar
    //2 - Hungry
    //3 - Love
    //4 - Energy

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        CreatePet();
    }

    void CreatePet()
    {
        love = 100;
        Energy = 100;
        Hungry = 100;
        Status = 1;

    }

    public void Eat()
    {
        animator.SetTrigger("Eat");
    }

    public void Sleep()
    {
        animator.SetTrigger("Energy");
    }

    public void Laugh()
    {
        animator.SetTrigger("Love");
    }

    public void Voltar()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
