using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI {
    partial class Form1 {

        const string path = @"../../../Debug/dll1.dll";

        [DllImport(path,
        EntryPoint = "FromChar",
        CallingConvention = CallingConvention.StdCall)]
        static extern void FromChar(char input);

        [DllImport(path,
        EntryPoint = "FromShort",
        CallingConvention = CallingConvention.StdCall)]
        static extern void FromShort(short input);

        [DllImport(path,
        EntryPoint = "FromInt",
        CallingConvention = CallingConvention.StdCall)]
        static extern void FromInt(int input);

        [DllImport(path,
        EntryPoint = "FromLong",
        CallingConvention = CallingConvention.StdCall)]
        static extern void FromLong(long input);

        [DllImport(path,
        EntryPoint = "FromDouble",
        CallingConvention = CallingConvention.StdCall)]
        static extern void FromDouble(double input);

        [DllImport(path,
        EntryPoint = "FromFloat",
        CallingConvention = CallingConvention.StdCall)]
        static extern void FromFloat(float input);

        [DllImport(path,
        EntryPoint = "ToLong",
        CallingConvention = CallingConvention.StdCall)]
        static extern long ToLong();

        public static string ToBinary(long input, int length, int type) {
            string res = String.Empty;
            if (type < 5)
                for (int i = length * 8 - 1; i >= 0; i--) {
                    res += (((input >> i) & 1) == 1) ? '1' : '0';
                } else {
                int[] spaces = new int[] { 62, 51 };
                if (type == 5)
                    spaces = new int[] { 30, 22 };
                for (int i = length * 8 - 1; i >= 0; i--) {
                    if (spaces.Contains(i))
                        res += ' ';
                    res += (((input >> i) & 1) == 1) ? '1' : '0';
                }
            }
            return res;
        }

    }
}
