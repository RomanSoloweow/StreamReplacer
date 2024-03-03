namespace StreamReplacer;

public interface IReplace
{
    long Start { get; }
    long End { get; }
    long Length { get; }
    long LengthChange => Start - End + Length;
    int Read(byte[] buffer, int offset, int count);
}