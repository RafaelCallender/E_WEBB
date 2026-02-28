using E_WEBB.SERVICES.FILE_SERVICES.fFILE_HELPER;
using System.Reflection;

namespace E_WEBB.SERVICES.FILE_SERVICES.TEXTFILE
{
    public class Read_TextFiles01
    {
        private static File_Helper01 File_H01 = new File_Helper01();
        private static string[] file_helper = File_H01.all_embedded_textfiles().Split();

        private static Assembly assembly = Assembly.GetExecutingAssembly();
        private static Stream[] stream01 = { assembly.GetManifestResourceStream(file_helper[0]),
                                    
        };
        private static StreamReader[] reader01 = { new StreamReader(stream01[0]),
                                            
        };
        private static string[] data01 = { reader01[0].ReadToEnd(),
                                 
        };

        public string client_textfile => string.Join("\n", data01[0]);

    }
}

