namespace StreamReplacer;

public class EmptyReplace : ReplaceToString
{
    public EmptyReplace() 
        : base(0, 0, string.Empty)
    {
    }
}