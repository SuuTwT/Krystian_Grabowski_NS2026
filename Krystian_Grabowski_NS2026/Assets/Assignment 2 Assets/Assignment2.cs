using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Assignment2 : MonoBehaviour
{

    public List<GameObject> Objects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
        checkDimension();

    }

        // Update is called once per frame
    void Update()
    {
        
    }
    void checkDimension()
    {
        foreach(GameObject element in Objects)
        {
            if (element.GetComponent<SpriteRenderer>() != null)
            {
                check2D(element);
            }
            else if (element.GetComponent<MeshRenderer>() != null)
            {
                check3D(element);
            }
            
        }
    }

    void check2D(GameObject obj)
    {
            Debug.Log(obj.name + " is 2D.");
    }

    void check3D(GameObject obj)
    {
            Debug.Log(obj.name + " is 3D.");
    }

}
