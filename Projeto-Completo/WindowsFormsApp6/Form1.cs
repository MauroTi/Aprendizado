using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        string nome = "";
        string vencedor = "";
        string box1 = "", box2 = "", box3 = "", box4 = "", box5 = "", box6 = "", box7 = "", box8 = "", box9 = "";
        int Numeroaleatorio;
        int contador;

        //Funções
        private void limpa_campos()
        {
            nome = "";
            box1 = "";
            box2 = "";
            box3 = "";
            box4 = "";
            box5 = "";
            box6 = "";
            box7 = "";
            box8 = "";
            box9 = "";
            Numeroaleatorio = 0;
            contador = 0;
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = "";
            textBox6.Text = ""; textBox7.Text = ""; textBox8.Text = ""; textBox9.Text = ""; textBox_nome.Text = "";
            label_resultado.Text = "";
        }

        private void condicoes_possiveis()
        {
            if (vencedor == "X")
            {
                label_resultado.Text = "O jogador " + nome + " é o vencedor com o símbolo X.";
                button1_jogada.Enabled = false;
                Desabilita_todos_textbox();
                MessageBox.Show("Você Ganhou!!!!");                
            }
            else if (vencedor == "O")
            {
                label_resultado.Text = "Eu sou o vencedor com o símbolo O.";
                button1_jogada.Enabled = false;
                Desabilita_todos_textbox();
                MessageBox.Show("Eu Ganhei!!!!");                
            }
            else if (vencedor == "Empatou")
            {
                label_resultado.Text = "Empatamos...Vamos Jogar Novamente.";
                button1_jogada.Enabled = false;
                Desabilita_todos_textbox();
                MessageBox.Show("Empatamos...Vamos Jogar Novamente.");
            }       
        }

        private void habilita_botao_jogada()
        {
            button1_jogada.Enabled = true;
        }

        private void populaVariaveis()
        {
            box1 = textBox1.Text;
            box2 = textBox2.Text;
            box3 = textBox3.Text;
            box4 = textBox4.Text;
            box5 = textBox5.Text;
            box6 = textBox6.Text;
            box7 = textBox7.Text;
            box8 = textBox8.Text;
            box9 = textBox9.Text;
        }

        private void Desabilita_todos_textbox()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
        }

        private void Habilita_todos_textbox()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
        }

        private void Liga_soleitura_todos_textbox()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
        }

        private void Desliga_soleitura_todos_textbox()
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox8.ReadOnly = false;
            textBox9.ReadOnly = false;
        }
       
        private void Le_jogada_define_ganhador()
        {
            if (((box1 == box2) && (box2 == box3)) && (box2 != ""))
            {
                vencedor = box1;
            }
            else if (((box4 == box5) && (box5 == box6)) && (box5 != ""))
            {
                vencedor = box5;
            }
            else if (((box7 == box8) && (box8 == box9)) && (box8 != ""))
            {
                vencedor = box8;
            }
            else if (((box1 == box4) && (box4 == box7)) && (box4 != ""))
            {
                vencedor = box4;
            }
            else if (((box2 == box5) && (box5 == box8)) && (box5 != ""))
            {
                vencedor = box5;
            }
            else if (((box3 == box6) && (box6 == box9)) && (box6 != ""))
            {
                vencedor = box6;
            }
            else if (((box1 == box5) && (box5 == box9)) && (box5 != ""))
            {
                vencedor = box5;
            }
            else if (((box3 == box5) && (box5 == box7)) && (box5 != ""))
            {
                vencedor = box5;
            }
            else
            {
                if ((vencedor == "") && (box1 != "") && (box2 != "") && (box3 != "") && (box4 != "") && (box5 != "") && (box6 != "") && (box7 != "") && (box8 != "") && (box9 != ""))
                { 
                    vencedor = "Empatou";              
                }
            }
        }

        private void Gera_Numeroaleatorio_1a9()
        {
            Random rdn = new Random();

            Numeroaleatorio = rdn.Next(1, 10);



            if (Numeroaleatorio == contador)
            {
                Gera_Numeroaleatorio_1a9();
            }

        }

        private void Computador_joga()
        {

            condicoes_possiveis();
            Gera_Numeroaleatorio_1a9();

            switch (Numeroaleatorio)
            {
                case 1:
                    if ((box1 == "") || (box1 == null) && (box1 != "X") && (box1 != "O"))
                    {
                        box1 = "O";
                        textBox1.Text = box1;
                    }
                    else if (vencedor != "")
                    {
                        condicoes_possiveis();
                    }
                    else
                    {
                        contador = 1;
                        Computador_joga();
                    }
                    break;
                case 2:
                    if ((box2 == "") || (box2 == null) && (box2 != "X") && (box2 != "O"))
                    {
                        box2 = "O";
                        textBox2.Text = box2;
                    }
                    else if (vencedor != "")
                    {
                        condicoes_possiveis();
                    }
                    else
                    {
                        contador = 2;
                        Computador_joga();
                    }
                    break;
                case 3:
                    if ((box3 == "") || (box3 == null) && (box3 != "X") && (box3 != "O"))
                    {
                        box3 = "O";
                        textBox3.Text = box3;
                    }
                    else if (vencedor != "")
                    {
                        condicoes_possiveis();
                    }
                    else
                    {
                        contador = 3;
                        Computador_joga();
                    }
                    break;
                case 4:
                    if ((box4 == "") || (box4 == null) && (box4 != "X") && (box4 != "O"))
                    {
                        box4 = "O";
                        textBox4.Text = box4;
                    }
                    else if (vencedor != "")
                    {
                        condicoes_possiveis();
                    }
                    else
                    {
                        contador = 4;
                        Computador_joga();
                    }
                    break;
                case 5:
                    if ((box5 == "") || (box5 == null) && (box5 != "X") && (box5 != "O"))
                    {
                        box5 = "O";
                        textBox5.Text = box5;
                    }
                    else if (vencedor != "")
                    {
                        condicoes_possiveis();
                    }
                    else
                    {
                        contador = 5;
                        Computador_joga();
                    }
                    break;
                case 6:
                    if ((box6 == "") || (box6 == null) && (box6 != "X") && (box6 != "O"))
                    {
                        box6 = "O";
                        textBox6.Text = box6;
                    }
                    else if (vencedor != "")
                    {
                        condicoes_possiveis();
                    }
                    else
                    {
                        contador = 6;
                        Computador_joga();
                    }
                    break;
                case 7:
                    if ((box7 == "") || (box7 == null) && (box7 != "X") && (box7 != "O"))
                    {
                        box7 = "O";
                        textBox7.Text = box7;
                    }
                    else if (vencedor != "")
                    {
                        condicoes_possiveis();
                    }
                    else
                    {
                        contador = 7;
                        Computador_joga();
                    }
                    break;
                case 8:
                    if ((box8 == "") || (box8 == null) && (box8 != "X") && (box8 != "O"))
                    {
                        box8 = "O";
                        textBox8.Text = box8;
                    }
                    else if (vencedor != "")
                    {
                        condicoes_possiveis();
                    }
                    else
                    {
                        contador = 8;
                        Computador_joga();
                    }
                    break;
                case 9:
                    if ((box9 == "") || (box9 == null) && (box9 != "X") && (box9 != "O"))
                    {
                        box9 = "O";
                        textBox9.Text = box9;
                    }
                    else if (vencedor != "")
                    {
                        condicoes_possiveis();
                    }
                    else
                    {
                        contador = 9;
                        Computador_joga();
                    }
                    break;
                default:
                    break;

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        //Faz botões redondos
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, button1.Width, button1.Height);
            button1.Region = new Region(forma);

            GraphicsPath forma2 = new GraphicsPath();
            forma2.AddEllipse(0, 0, button2.Width, button2.Height);
            button2.Region = new Region(forma);

            GraphicsPath forma1 = new GraphicsPath();
            forma1.AddEllipse(0, 0, button1_jogada.Width, button1_jogada.Height);
            button1_jogada.Region = new Region(forma);
        }

        //Botão Reinicia Jogo
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Botão Jogar Novamente
        private void button1_Click_1(object sender, EventArgs e)
        {
            Desliga_soleitura_todos_textbox();
            Habilita_todos_textbox();
            limpa_campos();
            vencedor = "";
        }


        //Escuta TextBox
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            habilita_botao_jogada();
            if ((e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.Back))
            {
                textBox1.Text = "X";
                Desabilita_todos_textbox();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            habilita_botao_jogada();
            if ((e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.Back))
            {
                textBox2.Text = "X";
                Desabilita_todos_textbox();
            }
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            habilita_botao_jogada();
            if ((e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.Back))
            {
                textBox3.Text = "X";
                Desabilita_todos_textbox();
            }
        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            habilita_botao_jogada();
            if ((e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.Back))
            {
                textBox4.Text = "X";
                Desabilita_todos_textbox();
            }
        }
        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            habilita_botao_jogada();
            if ((e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.Back))
            {
                textBox5.Text = "X";
                Desabilita_todos_textbox();
            }
        }
        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            habilita_botao_jogada();
            if ((e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.Back))
            {
                textBox6.Text = "X";
                Desabilita_todos_textbox();
            }
        }
        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            habilita_botao_jogada();
            if ((e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.Back))
            {
                textBox7.Text = "X";
                Desabilita_todos_textbox();
            }
        }
        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            habilita_botao_jogada();
            if ((e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.Back))
            {
                textBox8.Text = "X";
                Desabilita_todos_textbox();
            }
        }
        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            habilita_botao_jogada();
            if ((e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.Back))
            {
                textBox9.Text = "X";
                Desabilita_todos_textbox();
            }
        }
        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {
            nome = textBox_nome.Text;
        }

        //Botão de Jogada
        private void Button1_Click(object sender, EventArgs e)
        {
            populaVariaveis();
            Le_jogada_define_ganhador();
            condicoes_possiveis();

            if (vencedor == "")
            {
                Computador_joga();
            }
            else
            {
                vencedor = "";
                return;
            }

            Le_jogada_define_ganhador();
            button1_jogada.Enabled = false;
            Habilita_todos_textbox();
            condicoes_possiveis();
           
        }
    }
}


