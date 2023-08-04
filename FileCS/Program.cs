namespace FileCS {
    internal class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\file.txt";
            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine("GetDirectoryName" + Path.GetDirectoryName(path));
        }
    }
}