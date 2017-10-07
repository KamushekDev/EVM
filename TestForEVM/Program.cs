//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace TestForEVM {
//    class Program {

//        #region trash
//        [DllImport(@"../../../Debug/dll1.dll",
//        EntryPoint = "FromChar",
//        CallingConvention = CallingConvention.StdCall)]
//        static extern void FromChar(char input);

//        [DllImport(@"../../../Debug/dll1.dll",
//        EntryPoint = "FromShort",
//        CallingConvention = CallingConvention.StdCall)]
//        static extern void FromShort(short input);

//        [DllImport(@"../../../Debug/dll1.dll",
//        EntryPoint = "FromInt",
//        CallingConvention = CallingConvention.StdCall)]
//        static extern void FromInt(int input);

//        [DllImport(@"../../../Debug/dll1.dll",
//        EntryPoint = "FromLong",
//        CallingConvention = CallingConvention.StdCall)]
//        static extern void FromLong(long input);

//        [DllImport(@"../../../Debug/dll1.dll",
//        EntryPoint = "FromDouble",
//        CallingConvention = CallingConvention.StdCall)]
//        static extern void FromDouble(double input);

//        [DllImport(@"../../../Debug/dll1.dll",
//        EntryPoint = "FromFloat",
//        CallingConvention = CallingConvention.StdCall)]
//        static extern void FromFloat(float input);

//        [DllImport(@"../../../Debug/dll1.dll",
//        EntryPoint = "ToLong",
//        CallingConvention = CallingConvention.StdCall)]
//        static extern long ToLong();

//        public static string ToBinary(long input, int length) {
//            string res = String.Empty;
//            for (int i = length*8-1; i>=0; i--) {
//                if (i==2&&length==8)
//                    Console.Write(' ');
//                res+=(((input>>i)&1)==1) ? '1' : '0';
//            }
//            return res;
//        }

//        #endregion

//        public enum Types { Char, Short, Int, Long, Float, Double }

//        static void Main(string[] args) {
//            //Console.WriteLine(sizeof(char));
//            Console.WriteLine("Введите название вводимого типа: ");
//            Console.ForegroundColor=ConsoleColor.DarkGreen;
//            for (int i = 0; i<6; i++)
//                Console.Write((Types)i+((i!=5) ? ", " : ""));
//            Console.WriteLine();
//            Console.ForegroundColor=ConsoleColor.Gray;
//            Types type = Types.Char;
//            try {
//                type=(Types)Enum.Parse(typeof(Types), Console.ReadLine());
//            } catch (ArgumentException ex) {
//                Console.WriteLine(ex.Message);
//                Console.ReadKey();
//                return;
//            }
//            int ss = 0;
//            if (type!=Types.Char&&type!=Types.Float&&type!=Types.Double) {
//                Console.Write("Введите основание системы счисления (2/8/10/16): ");
//                ss=int.Parse(Console.ReadLine());
//            }
//            Console.Write("Введите данные: ");
//            string data = Console.ReadLine();
//            if (type==Types.Char) {
//                if (data.Length>1)
//                    Console.WriteLine("Введено больше 1 символа.");
//                FromChar(data[0]);
//            }
//            dynamic result = data;


//            int length = sizeof(char);
//            switch (type) {
//                case Types.Short:
//                    result=Short(data, ss);
//                    FromShort(result);
//                    length=sizeof(short);
//                    break;
//                case Types.Int:
//                    result=Int(data, ss);
//                    FromInt(result);
//                    length=sizeof(int);
//                    break;
//                case Types.Long:
//                    result=Long(data, ss);
//                    FromLong(result);
//                    length=sizeof(long);
//                    break;
//                case Types.Float:
//                    result=Float(data, ss);
//                    FromFloat(result);
//                    length=sizeof(float);
//                    break;
//                case Types.Double:
//                    result=FDouble(data, ss);
//                    FromDouble(result);
//                    length=sizeof(double);
//                    break;
//            }
//            Console.ForegroundColor=ConsoleColor.Green;
//            Console.WriteLine("[{0}]={1}", result, ToBinary(ToLong(), length));
//            Console.ReadKey();
//        }

//        private static dynamic FDouble(string data, int ss) {
//            try {
//                double res = Convert.ToDouble(data);
//                return res;
//            } catch (ArgumentException ex) {
//                Console.WriteLine(ex.Message);
//                return 0;
//            }
//        }

//        private static dynamic Float(string data, int ss) {
//            try {
//                float.TryParse(data, out float res);
//                return res;
//            } catch (ArgumentException ex) {
//                Console.WriteLine(ex.Message);
//                return 0;
//            }
//        }

//        private static dynamic Long(string data, int ss) {
//            try {
//                long res = Convert.ToInt64(data, ss);
//                return res;
//            } catch (ArgumentException ex) {
//                Console.WriteLine(ex.Message);
//                return 0;
//            }
//        }

//        private static dynamic Int(string data, int ss) {
//            try {
//                int res = Convert.ToInt32(data, ss);
//                return res;
//            } catch (ArgumentException ex) {
//                Console.WriteLine(ex.Message);
//                return 0;
//            }
//        }

//        private static dynamic Short(string data, int ss) {
//            try {
//                short res = Convert.ToInt16(data, ss);
//                return res;
//            } catch (ArgumentException ex) {
//                Console.WriteLine(ex.Message);
//                return 0;
//            }
//        }
//    }
//}
