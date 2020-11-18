using System;
using System.Collections.Generic;

namespace XamlDictionaryMergeTool
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("XamlDictionaryMergeTool: Xaml dictionary merge started");
            List<MergeParameter> mergeList = new List<MergeParameter>();
            for (var i = 0; i < args.Length / 2; i++)
            {
                string prm1 = args[i];
                string prm2 = args[i + 1];
                mergeList.Add(new MergeParameter {Folder = prm1, OutputFile = prm2});
            }

            foreach (var mergeParams in mergeList)
            {
                Console.WriteLine(
                    $"XamlDictionaryMergeTool: Merging {mergeParams.Folder} folder into a single file {mergeParams.OutputFile}");
                FolderMerger.MergeFolder(mergeParams.Folder, mergeParams.OutputFile);
            }
        }
    }
}