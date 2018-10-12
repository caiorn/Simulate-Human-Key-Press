using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
     /*
        Funcao: Simulador de pressionamento de teclas
        Autor: Caio S.
        Data: 12/10/18     
     */
namespace SimulateTyped {
    public partial class Form1 : Form {
        //teclas de ação para tratamento
        string[] key_words = {
            "8",    "BACKSPACE","◄",
            "9",    "TAB",      "◘",
            "13",   "ENTER",    "▼",
            "35",   "END",      "╣",
            "36",   "HOME",     "╠",
            "37",   "LEFT",     "←",
            "38",   "UP",       "↑",
            "39",   "RIGHT",    "→",
            "40",   "DOWN",     "↓",
            "46",   "DELETE",   "►"
        };

        //teclas de exibicao para tratamento(n haver conflito)
        string keys_reserv = "{}()^+%";        

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            contagem_inicia();
        }

        private async void contagem_inicia()
        {
            int temp = (int)nudTempoIniciar.Value;
            while ((int)nudTempoIniciar.Value-- > 1)            
                await Task.Delay(1000);            

            nudTempoIniciar.Value = temp;
            iniciar();           

        }

        private void iniciar()
        {
            string text = txtScript.Text.Replace("\r\n", "\n");

            //troca os caracteres especiais do script pela correspondente tecla(ex: ↑ = {UP})   
            for (int j = 2; j < key_words.Length; j += 3)
            {
                text = text.Replace(key_words[j], "{" + key_words[j - 1] + "}");
            }
            //separa cada parte do texto em uma posicao do vetor
            string[] letters = separar(text);

            pressionar(letters);
        }

        public async void pressionar(string[] charToPress) {
            for (int i = 0; i < charToPress.Length; i++) {
                SendKeys.Send(charToPress[i].ToString());
                await Task.Delay((int)nudTempoPressionar.Value);
            }
        }

        private string[] separar(string frase) {
            //cada letra sera armazenada em uma posicao no vetor,e as palavras que estão dentro de {} serao armazenada inteiramente(ex:a[0] == a, b[1] == {UP}) 
            var s = new System.Collections.Generic.List<string>();
            for (int i = 0, p = 0, a, b; i < frase.Length; i++, p++) {                
                if (frase.Substring(i, 1).Equals("{")) {
                    a = frase.IndexOf("{", i);
                    b = frase.IndexOf("}", 2+i);
                    s.Add(frase.Substring(a, 1 + b - a));
                    i = b;
                }
                else {
                    s.Add(frase.Substring(i, 1));
                }
            }
            return s.ToArray();
        }

        private string tratar_texto_pronto(string texto) {     
            string temp = "┸";
            keys_reserv = keys_reserv.Replace("}", temp);
            texto = texto.Replace("}", temp);
            foreach (char ch in keys_reserv.ToCharArray())            
                texto = texto.Replace(ch.ToString(), "{" + ch + "}");
            
            return texto.Replace(temp, "}");          
        }

        private void txtScript_KeyDown(object sender, KeyEventArgs e) {
            //ctrl + v
            if (e.Control && e.KeyCode == Keys.V) {
                e.SuppressKeyPress = true;
                txtScript.Text = tratar_texto_pronto(Clipboard.GetText());
                return;
            }

            //substitui a acao da tecla por um caracter para gravar o tipo de acao
            if (chkTeclasAcao.Checked) {             
                for (int i = 0; i < key_words.Length; i += 3) {
                    if ((int)e.KeyCode == int.Parse(key_words[i])) {
                        txtScript.AppendText(key_words[i + 2]);
                        //se for txtOriginal não bloquear ação das teclas (enter,tab)
                        if ((TextBox)sender == txtScript)
                            e.SuppressKeyPress = true;
                        break;
                    }
                }
            }
        }

        private void textOriginal_KeyDown(object sender, KeyEventArgs e) {
            txtScript_KeyDown(sender, e);
        }
        
        private void textOriginal_KeyPress(object sender, KeyPressEventArgs e) {
            if (keys_reserv.Contains(e.KeyChar.ToString()))            
                txtScript.AppendText("{"+e.KeyChar+"}");            
            else if (e.KeyChar != (char)Keys.Back && 
                     e.KeyChar != (char)Keys.Tab && 
                     e.KeyChar != (char)Keys.Return)            
                txtScript.AppendText(e.KeyChar.ToString());            
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            txtOriginal.Text = "";
            txtScript.Text = "";
        }

        private void btnDefinirFonte_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.FontMustExist = true;
            fontDialog1.ShowApply = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtScript.Font = txtOriginal.Font = fontDialog1.Font;
                txtScript.ForeColor = txtOriginal.ForeColor = fontDialog1.Color;
            }
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            string mensagem = "Qual background você deseja alterar?\nSIM - Campo de Texto\nNAO - Aplicacao";
            DialogResult dgr = MessageBox.Show(mensagem, "selecione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (colorDialog1.ShowDialog() == DialogResult.OK)            
                if (dgr == DialogResult.Yes)
                    txtOriginal.BackColor = txtScript.BackColor = colorDialog1.Color;
                else if (dgr == DialogResult.No)
                    BackColor = colorDialog1.Color;   
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new frmTest().Show();
        }
    }
}
/*
    Tratar:

    -ao copiar um codigo com algum caracteres (){}+%^ precisa ser colado pelo mouse senao o mesmo ira tratar novamente
    -shift + tab, shift + up... nao funciona
    -implementar tecla pause 
     
     https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=netframework-4.7.2
     */
