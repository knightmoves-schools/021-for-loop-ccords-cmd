namespace knightmoves;
public class ToDo
{
public string MarkAsDone(string[] todos){
    string[] result = new string[todos.length];
    for(int i = 0; i < todos.length; i++){
        result[i] = "done -" + todos[i];
    }
    return result
}
}
