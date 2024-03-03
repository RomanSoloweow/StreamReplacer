namespace StreamReplacer;

public class ReplaceToString : IReplace
{
    public ReplaceToString(long start, long end, string content)
    {
        Start = start;
        End = end;
        Content = content;
    }

    public long Start { get; }
    public long End { get; }
    private string Content { get; }
    public long Length => Content.Length;
    
    public int Read(byte[] buffer, int offset, int count)
    {
        throw new NotImplementedException();
    }
}