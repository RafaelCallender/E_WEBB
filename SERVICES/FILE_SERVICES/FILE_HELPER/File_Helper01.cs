using System.Diagnostics;
using System.Reflection;

namespace E_WEBB.SERVICES.FILE_SERVICES.fFILE_HELPER
{
    public class File_Helper01
    {
        private static string[] data01 = new string[100];

        private static readonly Assembly assembly = Assembly.GetExecutingAssembly();
        private static readonly string[] resources = assembly.GetManifestResourceNames();

        private static readonly string[] data02 = resources.Where(r => r.EndsWith(".txt", StringComparison.OrdinalIgnoreCase)).ToArray();
        private static readonly string[] imageExtensions01 = { ".png", ".jpg", ".jpeg", ".gif", ".bmp", ".svg", ".webp" };

        private static readonly string[] data03 = resources.Where(r => imageExtensions01.Any(ext => r.EndsWith(ext, StringComparison.OrdinalIgnoreCase))).ToArray();


        private static string[] textFiles => data02;
        private static string[] imagefiles => data03;

        public string all_embedded_files()
        {

            foreach (var a in resources)
            {
                data01[1] += $"{a}\n";
            }
            return data01[1];
        }
        public string all_embedded_textfiles()
        {
            foreach (var a in textFiles)
            {
                data01[2] += $"{a}\n";
            }
            return data01[2].Trim();

        }
        public string all_embedded_imagefiles()
        {
            foreach (var a in imagefiles)
            {
                data01[2] += $"{a}\n";
            }
            return data01[2].Trim();

        }
    }
}