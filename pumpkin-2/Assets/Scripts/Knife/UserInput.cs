public class UserInput
{
    public UserInput()
    {
    }

    ~UserInput()
    {
    }

    public bool IsMouseClicked()
        => UnityEngine.Input.GetMouseButtonDown(0);
}