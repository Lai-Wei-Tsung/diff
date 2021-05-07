using DiffMatchPatch;
using System;
using System.Collections.Generic;

public class hello
{
    public static void Main(string[] args)
    {
        diff_match_patch dmp = new diff_match_patch();
        List<Diff> diff = dmp.diff_main("你好棒，100分", "不理想，50分");
        // Result: [(-1, "Hell"), (1, "G"), (0, "o"), (1, "odbye"), (0, " World.")]
        //dmp.diff_cleanupSemantic(diff);
        
        dmp.diff_prettyHtml(diff);
        // Result: [(-1, "Hello"), (1, "Goodbye"), (0, " World.")]
        for (int i = 0; i < diff.Count; i++)
        {
            Console.WriteLine(diff[i]);
        }
        Console.ReadKey();
    }
}