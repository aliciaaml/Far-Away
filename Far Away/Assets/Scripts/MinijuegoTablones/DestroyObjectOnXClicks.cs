using UnityEngine;

public class DestroyObjectOnXClicks : MonoBehaviour
{
    [SerializeField] int clicks;
    [SerializeField] GameObject destroyObject;
    [SerializeField] GameObject objectShows;

    public Sprite sprite;
    public Sprite sprite2;

    public Timer timer;

    int contador;
    private void Start()
    {
        contador = 0;

        objectShows.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (timer.timerIsRunning)
        {
            contador += 1;
            if (contador == clicks)
            {
                destroyObject.SetActive(false);
                objectShows.SetActive(true);
            }

            if( contador == clicks - 1 ){
                gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
                gameObject.GetComponent<Iluminación>().nuevoSprite = sprite2;
                gameObject.GetComponent<Iluminación>().Rotismo();

                
            }
        }
        
    }
}
