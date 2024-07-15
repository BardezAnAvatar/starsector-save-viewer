// See https://aka.ms/new-console-template for more information
using SystemFinder.Utilities;

var root = XDocumentReader.OpenDocument();
var systems = XDocumentCreator.IsolateSstm(root);
XDocumentWriter.WriteSstm(systems);

Console.WriteLine("Done!");
Console.Beep();