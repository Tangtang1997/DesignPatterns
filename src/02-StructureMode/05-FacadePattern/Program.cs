// See https://aka.ms/new-console-template for more information
using _05_FacadePattern;

Console.WriteLine("Hello, World!");

MediaConverterFacade mediaConverter = new MediaConverterFacade();

mediaConverter.ConvertMedia("audio.mp3", "video.mp4", "subtitle.srt");