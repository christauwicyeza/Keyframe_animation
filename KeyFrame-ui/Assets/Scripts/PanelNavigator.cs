using UnityEngine;
using UnityEngine.UI;

public class PanelNavigator : MonoBehaviour
{
    public Animator pageAnimator;
    public Button nextPageButton1;
    public Button nextPageButton2;
    public Button previousPageButton2;
    public Button previousPageButton3;

    private void Start()
    {
        nextPageButton1.onClick.AddListener(GoToPanelTwo);
        nextPageButton2.onClick.AddListener(GoToPanelThree);
        previousPageButton2.onClick.AddListener(GoBackToPanelOne);
        previousPageButton3.onClick.AddListener(GoBackToPanelTwo);
    }

    private void GoToPanelTwo()
    {
        pageAnimator.SetBool("panel1", false);
        pageAnimator.SetBool("panel2", true);
        pageAnimator.SetBool("panel3", false);
    }

    private void GoToPanelThree()
    {
        pageAnimator.SetBool("panel1", false);
        pageAnimator.SetBool("panel2", false);
        pageAnimator.SetBool("panel3", true);
    }

    private void GoBackToPanelTwo()
    {
        pageAnimator.SetBool("panel1", false);
        pageAnimator.SetBool("panel2", true);
        pageAnimator.SetBool("panel3", false);
    }

    private void GoBackToPanelOne()
    {
        pageAnimator.SetBool("panel1", true);
        pageAnimator.SetBool("panel2", false);
        pageAnimator.SetBool("panel3", false);
    }

    
}
