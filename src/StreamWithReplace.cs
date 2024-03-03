namespace StreamReplacer;

public class StreamWithReplace: Stream
{
    private readonly Stream _stream;
    private long _position;
    private IReplace _replace;
    
    public StreamWithReplace(Stream stream)
    {
        _stream = stream;
    }
    
    public override void Flush()
    {
        throw new NotImplementedException();
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        throw new NotImplementedException();
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
        throw new NotImplementedException();
    }

    public override void SetLength(long value)
    {
        throw new NotImplementedException();
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        throw new NotImplementedException();
    }

    public override bool CanRead => _stream.CanRead;
    public override bool CanSeek => false;
    public override bool CanWrite => false;
    public override long Length => _stream.Length + _replace.LengthChange;

    public override long Position
    {
        get => _position;
        set => throw new NotSupportedException();
    }
}