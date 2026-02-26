using System.Dynamic;

class Page
{
    public string Message { get; private set; } = "읽기 전용 메시지";

    public void UpdateMessage(string message)
    {
        Message = message;
    }
}