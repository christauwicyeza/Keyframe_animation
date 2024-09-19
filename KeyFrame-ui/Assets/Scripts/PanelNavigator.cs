using UnityEngine;

public class PanelNavigator : MonoBehaviour
{
    public Animator pageAnimator; 

    /// <summary>
    /// go to the panel by index
    /// </summary>
    /// <param name="panelIndex">1, 2, or 3 depending on which show.</param>
    public void GoToPanel(int panelIndex)
    {
        ChangePanel(panelIndex);
    }

    /// <summary>
    /// changes to the specified panel
    /// </summary>
    /// <param name="panelIndex">Panel number to activate.</param>
    private void ChangePanel(int panelIndex)
    {
        pageAnimator.SetBool("panel1", panelIndex == 1);
        pageAnimator.SetBool("panel2", panelIndex == 2);
        pageAnimator.SetBool("panel3", panelIndex == 3);
    }
}
