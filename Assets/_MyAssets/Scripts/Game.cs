using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private int _pointage;

    // Start is called before the first frame update
    void Start()
    {
        _pointage = 0;
        Instruction();
    }

    static void Instruction()
    {
        Debug.Log("Course à obstacle");
        Debug.Log("Atteindre la fin du parcours le plus rapidement possible");
        Debug.Log("Chaque obstacle qui sera touché entrainera une pénalité");
    }

    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log("Nombre d'accrochages : " + _pointage);
    }
 
}
