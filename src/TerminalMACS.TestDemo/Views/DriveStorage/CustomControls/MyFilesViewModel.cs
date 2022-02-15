﻿using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace TerminalMACS.TestDemo.Views.DriveStorage.CustomControls;

internal class MyFilesViewModel
{
    //Resource Dictionary 
    private readonly ResourceDictionary dict =
        Application.LoadComponent(new Uri("TerminalMACS.TestDemo;component/Views/DriveStorage/Resources/Icons.xaml",
            UriKind.RelativeOrAbsolute)) as ResourceDictionary;

    public ObservableCollection<GetFileDetails> getFileDetails =>
        new()
        {
            new()
            {
                FileThumb = (PathGeometry)dict["Pdf"], FileName = "File 1", Fill = "Red", FileProgram = "Adobe Acrobat",
                ModifiedOn = "12.01.2020", FileType = ".pdf"
            },
            new()
            {
                FileThumb = (PathGeometry)dict["Png"], FileName = "File 2", Fill = "Green",
                FileProgram = "Photo Viewer", ModifiedOn = "18.02.2020", FileType = ".png"
            },
            new()
            {
                FileThumb = (PathGeometry)dict["txt"], FileName = "File 3", Fill = "CadetBlue", FileProgram = "Notepad",
                ModifiedOn = "15.07.2020", FileType = ".txt"
            },
            new()
            {
                FileThumb = (PathGeometry)dict["Pdf"], FileName = "File 4", Fill = "Green",
                FileProgram = "Adobe Acrobat", ModifiedOn = "22.07.2020", FileType = ".pdf"
            }
        };
}

internal class GetFileDetails
{
    public PathGeometry FileThumb { get; set; }
    public string Fill { get; set; }
    public string FileName { get; set; }
    public string FileProgram { get; set; }
    public string ModifiedOn { get; set; }
    public string FileType { get; set; }
}