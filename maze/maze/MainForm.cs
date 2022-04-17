using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace maze
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		public void KeyboardKeyPress(object sender, KeyPressEventArgs e)
		{
			PictureBox[] paredes = {pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, 
			pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, 
			pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, 
			door1, door2}; //Grupo de PictureBoxes chamado "paredes"
			
			cronometro.Start(); //Cronometragem é iniciada
			
			switch (e.KeyChar)
			{
				case 'a': //Se a tecla pressionada for A
					player.Left -= 40;
					break;
				case 'd': //Se a tecla pressionada for D
					player.Left += 40;
					break;
				case 's': //Se a tecla pressionada for S
					player.Top += 40;
					break;
				case 'w': //Se a tecla pressionada for W
					player.Top -= 40;
					break;
			}
			
			if(player.Location == key1.Location) //Se o player estiver no mesmo local da key1
			{
				door1.Visible = false;
				door1.Left = 302;
			}
			
			if(player.Location == key2.Location) //Se o player estiver no mesmo local da key2
			{
				door2.Visible = false;	
				door2.Top = 379;
			}
			
			if(player.Location == end.Location) //Se o player estiver no mesmo local do end
			{
				cronometro.Stop(); //Parar cronometragem
				MessageBox.Show("Você fez o labirinto em: " + tempo + " segundos.", "Parabéns!");
			}
			
			foreach(PictureBox parede in paredes) //Para cada "parede" no grupo de PictureBoxes "paredes"
			{
				if(player.Bounds.IntersectsWith(parede.Bounds)) //Se o jogador encostar em uma dessas PictureBoxes
				{
					switch (e.KeyChar)
					{
						case 'a': //Caso tenha apertado a tecla A
							player.Left += 40;
							break;
						case 'd': //Caso tenha apertado a tecla D
							player.Left -= 40;
							break;
						case 's': //Caso tenha apertado a tecla S
							player.Top -= 40;
							break;
						case 'w': //Caso tenha apertado a tecla W
							player.Top += 40;
							break;
					}
				}
			}
			
		}
		
		int tempo;
		public void TemporizadorTick(object sender, EventArgs e)
		{
			tempo = int.Parse(contador.Text); //Tempo recebe o número escrito em "contador"
			tempo++; //tempo + 1
			contador.Text = tempo.ToString();
		}
		
		void ResetClick(object sender, EventArgs e) //Botão de Resetar Jogo
		{
			player.Top = 19;
			player.Left = 22;
			
			door1.Visible = true;
			door1.Left = 262;
			
			door2.Visible = true;
			door2.Top = 339;
			
			cronometro.Stop(); //Parar cronometragem
			tempo = 0;
			contador.Text = tempo.ToString();
		}
	}
}