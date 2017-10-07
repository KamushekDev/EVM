using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class Form1 : Form {



        private bool allowMinus = true, allowComa, sleep = true;
        private int rightSymbols = 0;
        public enum Types { Char, Byte, Short, Int, Long, Float, Double }
        public static byte[] bites = new byte[] { 2, 1, 2, 4, 8, 4, 8 };
        public int Notation { get { return Notation; } set { if (value > 1 && value < 17) Notation = value; } }
        public Form1() {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
                ComboBType.Items.Add((Types)i);
            for (int i = 2; i <= 16; i++)
                ComboBNotation.Items.Add(i);
        }

        private void Form1_Load(object sender, EventArgs e) {
            ComboBNotation.SelectedIndex = 8;
            ComboBType.SelectedIndex = 3;
        }

        private double ConvertToDouble(string input, int notation) {
            try {
                checked {
                    double result = 0;
                    input = input.Replace(',', '.');
                    int coma = (input.IndexOf('.') > 0) ? input.IndexOf('.') : input.Length;

                    for (int i = coma - 1, j = 0; i >= ((input[0] == '-') ? 1 : 0); i--, j++)
                        result += Checker.tabl[input[i]] * Math.Pow(notation, j);

                    for (int i = coma + 1, j = -1; i < input.Length; i++, j--) {
                        result += Math.Pow(notation, j) * Checker.tabl[input[i]];
                    }
                    if (input[0] == '-')
                        result *= -1;
                    return result;
                }
            } catch {
                MessageBox.Show("Число вышло за пределы типа.");
            }
            return 0;
        }

        private long ConvertToLong(string input, int notation) {
            try {
                checked {
                    if (notation == 10)
                        return long.Parse(input);
                    else if (notation == 2 || notation == 8 || notation == 16) {
                        if (input[0] == '-')
                            return -Convert.ToInt64(input.Substring(1), notation);
                        return Convert.ToInt64(input, notation);
                    } else {
                        long sum = 0;
                        int minusCheck = 1;
                        if (input[0]=='-') {
                            input=input.Substring(1);
                            minusCheck=-1;
                        }
                        for (int i = 0; i < input.Length; i++) {
                            sum += (long)Math.Pow(notation, i) * Checker.tabl[input[input.Length - 1 - i]];
                        }
                        return sum*minusCheck;
                    }
                }
            } catch {
                MessageBox.Show("Число вышло за пределы типа.");
            }
            return 0;
        }

        private void BtnStart_Click(object sender, EventArgs e) {
            if (TextBData.Text.Length > 0) {
                if (ComboBType.SelectedIndex == 0) {
                    if (TextBData.Text.Length == 1)
                        Process(Convert.ToInt64(TextBData.Text[0]));
                    else
                        Process(ConvertToLong(TextBData.Text, 10));
                } else {
                    if (Check() || Checker.NotEnd())
                        MessageBox.Show("Somethiiing wrooong. I can feel it.");
                    if (ComboBType.SelectedIndex > 0 && ComboBType.SelectedIndex <= 4) {
                        Process(ConvertToLong(TextBData.Text, (int)ComboBNotation.Items[ComboBNotation.SelectedIndex]));
                    } else {
                        Process(ConvertToDouble(TextBData.Text, (int)ComboBNotation.Items[ComboBNotation.SelectedIndex]));
                    }
                }
            } else
                MessageBox.Show("Somethiiing wrooong. I can feel it. Just a feeling I've got like something about to happen, but I don't know what.", "Ошибка", MessageBoxButtons.OK);
        }

        private void Process(double a) {
            if (ComboBType.SelectedIndex == 5) {
                if ((float.MinValue+a) > 1E+24|| (a - float.MaxValue) > 1E+24) {
                    MessageBox.Show("Число вышло за пределы типа.");
                    return;
                }
                FromFloat((float)a);
            } else
                FromDouble(a);
            lblTen.Text = a.ToString();
            lblQuadro.Text = ConvertDouble(a, 8);
            lblHex.Text = ConvertDouble(a, 16);
            Print();
        }

        private void Process(long a) {
            int type = ComboBType.SelectedIndex;
            bool wrongInterval = false;
            switch (type) {
                case 0:
                    if ((int)char.MinValue > a || (int)char.MaxValue < a)
                        wrongInterval = true;
                    break;
                case 1:
                    if (byte.MinValue > a || byte.MaxValue < a)
                        wrongInterval = true;
                    break;
                case 2:
                    if (short.MinValue > a || short.MaxValue < a)
                        wrongInterval = true;
                    break;
                case 3:
                    if (int.MinValue > a || int.MaxValue < a)
                        wrongInterval = true;
                    break;
            }
            if (wrongInterval) {
                MessageBox.Show("Число вышло за пределы типа.");
                return;
            }

            FromLong(a);
            lblTen.Text = a.ToString();
            lblQuadro.Text = Convert.ToString(a, 8);
            lblHex.Text = Convert.ToString(a, 16).ToUpper();
            Print();
        }

        private void Print() {
            lblBinary.Text = ToBinary(ToLong(), bites[ComboBType.SelectedIndex], ComboBType.SelectedIndex);
            lblSymbol.Text = ((char)ToLong()).ToString();
        }

        private void ChangePress(object sender, EventArgs e) {
            ComboBNotation.Enabled = !(CheckBPress.Enabled & CheckBPress.Checked);
        }

        private string ConvertLong(long a, int notation) {
            string res = String.Empty;
            string minus = "";
            if (a < 0) {
                minus = "-";
                a *= -1;
            }
            while (a != 0) {
                res += Checker.tabl.ElementAt((int)(Math.Abs(a % (long)notation))).Key;
                a /= notation;
            }
            res = new string(res.Reverse().ToArray());
            res = minus + res;
            return (res == String.Empty) ? "0" : res;
        }

        private void ComboBType_SelectedValueChanged(object sender, EventArgs e) {
            UpdateValueBounds();

            if (ComboBType.SelectedIndex == 0) {

                CheckBPress.Enabled = true;
                TextBData.MaxLength = 1;
                allowMinus = false;
                allowComa = true;
            } else {
                CheckBPress.Enabled = false;
                TextBData.MaxLength = 1000;
            }
            if (0 < ComboBType.SelectedIndex && ComboBType.SelectedIndex < 5) {
                allowMinus = true;
                allowComa = false;
            } else if (5 <= ComboBType.SelectedIndex) {
                allowMinus = true;
                allowComa = true;
            }
            if (Check())
                MessageBox.Show("Something wrong! I can feel it.");
        }

        private void UpdateValueBounds() {
            int notation = (int)ComboBNotation.Items[ComboBNotation.SelectedIndex];
            string pattern = "Диапазон значений:\r\nот {0}\r\nдо {1}";
            switch (ComboBType.SelectedIndex) {
                case 0:
                    lblBounds.Text = String.Format(pattern, ConvertLong(char.MinValue, notation), ConvertLong(char.MaxValue, notation));
                    break;
                case 1:
                    lblBounds.Text = String.Format(pattern, ConvertLong(byte.MinValue, notation), ConvertLong(byte.MaxValue, notation));
                    break;
                case 2:
                    lblBounds.Text = String.Format(pattern, ConvertLong(short.MinValue, notation), ConvertLong(short.MaxValue, notation));
                    break;
                case 3:
                    lblBounds.Text = String.Format(pattern, ConvertLong(int.MinValue, notation), ConvertLong(int.MaxValue, notation));
                    break;
                case 4:
                    lblBounds.Text = String.Format(pattern, ConvertLong(long.MinValue, notation), ConvertLong(long.MaxValue, notation));
                    break;
                case 5:
                    lblBounds.Text = String.Format(pattern, ConvertDouble(float.MinValue, notation), ConvertDouble(float.MaxValue, notation));
                    //TextBData.Text = ConvertDouble(float.MaxValue, notation);
                    break;
                case 6:
                    lblBounds.Text = String.Format(pattern, ConvertDouble(double.MinValue, notation), ConvertDouble(double.MaxValue, notation));
                    break;

            }
        }

        private int Coma() {
            if (TextBData.Text.Contains(','))
                return TextBData.Text.IndexOf(',');
            else if (TextBData.Text.Contains('.'))
                return TextBData.Text.IndexOf('.');
            return -3;
        }

        private static string ConvertDouble(double a, int notation) {
            string res = String.Empty;
            while ((long)a != 0) {
                res += Checker.tabl.ElementAt((int)(Math.Abs(a % (long)notation))).Key;
                a /= notation;
            }
            res = ((a < 0) ? "-" : "") + new string(res.Reverse().ToArray());
            for (int i = 0; i < 15; i++) {
                a -= (long)a;
                if (i == 0 && a != 0)
                    res += ',';
                a *= notation;
                if ((int)a == 0)
                    break;
                res += Checker.tabl.ElementAt((int)Math.Abs(a)).Key;
            }
            if (res.Length > 76)
                res = res.Substring(0, 74) + "...";
            return (res == String.Empty) ? "0" : res;
        }

        private void TextBData_KeyDown(object sender, KeyEventArgs e) {
            if (CheckBPress.Enabled && CheckBPress.Checked) {
                TextBData.Text = e.KeyValue.ToString();
                e.SuppressKeyPress = true;
            } else {
                TextBData.SelectionStart = TextBData.Text.Length;
                TextBData.SelectionLength = 0;
                if (e.KeyCode == Keys.Back && TextBData.Text.Length > 0 && TextBData.Text.Length >= rightSymbols--)
                    Checker.Undo(TextBData.Text.Last(), allowMinus, allowComa, TextBData.Text.Length - 1, Coma(), TextBData.Text[0]);
            }

        }

        private void ComboBNotation_SelectedIndexChanged(object sender, EventArgs e) {
            Check();
            UpdateValueBounds();
        }

        private bool Check() {
            Checker.Set();
            Stack<int> errors = new Stack<int>();
            for (int i = 0; i < TextBData.Text.Length; i++) {
                if (Checker.CheckError(TextBData.Text[i], (byte)(int)ComboBNotation.Items[ComboBNotation.SelectedIndex], allowMinus, allowComa))
                    errors.Push(i);
            }
            if (errors.Count > 0) {

                if (MessageBox.Show("Удалить все обнаруженные ошибки?", "Ошибки", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    string result = TextBData.Text;
                    while (errors.Count > 0)
                        result = result.Remove(errors.Pop(), 1);
                    rightSymbols = result.Length;
                    TextBData.Text = result;
                    return false;
                }

                return true;
            }
            return false;
        }

        private void TextBData_TextChanged(object sender, EventArgs e) {
            //MessageBox.Show(String.Format("Minus: {0}; Coma: {1}", (allowMinus) ? '+' : '-', (allowComa) ? '+' : '-'));
            if (TextBData.Text.Length > rightSymbols && sleep && ComboBType.SelectedIndex != 0) {
                if (Checker.CheckError(TextBData.Text.Last(), (byte)(int)(ComboBNotation.Items[ComboBNotation.SelectedIndex]), allowMinus, allowComa)) {
                    char last = TextBData.Text.Last();
                    TextBData.Text = TextBData.Text.Substring(0, TextBData.Text.Length - 1);
                    MessageBox.Show(String.Format("Проверьте правильность ввода. \r\nСимвол '{0}' не может тут находиться.", last), "Ошибка", MessageBoxButtons.OK);
                    TextBData.SelectionStart = TextBData.Text.Length;
                    TextBData.SelectionLength = 0;
                } else
                    rightSymbols++;
            } else if (TextBData.Text.Length == 0)
                Checker.Set();
            //MessageBox.Show(Checker.state.ToString());
        }
    }

    public static class Checker {

        public enum State { Empty, SymbolBeforeComa, Coma, SymbolAfterComa, Symbols, SymbolAfterMinus };

        public static Dictionary<char, byte> tabl = new Dictionary<char, byte>() { { '0', 0 }, { '1', 1 }, { '2', 2 },
        { '3', 3 }, { '4', 4 }, { '5', 5 }, { '6', 6 }, { '7', 7 }, { '8', 8 }, { '9', 9 }, { 'A', 10 },
        { 'B', 11 }, { 'C', 12 }, { 'D', 13 }, { 'E', 14 } , { 'F', 15} };

        public static State state = State.Empty;

        public static void Undo(char last, bool allowMinus, bool allowComa, int current, int coma, char first) {
            switch (state) {
                case State.SymbolBeforeComa:
                    state = State.Empty;
                    break;
                case State.Coma:
                    if (current == 1)
                        state = State.SymbolBeforeComa;
                    break;
                case State.SymbolAfterComa:
                    if (last == ',' || last == '.')
                        state = State.Coma;
                    break;
                case State.Symbols:
                    if (allowComa) {
                        if (current - coma == 1)
                            state = State.SymbolAfterComa;
                    } else {
                        if (first == '-') {
                            if (current == 1)
                                state = State.SymbolAfterMinus;
                        } else if (current == 0)
                            state = State.Empty;
                    }

                    break;
                case State.SymbolAfterMinus:
                    state = State.Empty;
                    break;
            }
        }

        public static void Set() {
            state = State.Empty;
        }

        private static bool CheckNotationError(char last, byte notation) {
            if (tabl.ContainsKey(last) && (tabl[last] < notation))
                return false;
            return true;
        }

        public static bool NotEnd() {
            if (state == State.SymbolAfterComa || state == State.SymbolAfterMinus || state == State.SymbolBeforeComa)
                return true;
            return false;
        }

        public static bool CheckError(char last, byte notation, bool allowMinus, bool allowComa) {
            bool result = false;
            switch (state) {
                case State.Empty:
                    result = CheckEmpty(last, notation, allowMinus, allowComa);
                    break;
                case State.SymbolBeforeComa:
                    result = CheckSymbolBeforeComa(last, notation);
                    break;
                case State.Coma:
                    result = CheckComa(last, notation);
                    break;
                case State.SymbolAfterComa:
                    result = CheckSymbolAfterComa(last, notation);
                    break;
                case State.Symbols:
                    result = CheckSymbols(last, notation);
                    break;
                case State.SymbolAfterMinus:
                    result = CheckSymbolAfterMinus(last, notation);
                    break;
            }
            return result;
        }

        private static bool CheckSymbolAfterMinus(char last, byte notation) {
            bool result = CheckNotationError(last, notation);
            if (!result)
                state = State.Symbols;
            return result;
        }

        private static bool CheckSymbols(char last, byte notation) {
            return CheckNotationError(last, notation);
        }

        private static bool CheckSymbolAfterComa(char last, byte notation) {
            bool result = CheckNotationError(last, notation);
            if (!result)
                state = State.Symbols;
            return result;
        }

        private static bool CheckComa(char last, byte notation) {
            if (last == ',' || last == '.') {
                state = State.SymbolAfterComa;
                return false;
            }
            return CheckNotationError(last, notation);
        }

        private static bool CheckSymbolBeforeComa(char last, byte notation) {
            bool result = CheckNotationError(last, notation);
            if (!result)
                state = State.Coma;
            return result;
        }

        private static bool CheckEmpty(char last, byte notation, bool allowMinus, bool allowComa) {
            if (last == '-' && allowMinus) {
                if (allowComa)
                    state = State.SymbolBeforeComa;
                else
                    state = State.SymbolAfterMinus;
                return false;
            }
            bool result = CheckNotationError(last, notation);
            if (!result) {
                if (allowComa)
                    state = State.Coma;
                else
                    state = State.Symbols;
            }
            return result;
        }
    }

}
