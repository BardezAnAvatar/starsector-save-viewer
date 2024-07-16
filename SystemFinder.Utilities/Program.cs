// See https://aka.ms/new-console-template for more information
using SystemFinder.Utilities;

var root = XDocumentReader.OpenDocument();

var systems = XDocumentCreator.IsolateSstm(root);
XDocumentWriter.WriteSstm(systems);
var notQuiteSystems = XDocumentCreator.IsolateNonSstmSystems(root);
XDocumentWriter.WriteSstm(notQuiteSystems);

Console.WriteLine("Done!");
Console.Beep();