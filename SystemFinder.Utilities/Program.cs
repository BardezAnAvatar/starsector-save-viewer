// See https://aka.ms/new-console-template for more information
using SystemFinder.Utilities;

Console.WriteLine("Reading input XML ...");
var root = XDocumentReader.OpenDocument();
Console.WriteLine("Done!");
Console.WriteLine("");
Console.WriteLine("");

var distinctElementCount = XDocumentCreator.CountUniqueElements(root);
Console.WriteLine($"Found {distinctElementCount} distinct element types!");
Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("Reading `Sstm` star systems ...");
var systems = XDocumentCreator.IsolateSstm(root);
Console.WriteLine("Done!");
Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("Reading Non-`Sstm` star systems ...");
var notQuiteSystems = XDocumentCreator.IsolateNonSstmSystems(root);
Console.WriteLine("Done!");
Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("Building an XML document for XPaths ...");
var xPaths = XDocumentCreator.IsolateXPaths();
Console.WriteLine("Done!");
Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("Writing `Sstm` star systems ...");
XDocumentWriter.WriteSstm(systems);
Console.WriteLine("Done!");
Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("Writing Non-`Sstm` star systems ...");
XDocumentWriter.WriteNonSstmSystems(notQuiteSystems);
Console.WriteLine("Done!");
Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("Writing star systems XPath document ...");
XDocumentWriter.WriteXPathsForSystems(xPaths);
Console.WriteLine("Done!");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Analysis Finished!");
Console.Beep();