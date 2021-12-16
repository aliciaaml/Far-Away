using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectSlotInteraction : MonoBehaviour
{ 
    bool jugado1 = false;
    public static bool jugado2 = true;

    public void ClickTrigger()
    {
        if (gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite != null)
        {
            if (gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite.name == "Movil" && !jugado1)
            {
                gameObject.transform.parent.parent.parent.parent.GetComponent<Animator>().SetBool("Mouse", false);
                SceneManager.LoadScene("MinijuegoMovil");
                jugado1 = true;
            }

            // Esto para la segunda vez que se juega, accede al objeto con este script y cambia jugado2 a false para jugar, como una specie de trigger
            // Si te es util para como sea que estes haciendo los dialogos puedes meter aqui un trigger para ellos tambien
            if (gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite.name == "Movil" && jugado1 && !jugado2)
            {
                gameObject.transform.parent.parent.parent.parent.GetComponent<Animator>().SetBool("Mouse", false);
                SceneManager.LoadScene("MinijuegoMovilBien");
                jugado2 = true;


            }
        }

        else { return; }
       
    }
}
