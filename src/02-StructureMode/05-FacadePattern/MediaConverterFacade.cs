namespace _05_FacadePattern;

public class MediaConverterFacade
{
    private readonly AudioConverter _audioConverter = new();
    private readonly VideoConverter _videoConverter = new();
    private readonly SubtitleConverter _subtitleConverter = new();

    public void ConvertMedia(string audioFile, string videoFile, string subtitleFile)
    {
        _audioConverter.ConvertAudio(audioFile);
        _videoConverter.ConvertVideo(videoFile);
        _subtitleConverter.ConvertSubtitle(subtitleFile);
    }
}