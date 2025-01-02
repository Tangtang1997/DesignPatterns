# Overview
A Facade Pattern is a structural design pattern that provides a consistent interface to a set of interfaces within a subsystem, making the subsystem easier to use. By introducing a appearance class, the appearance pattern simplifies the interface of complex subsystems, reduces the coupling between clients and subsystems, and improves the usability and maintainability of the system.

# Structure
Appearance mode contains the following characters:

1. Facade: Provides a high-level interface to make the subsystem easier to use.
2. Subsystem: Implements the functions of the subsystem and handles the tasks assigned by the appearance object. The subsystem does not know that the facade exists; to the subsystem, the facade is just another client.

# Sample code
Suppose we have an application that needs to handle a complex audio-video conversion operation.

**Subsystem Class**
```csharp
public class AudioConverter
{
    public void ConvertAudio(string fileName)
    {
        Console.WriteLine($"Converting audio file: {fileName}");
    }
}

public class VideoConverter
{
    public void ConvertVideo(string fileName)
    {
        Console.WriteLine($"Converting video file: {fileName}");
    }
}

public class SubtitleConverter
{
    public void ConvertSubtitle(string fileName)
    {
        Console.WriteLine($"Converting subtitle file: {fileName}");
    }
}
```

**Facade Class**
```csharp
public class MediaConverterFacade
{
    private readonly AudioConverter _audioConverter;
    private readonly VideoConverter _videoConverter;
    private readonly SubtitleConverter _subtitleConverter;

    public MediaConverterFacade()
    {
        _audioConverter = new AudioConverter();
        _videoConverter = new VideoConverter();
        _subtitleConverter = new SubtitleConverter();
    }

    public void ConvertMedia(string audioFile, string videoFile, string subtitleFile)
    {
        _audioConverter.ConvertAudio(audioFile);
        _videoConverter.ConvertVideo(videoFile);
        _subtitleConverter.ConvertSubtitle(subtitleFile);
    }
}
```

**Client Code**
```csharp
class Program
{
    static void Main(string[] args)
    {
        MediaConverterFacade mediaConverter = new MediaConverterFacade();

        mediaConverter.ConvertMedia("audio.mp3", "video.mp4", "subtitle.srt");
    }
}
```

# Application Scenarios
Appearance mode is applicable to the following scenarios:

1. When you want to provide a simple interface to a complex subsystem.
2. When you want the coupling between the client and the subsystem to be low, the client only needs to interact with the appearance object, and does not need to know the details of the subsystem.
3. When you want the functionality of the subsystem to be distributed among multiple classes, and the interactions between these classes are complex.

# Advantages and disadvantages
**Advantages**
* Simplified interface: The facade pattern simplifies the interaction between clients and complex subsystems by providing a simple interface.
* Reduced coupling: Appearance mode reduces the coupling between the client and the subsystem, so that changes in the subsystem do not affect the client.
Improved maintainability: By introducing facade classes, subsystems can be more easily maintained and extended.

**Disadvantages**
May increase system complexity: Introducing facade classes may increase the complexity of the system, especially if the sub-system itself is already simple.
* Not conforming to the open closed principle: If you need to change the behavior of the subsystem, you may need to modify the appearance class, which violates the open closed principle.
